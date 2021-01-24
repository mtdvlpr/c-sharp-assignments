namespace Assignment1
{
    partial class ControlPanel
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
            this.btnNewDisplay = new System.Windows.Forms.Button();
            this.btnNextStation = new System.Windows.Forms.Button();
            this.btnStationsDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewDisplay
            // 
            this.btnNewDisplay.Location = new System.Drawing.Point(12, 223);
            this.btnNewDisplay.Name = "btnNewDisplay";
            this.btnNewDisplay.Size = new System.Drawing.Size(170, 41);
            this.btnNewDisplay.TabIndex = 3;
            this.btnNewDisplay.Text = "New train display";
            this.btnNewDisplay.UseVisualStyleBackColor = true;
            this.btnNewDisplay.Click += new System.EventHandler(this.BtnNewDisplay_Click);
            // 
            // btnNextStation
            // 
            this.btnNextStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStation.Location = new System.Drawing.Point(101, 37);
            this.btnNextStation.Name = "btnNextStation";
            this.btnNextStation.Size = new System.Drawing.Size(218, 78);
            this.btnNextStation.TabIndex = 2;
            this.btnNextStation.Text = "Next Station";
            this.btnNextStation.UseVisualStyleBackColor = true;
            this.btnNextStation.Click += new System.EventHandler(this.BtnNextStation_Click);
            // 
            // btnStationsDisplay
            // 
            this.btnStationsDisplay.Location = new System.Drawing.Point(233, 223);
            this.btnStationsDisplay.Name = "btnStationsDisplay";
            this.btnStationsDisplay.Size = new System.Drawing.Size(176, 41);
            this.btnStationsDisplay.TabIndex = 4;
            this.btnStationsDisplay.Text = "New stations display";
            this.btnStationsDisplay.UseVisualStyleBackColor = true;
            this.btnStationsDisplay.Click += new System.EventHandler(this.BtnStationsDisplay_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 276);
            this.Controls.Add(this.btnStationsDisplay);
            this.Controls.Add(this.btnNewDisplay);
            this.Controls.Add(this.btnNextStation);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewDisplay;
        private System.Windows.Forms.Button btnNextStation;
        private System.Windows.Forms.Button btnStationsDisplay;
    }
}