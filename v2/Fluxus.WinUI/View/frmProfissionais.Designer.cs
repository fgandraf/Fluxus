﻿namespace Fluxus.WinUI.View
{
    partial class frmProfissionais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfissionais));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.pctLupa = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvProfissionais = new System.Windows.Forms.DataGridView();
            this.ttpProfissionais = new System.Windows.Forms.ToolTip(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelTecnico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.responsavelLegal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usr_ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usurioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionais)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha2.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLinha2.Location = new System.Drawing.Point(610, 54);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(280, 1);
            this.pnlLinha2.TabIndex = 217;
            this.pnlLinha2.Visible = false;
            // 
            // pctLupa
            // 
            this.pctLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctLupa.Image = ((System.Drawing.Image)(resources.GetObject("pctLupa.Image")));
            this.pctLupa.Location = new System.Drawing.Point(610, 32);
            this.pctLupa.Name = "pctLupa";
            this.pctLupa.Size = new System.Drawing.Size(20, 20);
            this.pctLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLupa.TabIndex = 216;
            this.pctLupa.TabStop = false;
            this.pctLupa.Visible = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisar.Location = new System.Drawing.Point(633, 33);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(257, 18);
            this.txtPesquisar.TabIndex = 215;
            this.txtPesquisar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(68, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(35, 35);
            this.btnEditar.TabIndex = 212;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpProfissionais.SetToolTip(this.btnEditar, "Editar Profissional");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(109, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(35, 35);
            this.btnExcluir.TabIndex = 213;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpProfissionais.SetToolTip(this.btnExcluir, "Excluir Profissional");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(30, 25);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(35, 35);
            this.btnAdicionar.TabIndex = 211;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpProfissionais.SetToolTip(this.btnAdicionar, "Adicionar Profissional");
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvProfissionais
            // 
            this.dgvProfissionais.AllowUserToAddRows = false;
            this.dgvProfissionais.AllowUserToDeleteRows = false;
            this.dgvProfissionais.AllowUserToOrderColumns = true;
            this.dgvProfissionais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfissionais.BackgroundColor = System.Drawing.Color.White;
            this.dgvProfissionais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProfissionais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProfissionais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfissionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfissionais.ColumnHeadersHeight = 35;
            this.dgvProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProfissionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nome,
            this.nomeid,
            this.cpf,
            this.nascimento,
            this.profissao,
            this.carteira,
            this.entidade,
            this.telefone1,
            this.telefone2,
            this.email,
            this.responsavelTecnico,
            this.responsavelLegal,
            this.usr_ativo,
            this.usurioNome,
            this.usuarioSenha});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfissionais.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProfissionais.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvProfissionais.Location = new System.Drawing.Point(30, 85);
            this.dgvProfissionais.MultiSelect = false;
            this.dgvProfissionais.Name = "dgvProfissionais";
            this.dgvProfissionais.ReadOnly = true;
            this.dgvProfissionais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfissionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProfissionais.RowHeadersVisible = false;
            this.dgvProfissionais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProfissionais.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProfissionais.RowTemplate.Height = 30;
            this.dgvProfissionais.RowTemplate.ReadOnly = true;
            this.dgvProfissionais.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfissionais.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProfissionais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfissionais.ShowEditingIcon = false;
            this.dgvProfissionais.Size = new System.Drawing.Size(860, 445);
            this.dgvProfissionais.TabIndex = 214;
            this.dgvProfissionais.DoubleClick += new System.EventHandler(this.btnEditar_Click);
            this.dgvProfissionais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProfissionais_KeyDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.DataPropertyName = "tag";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 76;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.nome.DefaultCellStyle = dataGridViewCellStyle3;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // nomeid
            // 
            this.nomeid.DataPropertyName = "nameid";
            this.nomeid.HeaderText = "Nomeid";
            this.nomeid.Name = "nomeid";
            this.nomeid.ReadOnly = true;
            this.nomeid.Visible = false;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cpf.DefaultCellStyle = dataGridViewCellStyle4;
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            // 
            // nascimento
            // 
            this.nascimento.DataPropertyName = "birthday";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nascimento.DefaultCellStyle = dataGridViewCellStyle5;
            this.nascimento.HeaderText = "Nascimento";
            this.nascimento.Name = "nascimento";
            this.nascimento.ReadOnly = true;
            this.nascimento.Visible = false;
            // 
            // profissao
            // 
            this.profissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profissao.DataPropertyName = "profession";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.profissao.DefaultCellStyle = dataGridViewCellStyle6;
            this.profissao.HeaderText = "Profissão";
            this.profissao.Name = "profissao";
            this.profissao.ReadOnly = true;
            this.profissao.Width = 88;
            // 
            // carteira
            // 
            this.carteira.DataPropertyName = "permitNumber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.carteira.DefaultCellStyle = dataGridViewCellStyle7;
            this.carteira.HeaderText = "Carteira";
            this.carteira.Name = "carteira";
            this.carteira.ReadOnly = true;
            this.carteira.Visible = false;
            // 
            // entidade
            // 
            this.entidade.DataPropertyName = "association";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.entidade.DefaultCellStyle = dataGridViewCellStyle8;
            this.entidade.HeaderText = "Entidade";
            this.entidade.Name = "entidade";
            this.entidade.ReadOnly = true;
            this.entidade.Visible = false;
            // 
            // telefone1
            // 
            this.telefone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefone1.DataPropertyName = "phone1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.telefone1.DefaultCellStyle = dataGridViewCellStyle9;
            this.telefone1.HeaderText = "Telefone";
            this.telefone1.Name = "telefone1";
            this.telefone1.ReadOnly = true;
            this.telefone1.Width = 83;
            // 
            // telefone2
            // 
            this.telefone2.DataPropertyName = "phone2";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.telefone2.DefaultCellStyle = dataGridViewCellStyle10;
            this.telefone2.HeaderText = "Telefone 2";
            this.telefone2.Name = "telefone2";
            this.telefone2.ReadOnly = true;
            this.telefone2.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.email.DefaultCellStyle = dataGridViewCellStyle11;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // responsavelTecnico
            // 
            this.responsavelTecnico.DataPropertyName = "technicianResponsible";
            this.responsavelTecnico.HeaderText = "Rt";
            this.responsavelTecnico.Name = "responsavelTecnico";
            this.responsavelTecnico.ReadOnly = true;
            this.responsavelTecnico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.responsavelTecnico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.responsavelTecnico.Visible = false;
            // 
            // responsavelLegal
            // 
            this.responsavelLegal.DataPropertyName = "legalResponsible";
            this.responsavelLegal.HeaderText = "Rl";
            this.responsavelLegal.Name = "responsavelLegal";
            this.responsavelLegal.ReadOnly = true;
            this.responsavelLegal.Visible = false;
            // 
            // usr_ativo
            // 
            this.usr_ativo.DataPropertyName = "userActive";
            this.usr_ativo.HeaderText = "Usuário Ativo";
            this.usr_ativo.Name = "usr_ativo";
            this.usr_ativo.ReadOnly = true;
            // 
            // usurioNome
            // 
            this.usurioNome.DataPropertyName = "userName";
            this.usurioNome.HeaderText = "usr_nome";
            this.usurioNome.Name = "usurioNome";
            this.usurioNome.ReadOnly = true;
            this.usurioNome.Visible = false;
            // 
            // usuarioSenha
            // 
            this.usuarioSenha.DataPropertyName = "userPassword";
            this.usuarioSenha.HeaderText = "usr_senha";
            this.usuarioSenha.Name = "usuarioSenha";
            this.usuarioSenha.ReadOnly = true;
            this.usuarioSenha.Visible = false;
            // 
            // frmProfissionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.pnlLinha2);
            this.Controls.Add(this.pctLupa);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvProfissionais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfissionais";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profissionais";
            this.Load += new System.EventHandler(this.frmProfissionais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.PictureBox pctLupa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvProfissionais;
        private System.Windows.Forms.ToolTip ttpProfissionais;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteira;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn responsavelTecnico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn responsavelLegal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usr_ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usurioNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioSenha;
    }
}