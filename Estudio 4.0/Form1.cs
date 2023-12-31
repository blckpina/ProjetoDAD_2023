﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();

            menuStrip1.Enabled = false;

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202242", "cl202242", "Mm240607*"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 login_aluno = new Form3();
            login_aluno.MdiParent = this;
            login_aluno.Show();

        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cad_login = new Form2();
            cad_login.MdiParent = this;
            cad_login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(textBox1.Text, textBox2.Text);
            if(tipo == 0)
            { 
                MessageBox.Show("Usuário/Senha inválidos");            
            }
            if(tipo == 1)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            if(tipo == 2)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarModalidadeToolStripMenuItem.Enabled = false;
                excluirModalidadeToolStripMenuItem.Enabled = false;
                atualizarModalidadeToolStripMenuItem.Enabled = false;
                excluirToolStripMenuItem.Enabled = false;
                cadastrarToolStripMenuItem.Enabled = false;
            }
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 excluir_aluno = new Form4();
            excluir_aluno.MdiParent = this;
            excluir_aluno.Show();
        }

        private void atualizarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool atualiza2 = true;
            Form5 atualizar_aluno = new Form5(atualiza2);
            atualizar_aluno.MdiParent = this;
            atualizar_aluno.Show();
        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 cadastrar_modalidade = new Form6();
            cadastrar_modalidade.MdiParent = this;
            cadastrar_modalidade.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 excluir_modalidade = new Form7();
            excluir_modalidade.MdiParent = this;
            excluir_modalidade.Show();
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool atualiza = true;
            Form8 attconsul_modalidade = new Form8(atualiza);
            attconsul_modalidade.MdiParent = this;
            attconsul_modalidade.Show();
        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool atualiza = false;
            Form8 attconsul_modalidade = new Form8(atualiza);
            attconsul_modalidade.MdiParent = this;
            attconsul_modalidade.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 cadatrar_turma = new Form9();
            cadatrar_turma.MdiParent = this;
            cadatrar_turma.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 excluir_turma = new Form10();
            excluir_turma.MdiParent = this;
            excluir_turma.Show();
        }

        private void consultarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool atualiza2 = false;
            Form5 atualizar_aluno = new Form5(atualiza2);
            atualizar_aluno.MdiParent = this;
            atualizar_aluno.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 cadastrar_matricula = new Form11();
            cadastrar_matricula.MdiParent = this;
            cadastrar_matricula.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 consultarexcluir_matricula = new Form12(0);
            consultarexcluir_matricula.MdiParent = this;
            consultarexcluir_matricula.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form12 consultarexcluir_matricula = new Form12(1);
            consultarexcluir_matricula.MdiParent = this;
            consultarexcluir_matricula.Show();
        }
    }
}
