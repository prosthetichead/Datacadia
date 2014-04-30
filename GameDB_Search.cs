using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Datacadia
{
    public partial class GameDB_Search : Form
    {
        string searchString;
        string platform_id;

        public long ReturnedID { get; set; } 

        public GameDB_Search(string searchString, string platform_id, string gameName)
        {
            this.searchString = searchString;
            this.platform_id = platform_id;

            InitializeComponent();
            txtSearch.Text = searchString;
            labGameName.Text = gameName;
            labPlatformName.Text = platform_id;

        }

        private void gameDB_popup_Load(object sender, EventArgs e)
        {
            searchGamesDB();
        }

        private void searchGamesDB()
        {
            DataSet ds;

            searchString = txtSearch.Text;

            string url = string.Format("http://thegamesdb.net/api/GetGamesList.php?name={0}&platform={1}", searchString, platform_id);
            string xml = new WebClient().DownloadString(url);
            using (StringReader stringReader = new StringReader(xml))
            {
                ds = new DataSet();
                ds.ReadXml(stringReader);
            }
            
            listBoxGamesDBResults.DataSource = ds.Tables["Game"];
            listBoxGamesDBResults.DisplayMember = "GameTitle";
            listBoxGamesDBResults.ValueMember = "id";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string value = listBoxGamesDBResults.SelectedValue as string;
            ReturnedID = Convert.ToInt64(value);
            Debug.WriteLine(ReturnedID);
            this.DialogResult = DialogResult.OK;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchGamesDB();
        }
    }
}
