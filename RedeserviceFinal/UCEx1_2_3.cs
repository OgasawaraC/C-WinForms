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
    public partial class UCEx1_2_3 : UserControl
    {
        public UCEx1_2_3()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            string numero;
            numero = txtNumero.Text.ToString();

            lstNumero.Items.Add(numero);

            int v;
            if (!int.TryParse(txtNumero.Text, out v))
            {
                MessageBox.Show("Digite um Número!!");
                lstNumero.Items.Remove(numero);
                return;
            }

            string[] n = lstNumero.Items.Cast<string>().ToArray();
            lstNumero.Items.Clear();

            var order = n.OrderBy(p => int.Parse(p));
            foreach (var item in order)
            {
                lstNumero.Items.Add(item);
            }
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            string path = @"num.txt";

            FileStream fsCreate = File.Open(path, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fsCreate))
            {
                foreach (var line in lstNumero.Items)
                    sw.WriteLine(line.ToString());
            }
        }
    }
}
