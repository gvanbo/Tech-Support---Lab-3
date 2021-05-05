using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech_Support___Lab_3.Models;
using System.Text.RegularExpressions;

namespace Tech_Support___Lab_3
{
    public partial class AddModify : Form
    {
        TechSupportContext context = new TechSupportContext();
        public AddModify()
        {
            InitializeComponent();
        }

        public Product currentProduct { get; set; }
        public bool AddButtonSet { get; set; }

        private Product product = null;

        // Close the form, return to Form1
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddModify_Load(object sender, EventArgs e)
        {
            if (AddButtonSet == false) // Modify button clicked on form 1
            {
                productCodeTxt.Enabled = false; // this prevents user from modifying a primary key
                productCodeTxt.Text = currentProduct.ProductCode;
                nameTxt.Text = currentProduct.Name;
                versionTxt.Text = currentProduct.Version.ToString();
                releaseDateTxt.Text = currentProduct.ReleaseDate.ToString();
            }
        }

        // Save current product to database
        public void OKBtn_Click(object sender, EventArgs e)
        {
            product = new Product
            {
                ProductCode = productCodeTxt.Text,
                Name = nameTxt.Text,
                Version = Convert.ToDecimal(versionTxt.Text),
                ReleaseDate = Convert.ToDateTime(releaseDateTxt.Text)
            };

            if (AddButtonSet == false)
                context.Products.Update(product);
            else context.Products.Add(product);

            DialogResult save =
                MessageBox.Show(
                    $"Saving this Entry:\nCode: {productCodeTxt.Text}\nName: {nameTxt.Text}\nVersion: {versionTxt.Text}\n" +
                    $"Release Date: {releaseDateTxt.Text}",
                    "Confirm Entry",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            if (save == DialogResult.OK)
            {
                context.SaveChanges();
                this.Close();

            }

        }

        /// <summary>
        /// Validate Product Code - not longer than 10 characters, must be unique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productCodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (productCodeTxt.Text.Length > 10)
                MessageBox.Show("This field must be less than 10 characters");
        }

        /// <summary>
        ///  Vaoidate Product Code,  Check aginst primary keys in ProductCode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productCodeTxt_Validating(object sender, CancelEventArgs e)
        {

            if (productCodeTxt.Text == "")
            {
                MessageBox.Show($"Entry Error:\nProduct Code is a required field.");
                productCodeTxt.Focus();
            }

            else if (context.Products.Where(p => (p.ProductCode == productCodeTxt.Text)).Count() > 0)
            {
                MessageBox.Show("That Product code already exists.  Choose a unique product code");
                productCodeTxt.Focus();
                productCodeTxt.SelectAll();
            }

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                MessageBox.Show($"Entry Error:\nName is a required field.");
                versionTxt.Focus();
            }

            if (nameTxt.Text.Length > 50)
            {
                MessageBox.Show("The maximum amount of characters for a Product Name is 50");
                nameTxt.Focus();
                nameTxt.SelectAll();
            }
        }


        private void versionTxt_Validating(object sender, CancelEventArgs e)
        {
            if (versionTxt.Text == "")
            {
                MessageBox.Show($"Entry Error:\nVersion is a required field.");
                versionTxt.Focus();
            }
            else if (!Decimal.TryParse(versionTxt.Text, out _))
            {
                MessageBox.Show($"Entry Error\nVersion value must be a decimal ex: 0.0");
                versionTxt.Focus();
            }
        }

        private void releaseDateTxt_Validating(object sender, CancelEventArgs e)
        {
            if (releaseDateTxt.Text == "")
            {
                MessageBox.Show($"Entry Error:\nRelease Date is a required field.");
                versionTxt.Focus();
            }

            if (!DateTime.TryParse(releaseDateTxt.Text, out _))
            {
                MessageBox.Show($"Entry Error\nMust be a valid date\nPreferred Format: YYYY/MM/DD");
                releaseDateTxt.Focus();
            }
        }
    }
}