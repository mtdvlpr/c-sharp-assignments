namespace UI
{
    partial class ReservationsForm
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
            this.listViewReservations = new System.Windows.Forms.ListView();
            this.lblReservations = new System.Windows.Forms.Label();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewReservations
            // 
            this.listViewReservations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Customer,
            this.Book});
            this.listViewReservations.HideSelection = false;
            this.listViewReservations.Location = new System.Drawing.Point(15, 45);
            this.listViewReservations.Name = "listViewReservations";
            this.listViewReservations.Size = new System.Drawing.Size(703, 247);
            this.listViewReservations.TabIndex = 0;
            this.listViewReservations.UseCompatibleStateImageBehavior = false;
            this.listViewReservations.View = System.Windows.Forms.View.Details;
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Location = new System.Drawing.Point(12, 9);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(95, 17);
            this.lblReservations.TabIndex = 1;
            this.lblReservations.Text = "Reservations:";
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Customer
            // 
            this.Customer.Text = "Customer";
            this.Customer.Width = 150;
            // 
            // Book
            // 
            this.Book.Text = "Book";
            this.Book.Width = 311;
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 324);
            this.Controls.Add(this.lblReservations);
            this.Controls.Add(this.listViewReservations);
            this.Name = "ReservationsForm";
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewReservations;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Customer;
        private System.Windows.Forms.ColumnHeader Book;
        private System.Windows.Forms.Label lblReservations;
    }
}