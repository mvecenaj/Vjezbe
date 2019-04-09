using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto
{
    public partial class LotoEkran : Form
    {
        private Loto loto;
        public LotoEkran()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ActionUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(UplaceniBroj1.Text);
            vrijednosti.Add(UplaceniBroj2.Text);
            vrijednosti.Add(UplaceniBroj3.Text);
            vrijednosti.Add(UplaceniBroj4.Text);
            vrijednosti.Add(UplaceniBroj5.Text);
            vrijednosti.Add(UplaceniBroj6.Text);
            vrijednosti.Add(UplaceniBroj7.Text);

            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                ActionOdigraj.Enabled = true;
            }
            else
            {
                ActionOdigraj.Enabled = false;
                MessageBox.Show("Neispravna kombinacija");
            }

        }

        private void ActionOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitnuKombinaciju();
            DobitniBroj1.Text = loto.DobitniBrojevi[0].ToString();
            DobitniBroj2.Text = loto.DobitniBrojevi[1].ToString();
            DobitniBroj3.Text = loto.DobitniBrojevi[2].ToString();
            DobitniBroj4.Text = loto.DobitniBrojevi[3].ToString();
            DobitniBroj5.Text = loto.DobitniBrojevi[4].ToString();
            DobitniBroj6.Text = loto.DobitniBrojevi[5].ToString();
            DobitniBroj7.Text = loto.DobitniBrojevi[6].ToString();

            int brojPogodaka = loto.IzracunajBrojPogodaka();
            OutputBrojPogodaka.Text = brojPogodaka.ToString();
        }
    }
}
