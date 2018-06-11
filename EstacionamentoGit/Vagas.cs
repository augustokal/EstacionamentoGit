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
        SaidaVeic saidaVeic = new SaidaVeic();
        EntradaVeic entradaVeic = new EntradaVeic();
        public int status = 0;
        public Vagas()
        {
            InitializeComponent();
           
            
        }
        public void att()
        {
            InitializeComponent();
        }
        private void Vagas_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
            if (status == 0)
                
            {
                button1.BackColor = Color.Green;
                entradaVeic.Show();
                status = 1;
            }
            else
            {
                button1.BackColor = Color.Red;
                saidaVeic.Show();
                status = 0;

            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}
