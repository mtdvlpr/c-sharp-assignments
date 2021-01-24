namespace Assignment6
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
            this.btnRef = new System.Windows.Forms.Button();
            this.btnRefOut = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.radSquare = new System.Windows.Forms.RadioButton();
            this.radRoot = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnRef
            // 
            this.btnRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.Location = new System.Drawing.Point(23, 153);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(251, 36);
            this.btnRef.TabIndex = 0;
            this.btnRef.Text = "By Reference";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.BtnRef_Click);
            // 
            // btnRefOut
            // 
            this.btnRefOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefOut.Location = new System.Drawing.Point(23, 208);
            this.btnRefOut.Name = "btnRefOut";
            this.btnRefOut.Size = new System.Drawing.Size(251, 36);
            this.btnRefOut.TabIndex = 1;
            this.btnRefOut.Text = "By Reference Out";
            this.btnRefOut.UseVisualStyleBackColor = true;
            this.btnRefOut.Click += new System.EventHandler(this.BtnRefOut_Click);
            // 
            // btnValue
            // 
            this.btnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValue.Location = new System.Drawing.Point(23, 262);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(251, 36);
            this.btnValue.TabIndex = 2;
            this.btnValue.Text = "By Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.BtnValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(96, 348);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(178, 25);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(132, 34);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(142, 30);
            this.txtNumber.TabIndex = 6;
            // 
            // radSquare
            // 
            this.radSquare.AutoSize = true;
            this.radSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSquare.Location = new System.Drawing.Point(23, 94);
            this.radSquare.Name = "radSquare";
            this.radSquare.Size = new System.Drawing.Size(97, 29);
            this.radSquare.TabIndex = 7;
            this.radSquare.TabStop = true;
            this.radSquare.Text = "Square";
            this.radSquare.UseVisualStyleBackColor = true;
            // 
            // radRoot
            // 
            this.radRoot.AutoSize = true;
            this.radRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRoot.Location = new System.Drawing.Point(139, 94);
            this.radRoot.Name = "radRoot";
            this.radRoot.Size = new System.Drawing.Size(135, 29);
            this.radRoot.TabIndex = 8;
            this.radRoot.TabStop = true;
            this.radRoot.Text = "Square root";
            this.radRoot.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.radRoot);
            this.Controls.Add(this.radSquare);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnRefOut);
            this.Controls.Add(this.btnRef);
            this.Name = "Form1";
            this.Text = "Assignment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnRefOut;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.RadioButton radSquare;
        private System.Windows.Forms.RadioButton radRoot;
    }
}

