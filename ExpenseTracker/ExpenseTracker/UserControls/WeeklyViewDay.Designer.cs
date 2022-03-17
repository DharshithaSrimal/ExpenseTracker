namespace ExpenseTracker.CustomControls
{
    partial class WeeklyViewDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlExpenses = new System.Windows.Forms.Panel();
            this.lblDayTotalExpense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlExpenses
            // 
            this.pnlExpenses.AutoScroll = true;
            this.pnlExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExpenses.Location = new System.Drawing.Point(0, 0);
            this.pnlExpenses.Name = "pnlExpenses";
            this.pnlExpenses.Size = new System.Drawing.Size(150, 320);
            this.pnlExpenses.TabIndex = 0;
            // 
            // lblDayTotalExpense
            // 
            this.lblDayTotalExpense.Location = new System.Drawing.Point(3, 323);
            this.lblDayTotalExpense.Name = "lblDayTotalExpense";
            this.lblDayTotalExpense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDayTotalExpense.Size = new System.Drawing.Size(144, 33);
            this.lblDayTotalExpense.TabIndex = 1;
            this.lblDayTotalExpense.Text = "totalExpenses";
            this.lblDayTotalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeeklyViewDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.lblDayTotalExpense);
            this.Controls.Add(this.pnlExpenses);
            this.Name = "WeeklyViewDay";
            this.Size = new System.Drawing.Size(150, 356);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExpenses;
        private System.Windows.Forms.Label lblDayTotalExpense;
    }
}
