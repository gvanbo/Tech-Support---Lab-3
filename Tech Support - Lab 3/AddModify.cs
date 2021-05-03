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
            if (AddButtonSet == false) 
            {
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

            MessageBox.Show($"New product added\nCode: {productCodeTxt.Text}\n" +
                $"Name: {nameTxt.Text}\nVersion: {versionTxt.Text}\nRelease Date: {releaseDateTxt.Text}");
            this.Close();
        }
    }
}
