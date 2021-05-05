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
using Microsoft.EntityFrameworkCore;

namespace Tech_Support___Lab_3
{
    public partial class TechnicalSupportFrm : Form
    {
        TechSupportContext context;
        Product currentProduct;
        

        public TechnicalSupportFrm()
        {
            InitializeComponent();
        }

        

        private void TechnicalSupportFrm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            context = new TechSupportContext();
            productsDataGrid.AutoGenerateColumns = false;
            productsDataGrid.DataSource = context.Products.ToList();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string productId;
        public void productsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (productsDataGrid.SelectedRows.Count > 0)
            {

                currentProduct = (Product)productsDataGrid.SelectedRows[0].DataBoundItem;
                int index = productsDataGrid.SelectedCells[0].RowIndex;             /// Displays current product in text field for cust info
                string productId = (string)productsDataGrid.Rows[index].Cells[0].Value;

                
                displayCurrentProducttxt.Text = productId;          
                
            }
        }

        /// <summary>
        /// Removes selected record from Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeBtn_Click(object sender, EventArgs e)
        {
            DialogResult button = 
                MessageBox.Show(
                    "Are you sure that you want to remove the selected record?",
                    "Remove Item",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            if (button == DialogResult.OK)
            {
            context.Products.Remove(currentProduct);
            context.SaveChanges();
            Display();

            }
            
        }

        public bool AddButtonSet { get; set; }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddModify addNew = new AddModify();    //opens new form to add a record
            addNew.AddButtonSet = true;
            addNew.ShowDialog();
            Display();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            AddModify modifyProduct = new AddModify();    // opens a new form  to modify selected record
            modifyProduct.currentProduct = currentProduct;
            modifyProduct.AddButtonSet = false;
            modifyProduct.ShowDialog();
            Display();
        }
    }
}
