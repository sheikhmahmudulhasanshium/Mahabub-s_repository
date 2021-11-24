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
    public partial class UserControlDisplayDrinks : UserControl
    {
        private DataAccess DisplayDrinks { get; set; }
        public UserControlDisplayDrinks()
        {
            InitializeComponent();
            this.DisplayDrinks = new DataAccess();

            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "SELECT * FROM Foods WHERE CategoryId = 1;")
        {
            var ds = this.DisplayDrinks.ExecuteQuery(sql);

            this.dgvDisplayItems.AutoGenerateColumns = false;
            this.dgvDisplayItems.DataSource = ds.Tables[0];
        }
    }
}
