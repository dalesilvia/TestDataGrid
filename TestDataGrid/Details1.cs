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
    public partial class Details1 : Form
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Details1()
        {
            InitializeComponent();
        }

        private void oSDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oSDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTOpsEngineeringDataSet);

        }

        private void Details1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTOpsEngineeringDataSet.OSD' table. You can move, or remove it, as needed.
            this.oSDTableAdapter.Fill2(this.iTOpsEngineeringDataSet.OSD, id);

        //    this.oSDTableAdapter.GetDataBy(5);
        }

        private void oSDBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.oSDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTOpsEngineeringDataSet);

        }



        private void button2_Click(object sender, EventArgs e)
        {
          //  "C:\Program Files\Microsoft DaRT\v8.1\DartRemoteViewer.exe" -ticket=118-497-589 -ipaddress=10.5.14.52 -port=49161;

            string remoteApp="C:\\Program Files\\Microsoft DaRT\\v8.1\\DartRemoteViewer.exe";
            string remoteAppArs="-ticket=118-497-589 -ipaddress=10.5.14.52 -port=49161";
            System.Diagnostics.Process.Start(remoteApp,remoteAppArs);
            
        }

        private void ViewLogsbutton_Click(object sender, EventArgs e)
        {
            string LogsPath = string.Format("\\\\{0}00001\\c\\admin\\supporttools\\logs",hostNameTextBox.Text.Substring(0, 7));

            MessageBox.Show(LogsPath);
            string explorerApp = "explorer.exe";
            System.Diagnostics.Process.Start(explorerApp, LogsPath);
        }

        private void ViewClientLogsbutton_Click(object sender, EventArgs e)
        {
            string LogsPath = string.Format("\\\\{0}\\c\\admin\\supporttools\\logs", hostNameTextBox.Text);

            MessageBox.Show(LogsPath);
            string explorerApp = "explorer.exe";
            System.Diagnostics.Process.Start(explorerApp, LogsPath);
        }

        private void Netopbutton_Click(object sender, EventArgs e)
        {
            //C:\Program Files (x86)\Netop\Netop Remote Control\Guest> .\ngstw32.exe /h:10.5.5.101 /C:TCP/IP

            string remoteApp="C:\\Program Files (x86)\\Netop\\Netop Remote Control\\Guest\\ngstw32.exe";
            string remoteAppArs = string.Format("/h:{0} /C:TCP/IP", hostNameTextBox.Text);
            System.Diagnostics.Process.Start(remoteApp,remoteAppArs);
        }


    }
}
