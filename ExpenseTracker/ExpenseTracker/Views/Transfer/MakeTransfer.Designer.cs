namespace ExpenseTracker.Views.Transfer
{
    partial class MakeTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeTransfer));
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.erpToAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboxFromAccount = new System.Windows.Forms.ComboBox();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.cboxToAccount = new System.Windows.Forms.ComboBox();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.erpAmount = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpToAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            resources.ApplyResources(this.btnTransfer, "btnTransfer");
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            resources.ApplyResources(this.lblAmount, "lblAmount");
            this.lblAmount.Name = "lblAmount";
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            // 
            // erpToAccount
            // 
            this.erpToAccount.ContainerControl = this;
            // 
            // cboxFromAccount
            // 
            this.cboxFromAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFromAccount.FormattingEnabled = true;
            resources.ApplyResources(this.cboxFromAccount, "cboxFromAccount");
            this.cboxFromAccount.Name = "cboxFromAccount";
            // 
            // lblFromAccount
            // 
            resources.ApplyResources(this.lblFromAccount, "lblFromAccount");
            this.lblFromAccount.Name = "lblFromAccount";
            // 
            // cboxToAccount
            // 
            this.cboxToAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxToAccount.FormattingEnabled = true;
            resources.ApplyResources(this.cboxToAccount, "cboxToAccount");
            this.cboxToAccount.Name = "cboxToAccount";
            // 
            // lblToAccount
            // 
            resources.ApplyResources(this.lblToAccount, "lblToAccount");
            this.lblToAccount.Name = "lblToAccount";
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            resources.ApplyResources(this.nudAmount, "nudAmount");
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // erpAmount
            // 
            this.erpAmount.ContainerControl = this;
            // 
            // MakeTransfer
            // 
            this.AcceptButton = this.btnTransfer;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.cboxToAccount);
            this.Controls.Add(this.lblToAccount);
            this.Controls.Add(this.cboxFromAccount);
            this.Controls.Add(this.lblFromAccount);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MakeTransfer";
            this.ShowIcon = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.erpToAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider erpToAccount;
        private System.Windows.Forms.ComboBox cboxToAccount;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.ComboBox cboxFromAccount;
        private System.Windows.Forms.Label lblFromAccount;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ErrorProvider erpAmount;
    }
}