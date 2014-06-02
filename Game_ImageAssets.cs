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
using System.Xml.Linq;

namespace Datacadia
{
    public partial class Game_ImageAssets : Form
    {
        long platform_id;
        string game_file_name;
        long gamedb_id;
        string images_path;

        string imageType;
        string currentImagePath;

        string baseImgURL;
        XDocument xmlDoc;
        
        public Game_ImageAssets(long platform_id, string game_file_name, long gamedb_id, string images_path)
        {
            this.platform_id = platform_id;
            this.game_file_name = game_file_name;
            this.gamedb_id = gamedb_id;
            this.images_path = images_path;
            InitializeComponent();
        }

        private void Game_Images_Load(object sender, EventArgs e)
        {
            GetXML();
            getGameDB_ClearLogo();

            labSerchType.Text = "Clear Logo";
            imageType = "clearlogo";
            loadPictureBox();
            
        }

        private void getGameDB_FanArtIcons()
        {
            //Get FanArt Icons
            listView.Items.Clear();

            ImageList imagesFanArt = new ImageList();
            imagesFanArt.ImageSize = new Size(128, 128);
            imagesFanArt.ColorDepth = ColorDepth.Depth32Bit;
            int counter = 0;
            foreach (XElement fanArt_node in xmlDoc.Descendants("fanart"))
            {
                string thumb = fanArt_node.Element("thumb").Value;
                string original = fanArt_node.Element("original").Value;

                string thumbImgUrl = baseImgURL + thumb;
                string originalImgUrl = baseImgURL + original;
                imagesFanArt.Images.Add(LoadImage(thumbImgUrl));

                listView.Items.Add(originalImgUrl, counter);
                counter++;
            }

            listView.LargeImageList = imagesFanArt;
            listView.View = View.LargeIcon;
        }
        private void getGameDB_ScreenshotIcons()
        {
            listView.Items.Clear();

            ImageList imagesFanArt = new ImageList();
            imagesFanArt.ImageSize = new Size(128, 128);
            imagesFanArt.ColorDepth = ColorDepth.Depth32Bit;
            int counter = 0;
            foreach (XElement fanArt_node in xmlDoc.Descendants("screenshot"))
            {
                string thumb = fanArt_node.Element("thumb").Value;
                string original = fanArt_node.Element("original").Value;

                string thumbImgUrl = baseImgURL + thumb;
                string originalImgUrl = baseImgURL + original;
                imagesFanArt.Images.Add(LoadImage(thumbImgUrl));

                listView.Items.Add(originalImgUrl, counter);
                counter++;
            }

            listView.LargeImageList = imagesFanArt;
            listView.View = View.LargeIcon;
        }
        private void getGameDB_ClearLogo()
        {
            listView.Items.Clear();

            ImageList imagesFanArt = new ImageList();
            imagesFanArt.ImageSize = new Size(128, 128);
            imagesFanArt.ColorDepth = ColorDepth.Depth32Bit;
            int counter = 0;
            foreach (XElement fanArt_node in xmlDoc.Descendants("clearlogo"))
            {
                string thumb = fanArt_node.Value;
                string original = fanArt_node.Value;

                string thumbImgUrl = baseImgURL + thumb;
                string originalImgUrl = baseImgURL + original;
                imagesFanArt.Images.Add(LoadImage(thumbImgUrl));

                listView.Items.Add(originalImgUrl, counter);
                counter++;
            }

            listView.LargeImageList = imagesFanArt;
            listView.View = View.LargeIcon;
        }

        private void GetXML()
        {
            string url = string.Format("http://thegamesdb.net/api/GetArt.php?id={0}", gamedb_id);
            string xml = new WebClient().DownloadString(url);
            
            StringReader stringReader = new StringReader(xml);
            xmlDoc = XDocument.Load(stringReader);
            
            XElement dataNode = xmlDoc.Descendants("Data").First();
            baseImgURL = dataNode.Element("baseImgUrl").Value;
        }

        private Image LoadImage(string url)
        {
            System.Net.WebRequest request =
                System.Net.WebRequest.Create(url);

            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
                response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }

        private void btnReplaceWithSelected_Click(object sender, EventArgs e)
        {
            //Get list view index
            string url = listView.SelectedItems[0].Text;
            
            //delete current image, and download the gamesDB.net one.
            if (currentImagePath != "")
            {
                File.Delete(currentImagePath);
            }
            

            using (WebClient wc = new WebClient())
            {
                byte[] fileBytes = wc.DownloadData(url);

                string fileType = wc.ResponseHeaders[HttpResponseHeader.ContentType];

                string saveLoc = images_path + "\\" + imageType + "\\" + game_file_name;

                if (fileType != null)
                {
                    switch (fileType)
                    {
                        case "image/jpeg":
                            saveLoc += ".jpg";
                            break;
                        case "image/png":
                            saveLoc += ".png";
                            break;
                        default:
                            break;
                    }

                    System.IO.FileInfo file = new System.IO.FileInfo(saveLoc);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.
                    System.IO.File.WriteAllBytes(saveLoc, fileBytes);
                }
            }

            loadPictureBox();
        }

        

        private void btnFanArt_Click(object sender, EventArgs e)
        {
            getGameDB_FanArtIcons();
            labSerchType.Text = "Fan Art";
            imageType = "fanart";
            loadPictureBox();

        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            getGameDB_ScreenshotIcons();
            labSerchType.Text = "Screenshots";
            imageType = "screen";
            loadPictureBox();
        }

        private void loadPictureBox()
        {
            if (File.Exists(images_path + "\\" + imageType + "\\" + game_file_name + ".jpg"))
            {
                currentImagePath = images_path + "\\" + imageType + "\\" + game_file_name + ".jpg";
                pictureBox.ImageLocation = currentImagePath;
            }
            else if (File.Exists(images_path + "\\" + imageType + "\\" + game_file_name + ".png"))
            {
                currentImagePath = images_path + "\\" + imageType + "\\" + game_file_name + ".png";
                pictureBox.ImageLocation = currentImagePath;
            }
            else
            {
                currentImagePath = "";
                pictureBox.Image = null;
            }

        }

        private void btnClearLogo_Click(object sender, EventArgs e)
        {
            getGameDB_ClearLogo();
            labSerchType.Text = "Clear Logos";
            imageType = "clearlogo";
            loadPictureBox();
        }

    }
}
