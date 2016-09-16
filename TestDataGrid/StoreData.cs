using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataGrid
{
    public partial class StoreData : Form
    {
        public string StoreNumber;
        public StoreData()
        {
            InitializeComponent();
        }

        private void StoreData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bABWMstrDataDataSet.vwStoreDim' table. You can move, or remove it, as needed.
            this.vwStoreDimTableAdapter.Fill(this.bABWMstrDataDataSet.vwStoreDim,StoreNumber);

        }
    }
}
