using ExpenseTracker.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Views.Predections
{
    public partial class CategoryBasedPredection : Form
    {
        private ExpenseTrackerDataSet dbInfo;

        public CategoryBasedPredection(ExpenseTrackerDataSet dbInfo)
        {
            this.dbInfo = dbInfo;
            InitializeComponent();
        }

        private void btnLoadGraphClick(object sender, EventArgs e)
        {

            chartTransaction.Series[0].XValueMember = "Key";
            chartTransaction.Series[0].YValueMembers = "Total";
   
            var source = from T in this.dbInfo.Transaction.AsEnumerable()
                         join C in this.dbInfo.Category.AsEnumerable() on T.Field<int>("Category_Id") equals C.Field<int>("ID") into T1
                         from C in T1.DefaultIfEmpty()
                         join A in this.dbInfo.FinancialAccount.AsEnumerable() on T.Field<int>("FinancialAccount_Id") equals A.Field<int>("ID") into T2
                         from A in T2.DefaultIfEmpty()
                         select new
                         {
                             ID = T.Field<int>("Id"),
                             Type = T.Field<string>("Type"),
                             Name = C.Field<String>("Name"),
                             CatId = T.Field<int>("Category_Id"),
                             Amount = T.Field<decimal>("Amount"),
                             FA = T.Field<int>("FinancialAccount_Id")
                         };

            source = source.Where(x => x.FA == (cboxSelectedAccount.SelectedIndex + 1) && x.Type == cboxType.Text);
            var source2 = source.GroupBy(Tr => Tr.Name).Select(Group => new { Group.Key, Total = Group.Sum(Tr => Tr.Amount) });
            chartTransaction.DataSource = source2.ToList();
            chartTransaction.DataBind();
        }

        private void categoryBasedPredectionOnload(object sender, EventArgs e)
        {
            cboxSelectedAccount.DataSource = this.dbInfo.FinancialAccount;
            cboxSelectedAccount.DisplayMember = "Name";
            cboxSelectedAccount.ValueMember = "Id";
            cboxType.SelectedIndex = 0;
        }
    }
}
