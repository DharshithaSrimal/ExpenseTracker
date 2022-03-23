namespace ExpenseTracker.Views
{
    partial class WeeklyView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeeklyView));
            this.gboxWeekOptions = new System.Windows.Forms.GroupBox();
            this.dtpWeekEndingDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.gboxWeekOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxWeekOptions
            // 
            this.gboxWeekOptions.Controls.Add(this.cboxType);
            this.gboxWeekOptions.Controls.Add(this.label1);
            this.gboxWeekOptions.Controls.Add(this.dtpWeekEndingDate);
            this.gboxWeekOptions.Controls.Add(this.lblSelectDate);
            resources.ApplyResources(this.gboxWeekOptions, "gboxWeekOptions");
            this.gboxWeekOptions.Name = "gboxWeekOptions";
            this.gboxWeekOptions.TabStop = false;
            // 
            // dtpWeekEndingDate
            // 
            resources.ApplyResources(this.dtpWeekEndingDate, "dtpWeekEndingDate");
            this.dtpWeekEndingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWeekEndingDate.Name = "dtpWeekEndingDate";
            this.dtpWeekEndingDate.ValueChanged += new System.EventHandler(this.dtpWeekEndingDate_ValueChanged);
            // 
            // lblSelectDate
            // 
            resources.ApplyResources(this.lblSelectDate, "lblSelectDate");
            this.lblSelectDate.Name = "lblSelectDate";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            resources.GetString("cboxType.Items"),
            resources.GetString("cboxType.Items1")});
            resources.ApplyResources(this.cboxType, "cboxType");
            this.cboxType.Name = "cboxType";
            this.cboxType.SelectedIndexChanged += new System.EventHandler(this.typeChanged);
            // 
            // WeeklyView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gboxWeekOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WeeklyView";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.weeklyViewOnLoad);
            this.gboxWeekOptions.ResumeLayout(false);
            this.gboxWeekOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxWeekOptions;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.DateTimePicker dtpWeekEndingDate;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.Label label1;
    }
}