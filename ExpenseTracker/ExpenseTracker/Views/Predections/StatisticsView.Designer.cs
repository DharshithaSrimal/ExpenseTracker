namespace ExpenseTracker.Views.Predections
{
    partial class StatisticsView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSelectedAccount = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCatIncMost = new System.Windows.Forms.Label();
            this.lblCatExpMost = new System.Windows.Forms.Label();
            this.lblIncMost = new System.Windows.Forms.Label();
            this.lblExpMost = new System.Windows.Forms.Label();
            this.lblIncLeast = new System.Windows.Forms.Label();
            this.lblCatIncLeast = new System.Windows.Forms.Label();
            this.lblExpLeast = new System.Windows.Forms.Label();
            this.lblCatExpLeast = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxSelectedAccount);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Financial Account Statistics";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.loadStatisticsClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Financial Account";
            // 
            // cboxSelectedAccount
            // 
            this.cboxSelectedAccount.FormattingEnabled = true;
            this.cboxSelectedAccount.Location = new System.Drawing.Point(149, 22);
            this.cboxSelectedAccount.Name = "cboxSelectedAccount";
            this.cboxSelectedAccount.Size = new System.Drawing.Size(122, 24);
            this.cboxSelectedAccount.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblExpense);
            this.groupBox2.Controls.Add(this.lblIncome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comparison";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Balance:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblExpLeast);
            this.groupBox6.Controls.Add(this.lblCatExpLeast);
            this.groupBox6.Location = new System.Drawing.Point(267, 138);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 68);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Least Spending Category:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblIncLeast);
            this.groupBox5.Controls.Add(this.lblCatIncLeast);
            this.groupBox5.Location = new System.Drawing.Point(27, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 68);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Least Earning Category:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblExpMost);
            this.groupBox4.Controls.Add(this.lblCatExpMost);
            this.groupBox4.Location = new System.Drawing.Point(267, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 68);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Most Spending Category:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblIncMost);
            this.groupBox3.Controls.Add(this.lblCatIncMost);
            this.groupBox3.Location = new System.Drawing.Point(27, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Most Earning Category:";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Location = new System.Drawing.Point(358, 32);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(0, 16);
            this.lblExpense.TabIndex = 3;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(119, 32);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(0, 16);
            this.lblIncome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Expense:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Income:";
            // 
            // lblCatIncMost
            // 
            this.lblCatIncMost.AutoSize = true;
            this.lblCatIncMost.Location = new System.Drawing.Point(17, 22);
            this.lblCatIncMost.Name = "lblCatIncMost";
            this.lblCatIncMost.Size = new System.Drawing.Size(40, 16);
            this.lblCatIncMost.TabIndex = 0;
            this.lblCatIncMost.Text = "None";
            // 
            // lblCatExpMost
            // 
            this.lblCatExpMost.AutoSize = true;
            this.lblCatExpMost.Location = new System.Drawing.Point(16, 22);
            this.lblCatExpMost.Name = "lblCatExpMost";
            this.lblCatExpMost.Size = new System.Drawing.Size(40, 16);
            this.lblCatExpMost.TabIndex = 0;
            this.lblCatExpMost.Text = "None";
            // 
            // lblIncMost
            // 
            this.lblIncMost.AutoSize = true;
            this.lblIncMost.Location = new System.Drawing.Point(17, 49);
            this.lblIncMost.Name = "lblIncMost";
            this.lblIncMost.Size = new System.Drawing.Size(34, 16);
            this.lblIncMost.TabIndex = 1;
            this.lblIncMost.Text = "Rs.0";
            // 
            // lblExpMost
            // 
            this.lblExpMost.AutoSize = true;
            this.lblExpMost.Location = new System.Drawing.Point(16, 49);
            this.lblExpMost.Name = "lblExpMost";
            this.lblExpMost.Size = new System.Drawing.Size(34, 16);
            this.lblExpMost.TabIndex = 1;
            this.lblExpMost.Text = "Rs.0";
            // 
            // lblIncLeast
            // 
            this.lblIncLeast.AutoSize = true;
            this.lblIncLeast.Location = new System.Drawing.Point(17, 49);
            this.lblIncLeast.Name = "lblIncLeast";
            this.lblIncLeast.Size = new System.Drawing.Size(34, 16);
            this.lblIncLeast.TabIndex = 3;
            this.lblIncLeast.Text = "Rs.0";
            // 
            // lblCatIncLeast
            // 
            this.lblCatIncLeast.AutoSize = true;
            this.lblCatIncLeast.Location = new System.Drawing.Point(17, 22);
            this.lblCatIncLeast.Name = "lblCatIncLeast";
            this.lblCatIncLeast.Size = new System.Drawing.Size(40, 16);
            this.lblCatIncLeast.TabIndex = 2;
            this.lblCatIncLeast.Text = "None";
            // 
            // lblExpLeast
            // 
            this.lblExpLeast.AutoSize = true;
            this.lblExpLeast.Location = new System.Drawing.Point(22, 49);
            this.lblExpLeast.Name = "lblExpLeast";
            this.lblExpLeast.Size = new System.Drawing.Size(34, 16);
            this.lblExpLeast.TabIndex = 3;
            this.lblExpLeast.Text = "Rs.0";
            // 
            // lblCatExpLeast
            // 
            this.lblCatExpLeast.AutoSize = true;
            this.lblCatExpLeast.Location = new System.Drawing.Point(22, 22);
            this.lblCatExpLeast.Name = "lblCatExpLeast";
            this.lblCatExpLeast.Size = new System.Drawing.Size(40, 16);
            this.lblCatExpLeast.TabIndex = 2;
            this.lblCatExpLeast.Text = "None";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(93, 226);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(34, 16);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Rs.0";
            // 
            // StatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StatisticsView";
            this.Text = "Statistics View";
            this.Load += new System.EventHandler(this.statisticsViewOnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxSelectedAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCatIncMost;
        private System.Windows.Forms.Label lblCatExpMost;
        private System.Windows.Forms.Label lblExpMost;
        private System.Windows.Forms.Label lblIncMost;
        private System.Windows.Forms.Label lblExpLeast;
        private System.Windows.Forms.Label lblCatExpLeast;
        private System.Windows.Forms.Label lblIncLeast;
        private System.Windows.Forms.Label lblCatIncLeast;
        private System.Windows.Forms.Label lblBalance;
    }
}