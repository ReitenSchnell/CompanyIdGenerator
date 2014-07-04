using System;
using System.Web.UI;

namespace CompanyIdGenerator
{
    public partial class Default : Page
    {
        protected void Page_Load (object sender, EventArgs e)
        {            
            genCode.Click += btnGenerate_Click;
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            //var clickedButton = (Button)sender;
            if (sweCompany.Checked)
            {
                codeBox.Text = string.Empty;
                codeBox.Text = SweCompanyCode.Generate();
            }
            else if (finCompany.Checked)
            {
                codeBox.Text = string.Empty;
                codeBox.Text = FinCompanyCode.Generate();
            }
            else if (sweTax.Checked)
            {
                codeBox.Text = string.Empty;
                codeBox.Text = SweTaxCode.Generate();
            }
            else if (finTax.Checked)
            {
                codeBox.Text = string.Empty;
                codeBox.Text = FinTaxCode.Generate();
            }
            else
            {
                codeBox.Text = string.Empty;
                codeBox.Text = "Please select code type";
            }
        }
    }
}