using System;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormItemsInfo : Form
    {
        private FormLogin Logout { get; set; }
        private FormHome FormHome { set; get; }
        private DataAccess DataAccess { set; get; }

        public string selectedCategory = "Coffee";

        private UserControlDisplayDrinks UserControlDisplayDrinks { get; set; }
        private UserControlDisplaySandwiches UserControlDisplaySandwiches { get; set; }
        private UserControlDisplayBakery UserControlDisplayBakery { get; set; }

        public FormItemsInfo()
        {
            InitializeComponent();
            this.UserControlDisplayDrinks = new UserControlDisplayDrinks();
            this.UserControlDisplaySandwiches = new UserControlDisplaySandwiches();
            this.UserControlDisplayBakery = new UserControlDisplayBakery();
            this.DataAccess = new DataAccess();
        }
        public FormItemsInfo(FormHome formHome)
        {
            InitializeComponent();
            this.FormHome = formHome;
            this.UserControlDisplayDrinks = new UserControlDisplayDrinks();
            this.UserControlDisplaySandwiches = new UserControlDisplaySandwiches();
            this.UserControlDisplayBakery = new UserControlDisplayBakery();
            this.DataAccess = new DataAccess();
        }

        public FormItemsInfo(FormLogin logout)
        {
            InitializeComponent();
            this.Logout = logout;
        }

        private void linkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            this.Logout.Visible = true;
        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            this.selectedCategory = "Coffee";
            this.panelDisplayDrinks.Controls.Clear();

            this.panelDisplayDrinks.Controls.Add(this.UserControlDisplayDrinks);
        }
        private void btnSandwiches_Click(object sender, EventArgs e)
        {
            this.selectedCategory = "Sandwiches";
            this.panelDisplayDrinks.Controls.Clear();

            UserControlDisplaySandwiches displaySandwiches = new UserControlDisplaySandwiches();
            this.panelDisplayDrinks.Controls.Add(displaySandwiches);
        }
        private void btnBakery_Click(object sender, EventArgs e)
        {
            this.selectedCategory = "Bakery";
            this.panelDisplayDrinks.Controls.Clear();

            UserControlDisplayBakery displayBakery = new UserControlDisplayBakery();
            this.panelDisplayDrinks.Controls.Add(displayBakery);
        }
        private void FormItemsInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormHome.Visible = true;
            this.Visible = false;
        }
        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            FormAddItemToList addItemToList;
            addItemToList = new FormAddItemToList(this, this.UserControlDisplayDrinks);
            addItemToList.Visible = true;
        }
        private void btnAddSandwiches_Click(object sender, EventArgs e)
        {
            FormAddItemToList addItemToList;
            addItemToList = new FormAddItemToList(this, this.UserControlDisplaySandwiches);
            addItemToList.Visible = true;
        }
        private void btnAddBakery_Click(object sender, EventArgs e)
        {
            FormAddItemToList addItemToList;
            addItemToList = new FormAddItemToList(this, this.UserControlDisplayBakery);
            addItemToList.Visible = true;
        }
    }
}
