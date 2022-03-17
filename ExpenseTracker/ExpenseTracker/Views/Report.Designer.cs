namespace ExpenseTracker.Views
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.cboxSelectedAccount = new System.Windows.Forms.ComboBox();
            this.lblFinancialAccount = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.gboxFilter = new System.Windows.Forms.GroupBox();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gboxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxSelectedAccount
            // 
            this.cboxSelectedAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSelectedAccount.FormattingEnabled = true;
            resources.ApplyResources(this.cboxSelectedAccount, "cboxSelectedAccount");
            this.cboxSelectedAccount.Name = "cboxSelectedAccount";
            this.cboxSelectedAccount.Sorted = true;
            // 
            // lblFinancialAccount
            // 
            resources.ApplyResources(this.lblFinancialAccount, "lblFinancialAccount");
            this.lblFinancialAccount.Name = "lblFinancialAccount";
            // 
            // lblStartDate
            // 
            resources.ApplyResources(this.lblStartDate, "lblStartDate");
            this.lblStartDate.Name = "lblStartDate";
            // 
            // lblEndDate
            // 
            resources.ApplyResources(this.lblEndDate, "lblEndDate");
            this.lblEndDate.Name = "lblEndDate";
            // 
            // dtpStartDate
            // 
            resources.ApplyResources(this.dtpStartDate, "dtpStartDate");
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Name = "dtpStartDate";
            // 
            // dtpEndDate
            // 
            resources.ApplyResources(this.dtpEndDate, "dtpEndDate");
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Name = "dtpEndDate";
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // gboxFilter
            // 
            this.gboxFilter.Controls.Add(this.cboxCategory);
            this.gboxFilter.Controls.Add(this.lblCategory);
            this.gboxFilter.Controls.Add(this.cboxSelectedAccount);
            this.gboxFilter.Controls.Add(this.btnApply);
            this.gboxFilter.Controls.Add(this.lblFinancialAccount);
            this.gboxFilter.Controls.Add(this.dtpEndDate);
            this.gboxFilter.Controls.Add(this.dtpStartDate);
            this.gboxFilter.Controls.Add(this.lblStartDate);
            this.gboxFilter.Controls.Add(this.lblEndDate);
            resources.ApplyResources(this.gboxFilter, "gboxFilter");
            this.gboxFilter.Name = "gboxFilter";
            this.gboxFilter.TabStop = false;
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            resources.ApplyResources(this.cboxCategory, "cboxCategory");
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Sorted = true;
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            // 
            // Report
            // 
            this.AcceptButton = this.btnApply;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gboxFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Report";
            this.ShowIcon = false;
            this.gboxFilter.ResumeLayout(false);
            this.gboxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxSelectedAccount;
        private System.Windows.Forms.Label lblFinancialAccount;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gboxFilter;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}