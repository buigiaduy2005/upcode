using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_part2___waterbill___bui_gia_duy
{
    public partial class WaterBill_Total : Form
    {
        private int orderNumber = 1;
        public WaterBill_Total()
        {
            InitializeComponent();
            InitializeCustomerTypes();
            InitializeListView();
        }
        private void InitializeCustomerTypes()
        {
            cbocustomertype.Items.Add("Household");
            cbocustomertype.Items.Add("Administrative Agency");
            cbocustomertype.Items.Add("Production Units");
            cbocustomertype.Items.Add("Business Services");
            cbocustomertype.SelectedIndex = 0;
        }
        private void InitializeListView()
        {
            listViewResult.Columns.Add("Order", 50);
            listViewResult.Columns.Add("Customer Name", 150);
            listViewResult.Columns.Add("Customer Type ", 150);
            listViewResult.Columns.Add("Last Month's Reading ", 120);
            listViewResult.Columns.Add("This Month's Reading ", 120);
            listViewResult.Columns.Add("Consumption", 100);
            listViewResult.Columns.Add("WaterBill ", 120);
            listViewResult.Columns.Add("Environmental Fee", 120);
            listViewResult.Columns.Add("VAT", 100);
            listViewResult.Columns.Add("TotalBill ", 120);
            listViewResult.Columns.Add("Consumption Difference", 150);

        }
        private (double TotalWaterBill, double EnvironmentalFee, double VAT, double TotalWithVat, string ConsumptionChange)
            CalculateWaterBill(string customerType, double consumption, int numberOfPeople)
        {
            double pricePerCubicMeter = 0;
            double totalWaterBill = 0;

            switch (customerType.ToLower())
            {
                case "household":
                    double householdConsumptionPerPerson = consumption / numberOfPeople;

                    if (householdConsumptionPerPerson <= 10)
                    {
                        pricePerCubicMeter = 5.973;
                    }
                    else if (householdConsumptionPerPerson <= 20)
                    {
                        pricePerCubicMeter = 7.052;
                    }
                    else if (householdConsumptionPerPerson <= 30)
                    {
                        pricePerCubicMeter = 8.699;
                    }
                    else
                    {
                        pricePerCubicMeter = 15.929;
                    }

                    totalWaterBill = consumption * pricePerCubicMeter;
                    break;

                case "administrative agency":
                case "public services":
                    pricePerCubicMeter = 9.955;
                    totalWaterBill = consumption * pricePerCubicMeter;
                    break;

                case "production units":
                    pricePerCubicMeter = 11.615;
                    totalWaterBill = consumption * pricePerCubicMeter;
                    break;

                case "business services":
                    pricePerCubicMeter = 22.068;
                    totalWaterBill = consumption * pricePerCubicMeter;
                    break;

                default:
                    throw new ArgumentException("Invalid customer type.");
            }

            // Tính toán phí bảo vệ môi trường và VAT
            double totalEnvironmentalFee = totalWaterBill * 0.1;
            double vat = totalWaterBill * 0.1;
            double totalWithVat = totalWaterBill + totalEnvironmentalFee + vat;

            // Tính toán chênh lệch tiêu thụ
            string consumptionChange;
            if (consumption > 0)
            {
                consumptionChange = $"increase {consumption} m3";
            }
            else if (consumption < 0)
            {
                consumptionChange = $"reduced {-consumption} m3";
            }
            else
            {
                consumptionChange = "unchanged";
            }

            return (totalWaterBill, totalEnvironmentalFee, vat, totalWithVat, consumptionChange);
        }

        private void comboBoxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị hộp nhập liệu cho số thành viên trong gia đình nếu là hộ gia đình
            bool isHousehold = cbocustomertype.SelectedItem.ToString().ToLower() == "household";
            lablefamilymember.Visible = isHousehold;
            txtfamilymember.Visible = isHousehold;
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy và kiểm tra đầu vào
                string name = txtcustomername.Text;
                string type = cbocustomertype.SelectedItem.ToString();

                if (!int.TryParse(txtthismonth.Text, out int thisMonthReading))
                {
                    MessageBox.Show("Invalid input for this month index. Please enter a valid number.");
                    return;
                }

                if (!int.TryParse(txtlastmonth.Text, out int lastMonthReading))
                {
                    MessageBox.Show("Invalid input for previous month index. Please enter a valid number.");
                    return;
                }

                // Tính toán mức tiêu thụ
                double consumption = thisMonthReading - lastMonthReading;

                if (consumption < 0)
                {
                    MessageBox.Show("This month's index must be greater than or equal to the previous month's index.");
                    return;
                }

                // Lấy số thành viên trong gia đình nếu là hộ gia đình
                int numberOfPeople = 1;
                if (type.ToLower() == "household")
                {
                    if (!int.TryParse(txtfamilymember.Text, out numberOfPeople))
                    {
                        MessageBox.Show("Invalid input for family member number. Please enter a valid number.");
                        return;
                    }
                }

                // Tính toán hóa đơn nước
                var result = CalculateWaterBill(type, consumption, numberOfPeople);

                // Hiển thị kết quả trong ListView
                ListViewItem item = new ListViewItem(new[]
                {
                    orderNumber.ToString(),
                    name,
                    type,
                    lastMonthReading.ToString(),
                    thisMonthReading.ToString(),
                    consumption.ToString("F2"),
                    result.TotalWaterBill.ToString("F2"),
                    result.EnvironmentalFee.ToString("F2"),
                    result.VAT.ToString("F2"),
                    result.TotalWithVat.ToString("F2"),
                    result.ConsumptionChange
                });

                listViewResult.Items.Add(item);
                orderNumber++;
                string output = $"Order: {orderNumber - 1}\n" +
                               $"Customer Name: {name}\n" +
                               $"Customer Type: {type}\n" +
                               $"Last Month's Reading: {lastMonthReading}\n" +
                               $"This Month's Reading: {thisMonthReading}\n" +
                               $"Consumption: {consumption:F2} m3\n" +
                               $"Water Bill: {result.TotalWaterBill:F2}\n" +
                               $"Environmental Fee: {result.EnvironmentalFee:F2}\n" +
                               $"VAT: {result.VAT:F2}\n" +
                               $"Total Bill: {result.TotalWithVat:F2}\n" +
                               $"Consumption Difference: {result.ConsumptionChange}\n\n";

                richTextBoxResul.AppendText(output);
               
                // Hiển thị tổng hóa đơn vào TextBox
                txttotal.Text = result.TotalWithVat.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            
        }
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            foreach (ListViewItem item in listViewResult.Items)
            {
                item.BackColor = SystemColors.Window; // Reset background color
                if (item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(subItem => subItem.Text.ToLower().Contains(keyword)))
                {
                    item.BackColor = Color.Yellow; // Highlight the matching item
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            foreach (ListViewItem item in listViewResult.Items)
            {
                item.BackColor = SystemColors.Window; // Reset background color
            }
        }
    }
}
