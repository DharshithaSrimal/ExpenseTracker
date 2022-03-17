using ExpenseTracker.DataAccess;

namespace ExpenseTracker.Views
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ExpenseTrackerDataSet dbSet = new ExpenseTrackerDataSet();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategoriesAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategoriesView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinancialAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFAccountsAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFAccountsView = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnTransferFunds = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.gboxFinancialAccount = new System.Windows.Forms.GroupBox();
            this.btnShowTransactions = new System.Windows.Forms.Button();
            this.btnReportView = new System.Windows.Forms.Button();
            this.btnWeeklyView = new System.Windows.Forms.Button();
            this.cboxSelectedAccount = new System.Windows.Forms.ComboBox();
            this.gboxAddTransaction = new System.Windows.Forms.GroupBox();
            this.gboxRecentTransactions = new System.Windows.Forms.GroupBox();
            this.pnlRecentTransactions = new System.Windows.Forms.Panel();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.lblNoRecords = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gboxFinancialAccount.SuspendLayout();
            this.gboxAddTransaction.SuspendLayout();
            this.gboxRecentTransactions.SuspendLayout();
            this.pnlRecentTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCategories,
            this.tsmiFinancialAccounts});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsmiCategories
            // 
            this.tsmiCategories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCategoriesAddNew,
            this.tsmiCategoriesView});
            this.tsmiCategories.Name = "tsmiCategories";
            resources.ApplyResources(this.tsmiCategories, "tsmiCategories");
            // 
            // tsmiCategoriesAddNew
            // 
            this.tsmiCategoriesAddNew.Name = "tsmiCategoriesAddNew";
            resources.ApplyResources(this.tsmiCategoriesAddNew, "tsmiCategoriesAddNew");
            this.tsmiCategoriesAddNew.Click += new System.EventHandler(this.addCategoriesClick);
            // 
            // tsmiCategoriesView
            // 
            this.tsmiCategoriesView.Name = "tsmiCategoriesView";
            resources.ApplyResources(this.tsmiCategoriesView, "tsmiCategoriesView");
            this.tsmiCategoriesView.Click += new System.EventHandler(this.viewCategoriesClick);
            // 
            // tsmiFinancialAccounts
            // 
            this.tsmiFinancialAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFAccountsAddNew,
            this.tsmiFAccountsView});
            this.tsmiFinancialAccounts.Name = "tsmiFinancialAccounts";
            resources.ApplyResources(this.tsmiFinancialAccounts, "tsmiFinancialAccounts");
            // 
            // tsmiFAccountsAddNew
            // 
            this.tsmiFAccountsAddNew.Name = "tsmiFAccountsAddNew";
            resources.ApplyResources(this.tsmiFAccountsAddNew, "tsmiFAccountsAddNew");
            this.tsmiFAccountsAddNew.Click += new System.EventHandler(this.addFinancialAccountClick);
            // 
            // tsmiFAccountsView
            // 
            this.tsmiFAccountsView.Name = "tsmiFAccountsView";
            resources.ApplyResources(this.tsmiFAccountsView, "tsmiFAccountsView");
            this.tsmiFAccountsView.Click += new System.EventHandler(this.viewFinancialAccountsClick);
            // 
            // lblProductName
            // 
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.Name = "lblProductName";
            // 
            // btnNewRecord
            // 
            resources.ApplyResources(this.btnNewRecord, "btnNewRecord");
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnTransferFunds
            // 
            resources.ApplyResources(this.btnTransferFunds, "btnTransferFunds");
            this.btnTransferFunds.Name = "btnTransferFunds";
            this.btnTransferFunds.UseVisualStyleBackColor = true;
            this.btnTransferFunds.Click += new System.EventHandler(this.btnViewAllTransactionClick);
            // 
            // lblBalance
            // 
            resources.ApplyResources(this.lblBalance, "lblBalance");
            this.lblBalance.Name = "lblBalance";
            // 
            // gboxFinancialAccount
            // 
            this.gboxFinancialAccount.Controls.Add(this.btnShowTransactions);
            this.gboxFinancialAccount.Controls.Add(this.btnReportView);
            this.gboxFinancialAccount.Controls.Add(this.btnWeeklyView);
            this.gboxFinancialAccount.Controls.Add(this.cboxSelectedAccount);
            resources.ApplyResources(this.gboxFinancialAccount, "gboxFinancialAccount");
            this.gboxFinancialAccount.Name = "gboxFinancialAccount";
            this.gboxFinancialAccount.TabStop = false;
            // 
            // btnShowTransactions
            // 
            resources.ApplyResources(this.btnShowTransactions, "btnShowTransactions");
            this.btnShowTransactions.Name = "btnShowTransactions";
            this.btnShowTransactions.UseVisualStyleBackColor = true;
            this.btnShowTransactions.Click += new System.EventHandler(this.viewTransactionsClick);
            // 
            // btnReportView
            // 
            resources.ApplyResources(this.btnReportView, "btnReportView");
            this.btnReportView.Name = "btnReportView";
            this.btnReportView.UseVisualStyleBackColor = true;
            this.btnReportView.Click += new System.EventHandler(this.btnReportView_Click);
            // 
            // btnWeeklyView
            // 
            resources.ApplyResources(this.btnWeeklyView, "btnWeeklyView");
            this.btnWeeklyView.Name = "btnWeeklyView";
            this.btnWeeklyView.UseVisualStyleBackColor = true;
            this.btnWeeklyView.Click += new System.EventHandler(this.btnWeeklyView_Click);
            // 
            // cboxSelectedAccount
            // 
            this.cboxSelectedAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSelectedAccount.FormattingEnabled = true;
            resources.ApplyResources(this.cboxSelectedAccount, "cboxSelectedAccount");
            this.cboxSelectedAccount.Name = "cboxSelectedAccount";
            // 
            // gboxAddTransaction
            // 
            this.gboxAddTransaction.Controls.Add(this.btnNewRecord);
            this.gboxAddTransaction.Controls.Add(this.btnTransferFunds);
            resources.ApplyResources(this.gboxAddTransaction, "gboxAddTransaction");
            this.gboxAddTransaction.Name = "gboxAddTransaction";
            this.gboxAddTransaction.TabStop = false;
            // 
            // gboxRecentTransactions
            // 
            this.gboxRecentTransactions.Controls.Add(this.pnlRecentTransactions);
            resources.ApplyResources(this.gboxRecentTransactions, "gboxRecentTransactions");
            this.gboxRecentTransactions.Name = "gboxRecentTransactions";
            this.gboxRecentTransactions.TabStop = false;
            // 
            // pnlRecentTransactions
            // 
            resources.ApplyResources(this.pnlRecentTransactions, "pnlRecentTransactions");
            this.pnlRecentTransactions.Controls.Add(this.dgvTransactions);
            this.pnlRecentTransactions.Controls.Add(this.lblNoRecords);
            this.pnlRecentTransactions.Controls.Add(this.lblBalance);
            this.pnlRecentTransactions.Name = "pnlRecentTransactions";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvTransactions, "dgvTransactions");
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowTemplate.Height = 24;
            // 
            // lblNoRecords
            // 
            resources.ApplyResources(this.lblNoRecords, "lblNoRecords");
            this.lblNoRecords.Name = "lblNoRecords";
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.gboxRecentTransactions);
            this.Controls.Add(this.gboxAddTransaction);
            this.Controls.Add(this.gboxFinancialAccount);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.dashboardLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxFinancialAccount.ResumeLayout(false);
            this.gboxAddTransaction.ResumeLayout(false);
            this.gboxRecentTransactions.ResumeLayout(false);
            this.pnlRecentTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategories;
        private System.Windows.Forms.ToolStripMenuItem tsmiFinancialAccounts;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategoriesAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategoriesView;
        private System.Windows.Forms.ToolStripMenuItem tsmiFAccountsAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiFAccountsView;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Button btnTransferFunds;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox gboxFinancialAccount;
        private System.Windows.Forms.ComboBox cboxSelectedAccount;
        private System.Windows.Forms.GroupBox gboxAddTransaction;
        private System.Windows.Forms.GroupBox gboxRecentTransactions;
        private System.Windows.Forms.Panel pnlRecentTransactions;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblNoRecords;
        private System.Windows.Forms.Button btnWeeklyView;
        private System.Windows.Forms.Button btnReportView;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnShowTransactions;
    }
}