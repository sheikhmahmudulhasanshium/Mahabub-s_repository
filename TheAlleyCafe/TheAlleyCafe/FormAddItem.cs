using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormAddItemToList : Form
    {
        private FormItemsInfo FormItemsInfo { get; set; }
        private DataAccess DataAccess { get; set; }
        private UserControlDisplayDrinks UserControlDisplayDrinks { set; get; }
        private UserControlDisplaySandwiches UserControlDisplaySandwiches { set; get; }
        private UserControlDisplayBakery UserControlDisplayBakery { set; get; }
        private int CategoryId { set; get; }
        public FormAddItemToList()
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
        } 
        public FormAddItemToList(FormItemsInfo formItemInfo, UserControlDisplayDrinks userControlDisplayDrinks)
        {
            InitializeComponent();
            this.CategoryId = 1;
            this.UserControlDisplayDrinks = userControlDisplayDrinks;
            this.FormItemsInfo = formItemInfo;
            this.DataAccess = new DataAccess();
        }
        public FormAddItemToList(FormItemsInfo formItemInfo, UserControlDisplaySandwiches userControlDisplaySandwiches)
        {
            InitializeComponent();
            this.CategoryId = 2;
            this.UserControlDisplaySandwiches = userControlDisplaySandwiches;
            this.FormItemsInfo = formItemInfo;
            this.DataAccess = new DataAccess();
        }
        public FormAddItemToList(FormItemsInfo formItemInfo, UserControlDisplayBakery userControlDisplayBakery)
        {
            InitializeComponent();
            this.CategoryId = 3;
            this.UserControlDisplayBakery = userControlDisplayBakery;
            this.FormItemsInfo = formItemInfo;
            this.DataAccess = new DataAccess();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "INSERT INTO Foods(Name, Price, CategoryId) VALUES('" + this.txtItemName.Text + "', '" + this.txtItemPrice.Text + "', '" + this.CategoryId + "');";
                int count = this.DataAccess.ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    if (this.CategoryId == 1)
                    {
                        this.UserControlDisplayDrinks.PopulateGridView();
                    }
                    if (this.CategoryId == 2)
                    {
                        this.UserControlDisplaySandwiches.PopulateGridView();
                    }
                    if (this.CategoryId == 3)
                    {
                        this.UserControlDisplayBakery.PopulateGridView();
                    }

                    MessageBox.Show("Item Added Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to add new item");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormAddItemToList_Load(object sender, EventArgs e)
        {
            if (this.CategoryId == 1)
            {
                this.lblCategory.Text = "Category: Coffe";
            }
            if (this.CategoryId == 2)
            {
                this.lblCategory.Text = "Category: Sandwiches";
            }
            if (this.CategoryId == 3)
            {
                this.lblCategory.Text = "Category: Bakery";
            }
        }
    }
}
