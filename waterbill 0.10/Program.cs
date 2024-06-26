using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waterbill_0._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nhập tên khách hàng 
            Console.WriteLine("Customer name:");
            string name = Console.ReadLine();
            // chọn loại khách hàng 
            Console.WriteLine("Select the customer type:");
            string type = GetCustomerType();
            // nhập số nước tháng này 
            Console.WriteLine("This month’s water meter readings:");
            if (!int.TryParse(Console.ReadLine(), out int thisMonthReading))
            {
                Console.WriteLine("Invalid input for water meter reading. Please enter a valid number.");
                return;
            }
            // nhập số nước  tháng trước 
            Console.WriteLine("Last month’s water meter readings:");
            if (!int.TryParse(Console.ReadLine(), out int lastMonthReading))
            {
                Console.WriteLine("Invalid input for previous month's water meter reading. Please enter a valid number.");
                return;
            }

            // khởi tạo biến tổng bill 
            double totalWaterBill = 0;
            // tính lượng tiêu thụ 
            double consumption = thisMonthReading - lastMonthReading;

            // kiểm tra điều kiện nước tiêu thụ
            if (consumption < 0)
            {
                Console.WriteLine("This month's reading must be greater than or equal to last month's reading.");
                return;
            }

            // khởi tạo biến giá 
            double pricePerCubicMeter = 0;
             
            // điêù kiện sử lí các lại khách hàng 
            switch (type.ToLower())
            {    
                case "household":
                    // yêu cầu nhập số  lượng thành viên 
                    Console.WriteLine("Number of family members:");
                    if (!int.TryParse(Console.ReadLine(), out int numberOfPeople))
                    {
                        Console.WriteLine("Invalid input for number of family members. Please enter a valid number.");
                        return;
                    }
                    // tính toán luọng nước tiêu thụ cho môi đàu người 
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
                    // tổng bill  = số tiêu thụ * giá mỗi khối 
                    totalWaterBill = consumption * pricePerCubicMeter ;
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
                    Console.WriteLine("Invalid customer type.");
                    return;
            }

            // Tính phí bảo vệ môi trường = totalWaterBil  * 0,1 
            double totalEnvironmentalFee =totalWaterBill * 0.1 ;

            // Tính VAT (10% của tổng chi phí) = ( tổng bill  ) * 0,1 
            double vat = totalWaterBill  * 0.1;

            // Tổng cộng (Total) = chi phí + phí bảo vệ môi trường + VAT
            double totalWithVat = totalWaterBill + totalEnvironmentalFee + vat;

            // Hiển thị hóa đơn
            Console.WriteLine("\n          YOUR BILL       ");
            Console.WriteLine("|--------------------------------------------------------------");
            Console.WriteLine("| Name: {0}                                                     ", name);
            Console.WriteLine("|--------------------------------------------------------------");
            Console.WriteLine("| Last Month's Reading: {0} m3                                ", lastMonthReading);
            Console.WriteLine("| This Month's Reading: {0} m3                                ", thisMonthReading);
            Console.WriteLine("| Consumption: {0} m3                                          ", consumption);
            Console.WriteLine("|--------------------------------------------------------------");
            Console.WriteLine("| Water Bill: {0:F2} VND                                       ", totalWaterBill);
            Console.WriteLine("| Environmental Protection Fee: {0:F2} VND                      ", totalEnvironmentalFee);
            Console.WriteLine("| VAT (10%): {0:F2} VND                                         ", vat);
            Console.WriteLine("| Total Water Bill (with VAT): {0:F2} VND                     ", totalWithVat);
            Console.WriteLine("|--------------------------------------------------------------");

            // tính toan mức chênh lệch trong tiêu thụ , đưa ra chỉ dẫn 
            // mức tieue thụ chênh lệch = số nước tháng này - số nước tháng truoc
            int consumptionDifference = Math.Abs(thisMonthReading - lastMonthReading);
            if (thisMonthReading > lastMonthReading)
            {
                Console.WriteLine("| Consumption increased by: {0} m3 compared to last month      ", consumptionDifference);
            }
            else if (thisMonthReading < lastMonthReading)
            {
                Console.WriteLine("| Consumption decreased by: {0} m3 compared to last month     ", consumptionDifference);
            }
            else
            {
                Console.WriteLine("| Consumption did not change compared to last month      "); 
            }
            Console.WriteLine("|--------------------------------------------------------------");
            Console.ReadLine();
        }
        // cọn loại kahchs hang 
        static string GetCustomerType()
        {
            Console.WriteLine("1. Household");
            Console.WriteLine("2. Administrative Agency / Public Services");
            Console.WriteLine("3. Production Units");
            Console.WriteLine("4. Business Services");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }

            switch (choice)
            {
                case 1:
                    return "Household";
                case 2:
                    return "Administrative Agency";
                case 3:
                    return "Production Units";
                case 4:
                    return "Business Services";
                default:
                    return "";
            }
        }
    }
    }

