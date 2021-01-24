namespace Assignment7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDegrees = new System.Windows.Forms.TextBox();
            this.radFromCelsius = new System.Windows.Forms.RadioButton();
            this.radFromFahrenheit = new System.Windows.Forms.RadioButton();
            this.radFromKelvin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radToCelsius = new System.Windows.Forms.RadioButton();
            this.radToKelvin = new System.Windows.Forms.RadioButton();
            this.radToFahrenheit = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature:";
            // 
            // txtDegrees
            // 
            this.txtDegrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegrees.Location = new System.Drawing.Point(259, 39);
            this.txtDegrees.Name = "txtDegrees";
            this.txtDegrees.Size = new System.Drawing.Size(151, 30);
            this.txtDegrees.TabIndex = 1;
            // 
            // radFromCelsius
            // 
            this.radFromCelsius.AutoSize = true;
            this.radFromCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFromCelsius.Location = new System.Drawing.Point(16, 41);
            this.radFromCelsius.Name = "radFromCelsius";
            this.radFromCelsius.Size = new System.Drawing.Size(98, 29);
            this.radFromCelsius.TabIndex = 2;
            this.radFromCelsius.TabStop = true;
            this.radFromCelsius.Text = "Celsius";
            this.radFromCelsius.UseVisualStyleBackColor = true;
            // 
            // radFromFahrenheit
            // 
            this.radFromFahrenheit.AutoSize = true;
            this.radFromFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFromFahrenheit.Location = new System.Drawing.Point(16, 83);
            this.radFromFahrenheit.Name = "radFromFahrenheit";
            this.radFromFahrenheit.Size = new System.Drawing.Size(126, 29);
            this.radFromFahrenheit.TabIndex = 3;
            this.radFromFahrenheit.TabStop = true;
            this.radFromFahrenheit.Text = "Fahrenheit";
            this.radFromFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radFromKelvin
            // 
            this.radFromKelvin.AutoSize = true;
            this.radFromKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFromKelvin.Location = new System.Drawing.Point(16, 135);
            this.radFromKelvin.Name = "radFromKelvin";
            this.radFromKelvin.Size = new System.Drawing.Size(87, 29);
            this.radFromKelvin.TabIndex = 4;
            this.radFromKelvin.TabStop = true;
            this.radFromKelvin.Text = "Kelvin";
            this.radFromKelvin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Converted temperature:";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(259, 394);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(151, 24);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFromCelsius);
            this.groupBox1.Controls.Add(this.radFromFahrenheit);
            this.groupBox1.Controls.Add(this.radFromKelvin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 190);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radToCelsius);
            this.groupBox2.Controls.Add(this.radToKelvin);
            this.groupBox2.Controls.Add(this.radToFahrenheit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(259, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 190);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To:";
            // 
            // radToCelsius
            // 
            this.radToCelsius.AutoSize = true;
            this.radToCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToCelsius.Location = new System.Drawing.Point(15, 41);
            this.radToCelsius.Name = "radToCelsius";
            this.radToCelsius.Size = new System.Drawing.Size(98, 29);
            this.radToCelsius.TabIndex = 5;
            this.radToCelsius.TabStop = true;
            this.radToCelsius.Text = "Celsius";
            this.radToCelsius.UseVisualStyleBackColor = true;
            // 
            // radToKelvin
            // 
            this.radToKelvin.AutoSize = true;
            this.radToKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToKelvin.Location = new System.Drawing.Point(15, 135);
            this.radToKelvin.Name = "radToKelvin";
            this.radToKelvin.Size = new System.Drawing.Size(87, 29);
            this.radToKelvin.TabIndex = 7;
            this.radToKelvin.TabStop = true;
            this.radToKelvin.Text = "Kelvin";
            this.radToKelvin.UseVisualStyleBackColor = true;
            // 
            // radToFahrenheit
            // 
            this.radToFahrenheit.AutoSize = true;
            this.radToFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToFahrenheit.Location = new System.Drawing.Point(15, 83);
            this.radToFahrenheit.Name = "radToFahrenheit";
            this.radToFahrenheit.Size = new System.Drawing.Size(126, 29);
            this.radToFahrenheit.TabIndex = 6;
            this.radToFahrenheit.TabStop = true;
            this.radToFahrenheit.Text = "Fahrenheit";
            this.radToFahrenheit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDegrees);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDegrees;
        private System.Windows.Forms.RadioButton radFromCelsius;
        private System.Windows.Forms.RadioButton radFromFahrenheit;
        private System.Windows.Forms.RadioButton radFromKelvin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radToCelsius;
        private System.Windows.Forms.RadioButton radToKelvin;
        private System.Windows.Forms.RadioButton radToFahrenheit;
    }
}

