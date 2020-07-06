﻿namespace Arqueng.VIEW
{
    partial class frmAddFatura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFatura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.txtValorDeslocamento = new System.Windows.Forms.TextBox();
            this.txtValorOS = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRRTART = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.btnFaturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividade_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_concluída = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_atividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_deslocamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpFatura = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlLinha2);
            this.panel1.Controls.Add(this.txtValorDeslocamento);
            this.panel1.Controls.Add(this.txtValorOS);
            this.panel1.Controls.Add(this.txtValorTotal);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRRTART);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.dgvOS);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 500);
            this.panel1.TabIndex = 295;
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLinha2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLinha2.Location = new System.Drawing.Point(691, 457);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(190, 1);
            this.pnlLinha2.TabIndex = 422;
            // 
            // txtValorDeslocamento
            // 
            this.txtValorDeslocamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDeslocamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorDeslocamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorDeslocamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDeslocamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDeslocamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorDeslocamento.Location = new System.Drawing.Point(825, 436);
            this.txtValorDeslocamento.MaxLength = 100;
            this.txtValorDeslocamento.Name = "txtValorDeslocamento";
            this.txtValorDeslocamento.ReadOnly = true;
            this.txtValorDeslocamento.Size = new System.Drawing.Size(55, 15);
            this.txtValorDeslocamento.TabIndex = 421;
            this.txtValorDeslocamento.Text = "00.000,00";
            this.txtValorDeslocamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorOS
            // 
            this.txtValorOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorOS.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorOS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorOS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorOS.Location = new System.Drawing.Point(764, 436);
            this.txtValorOS.MaxLength = 100;
            this.txtValorOS.Name = "txtValorOS";
            this.txtValorOS.ReadOnly = true;
            this.txtValorOS.Size = new System.Drawing.Size(55, 15);
            this.txtValorOS.TabIndex = 420;
            this.txtValorOS.Text = "00.000,00";
            this.txtValorOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorTotal.Location = new System.Drawing.Point(764, 461);
            this.txtValorTotal.MaxLength = 100;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(116, 20);
            this.txtValorTotal.TabIndex = 419;
            this.txtValorTotal.Text = "R$00.000,00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemover
            // 
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(30, 424);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(25, 25);
            this.btnRemover.TabIndex = 418;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpFatura.SetToolTip(this.btnRemover, "Remover linha");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(27, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 309;
            this.label6.Text = "Data:";
            // 
            // txtRRTART
            // 
            this.txtRRTART.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRRTART.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRRTART.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRRTART.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRRTART.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRRTART.Location = new System.Drawing.Point(442, 55);
            this.txtRRTART.MaxLength = 100;
            this.txtRRTART.Name = "txtRRTART";
            this.txtRRTART.Size = new System.Drawing.Size(200, 23);
            this.txtRRTART.TabIndex = 307;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(439, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 308;
            this.label5.Text = "ART/RRT Nº:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescricao.Location = new System.Drawing.Point(186, 55);
            this.txtDescricao.MaxLength = 20;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(250, 23);
            this.txtDescricao.TabIndex = 305;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescricao.Location = new System.Drawing.Point(183, 39);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(59, 13);
            this.lblDescricao.TabIndex = 306;
            this.lblDescricao.Text = "Descrição:";
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpData.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.dtpData.CustomFormat = "";
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(30, 55);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(150, 23);
            this.dtpData.TabIndex = 304;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotal.Location = new System.Drawing.Point(701, 461);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 20);
            this.lblTotal.TabIndex = 300;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblSubtotal.Location = new System.Drawing.Point(704, 436);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 13);
            this.lblSubtotal.TabIndex = 299;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AllowUserToOrderColumns = true;
            this.dgvOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOS.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOS.ColumnHeadersHeight = 35;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data_ordem,
            this.referencia,
            this.atividade_cod,
            this.cidade,
            this.nome_cliente,
            this.data_vistoria,
            this.data_concluída,
            this.valor_atividade,
            this.valor_deslocamento});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOS.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvOS.Location = new System.Drawing.Point(30, 118);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOS.RowHeadersVisible = false;
            this.dgvOS.RowHeadersWidth = 40;
            this.dgvOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOS.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.RowTemplate.Height = 30;
            this.dgvOS.RowTemplate.ReadOnly = true;
            this.dgvOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.ShowEditingIcon = false;
            this.dgvOS.Size = new System.Drawing.Size(850, 300);
            this.dgvOS.TabIndex = 223;
            // 
            // btnFaturar
            // 
            this.btnFaturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaturar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFaturar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnFaturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFaturar.Location = new System.Drawing.Point(770, 530);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(150, 25);
            this.btnFaturar.TabIndex = 296;
            this.btnFaturar.Text = "&Faturar";
            this.btnFaturar.UseVisualStyleBackColor = false;
            this.btnFaturar.Click += new System.EventHandler(this.btnFaturar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(639, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 25);
            this.btnCancelar.TabIndex = 297;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // data_ordem
            // 
            this.data_ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_ordem.DataPropertyName = "data_ordem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_ordem.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_ordem.HeaderText = "Data da Ordem";
            this.data_ordem.MinimumWidth = 75;
            this.data_ordem.Name = "data_ordem";
            this.data_ordem.ReadOnly = true;
            this.data_ordem.Width = 75;
            // 
            // referencia
            // 
            this.referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.referencia.DataPropertyName = "referencia";
            this.referencia.HeaderText = "Referência";
            this.referencia.MinimumWidth = 130;
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            this.referencia.Width = 130;
            // 
            // atividade_cod
            // 
            this.atividade_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.atividade_cod.DataPropertyName = "atividade_cod";
            this.atividade_cod.HeaderText = "Tipo";
            this.atividade_cod.MinimumWidth = 45;
            this.atividade_cod.Name = "atividade_cod";
            this.atividade_cod.ReadOnly = true;
            this.atividade_cod.Width = 45;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 60;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 60;
            // 
            // nome_cliente
            // 
            this.nome_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_cliente.DataPropertyName = "nome_cliente";
            this.nome_cliente.HeaderText = "Nome do Cliente";
            this.nome_cliente.MinimumWidth = 130;
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            // 
            // data_vistoria
            // 
            this.data_vistoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_vistoria.DataPropertyName = "data_vistoria";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_vistoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_vistoria.HeaderText = "Data da Vistoria";
            this.data_vistoria.MinimumWidth = 75;
            this.data_vistoria.Name = "data_vistoria";
            this.data_vistoria.ReadOnly = true;
            this.data_vistoria.Width = 75;
            // 
            // data_concluída
            // 
            this.data_concluída.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_concluída.DataPropertyName = "data_concluida";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_concluída.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_concluída.HeaderText = "Data da Conclusão";
            this.data_concluída.MinimumWidth = 75;
            this.data_concluída.Name = "data_concluída";
            this.data_concluída.ReadOnly = true;
            this.data_concluída.Width = 75;
            // 
            // valor_atividade
            // 
            this.valor_atividade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.valor_atividade.DataPropertyName = "valor_atividade";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valor_atividade.DefaultCellStyle = dataGridViewCellStyle5;
            this.valor_atividade.HeaderText = "Valor OS";
            this.valor_atividade.MinimumWidth = 55;
            this.valor_atividade.Name = "valor_atividade";
            this.valor_atividade.ReadOnly = true;
            this.valor_atividade.Width = 55;
            // 
            // valor_deslocamento
            // 
            this.valor_deslocamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.valor_deslocamento.DataPropertyName = "valor_deslocamento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valor_deslocamento.DefaultCellStyle = dataGridViewCellStyle6;
            this.valor_deslocamento.HeaderText = "Desloca.";
            this.valor_deslocamento.MinimumWidth = 55;
            this.valor_deslocamento.Name = "valor_deslocamento";
            this.valor_deslocamento.ReadOnly = true;
            this.valor_deslocamento.Width = 55;
            // 
            // frmAddFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(929, 567);
            this.Controls.Add(this.btnFaturar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddFatura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturar";
            this.Load += new System.EventHandler(this.frmAddFatura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnFaturar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRRTART;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorDeslocamento;
        private System.Windows.Forms.TextBox txtValorOS;
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividade_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_vistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_concluída;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_atividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_deslocamento;
        private System.Windows.Forms.ToolTip ttpFatura;
    }
}