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
    public partial class EntradaVeic : Form
    {

        Veiculo veiculo;
        Cliente cliente;
        public EntradaVeic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vagas vagas = new Vagas();
            vagas.att();


            veiculo = new Veiculo();
            veiculo.Tipo = maskedTextBoxPlaca.Text;
            veiculo.Placa = maskedTextBoxPlaca.Text;
            veiculo.Modelo = Convert.ToString(comboBoxTipo.SelectedValue);


            cliente = new Cliente();
            cliente.Cpf = maskedTextBoxCPF.Text;
            cliente.Nome = textBoxNome.Text;
            cliente.Endereco = textBoxEndereco.Text;
            cliente.Numero = maskedTextBoxNumero.Text;
            Dispose();
        }
    }
}
