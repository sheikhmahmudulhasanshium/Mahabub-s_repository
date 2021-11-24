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
    public partial class UserControlDisplaySandwiches : UserControl
    {
        private DataAccess DisplaySandwiches { get; set; }
        public UserControlDisplaySandwiches()
        {
            InitializeComponent();
            this.DisplaySandwiches = new DataAccess();

            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "SELECT * FROM Foods WHERE CategoryId = 2;")
        {
            var ds = this.DisplaySandwiches.ExecuteQuery(sql);

            this.dgvDisplaySandwiches.AutoGenerateColumns = false;
            this.dgvDisplaySandwiches.DataSource = ds.Tables[0];
        }

    }
}
