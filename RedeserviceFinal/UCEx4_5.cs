using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RedeserviceFinal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeserviceFinal
{
    public partial class UCEx4_5 : UserControl
    {
        public UCEx4_5()
        {
            InitializeComponent();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            List<ClsTeste> data = new List<ClsTeste>();
            for (int i = 1; i <= 100; i++)
            {
                data.Add(new ClsTeste()
                {
                    Codigo = i,
                    Descricao = DateTime.Now.ToString("yyyy/MM/dd HH:m:ss.fff")
                });
            }

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"data.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        private void btnLerJson_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText(@"data.json");

            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(path, (typeof(DataTable)));
            grdJson.DataSource = dataTable;
        }
    }
}
