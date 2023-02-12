﻿using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using System.Data;
using System.Linq;
using Fluxus.Services;
using System.Threading.Tasks;

namespace Fluxus.WinUI.View
{
    public partial class frmOSFluxo : Form
    {
        frmPrincipal _frmPrincipal;
        Control _lastEnteredControl;
        DataGridView _dgvOrigem;
        DataTable _dtOSNFaturada;



        //:METHODS
        private void ContarRegistros(DataGridView dgv)
        {
            if (dgv.Tag.ToString() == "RECEBIDA")
                lblTitRecebidas.Text = "RECEBIDAS [" + dgv.Rows.Count.ToString() + "]";
            if (dgv.Tag.ToString() == "PENDENTE")
                lblTitPendentes.Text = "PENDENTES [" + dgv.Rows.Count.ToString() + "]";
            if (dgv.Tag.ToString() == "VISTORIADA")
                lblTitVistoriadas.Text = "VISTORIADAS [" + dgv.Rows.Count.ToString() + "]";
            if (dgv.Tag.ToString() == "CONCLUÍDA")
                lblTitConcluidas.Text = "CONCLUÍDAS [" + dgv.Rows.Count.ToString() + "]";


        }

        private void ListarOS(DataGridView dgv)
        {
            try
            {
                DataView dvOS = new DataView(_dtOSNFaturada);


                if (cboProfissional.SelectedIndex == 0)
                    dvOS.RowFilter = String.Format("Status = '{0}'", Convert.ToInt32(dgv.Tag.ToString()));
                else
                    dvOS.RowFilter = String.Format("Status = '{0}' AND ProfessionalId = '{1}'", Convert.ToInt32(dgv.Tag.ToString()), cboProfissional.SelectedValue.ToString());

                dgv.DataSource = dvOS;





                if (dvOS.Count == 0)
                {
                    dgv.ContextMenuStrip = null;
                    dgv.Cursor = Cursors.Default;
                }
                else
                {
                    dgv.ContextMenuStrip = menuContext;
                }

                ContarRegistros(dgv);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EditarOS(DataGridView dgv)
        {
            if (dgv != null)
            {
                Domain.Entities.ServiceOrder ordemDeServico = new Services.ServiceOrderService().GetBy(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));

                frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name, ordemDeServico);


                formNeto.Text = "Alterar";
                _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
            }
        }

        private void ExcluirOS(DataGridView dgv)
        {
            if (dgv != null)
            {
                var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        new Services.ServiceOrderService().Delete((Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)));

                        _dtOSNFaturada = new Services.ServiceOrderService().GetOrdensDoFluxo();
                        ListarOS(dgv);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AtualizaStatus(DataGridView dgvDestino, DragEventArgs ev)
        {
            try
            {

                int sourcerow = Convert.ToInt32(ev.Data.GetData(Type.GetType("System.Int32")));

                if (sourcerow >= 0)
                {

                    string status = dgvDestino.Tag.ToString();
                    int id = Convert.ToInt32(_dgvOrigem.Rows[sourcerow].Cells[0].Value);

                    DataRow linha = _dtOSNFaturada.Select("Id = " + id).FirstOrDefault();
                    linha["Status"] = status;

                    ListarOS(_dgvOrigem);
                    ListarOS(dgvDestino);

                    new Services.ServiceOrderService().UpdateStatus(id, status);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CapturaDGVOrigem(DataGridView dgv, MouseEventArgs e)
        {
            int SourceRow;
            _dgvOrigem = dgv;
            SourceRow = dgv.HitTest(e.X, e.Y).RowIndex;
            dgv.DoDragDrop(SourceRow, DragDropEffects.Move);
        }





        //:EVENTS
        ///_______Form
        public frmOSFluxo(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            foreach (Control ctrl in Controls)
            {
                if (ctrl is DataGridView)
                    ctrl.Enter += delegate (object sender, EventArgs e)
                    {
                        _lastEnteredControl = (Control)sender;
                    };
            }

            dgvRecebidas.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvRecebidas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvRecebidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvPendentes.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPendentes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPendentes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvVistoriadas.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVistoriadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVistoriadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvConcluidas.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConcluidas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConcluidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            _dtOSNFaturada = new Services.ServiceOrderService().GetOrdensDoFluxo();

        }

        private void frmOSFluxo_Load(object sender, EventArgs e)
        {

            cboProfissional.DataSource = new ProfissionalService().ListarCodigoENomeid(true);

            if (Logged.Rl)
            {
                cboProfissional.Enabled = true;
                pnlLinhaFaturar.Show();
                pnlFaturar.Show();


                if (Logged.Rt)
                    cboProfissional.SelectedValue = Convert.ToInt32(Logged.ProfessionalId);
                else
                    cboProfissional.SelectedIndex = 0;
                return;
            }


            cboProfissional.SelectedValue = Convert.ToInt32(Logged.ProfessionalId);


            ListarOS(dgvRecebidas);
            ListarOS(dgvPendentes);
            ListarOS(dgvVistoriadas);
            ListarOS(dgvConcluidas);

        }





        ///_______Button
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            if (dgvConcluidas.Rows.Count > 0)
            {
                _frmPrincipal.lblTitulo.Text = "Fatura";
                _frmPrincipal.lblTitulo.Refresh();
                frmAddFatura formNeto = new frmAddFatura(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
            }
            else
                MessageBox.Show("Não há ordens concluídas à faturar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        ///_______ContextMenu
        private void mnuEditar_Click(object sender, EventArgs e)
        {
            EditarOS((DataGridView)_lastEnteredControl);
        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            ExcluirOS((DataGridView)_lastEnteredControl);
        }






        ///_______ComboBox
        private void cboProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarOS(dgvRecebidas);
            ListarOS(dgvPendentes);
            ListarOS(dgvVistoriadas);
            ListarOS(dgvConcluidas);
        }





        ///_______DataGridView
        private void dgvRecebidas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
        }

        private void dgvRecebidas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void dgvRecebidas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvRecebidas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
            ContarRegistros(_dgvOrigem);
            ContarRegistros((DataGridView)sender);
        }

        private void dgvRecebidas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaDGVOrigem((DataGridView)sender, e);
        }

        private void dgvRecebidas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }





        private void dgvPendentes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
        }

        private void dgvPendentes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void dgvPendentes_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvPendentes_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
            ContarRegistros(_dgvOrigem);
            ContarRegistros((DataGridView)sender);
        }

        private void dgvPendentes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaDGVOrigem((DataGridView)sender, e);
        }

        private void dgvPendentes_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }





        private void dgvVistoriadas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
        }

        private void dgvVistoriadas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void dgvVistoriadas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvVistoriadas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
            ContarRegistros(_dgvOrigem);
            ContarRegistros((DataGridView)sender);
        }

        private void dgvVistoriadas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaDGVOrigem((DataGridView)sender, e);
        }

        private void dgvVistoriadas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }






        private void dgvConcluidas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
        }

        private void dgvConcluidas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void dgvConcluidas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvConcluidas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
            ContarRegistros(_dgvOrigem);
            ContarRegistros((DataGridView)sender);
        }

        private void dgvConcluidas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }

        private void dgvConcluidas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaDGVOrigem((DataGridView)sender, e);
        }
    }



}
