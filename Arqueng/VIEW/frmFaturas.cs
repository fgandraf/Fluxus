﻿using Arqueng.ENTIDADES;
using Arqueng.MODEL;
using System;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Globalization;
using Arqueng.RELATORIOS;

namespace Arqueng.VIEW
{


    public partial class frmFaturas : Form
    {
        FaturasMODEL model = new FaturasMODEL();
        OsMODEL modelOS = new OsMODEL();
        OsENT dado = new OsENT();
        FaturasENT dadofat = new FaturasENT();



        //:METHODS
        private void PopulateGridFatura()
        {
            try
            {
                DataView dvFaturas = new DataView(DT.DT_Faturas);//------
                dgvFaturas.DataSource = dvFaturas;//-----------
                if (dgvFaturas.Rows.Count > 0)
                {
                    tblFaturas.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateGridOS()
        {
            if (dgvFaturas.Rows.Count > 0)
            {
                try
                {
                    DataView dvOS = new DataView(DT.DT_OS);
                    dvOS.RowFilter = String.Format("fatura_cod = '{0}'", dgvFaturas.CurrentRow.Cells[0].Value.ToString());
                    dgvOS.DataSource = dvOS;

                    txtData.Text = dgvFaturas.CurrentRow.Cells[2].Value.ToString();
                    txtValorOS.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[3].Value);
                    txtValorDeslocamento.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[4].Value);
                    txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[5].Value);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }





        public frmFaturas()
        {
            InitializeComponent();
        }



        

        private DataTable Profissionais()
        {
            DataTable dt = new DataTable();
            try
            {
                dado.Fatura_cod = dgvFaturas.CurrentRow.Cells[0].Value.ToString();
                dt = modelOS.DistinctProOSFaturadaModel(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void frmFaturas_Load(object sender, EventArgs e)
        {
            PopulateGridFatura();
            PopulateGridOS();
        }


        private void dgvFaturas_MouseClick(object sender, MouseEventArgs e)
        {
            PopulateGridOS();
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string caminho = null;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = saveFileDialog.FileName;
                //CONVERTER bytes[] EM Imagem
                System.Drawing.Image logoImagem;
                using (var stream = new MemoryStream(Globais.Logo))
                    logoImagem = System.Drawing.Image.FromStream(stream);
                //CHAMAR O MÉTODO
                    itsFatura.GerarFaturaPDF
                    (
                    logoImagem,
                    Globais.Edital,
                    Globais.Contrato,
                    Globais.Razao,
                    Globais.Cnpj,
                    Profissionais(),
                    ((DataView)dgvOS.DataSource).ToTable(),
                    caminho
                    ); 
            }
        }

        private void frmFaturas_Leave(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }



}