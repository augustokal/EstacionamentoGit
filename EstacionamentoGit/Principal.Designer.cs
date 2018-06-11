namespace EstacionamentoGit
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.operacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEntradaDeVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioMensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 476);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 87);
            this.button4.TabIndex = 7;
            this.button4.Text = "Relatório mensal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 87);
            this.button2.TabIndex = 5;
            this.button2.Text = "Relatório diário";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Octin Vintage B Rg", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Administrativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Octin Vintage B Rg", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operacional";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar entrada/saida veiculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstacionamentoGit.Properties.Resources.logo_fundo;
            this.pictureBox1.Location = new System.Drawing.Point(190, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // operacionalToolStripMenuItem
            // 
            this.operacionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEntradaDeVeiculoToolStripMenuItem});
            this.operacionalToolStripMenuItem.Name = "operacionalToolStripMenuItem";
            this.operacionalToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.operacionalToolStripMenuItem.Text = "Operacional";
            // 
            // registrarEntradaDeVeiculoToolStripMenuItem
            // 
            this.registrarEntradaDeVeiculoToolStripMenuItem.Name = "registrarEntradaDeVeiculoToolStripMenuItem";
            this.registrarEntradaDeVeiculoToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.registrarEntradaDeVeiculoToolStripMenuItem.Text = "Registrar entrada/saída de veiculo";
            this.registrarEntradaDeVeiculoToolStripMenuItem.Click += new System.EventHandler(this.registrarEntradaDeVeiculoToolStripMenuItem_Click);
            // 
            // gerênciaToolStripMenuItem
            // 
            this.gerênciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDiárioToolStripMenuItem,
            this.relatórioMensalToolStripMenuItem});
            this.gerênciaToolStripMenuItem.Name = "gerênciaToolStripMenuItem";
            this.gerênciaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.gerênciaToolStripMenuItem.Text = "Gerência";
            this.gerênciaToolStripMenuItem.Click += new System.EventHandler(this.gerênciaToolStripMenuItem_Click);
            // 
            // relatórioDiárioToolStripMenuItem
            // 
            this.relatórioDiárioToolStripMenuItem.Name = "relatórioDiárioToolStripMenuItem";
            this.relatórioDiárioToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.relatórioDiárioToolStripMenuItem.Text = "Relatório diário";
            this.relatórioDiárioToolStripMenuItem.Click += new System.EventHandler(this.relatórioDiárioToolStripMenuItem_Click);
            // 
            // relatórioMensalToolStripMenuItem
            // 
            this.relatórioMensalToolStripMenuItem.Name = "relatórioMensalToolStripMenuItem";
            this.relatórioMensalToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.relatórioMensalToolStripMenuItem.Text = "Relatório mensal";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionalToolStripMenuItem,
            this.gerênciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem operacionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEntradaDeVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDiárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioMensalToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}