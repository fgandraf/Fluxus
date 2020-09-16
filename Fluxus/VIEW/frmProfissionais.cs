﻿using System;
using System.Windows.Forms;
using Fluxus.ENTIDADES;
using Fluxus.MODEL;

namespace Fluxus.VIEW
{
    public partial class frmProfissionais : Form
    {
        frmPrincipal _frmPrincipal;



        //:METHODS
        private void Listar()
        {
            try
            {
                ProfissionaisMODEL model = new ProfissionaisMODEL();
                dgvProfissionais.DataSource = model.ListarProfissionaisMODEL();

                if (dgvProfissionais.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvProfissionais.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvProfissionais.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete()
        {
            try
            {
                ENTIDADES.ProfissionaisENT dado = new ENTIDADES.ProfissionaisENT();
                ProfissionaisMODEL model = new ProfissionaisMODEL();
                dado.Codigo = dgvProfissionais.CurrentRow.Cells[0].Value.ToString();
                model.DeleteProfissionalMODEL(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //:EVENTS
        //_______Form
        public frmProfissionais(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }
        private void frmProfissionais_Load(object sender, EventArgs e)
        {
            Listar();
            if (Globais.Rl == false)
            {
                btnAdicionar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }





        //_______Button
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Delete();
                Listar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Globais.Rl == false)
                return;


            frmAddProfissional formNeto = new frmAddProfissional
                (
                _frmPrincipal,
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["codigo"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["nome"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["nomeid"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["cpf"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["nascimento"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["profissao"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["carteira"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["entidade"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["telefone1"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["telefone2"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["email"].Value),
                Convert.ToBoolean(dgvProfissionais.CurrentRow.Cells["rt"].Value),
                Convert.ToBoolean(dgvProfissionais.CurrentRow.Cells["rl"].Value),
                Convert.ToBoolean(dgvProfissionais.CurrentRow.Cells["usr_ativo"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["usr_nome"].Value),
                Convert.ToString(dgvProfissionais.CurrentRow.Cells["usr_senha"].Value)
                );
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddProfissional formNeto = new frmAddProfissional(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }





        //_______DataGridView
        private void dgvProfissionais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvProfissionais.CurrentCell.Selected)
                btnExcluir.PerformClick();
        }



    }



}