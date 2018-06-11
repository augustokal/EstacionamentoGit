using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;



namespace EstacionamentoGit
{
    public partial class Principal : Form
        

    {
        public Principal()
        {
            InitializeComponent();
        }

        private void registrarEntradaDeVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vagas vagas = new Vagas();
            vagas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Vagas vagas = new Vagas();
            vagas.Show();
        }

        private void gerênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        public void conex()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=admin;Database=Estacionamento;");
            conn.Open();

        }
        private void button2_Click(object sender, EventArgs e)
        {

           
                Relatorio_diario relatorioDiario = new Relatorio_diario();
                relatorioDiario.Show();
                
           
            


        }

        private void relatórioDiárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_diario relatorioDiario = new Relatorio_diario();
            relatorioDiario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RelatorioMensal relatorioMensal = new RelatorioMensal();
            relatorioMensal.Show();

        }
    }
}
