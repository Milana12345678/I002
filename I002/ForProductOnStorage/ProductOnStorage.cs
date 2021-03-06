using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I002
{
    public partial class ProductOnStorage : Form
    {
        public ProductOnStorage()
        {
            InitializeComponent();
        }

        private void ProductOnStorage_Load(object sender, EventArgs e)
        {
            EntityProductOnStorage product = new EntityProductOnStorage();
            product.ReadProduct(tableForProducts);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BuyProduct product = new BuyProduct();
            product.Show();
            EntityProductOnStorage entityProduct = new EntityProductOnStorage();
            entityProduct.ReadProduct(tableForProducts);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SellProductForm sellProductForm = new SellProductForm();
            sellProductForm.Show();
            EntityProductOnStorage entityProduct = new EntityProductOnStorage();
            entityProduct.ReadProduct(tableForProducts);
           
        }

        private void TxtFind_TextChanged(object sender, EventArgs e)
        {
            EntityProductOnStorage storage = new EntityProductOnStorage();
            storage.FindProduct(tableForProducts, TxtFind.Text);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabFind_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
