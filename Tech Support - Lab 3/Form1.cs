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
            context = new TechSupportContext();
            productsDataGrid.AutoGenerateColumns = false;
            productsDataGrid.DataSource = context.Products.ToList();

            productsListB.DataSource = context.Products.AsEnumerable();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string productId;
        private void productsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (productsDataGrid.SelectedRows.Count > 0)
            {
                int index = productsDataGrid.SelectedCells[0].RowIndex;
                string productId = (string)productsDataGrid.Rows[index].Cells[0].Value;

                
                displayCurrentProducttxt.Text = productId;
            }
        }


    }
}
