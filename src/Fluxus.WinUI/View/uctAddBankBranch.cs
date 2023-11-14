﻿using Fluxus.Domain.Entities;
using Fluxus.Infra.Services;
using Fluxus.App;
using System.Text.RegularExpressions;
using Fluxus.Domain.Interfaces;
using Fluxus.Infra.Repositories;

namespace Fluxus.WinUI.View
{
    public partial class uctAddBankBranch : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly int _id;
        private IBankBranchRepository _bankBranchRepository;

        public uctAddBankBranch(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _bankBranchRepository = new BankBranchRepository();
        }

        public uctAddBankBranch(string agencia)
        {
            InitializeComponent();
            _bankBranchRepository = new BankBranchRepository();

            this.Size = new System.Drawing.Size(650, 600);
            this.Tag = "Adicionar";

            txtAgencia.Text = agencia;
        }

        public uctAddBankBranch(frmMain frm1, BankBranch branch)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _bankBranchRepository = new BankBranchRepository();

            _id = branch.Id;
            txtAgencia.Text = branch.BranchNumber;
            txtNome.Text = branch.Name;
            txtEndereco.Text = branch.Address;
            txtComplemento.Text = branch.Complement;
            txtBairro.Text = branch.District;
            txtCidade.Text = branch.City;
            txtCEP.Text = branch.Zip;
            cboUF.Text = branch.State;
            txtContato.Text = branch.ContactName;
            txtTelefone1.Text = branch.Phone1;
            txtTelefone2.Text = branch.Phone2;
            txtEmail.Text = branch.Email;

            txtAgencia.Enabled = false;
        }

        private void frmAddAgencia_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "Adicionar")
                txtAgencia.Focus();
            else
                txtNome.Focus();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            var method = this.Tag.ToString();
            var service = new BankBranchService(_bankBranchRepository);
            service.BankBranch = PopulateObject();

            var success = service.Execute(method);

            if (success)
                btnCancelar_Click(sender, e);
            else
                MessageBox.Show(service.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctBankBranch formFilho = new uctBankBranch(_frmPrincipal);
            _frmPrincipal.OpenUserControl(formFilho);
        }

        private void OnValidated_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskValidated(sender);

        private void OnEnter_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskEnter(sender);

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = Regex.Replace(txtCEP.Text, "[^0-9]", "");

            if (!String.IsNullOrEmpty(cep) && cep.Length == 8)
            {
                var result = new ViaCep().GetViaCep(cep);
                if (result != null || !result.Erro)
                {
                    txtEndereco.Text = result.Logradouro;
                    txtComplemento.Text = result.Complemento;
                    txtBairro.Text = result.Bairro;
                    txtCidade.Text = result.Localidade;
                    cboUF.Text = result.Uf;
                }
            }
        }

        private BankBranch PopulateObject()
        {
            BankBranch branch = new BankBranch
            {
                Id = _id,
                BranchNumber = txtAgencia.Text,
                Name = txtNome.Text,
                Address = txtEndereco.Text,
                Complement = txtComplemento.Text,
                District = txtBairro.Text,
                City = txtCidade.Text,
                Zip = txtCEP.Text,
                State = cboUF.Text,
                ContactName = txtContato.Text,
                Phone1 = txtTelefone1.Text,
                Phone2 = txtTelefone2.Text,
                Email = txtEmail.Text
            };
            return branch;
        }

    }

}
