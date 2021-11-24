using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormHome : Form
    {
        private FormLogin Logout { get; set; }
        private DataAccess DataAccess { set; get; }
        private DataRow UserData { set; get; }
        private int UserId { set; get; }
        private FormEmployee FormEmployee { set;get; }
        public FormHome()
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
        }
        public FormHome(FormLogin logout, DataRow userData)
        {
            InitializeComponent();
            this.Logout = logout;
            this.UserData = userData;
            this.UserId = int.Parse(this.UserData["Id"].ToString());

            if (this.UserData["Role"].ToString() != "Admin")
            {
                this.btnEmployee.Hide();
            }
        }

        public DataTable PopulateGridView(string sql)
        {
            var ds = this.DataAccess.ExecuteQuery(sql);
            return ds.Tables[0];
        }


        private void btnItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormItemsInfo formItemsInfo = new FormItemsInfo(this);
            formItemsInfo.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FormOrderInformation orders = new FormOrderInformation(this,this.UserId);
            this.Visible = false;
            orders.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee(this);
            this.Visible = false;
            formEmployee.Visible = true;
        }

        private void linkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            this.Logout.Visible = true;
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
