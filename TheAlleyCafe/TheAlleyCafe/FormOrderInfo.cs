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
    public partial class FormOrderInformation : Form
    {
        private FormHome FormHome { set; get; }
        private int UserId { set; get; }
        public FormOrderInformation()
        {
            InitializeComponent();
        }
        public FormOrderInformation(FormHome formHome, int userId)
        {
            InitializeComponent();
            this.FormHome = formHome;
            this.UserId = userId;
        }
        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            FormTakeOrder formTakeOrder = new FormTakeOrder(this,this.UserId);
            this.Visible = false;
            formTakeOrder.Visible = true;
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            FormOrderDetails formOrderDetails = new FormOrderDetails();
            formOrderDetails.Visible = true;
        }
        private void FormOrderInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormHome.Visible = true;
            this.Visible = false;
        }
    }
}
