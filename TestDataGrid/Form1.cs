using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management.Automation;
//change1
namespace TestDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oSDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oSDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTOpsEngineeringDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTOpsEngineeringDataSet.OSD' table. You can move, or remove it, as needed.
            this.oSDTableAdapter.Fill(this.iTOpsEngineeringDataSet.OSD);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s=oSDDataGridView.CurrentRow.Cells[0].ToString();

            DataGridViewRow row=oSDDataGridView.SelectedRows[0];
            int id = (int)row.Cells[0].Value;
     //       System.Windows.Forms.MessageBox.Show("id="+id.ToString());

             Details1 D = new Details1();
             D.ID = id;
             D.ShowDialog();


        }

        private void Filterbutton_Click(object sender, EventArgs e)
        {
            string filterString = FiltertextBox.Text;
            char separator=' ';
            if(filterString.Contains(','))
                separator=',';
            else if(filterString.Contains(';'))
                separator=';';
            else if(filterString.Contains('-'))
                separator='-';
            else if(filterString.Contains(':'))
                separator=':';
            
            string[]filter=filterString.Split((separator));
            string SqlFilter = null;
            foreach(string i in filter)
            {
                if (!string.IsNullOrEmpty(SqlFilter))
                    SqlFilter += " or ";

                 SqlFilter += "HostName like '%" + i + "%'";
            }



            BindingSource bs = new BindingSource();
            bs.DataSource = oSDDataGridView.DataSource;
            bs.Filter = SqlFilter;
            oSDDataGridView.DataSource = bs;
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {

            this.oSDTableAdapter.Fill(this.iTOpsEngineeringDataSet.OSD);
        }

        private void StoreDetailsbutton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = oSDDataGridView.SelectedRows[0];
            string HostName = (string)row.Cells[2].Value;
            string StoreNumber=HostName.Substring(3, 4);

            StoreData sd = new StoreData();
            sd.StoreNumber = StoreNumber;
            sd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PowerShell ps = PowerShell.Create();

            //ps.AddScript("C:\\Users\\dales\\documents\\visual studio 2013\\Projects\\WindowsFormsPowershell\\WindowsFormsPowershell\\pstest.ps1");
            //    ps.AddCommand("Set-ExecutionPolicy");
            //    ps.AddParameter("ExecutionPolicy", "RemoteSigned");
            //    ps.Invoke();
            //    ps.Commands.Clear();
            ps.AddCommand("C:\\Users\\dales\\documents\\visual studio 2013\\Projects\\WindowsFormsPowershell\\WindowsFormsPowershell\\pstest.ps1");
            ps.AddCommand("C:\\Users\\dales\\documents\\visual studio 2013\\Projects\\WindowsFormsPowershell\\WindowsFormsPowershell\\pstest.ps1");
            //    ps.AddCommand("powershell");
            //     ps.Invoke();


            foreach (PSObject result in ps.Invoke())
            {
                string tempstr = string.Format("{0}-{1}\r\n", result.Members["ProcessName"].Value, result.Members["ID"].Value);
                textBox1.Text += tempstr;
            }
        }
    }
}
