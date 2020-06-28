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
    public partial class MainPanel : Form
    {
        private Product selectedProduct;
        private Employee selectedEmployee;
        private Order selectedOrder;

        public MainPanel()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductPanel addProductPanel = new AddProductPanel();
            addProductPanel.Show();
        }

        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                dataGridViewProducts.DataSource = unitOfWork.Products.GetAll();
            }
        }

        private void MainPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedProduct = new Product();
            selectedProduct.ProductId = Int32.Parse(dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
            selectedProduct.Name = dataGridViewProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            selectedProduct.Brand = dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedProduct.Price = Double.Parse(dataGridViewProducts.Rows[e.RowIndex].Cells[3].Value.ToString());
            selectedProduct.Count = Int32.Parse(dataGridViewProducts.Rows[e.RowIndex].Cells[4].Value.ToString());

            productIdBox.Text = selectedProduct.ProductId.ToString();
            productNameBox.Text = selectedProduct.Name;
            productBrandBox.Text = selectedProduct.Brand;
            productPriceBox.Text = selectedProduct.Price.ToString();
            productCountBox.Text = selectedProduct.Count.ToString();
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                try
                {
                    Product product = unitOfWork.Products.Get(selectedProduct.ProductId);
                    product.Name = productNameBox.Text;
                    product.Brand = productBrandBox.Text;
                    product.Price = Double.Parse(productPriceBox.Text);
                    product.Count = Int32.Parse(productCountBox.Text);
                    unitOfWork.Products.Update(product);
                    unitOfWork.Complete();
                }
                catch
                {
                    MessageBox.Show("Campuri necompletate.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                Product product = unitOfWork.Products.Get(selectedProduct.ProductId);
                unitOfWork.Products.Remove(product);
                unitOfWork.Complete();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                dataGridViewOrders.DataSource = unitOfWork.Orders.GetAll();
            }
        }

        private void customersRefreshButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                dataGridViewCustomers.DataSource = unitOfWork.Customers.GetAll();
            }
        }

        private void employeeRefreshButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                dataGridViewEmployees.DataSource = unitOfWork.Employees.GetAll();
            }
        }

        private void logRefreshButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                dataGridViewLogs.DataSource = unitOfWork.Logs.GetAll();
            }
        }

        private void dataGridViewCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridViewEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedEmployee = new Employee();
            selectedEmployee.EmployeeId = Int32.Parse(dataGridViewEmployees.Rows[e.RowIndex].Cells[0].Value.ToString());
            selectedEmployee.Name = dataGridViewEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
            selectedEmployee.PhoneNumber = dataGridViewEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedEmployee.Adress = dataGridViewEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
            selectedEmployee.EmployementDate = DateTime.Parse(dataGridViewEmployees.Rows[e.RowIndex].Cells[4].Value.ToString());

            employeeIdBox.Text = selectedEmployee.EmployeeId.ToString();
            employeeNameBox.Text = selectedEmployee.Name;
            employeePhoneBox.Text = selectedEmployee.PhoneNumber;
            employeeAdressBox.Text = selectedEmployee.Adress;
            employeeDateBox.Text = selectedEmployee.EmployementDate.ToString();
        }

        private void employeeUpdateButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                try
                {
                    Employee employee = unitOfWork.Employees.Get(selectedEmployee.EmployeeId);
                    employee.Name = employeeNameBox.Text;
                    employee.PhoneNumber = employeePhoneBox.Text;
                    employee.Adress = employeeAdressBox.Text;

                    unitOfWork.Employees.Update(employee);
                    unitOfWork.Complete();
                }
                catch
                {
                    MessageBox.Show("Campuri necompletate.");
                }
            }
        }

        private void employeeRemoveButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                Employee employee = unitOfWork.Employees.Get(selectedEmployee.EmployeeId);
                unitOfWork.Employees.Remove(employee);
                unitOfWork.Complete();
            }
        }

        private void orderCompleteButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                Product product = unitOfWork.Products.Get(selectedOrder.ProductId);
                product.Count -= selectedOrder.Quantity;
                if (product.Count <= 1)
                {
                    unitOfWork.Products.Remove(product);
                    unitOfWork.Orders.Remove(selectedOrder);
                }
                else
                {
                    unitOfWork.Orders.Remove(selectedOrder);
                    unitOfWork.Products.Update(product);
                }
                unitOfWork.Complete();
            }
        }

        private void dataGridViewOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedOrder = new Order();
            selectedOrder.OrderId = Int32.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            selectedOrder.CustomerId = Int32.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells[1].Value.ToString());
            selectedOrder.ProductId = Int32.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells[2].Value.ToString());
            selectedOrder.EmployeeId = Int32.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells[3].Value.ToString());
            selectedOrder.Quantity = Int32.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                dataGridViewProducts.DataSource = unitOfWork.Products.SearchProducts(searchTermBox.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = comboBox1.SelectedItem.ToString();

            using (var unitOfWork = new UnitOfWork(new MyMusicContext()))
            {
                switch (option)
                {
                    case "Alphabetically":
                        dataGridViewProducts.DataSource = unitOfWork.Products.OrderProductsByName();
                        break;
                    case "Price Asc":
                        dataGridViewProducts.DataSource = unitOfWork.Products.OrderProductsByPriceAsc();
                        break;
                    case "Price Desc":
                        dataGridViewProducts.DataSource = unitOfWork.Products.OrderProductsByPriceDesc();
                        break;
                }
            }
        }
    }
}
