using ExpenseTracker.DataAccess.DataObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker.Views.FinancialAccount
{
    public partial class AddFinancialAccount : Form
    {
        public FinancialAccountInfo FinancialAccData { get; set; }

        public AddFinancialAccount()
        {
            InitializeComponent();
            SetUpViewData();
        }

        private void TboxName_TextChanged(object sender, EventArgs e)
        {
            // clear the error associated
            errorProvider.SetError(tboxName, string.Empty);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tboxName.Text))
            {
                isValid = false;
                errorProvider.SetError(tboxName, Properties.Resources.ADD_NAME_MANDATORY);
            }

            if (tboxName.Text.Length > 30)
            {
                isValid = false;
                errorProvider.SetError(tboxName, Properties.Resources.ADD_NAME_MAX_LENGTH);
            }
            if (String.IsNullOrEmpty(tboxBalance.Text))
            {
                isValid = false;
                errorProvider.SetError(tboxBalance, string.Empty);
            }

            if (isValid)
            {
                this.FinancialAccData = new FinancialAccountInfo();
                FinancialAccData.FinancialAccName = tboxName.Text;
                FinancialAccData.FinancialAccColor = cboxColor.SelectedValue.ToString();
                FinancialAccData.Balance = Convert.ToDecimal(tboxBalance.Text);
                this.Hide();
            }
        }

        private void SetUpViewData()
        {
            tboxName.TextChanged += TboxName_TextChanged;

            // setting up the form title
            this.Text = Properties.Resources.FA_ADD_NEW;

            // setting up color picker
            cboxColor.DataSource = typeof(Color).GetProperties()
                .Where(x => x.PropertyType == typeof(Color))
                .Select(x => x.GetValue(null)).ToList();
            cboxColor.MaxDropDownItems = 10;
            cboxColor.IntegralHeight = false;
            cboxColor.DrawMode = DrawMode.OwnerDrawFixed;
            cboxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxColor.DrawItem += cboxColor_DrawItem;
        }

        private void cboxColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cboxColor.GetItemText(cboxColor.Items[e.Index]);
                var color = (Color)cboxColor.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cboxColor.Font, r2,
                        cboxColor.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
