using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeserviceFinal
{
    public partial class UCEx7 : UserControl
    {
        public UCEx7()
        {
            InitializeComponent();
        }
        private async void GetBancos()
        {
            string uri = "https://brasilapi.com.br/api/banks/v1";
            using (var client = new HttpClient())
            {
                using (var res = await client.GetAsync(uri))
                {
                    var BancosJsonString = await res.Content.ReadAsStringAsync();

                    DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(BancosJsonString, (typeof(DataTable)));
                    grdBancos.DataSource = dataTable;
                }
            }
        }

        private void btnConsultarBancos_Click(object sender, EventArgs e)
        {
            GetBancos();
        }
    }
}
