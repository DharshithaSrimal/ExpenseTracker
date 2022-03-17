namespace ExpenseTracker.Views.Transaction
{
    partial class AddTransaction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransaction));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tboxNote = new System.Windows.Forms.TextBox();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.errProviderAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.tboxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.rbtnIncome = new System.Windows.Forms.RadioButton();
            this.rbtnExpense = new System.Windows.Forms.RadioButton();
            this.cboxFinancialAccount = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errProviderNote = new System.Windows.Forms.ErrorProvider(this.components);
            this.financialAccountDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialAccountDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financialAccountRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gboxRecurrency = new System.Windows.Forms.GroupBox();
            this.gboxHowLong = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpUntillThisDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnRecurring = new System.Windows.Forms.RadioButton();
            this.rbtnOneTime = new System.Windows.Forms.RadioButton();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financialAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAccountDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAccountDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAccountRowBindingSource)).BeginInit();
            this.gboxRecurrency.SuspendLayout();
            this.gboxHowLong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // lblNote
            // 
            resources.ApplyResources(this.lblNote, "lblNote");
            this.lblNote.Name = "lblNote";
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // tboxNote
            // 
            resources.ApplyResources(this.tboxNote, "tboxNote");
            this.tboxNote.Name = "tboxNote";
            this.tboxNote.TextChanged += new System.EventHandler(this.TboxNote_TextChanged);
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            resources.ApplyResources(this.cboxCategory, "cboxCategory");
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.SelectedIndexChanged += new System.EventHandler(this.categorySelectedhanged);
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            // 
            // errProviderAmount
            // 
            this.errProviderAmount.ContainerControl = this;
            // 
            // tboxAmount
            // 
            resources.ApplyResources(this.tboxAmount, "tboxAmount");
            this.tboxAmount.Name = "tboxAmount";
            this.tboxAmount.TextChanged += new System.EventHandler(this.tboxAmount_TextChanged);
            // 
            // lblAmount
            // 
            resources.ApplyResources(this.lblAmount, "lblAmount");
            this.lblAmount.Name = "lblAmount";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // rbtnIncome
            // 
            resources.ApplyResources(this.rbtnIncome, "rbtnIncome");
            this.rbtnIncome.Name = "rbtnIncome";
            this.rbtnIncome.TabStop = true;
            this.rbtnIncome.UseVisualStyleBackColor = true;
            this.rbtnIncome.CheckedChanged += new System.EventHandler(this.radioboxType_CheckedChanged);
            // 
            // rbtnExpense
            // 
            resources.ApplyResources(this.rbtnExpense, "rbtnExpense");
            this.rbtnExpense.Name = "rbtnExpense";
            this.rbtnExpense.TabStop = true;
            this.rbtnExpense.UseVisualStyleBackColor = true;
            this.rbtnExpense.CheckedChanged += new System.EventHandler(this.radioboxType_CheckedChanged);
            // 
            // cboxFinancialAccount
            // 
            this.cboxFinancialAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFinancialAccount.FormattingEnabled = true;
            resources.ApplyResources(this.cboxFinancialAccount, "cboxFinancialAccount");
            this.cboxFinancialAccount.Name = "cboxFinancialAccount";
            // 
            // lblAccount
            // 
            resources.ApplyResources(this.lblAccount, "lblAccount");
            this.lblAccount.Name = "lblAccount";
            // 
            // lblDateTime
            // 
            resources.ApplyResources(this.lblDateTime, "lblDateTime");
            this.lblDateTime.Name = "lblDateTime";
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Name = "dateTimePicker";
            // 
            // errProviderNote
            // 
            this.errProviderNote.ContainerControl = this;
            // 
            // financialAccountDataTableBindingSource
            // 
            this.financialAccountDataTableBindingSource.DataSource = typeof(ExpenseTracker.DataAccess.ExpenseTrackerDataSet.FinancialAccountDataTable);
            // 
            // financialAccountDataTableBindingSource1
            // 
            this.financialAccountDataTableBindingSource1.DataSource = typeof(ExpenseTracker.DataAccess.ExpenseTrackerDataSet.FinancialAccountDataTable);
            // 
            // financialAccountRowBindingSource
            // 
            this.financialAccountRowBindingSource.DataSource = typeof(ExpenseTracker.DataAccess.ExpenseTrackerDataSet.FinancialAccountRow);
            // 
            // gboxRecurrency
            // 
            this.gboxRecurrency.Controls.Add(this.gboxHowLong);
            this.gboxRecurrency.Controls.Add(this.rbtnRecurring);
            this.gboxRecurrency.Controls.Add(this.rbtnOneTime);
            resources.ApplyResources(this.gboxRecurrency, "gboxRecurrency");
            this.gboxRecurrency.Name = "gboxRecurrency";
            this.gboxRecurrency.TabStop = false;
            // 
            // gboxHowLong
            // 
            this.gboxHowLong.Controls.Add(this.label1);
            this.gboxHowLong.Controls.Add(this.dtpUntillThisDate);
            resources.ApplyResources(this.gboxHowLong, "gboxHowLong");
            this.gboxHowLong.Name = "gboxHowLong";
            this.gboxHowLong.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dtpUntillThisDate
            // 
            resources.ApplyResources(this.dtpUntillThisDate, "dtpUntillThisDate");
            this.dtpUntillThisDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUntillThisDate.Name = "dtpUntillThisDate";
            // 
            // rbtnRecurring
            // 
            resources.ApplyResources(this.rbtnRecurring, "rbtnRecurring");
            this.rbtnRecurring.Name = "rbtnRecurring";
            this.rbtnRecurring.TabStop = true;
            this.rbtnRecurring.UseVisualStyleBackColor = true;
            this.rbtnRecurring.CheckedChanged += new System.EventHandler(this.rbtnRecurringChanged);
            // 
            // rbtnOneTime
            // 
            resources.ApplyResources(this.rbtnOneTime, "rbtnOneTime");
            this.rbtnOneTime.Name = "rbtnOneTime";
            this.rbtnOneTime.TabStop = true;
            this.rbtnOneTime.UseVisualStyleBackColor = true;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = typeof(ExpenseTracker.DataAccess.ExpenseTrackerDataSet);
            // 
            // financialAccountBindingSource
            // 
            this.financialAccountBindingSource.DataSource = typeof(ExpenseTracker.DataAccess.FinancialAccount);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = typeof(ExpenseTracker.DataAccess.ExpenseTrackerDataSet);
            // 
            // categoryInfoBindingSource
            // 
            this.categoryInfoBindingSource.DataSource = typeof(ExpenseTracker.DataAccess.DataObjects.CategoryInfo);
            // 
            // AddTransaction
            // 
            this.AcceptButton = this.btnCreate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.gboxRecurrency);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.cboxFinancialAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.rbtnExpense);
            this.Controls.Add(this.rbtnIncome);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tboxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.tboxNote);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTransaction";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.addTransactionsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAccountDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAccountDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAccountRowBindingSource)).EndInit();
            this.gboxRecurrency.ResumeLayout(false);
            this.gboxRecurrency.PerformLayout();
            this.gboxHowLong.ResumeLayout(false);
            this.gboxHowLong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tboxNote;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider errProviderAmount;
        private System.Windows.Forms.TextBox tboxAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.RadioButton rbtnExpense;
        private System.Windows.Forms.RadioButton rbtnIncome;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ComboBox cboxFinancialAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ErrorProvider errProviderNote;
        private System.Windows.Forms.BindingSource financialAccountDataTableBindingSource;
        private System.Windows.Forms.BindingSource financialAccountBindingSource;
        private System.Windows.Forms.BindingSource financialAccountDataTableBindingSource1;
        private System.Windows.Forms.BindingSource financialAccountRowBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource categoryInfoBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.GroupBox gboxRecurrency;
        private System.Windows.Forms.GroupBox gboxHowLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpUntillThisDate;
        private System.Windows.Forms.RadioButton rbtnRecurring;
        private System.Windows.Forms.RadioButton rbtnOneTime;
    }
}