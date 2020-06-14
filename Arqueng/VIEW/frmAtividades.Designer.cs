﻿namespace Arqueng.VIEW
{
    partial class frmAtividades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtividades));
            this.dgvAtividades = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_atividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_deslocamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pctLupa = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.ttpAtividades = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtividades
            // 
            this.dgvAtividades.AllowUserToAddRows = false;
            this.dgvAtividades.AllowUserToDeleteRows = false;
            this.dgvAtividades.AllowUserToOrderColumns = true;
            this.dgvAtividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtividades.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAtividades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAtividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAtividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAtividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAtividades.ColumnHeadersHeight = 35;
            this.dgvAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAtividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.valor_atividade,
            this.valor_deslocamento});
            this.dgvAtividades.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvAtividades.Location = new System.Drawing.Point(50, 85);
            this.dgvAtividades.MultiSelect = false;
            this.dgvAtividades.Name = "dgvAtividades";
            this.dgvAtividades.ReadOnly = true;
            this.dgvAtividades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAtividades.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAtividades.RowHeadersVisible = false;
            this.dgvAtividades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvAtividades.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAtividades.RowTemplate.Height = 40;
            this.dgvAtividades.RowTemplate.ReadOnly = true;
            this.dgvAtividades.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAtividades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAtividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtividades.ShowEditingIcon = false;
            this.dgvAtividades.Size = new System.Drawing.Size(820, 445);
            this.dgvAtividades.TabIndex = 4;
            this.dgvAtividades.DoubleClick += new System.EventHandler(this.btnEditar_Click);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.DataPropertyName = "codigo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.codigo.DefaultCellStyle = dataGridViewCellStyle9;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 76;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.descricao.DefaultCellStyle = dataGridViewCellStyle10;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // valor_atividade
            // 
            this.valor_atividade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valor_atividade.DataPropertyName = "valor_atividade";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.valor_atividade.DefaultCellStyle = dataGridViewCellStyle11;
            this.valor_atividade.HeaderText = "Atividade (R$)";
            this.valor_atividade.Name = "valor_atividade";
            this.valor_atividade.ReadOnly = true;
            this.valor_atividade.Width = 117;
            // 
            // valor_deslocamento
            // 
            this.valor_deslocamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valor_deslocamento.DataPropertyName = "valor_deslocamento";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.valor_deslocamento.DefaultCellStyle = dataGridViewCellStyle12;
            this.valor_deslocamento.HeaderText = "Deslocamento (R$)";
            this.valor_deslocamento.Name = "valor_deslocamento";
            this.valor_deslocamento.ReadOnly = true;
            this.valor_deslocamento.Width = 146;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(50, 25);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(35, 35);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpAtividades.SetToolTip(this.btnAdicionar, "Adicionar nova atividade");
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(129, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(35, 35);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpAtividades.SetToolTip(this.btnExcluir, "Excluir atividade");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(88, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(35, 35);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpAtividades.SetToolTip(this.btnEditar, "Editar atividade");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pctLupa
            // 
            this.pctLupa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pctLupa.Image = ((System.Drawing.Image)(resources.GetObject("pctLupa.Image")));
            this.pctLupa.Location = new System.Drawing.Point(590, 32);
            this.pctLupa.Name = "pctLupa";
            this.pctLupa.Size = new System.Drawing.Size(20, 20);
            this.pctLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLupa.TabIndex = 202;
            this.pctLupa.TabStop = false;
            this.pctLupa.Visible = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPesquisar.Location = new System.Drawing.Point(613, 33);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(257, 18);
            this.txtPesquisar.TabIndex = 201;
            this.ttpAtividades.SetToolTip(this.txtPesquisar, "Digite aqui para pesquisar");
            this.txtPesquisar.Visible = false;
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlLinha2.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLinha2.Location = new System.Drawing.Point(590, 54);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(280, 1);
            this.pnlLinha2.TabIndex = 203;
            this.pnlLinha2.Visible = false;
            // 
            // frmAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.pnlLinha2);
            this.Controls.Add(this.pctLupa);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvAtividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtividades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividades";
            this.Load += new System.EventHandler(this.frmAtividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAtividades;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox pctLupa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.ToolTip ttpAtividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_atividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_deslocamento;
    }
}