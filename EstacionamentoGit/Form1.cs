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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // NpgsqlCommand com = new NpgsqlCommand(query, con);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBoxUser.Text=="Augusto")&&(textBox2.Text =="1234" ))
            {
                Principal principal = new Principal();
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Senha ou usuário errados", "Erro ao tentar efetuar login");
            }



            /*NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=admin;Database=Estacionamento;");
            con.Open();
            String query = "";
            DataSet dados = new DataSet();
            query = "SELECT * FROM FUNCIONARIO WHERE LOGIN =' " +textBoxUser.Text+ " 'AND SENHA = '"+textBox2.Text+ " ' ;";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, con);
            add.Fill(dados);*/
           
            
           
        }
    }
}
