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

        private void OKBtn_Click(object sender, EventArgs e)
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


            context.SaveChanges();

            MessageBox.Show($"Saving this Entry:\nCode: {productCodeTxt.Text}\n" +
                $"Name: {nameTxt.Text}\nVersion: {versionTxt.Text}\nRelease Date: {releaseDateTxt.Text}");
            this.Close();
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

        private void productCodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (context.Products.Where(p => (p.ProductCode == productCodeTxt.Text)).Count() > 0)
            {
                MessageBox.Show("That Product code already exists.  Choose a unique product code");
                productCodeTxt.Focus();
                productCodeTxt.SelectAll();
            }


        }
    }
}
