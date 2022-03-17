namespace ExpenseTracker.Views.Transaction
{
    partial class EditTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTransaction));
            this.btnSave = new System.Windows.Forms.Button();
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
            this.cboxPayee = new System.Windows.Forms.ComboBox();
            this.lblPayee = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cboxEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.errProviderNote = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderNote)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // cboxPayee
            // 
            this.cboxPayee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxPayee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxPayee.FormattingEnabled = true;
            resources.ApplyResources(this.cboxPayee, "cboxPayee");
            this.cboxPayee.Name = "cboxPayee";
            // 
            // lblPayee
            // 
            resources.ApplyResources(this.lblPayee, "lblPayee");
            this.lblPayee.Name = "lblPayee";
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
            // cboxEvent
            // 
            this.cboxEvent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxEvent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxEvent.FormattingEnabled = true;
            resources.ApplyResources(this.cboxEvent, "cboxEvent");
            this.cboxEvent.Name = "cboxEvent";
            // 
            // lblEvent
            // 
            resources.ApplyResources(this.lblEvent, "lblEvent");
            this.lblEvent.Name = "lblEvent";
            // 
            // errProviderNote
            // 
            this.errProviderNote.ContainerControl = this;
            // 
            // EditTransaction
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.cboxEvent);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.cboxPayee);
            this.Controls.Add(this.lblPayee);
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
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTransaction";
            this.ShowIcon = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.ComboBox cboxPayee;
        private System.Windows.Forms.Label lblPayee;
        private System.Windows.Forms.ComboBox cboxFinancialAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cboxEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ErrorProvider errProviderNote;
    }
}