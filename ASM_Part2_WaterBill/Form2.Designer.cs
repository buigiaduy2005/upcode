namespace ASM_Part2_WaterBill
{
    partial class WaterBill_Total
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterBill_Total));
            this.label1 = new System.Windows.Forms.Label();
            this.cbocustomertype = new System.Windows.Forms.ComboBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lablefamilymember = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlastmonth = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtthismonth = new System.Windows.Forms.TextBox();
            this.txtfamilymember = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // cbocustomertype
            // 
            this.cbocustomertype.FormattingEnabled = true;
            this.cbocustomertype.Location = new System.Drawing.Point(250, 224);
            this.cbocustomertype.Name = "cbocustomertype";
            this.cbocustomertype.Size = new System.Drawing.Size(121, 21);
            this.cbocustomertype.TabIndex = 2;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(640, 222);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click_1);
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(22, 274);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(712, 141);
            this.listViewResult.TabIndex = 4;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "This Month\'s Reading : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Month\'s Reading ; ";
            // 
            // lablefamilymember
            // 
            this.lablefamilymember.AutoSize = true;
            this.lablefamilymember.BackColor = System.Drawing.Color.Transparent;
            this.lablefamilymember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablefamilymember.Location = new System.Drawing.Point(63, 192);
            this.lablefamilymember.Name = "lablefamilymember";
            this.lablefamilymember.Size = new System.Drawing.Size(114, 15);
            this.lablefamilymember.TabIndex = 0;
            this.lablefamilymember.Text = "Family Member :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Type :  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total  :";
            // 
            // txtlastmonth
            // 
            this.txtlastmonth.Location = new System.Drawing.Point(250, 147);
            this.txtlastmonth.Name = "txtlastmonth";
            this.txtlastmonth.Size = new System.Drawing.Size(121, 20);
            this.txtlastmonth.TabIndex = 1;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(250, 27);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(121, 20);
            this.txtcustomername.TabIndex = 5;
            // 
            // txtthismonth
            // 
            this.txtthismonth.Location = new System.Drawing.Point(250, 86);
            this.txtthismonth.Name = "txtthismonth";
            this.txtthismonth.Size = new System.Drawing.Size(121, 20);
            this.txtthismonth.TabIndex = 6;
            // 
            // txtfamilymember
            // 
            this.txtfamilymember.Location = new System.Drawing.Point(250, 192);
            this.txtfamilymember.Name = "txtfamilymember";
            this.txtfamilymember.Size = new System.Drawing.Size(121, 20);
            this.txtfamilymember.TabIndex = 7;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(615, 122);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 8;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(659, 421);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // WaterBill_Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtfamilymember);
            this.Controls.Add(this.txtthismonth);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.cbocustomertype);
            this.Controls.Add(this.txtlastmonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lablefamilymember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WaterBill_Total";
            this.Text = "WaterBill_Total ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbocustomertype;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lablefamilymember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlastmonth;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtthismonth;
        private System.Windows.Forms.TextBox txtfamilymember;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnexit;
    }
}