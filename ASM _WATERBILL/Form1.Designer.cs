namespace ASM__WATERBILL
{
    partial class Form1
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
            this.listViewResult = new System.Windows.Forms.ListView();
            this.btncalculate = new System.Windows.Forms.Button();
            this.cbocustomertype = new System.Windows.Forms.ComboBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlastmonth = new System.Windows.Forms.TextBox();
            this.txtfamilymember = new System.Windows.Forms.TextBox();
            this.txtthismonth = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lablefamilymember = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(21, 248);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(652, 181);
            this.listViewResult.TabIndex = 0;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(474, 200);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Caclulate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // cbocustomertype
            // 
            this.cbocustomertype.FormattingEnabled = true;
            this.cbocustomertype.Location = new System.Drawing.Point(176, 172);
            this.cbocustomertype.Name = "cbocustomertype";
            this.cbocustomertype.Size = new System.Drawing.Size(121, 21);
            this.cbocustomertype.TabIndex = 2;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(176, 31);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(100, 20);
            this.txtcustomername.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "This Month\'s Reading :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Type : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Month\'s Reading :";
            // 
            // txtlastmonth
            // 
            this.txtlastmonth.Location = new System.Drawing.Point(176, 86);
            this.txtlastmonth.Name = "txtlastmonth";
            this.txtlastmonth.Size = new System.Drawing.Size(100, 20);
            this.txtlastmonth.TabIndex = 3;
            // 
            // txtfamilymember
            // 
            this.txtfamilymember.Location = new System.Drawing.Point(176, 112);
            this.txtfamilymember.Name = "txtfamilymember";
            this.txtfamilymember.Size = new System.Drawing.Size(100, 20);
            this.txtfamilymember.TabIndex = 3;
            // 
            // txtthismonth
            // 
            this.txtthismonth.Location = new System.Drawing.Point(176, 57);
            this.txtthismonth.Name = "txtthismonth";
            this.txtthismonth.Size = new System.Drawing.Size(100, 20);
            this.txtthismonth.TabIndex = 3;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(511, 128);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total : ";
            // 
            // lablefamilymember
            // 
            this.lablefamilymember.AutoSize = true;
            this.lablefamilymember.Location = new System.Drawing.Point(44, 118);
            this.lablefamilymember.Name = "lablefamilymember";
            this.lablefamilymember.Size = new System.Drawing.Size(86, 13);
            this.lablefamilymember.TabIndex = 7;
            this.lablefamilymember.Text = "Family Member : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lablefamilymember);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfamilymember);
            this.Controls.Add(this.txtthismonth);
            this.Controls.Add(this.txtlastmonth);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.cbocustomertype);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listViewResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.ComboBox cbocustomertype;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlastmonth;
        private System.Windows.Forms.TextBox txtfamilymember;
        private System.Windows.Forms.TextBox txtthismonth;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lablefamilymember;
    }
}

