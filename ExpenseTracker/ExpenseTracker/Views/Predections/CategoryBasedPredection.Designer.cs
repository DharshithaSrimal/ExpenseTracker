namespace ExpenseTracker.Views.Predections
{
    partial class CategoryBasedPredection
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTransaction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadGraph = new System.Windows.Forms.Button();
            this.cboxSelectedAccount = new System.Windows.Forms.ComboBox();
            this.cboxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTransaction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTransaction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTransaction.Legends.Add(legend1);
            this.chartTransaction.Location = new System.Drawing.Point(47, 59);
            this.chartTransaction.Name = "chartTransaction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Category";
            this.chartTransaction.Series.Add(series1);
            this.chartTransaction.Size = new System.Drawing.Size(520, 358);
            this.chartTransaction.TabIndex = 0;
            this.chartTransaction.Text = "Category Based Predection";
            // 
            // btnLoadGraph
            // 
            this.btnLoadGraph.Location = new System.Drawing.Point(587, 139);
            this.btnLoadGraph.Name = "btnLoadGraph";
            this.btnLoadGraph.Size = new System.Drawing.Size(187, 23);
            this.btnLoadGraph.TabIndex = 1;
            this.btnLoadGraph.Text = "Load Graph";
            this.btnLoadGraph.UseVisualStyleBackColor = true;
            this.btnLoadGraph.Click += new System.EventHandler(this.btnLoadGraphClick);
            // 
            // cboxSelectedAccount
            // 
            this.cboxSelectedAccount.FormattingEnabled = true;
            this.cboxSelectedAccount.Location = new System.Drawing.Point(584, 59);
            this.cboxSelectedAccount.Name = "cboxSelectedAccount";
            this.cboxSelectedAccount.Size = new System.Drawing.Size(187, 24);
            this.cboxSelectedAccount.TabIndex = 2;
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cboxType.Location = new System.Drawing.Point(584, 98);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(187, 24);
            this.cboxType.TabIndex = 3;
            // 
            // CategoryBasedPredection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.cboxSelectedAccount);
            this.Controls.Add(this.btnLoadGraph);
            this.Controls.Add(this.chartTransaction);
            this.Name = "CategoryBasedPredection";
            this.Text = "Predection";
            this.Load += new System.EventHandler(this.categoryBasedPredectionOnload);
            ((System.ComponentModel.ISupportInitialize)(this.chartTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTransaction;
        private System.Windows.Forms.Button btnLoadGraph;
        private System.Windows.Forms.ComboBox cboxSelectedAccount;
        private System.Windows.Forms.ComboBox cboxType;
    }
}