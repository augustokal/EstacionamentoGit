﻿using System;
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
    }
}
