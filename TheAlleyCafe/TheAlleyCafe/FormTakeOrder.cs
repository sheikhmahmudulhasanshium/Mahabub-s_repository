using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormTakeOrder : Form
    {
        private FormOrderInformation FormOrderInformation { set; get; }
        private DataAccess DataAccess { set; get; }
        private DataTable Table { set; get; }
        private int UserId { set; get; }
        private float TotalPrice { set; get; }
        private int rowCounter = 0;

        public FormTakeOrder()
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
            this.Table = new DataTable();
            this.PopulateGridView();
            this.CreateOrderContentTable();
            panelOrderInfo.Visible = false;
        }      
        public FormTakeOrder(FormOrderInformation formOrderInformation, int userId)
        {
            InitializeComponent();
            this.FormOrderInformation = formOrderInformation;
            this.DataAccess = new DataAccess();
            this.Table = new DataTable();
            this.UserId = userId;
            this.PopulateGridView();
            this.CreateOrderContentTable();
            panelOrderInfo.Visible = false;
        }
        public void PopulateGridView(string sql = "SELECT * FROM Categories;")
        {
            var ds = this.DataAccess.ExecuteQuery(sql);
            this.numQuantity.Value = 1;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                this.cmbCategories.Items.Add(new KeyValuePair<string, string>(row["Name"].ToString(), row["Id"].ToString()));
                this.cmbCategories.ValueMember = "Value";
                this.cmbCategories.DisplayMember = "Key";
            }
        }
        public void CreateOrderContentTable()
        {
            string[] columns = { "Category", "Food", "Quantity", "Price", "Delete", "CategoryId", "FoodId" };

            foreach (var column in columns)
            {
                this.Table.Columns.Add(column, typeof(string));
            }
        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryId = ((KeyValuePair<string, string>)this.cmbCategories.SelectedItem).Value;

            string sql = "SELECT * FROM Foods WHERE CategoryId=" + categoryId;

            var ds = this.DataAccess.ExecuteQuery(sql);

            this.cmbFoods.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                this.cmbFoods.Items.Add(new KeyValuePair<string, string>(row["Name"].ToString(), row["Id"].ToString()));
                this.cmbFoods.ValueMember = "Value";
                this.cmbFoods.DisplayMember = "Key";
            }

            this.panelOrderInfo.Visible = true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            this.dvgDisplayOrder.AutoGenerateColumns = false;

            var categoryName = ((KeyValuePair<string, string>)this.cmbCategories.SelectedItem).Key;
            var foodName = ((KeyValuePair<string, string>)this.cmbFoods.SelectedItem).Key;
            var quantity = this.numQuantity.Value;
            var categoryId = ((KeyValuePair<string, string>)this.cmbCategories.SelectedItem).Value;
            string foodId = ((KeyValuePair<string, string>)this.cmbFoods.SelectedItem).Value;
            var deleteButton = "Delete";

            var sql = "SELECT Price FROM Foods WHERE Id='" + foodId + "';";
            var ds = this.DataAccess.ExecuteQuery(sql);
            var price = float.Parse(ds.Tables[0].Rows[0]["Price"].ToString()) * (int)this.numQuantity.Value;

            this.TotalPrice += price;

            this.Table.Rows.Add(categoryName, foodName, quantity, price, deleteButton, categoryId, foodId);

            var row = this.Table.Rows[this.rowCounter++].ItemArray;
            this.dvgDisplayOrder.Rows.Add(row);


            this.numQuantity.Value = 1;
        }

        private void dvgDisplayOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgDisplayOrder.Columns["Delete"].Index)
            {
                this.TotalPrice -= float.Parse(this.Table.Rows[e.RowIndex]["Price"].ToString());
                dvgDisplayOrder.Rows.RemoveAt(e.RowIndex);
                this.Table.Rows[e.RowIndex].Delete();
                this.rowCounter--;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var totalPrice = this.TotalPrice;
            if (this.chkVat.Checked)
            {
                totalPrice = (totalPrice * 0.15f) + totalPrice;
            }

            try
            {
                var sql = "INSERT INTO Orders (Price, Date, EmployeeId) output inserted.ID VALUES ('" + totalPrice + "', " +
                    "'"+ this.dtpDate.Value.ToString("yyyy-MM-dd") + "', '"+this.UserId+"');";
                //MessageBox.Show($"{this.UserId}");
                var orderId = this.DataAccess.ExecuteScalar(sql);
                var employeeId = this.DataAccess.ExecuteScalar(sql);

                foreach (DataRow row in this.Table.Rows)
                {
                    var subSql = "INSERT INTO OrdersItems (OrderId, FoodId, Quantity, Price) VALUES ('" + orderId + "', '" + row["foodId"].ToString() +
                        "', '" + row["Quantity"].ToString() + "', '" + row["Price"].ToString() + "');";

                    this.DataAccess.ExecuteQuery(subSql);
                }
                this.dvgDisplayOrder.Rows.Clear();
                this.Table.Clear();

                FormReceipt formReceipt = new FormReceipt(orderId);
                formReceipt.Visible = true;

            } catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void FormTakeOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormOrderInformation.Visible = true;
            this.Visible = false;
        }
    }
}
