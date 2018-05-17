using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoGit
{
    public partial class Vagas : Form
    {
        public Vagas()
        {
            InitializeComponent();
        }

        private void Vagas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntradaVeic entradaVeic = new EntradaVeic();
            entradaVeic.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaidaVeic saidaVeic = new SaidaVeic();
            saidaVeic.Show();
        }
    }
}
