using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeserviceFinal
{
    public partial class UCEx8 : UserControl
    {
        public UCEx8()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click_1(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                client.DownloadFile(new Uri("https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png"), @"redeservice.png");
            }

            byte[] imgArray = File.ReadAllBytes(@"redeservice.png");
            string base64 = Convert.ToBase64String(imgArray);
            rtfBase64.Text = base64;
        }
    }
}
