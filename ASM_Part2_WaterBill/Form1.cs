using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_Part2_WaterBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if ((txtname.Text == "") || (txtpass.Text == ""))
            {
                MessageBox.Show("chua nhapj thong tin ");
            }
            else
            {
                if((txtname.Text =="duy")&&(txtpass.Text == "123"))
                {
                    MessageBox.Show("dasng nhap thanh cong");
                    WaterBill_Total insideForm = new WaterBill_Total();
                    insideForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("dang nhap khong thanh cong ");
                }

                
            }
        }      
    }
}
