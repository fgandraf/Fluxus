﻿using Fluxus.Domain.Entities;
using System.Globalization;
using Fluxus.App.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI.View
{
    public partial class uctAddInvoice : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private double _subtotal_os = 0.00;
        private double _subtotal_desloc = 0.00;
        private IServiceProvider _serviceProvider;

        public uctAddInvoice(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmAddFatura_Load(object sender, EventArgs e)
        {
            var serviceOrderService = _serviceProvider.GetService<ServiceOrderService>();

            dgvOS.DataSource = serviceOrderService.GetOrdensConcluidasNaoFaturadas();
            Calculate();
            txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
                return;
            else
            {
                var dialog = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells[2].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells[6].Value.ToString(), "Não Faturar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Yes)
                {
                    dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);
                    Calculate();
                }
            }
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            var service = _serviceProvider.GetService<InvoiceService>();
            service.Invoice = PopulateToObject();

            var result = service.Insert();
            int invoiceId = result.Id;

            if (invoiceId == 0)
            {
                MessageBox.Show(service.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgvOS.Rows)
            {
                int idOS = Convert.ToInt32(row.Cells["Id"].Value);
                var serviceOrderService = _serviceProvider.GetService<ServiceOrderService>();
                serviceOrderService.UpdateFaturaCod(idOS, invoiceId);
            }

            MessageBox.Show("Ordens faturadas com sucesso!", "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnCancelar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctServiceOrder formFilho = new uctServiceOrder(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formFilho);
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
            => txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();

        private void Calculate()
        {
            _subtotal_os = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells["valor_atividade"].Value ?? 0));
            _subtotal_desloc = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells["valor_deslocamento"].Value ?? 0));

            txtValorOS.Text = string.Format("{0:0,0.00}", _subtotal_os);
            txtValorDeslocamento.Text = string.Format("{0:0,0.00}", _subtotal_desloc);
            txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", _subtotal_os + _subtotal_desloc);
        }

        private Invoice PopulateToObject()
        {
            Invoice invoice = new Invoice
            (
                id: 0,
                description: txtDescricao.Text,
                issueDate: dtpData.Value,
                subtotalService: _subtotal_os,
                subtotalMileageAllowance: _subtotal_desloc,
                total: _subtotal_os + _subtotal_desloc
            ) ;
            return invoice;
        }

    }

}
