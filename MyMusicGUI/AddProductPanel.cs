using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMusicBusiness;
using MyMusicPersistence;
using Microsoft.EntityFrameworkCore;

namespace MyMusicGUI
{
    public partial class AddProductPanel : Form
    {
        public AddProductPanel()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                unitOfWork.Products.Add(new Product(productNameBox.Text,
                    productBrandBox.Text, 
                    Double.Parse(productPriceBox.Text),
                    Int32.Parse(productCountBox.Text)));
                unitOfWork.Complete();
            }
            this.Hide();
        }
    }
}
