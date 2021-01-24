namespace Assignment13
{
    partial class frm13
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.ckbRefuel = new System.Windows.Forms.CheckBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.txtLitres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(58, 226);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(324, 48);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate Rental Price";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of rental days:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of kms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of litres tanked:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rental price:";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(228, 323);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(127, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "...";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbRefuel
            // 
            this.ckbRefuel.AutoSize = true;
            this.ckbRefuel.Location = new System.Drawing.Point(58, 152);
            this.ckbRefuel.Name = "ckbRefuel";
            this.ckbRefuel.Size = new System.Drawing.Size(203, 21);
            this.ckbRefuel.TabIndex = 6;
            this.ckbRefuel.Text = "Refuel on account of renter";
            this.ckbRefuel.UseVisualStyleBackColor = true;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(282, 64);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 22);
            this.txtDays.TabIndex = 7;
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(282, 112);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(100, 22);
            this.txtKms.TabIndex = 8;
            // 
            // txtLitres
            // 
            this.txtLitres.Location = new System.Drawing.Point(282, 185);
            this.txtLitres.Name = "txtLitres";
            this.txtLitres.Size = new System.Drawing.Size(100, 22);
            this.txtLitres.TabIndex = 9;
            // 
            // frm13
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLitres);
            this.Controls.Add(this.txtKms);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.ckbRefuel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "frm13";
            this.Text = "Assignment 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox ckbRefuel;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.TextBox txtLitres;
    }
}

