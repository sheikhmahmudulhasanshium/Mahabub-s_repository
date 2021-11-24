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
    public partial class UserControlDisplayBakery : UserControl
    {
        private DataAccess DisplayBakery { get; set; }
        public UserControlDisplayBakery()
        {
            InitializeComponent();
            this.DisplayBakery = new DataAccess();

            this.PopulateGridView();
        }

        public void PopulateGridView(string sql = "SELECT * FROM Foods WHERE CategoryId = 3;")
        {
            var ds = this.DisplayBakery.ExecuteQuery(sql);

            this.dgvDisplayBakery.AutoGenerateColumns = false;
            this.dgvDisplayBakery.DataSource = ds.Tables[0];
        }
    }
}
