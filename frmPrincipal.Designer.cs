namespace AWSBackup
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TcPrincipal = new System.Windows.Forms.TabControl();
            this.tpAgenda = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.txtDiretorioBackup = new System.Windows.Forms.TextBox();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.cbAmazon = new System.Windows.Forms.CheckBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaminhoBackup = new System.Windows.Forms.TextBox();
            this.btnBrowseBanco = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.clbDias = new System.Windows.Forms.CheckedListBox();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpHoraBackup = new System.Windows.Forms.DateTimePicker();
            this.txtNumBackup = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.amazonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.origemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diabackupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerobackupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diretoriobackupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsAgenda = new System.Data.DataSet();
            this.dtAgenda = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.tpBackup = new System.Windows.Forms.TabPage();
            txtLog = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtTempoEspera = new System.Windows.Forms.TextBox();
            this.btnGfix = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.txtGfix = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.cbOldDescription = new System.Windows.Forms.CheckBox();
            this.cbNoTransportable = new System.Windows.Forms.CheckBox();
            this.cbNoGarbageCollect = new System.Windows.Forms.CheckBox();
            this.cbNoDatabaseTrigger = new System.Windows.Forms.CheckBox();
            this.cbMetaDataOnly = new System.Windows.Forms.CheckBox();
            this.cbIgnoreChecksum = new System.Windows.Forms.CheckBox();
            this.cbExpand = new System.Windows.Forms.CheckBox();
            this.cbConvert = new System.Windows.Forms.CheckBox();
            this.cbIgnoreLimbo = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPortaServidor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.tpAmazon = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAWSSecretAccessKey = new System.Windows.Forms.TextBox();
            this.txtAWSAccessKeyId = new System.Windows.Forms.TextBox();
            this.tcAmazon = new System.Windows.Forms.TabControl();
            this.tpAmazonDownload = new System.Windows.Forms.TabPage();
            this.LabelBytesTransfered = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonAbort = new System.Windows.Forms.Button();
            this.ButtonDownloadFile = new System.Windows.Forms.Button();
            this.ProgressBarDownload = new System.Windows.Forms.ProgressBar();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtDownloadBucketName = new System.Windows.Forms.TextBox();
            this.txtDownloadKeyName = new System.Windows.Forms.TextBox();
            this.txtDownloadFileName = new System.Windows.Forms.TextBox();
            this.tpAmazonUpload = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.CheckBoxUploadMakePublic = new System.Windows.Forms.CheckBox();
            this.txtUploadContentType = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.ButtonUploadBrowse = new System.Windows.Forms.Button();
            this.txtUploadKeyName = new System.Windows.Forms.TextBox();
            this.txtUploadBucketName = new System.Windows.Forms.TextBox();
            this.txtUploadFileName = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LabelAction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBarUpload = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonUploadFile = new System.Windows.Forms.Button();
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtContaEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmailDestinatario = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSenhaEmitente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtEmailEmitente = new System.Windows.Forms.TextBox();
            this.tpArquivo = new System.Windows.Forms.TabPage();
            this.dgvArquivo = new System.Windows.Forms.DataGridView();
            this.idarquivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecionadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idplanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dsArquivo = new System.Data.DataSet();
            this.dtArquivo = new System.Data.DataTable();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmsMenu.SuspendLayout();
            this.TcPrincipal.SuspendLayout();
            this.tpAgenda.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAgenda)).BeginInit();
            this.tpBackup.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpAmazon.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcAmazon.SuspendLayout();
            this.tpAmazonDownload.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.tpAmazonUpload.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tpEmail.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tpArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArquivo)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Programa responsavel pelo backup da base de dados firebird";
            this.notifyIcon1.BalloonTipTitle = "Backup Firebird";
            this.notifyIcon1.ContextMenuStrip = this.cmsMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AWS3 Backup ";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(103, 48);
            this.cmsMenu.DoubleClick += new System.EventHandler(this.cmsMenu_DoubleClick);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exibirToolStripMenuItem.Text = "Exibir";
            this.exibirToolStripMenuItem.Click += new System.EventHandler(this.exibirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // TcPrincipal
            // 
            this.TcPrincipal.Controls.Add(this.tpAgenda);
            this.TcPrincipal.Controls.Add(this.tpBackup);
            this.TcPrincipal.Controls.Add(this.tpAmazon);
            this.TcPrincipal.Controls.Add(this.tpEmail);
            this.TcPrincipal.Controls.Add(this.tpArquivo);
            this.TcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TcPrincipal.Name = "TcPrincipal";
            this.TcPrincipal.SelectedIndex = 0;
            this.TcPrincipal.Size = new System.Drawing.Size(746, 470);
            this.TcPrincipal.TabIndex = 94;
            this.TcPrincipal.Click += new System.EventHandler(this.TcPrincipal_Click);
            // 
            // tpAgenda
            // 
            this.tpAgenda.Controls.Add(this.panel5);
            this.tpAgenda.Controls.Add(this.panel4);
            this.tpAgenda.Controls.Add(this.panel1);
            this.tpAgenda.Location = new System.Drawing.Point(4, 22);
            this.tpAgenda.Name = "tpAgenda";
            this.tpAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgenda.Size = new System.Drawing.Size(738, 444);
            this.tpAgenda.TabIndex = 6;
            this.tpAgenda.Text = "Agenda";
            this.tpAgenda.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.txtDiretorioBackup);
            this.panel5.Controls.Add(this.cbAtivo);
            this.panel5.Controls.Add(this.cbAmazon);
            this.panel5.Controls.Add(this.txtId);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtCaminhoBackup);
            this.panel5.Controls.Add(this.btnBrowseBanco);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtCaminho);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.clbDias);
            this.panel5.Controls.Add(this.txtPlano);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.dtpHoraBackup);
            this.panel5.Controls.Add(this.txtNumBackup);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(732, 212);
            this.panel5.TabIndex = 12;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(67, 163);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 13);
            this.label30.TabIndex = 94;
            this.label30.Text = "Diretorio ";
            // 
            // txtDiretorioBackup
            // 
            this.txtDiretorioBackup.Location = new System.Drawing.Point(122, 160);
            this.txtDiretorioBackup.Name = "txtDiretorioBackup";
            this.txtDiretorioBackup.Size = new System.Drawing.Size(250, 20);
            this.txtDiretorioBackup.TabIndex = 8;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(189, 189);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbAtivo.TabIndex = 10;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // cbAmazon
            // 
            this.cbAmazon.AutoSize = true;
            this.cbAmazon.Location = new System.Drawing.Point(119, 189);
            this.cbAmazon.Name = "cbAmazon";
            this.cbAmazon.Size = new System.Drawing.Size(64, 17);
            this.cbAmazon.TabIndex = 9;
            this.cbAmazon.Text = "Amazon";
            this.cbAmazon.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(123, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(99, 7);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 13);
            this.label29.TabIndex = 92;
            this.label29.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Destino";
            // 
            // txtCaminhoBackup
            // 
            this.txtCaminhoBackup.Location = new System.Drawing.Point(123, 134);
            this.txtCaminhoBackup.Name = "txtCaminhoBackup";
            this.txtCaminhoBackup.Size = new System.Drawing.Size(250, 20);
            this.txtCaminhoBackup.TabIndex = 7;
            // 
            // btnBrowseBanco
            // 
            this.btnBrowseBanco.Location = new System.Drawing.Point(379, 108);
            this.btnBrowseBanco.Name = "btnBrowseBanco";
            this.btnBrowseBanco.Size = new System.Drawing.Size(27, 20);
            this.btnBrowseBanco.TabIndex = 6;
            this.btnBrowseBanco.Text = "...";
            this.btnBrowseBanco.UseVisualStyleBackColor = true;
            this.btnBrowseBanco.Click += new System.EventHandler(this.btnBrowseBanco_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Origem";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(123, 108);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(250, 20);
            this.txtCaminho.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(444, 11);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(132, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "Dia(s) de Execução(ções):";
            // 
            // clbDias
            // 
            this.clbDias.FormattingEnabled = true;
            this.clbDias.Items.AddRange(new object[] {
            "segunda-feira",
            "terça-feira",
            "quarta-feira",
            "quinta-feira",
            "sexta-feira",
            "sabado",
            "domingo"});
            this.clbDias.Location = new System.Drawing.Point(447, 30);
            this.clbDias.Name = "clbDias";
            this.clbDias.Size = new System.Drawing.Size(204, 169);
            this.clbDias.TabIndex = 10;
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(123, 30);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(250, 20);
            this.txtPlano.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(49, 33);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "Nome Plano:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(44, 85);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "Hora Backup:";
            // 
            // dtpHoraBackup
            // 
            this.dtpHoraBackup.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraBackup.Location = new System.Drawing.Point(123, 82);
            this.dtpHoraBackup.Name = "dtpHoraBackup";
            this.dtpHoraBackup.Size = new System.Drawing.Size(100, 20);
            this.dtpHoraBackup.TabIndex = 4;
            // 
            // txtNumBackup
            // 
            this.txtNumBackup.Location = new System.Drawing.Point(123, 56);
            this.txtNumBackup.Name = "txtNumBackup";
            this.txtNumBackup.Size = new System.Drawing.Size(100, 20);
            this.txtNumBackup.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Numero de Backups:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExcluir);
            this.panel4.Controls.Add(this.btnSalvar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(732, 45);
            this.panel4.TabIndex = 12;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(112, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(6, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 36);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvAgenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 177);
            this.panel1.TabIndex = 16;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AllowUserToOrderColumns = true;
            this.dgvAgenda.AutoGenerateColumns = false;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.idDataGridViewTextBoxColumn,
            this.planoDataGridViewTextBoxColumn,
            this.ativoDataGridViewTextBoxColumn,
            this.amazonDataGridViewTextBoxColumn,
            this.origemDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.opcoesDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.diabackupDataGridViewTextBoxColumn,
            this.numerobackupDataGridViewTextBoxColumn,
            this.diretoriobackupDataGridViewTextBoxColumn});
            this.dgvAgenda.DataMember = "tblAgenda";
            this.dgvAgenda.DataSource = this.dsAgenda;
            this.dgvAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgenda.Location = new System.Drawing.Point(0, 0);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(732, 177);
            this.dgvAgenda.TabIndex = 0;
            this.dgvAgenda.DoubleClick += new System.EventHandler(this.dgvAgenda_DoubleClick);
            // 
            // check
            // 
            this.check.DataPropertyName = "check";
            this.check.HeaderText = "Sel.";
            this.check.Name = "check";
            this.check.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // planoDataGridViewTextBoxColumn
            // 
            this.planoDataGridViewTextBoxColumn.DataPropertyName = "plano";
            this.planoDataGridViewTextBoxColumn.HeaderText = "plano";
            this.planoDataGridViewTextBoxColumn.Name = "planoDataGridViewTextBoxColumn";
            // 
            // ativoDataGridViewTextBoxColumn
            // 
            this.ativoDataGridViewTextBoxColumn.DataPropertyName = "ativo";
            this.ativoDataGridViewTextBoxColumn.HeaderText = "ativo";
            this.ativoDataGridViewTextBoxColumn.Name = "ativoDataGridViewTextBoxColumn";
            this.ativoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ativoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // amazonDataGridViewTextBoxColumn
            // 
            this.amazonDataGridViewTextBoxColumn.DataPropertyName = "amazon";
            this.amazonDataGridViewTextBoxColumn.HeaderText = "amazon";
            this.amazonDataGridViewTextBoxColumn.Name = "amazonDataGridViewTextBoxColumn";
            this.amazonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.amazonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // origemDataGridViewTextBoxColumn
            // 
            this.origemDataGridViewTextBoxColumn.DataPropertyName = "origem";
            this.origemDataGridViewTextBoxColumn.HeaderText = "origem";
            this.origemDataGridViewTextBoxColumn.Name = "origemDataGridViewTextBoxColumn";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // opcoesDataGridViewTextBoxColumn
            // 
            this.opcoesDataGridViewTextBoxColumn.DataPropertyName = "opcoes";
            this.opcoesDataGridViewTextBoxColumn.HeaderText = "opcoes";
            this.opcoesDataGridViewTextBoxColumn.Name = "opcoesDataGridViewTextBoxColumn";
            this.opcoesDataGridViewTextBoxColumn.Visible = false;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // diabackupDataGridViewTextBoxColumn
            // 
            this.diabackupDataGridViewTextBoxColumn.DataPropertyName = "diabackup";
            this.diabackupDataGridViewTextBoxColumn.HeaderText = "diabackup";
            this.diabackupDataGridViewTextBoxColumn.Name = "diabackupDataGridViewTextBoxColumn";
            this.diabackupDataGridViewTextBoxColumn.Visible = false;
            // 
            // numerobackupDataGridViewTextBoxColumn
            // 
            this.numerobackupDataGridViewTextBoxColumn.DataPropertyName = "numerobackup";
            this.numerobackupDataGridViewTextBoxColumn.HeaderText = "numerobackup";
            this.numerobackupDataGridViewTextBoxColumn.Name = "numerobackupDataGridViewTextBoxColumn";
            // 
            // diretoriobackupDataGridViewTextBoxColumn
            // 
            this.diretoriobackupDataGridViewTextBoxColumn.DataPropertyName = "diretorio_backup";
            this.diretoriobackupDataGridViewTextBoxColumn.HeaderText = "diretorio_backup";
            this.diretoriobackupDataGridViewTextBoxColumn.Name = "diretoriobackupDataGridViewTextBoxColumn";
            // 
            // dsAgenda
            // 
            this.dsAgenda.DataSetName = "NewDataSet";
            this.dsAgenda.Tables.AddRange(new System.Data.DataTable[] {
            this.dtAgenda});
            // 
            // dtAgenda
            // 
            this.dtAgenda.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn17,
            this.dataColumn18});
            this.dtAgenda.TableName = "tblAgenda";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.AutoIncrement = true;
            this.dataColumn1.Caption = "Codigo";
            this.dataColumn1.ColumnName = "id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Ativo";
            this.dataColumn2.ColumnName = "ativo";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Amazon";
            this.dataColumn3.ColumnName = "amazon";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Origem";
            this.dataColumn4.ColumnName = "origem";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Destino";
            this.dataColumn5.ColumnName = "destino";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Opcoes";
            this.dataColumn6.ColumnName = "opcoes";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Plano";
            this.dataColumn7.ColumnName = "plano";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Hora";
            this.dataColumn8.ColumnName = "hora";
            this.dataColumn8.DataType = typeof(System.TimeSpan);
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "Dia(s) Backup";
            this.dataColumn9.ColumnName = "diabackup";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "Qtd Backup";
            this.dataColumn10.ColumnName = "numerobackup";
            this.dataColumn10.DataType = typeof(int);
            // 
            // dataColumn17
            // 
            this.dataColumn17.Caption = "Diretorio";
            this.dataColumn17.ColumnName = "diretorio_backup";
            // 
            // dataColumn18
            // 
            this.dataColumn18.Caption = "Sel.";
            this.dataColumn18.ColumnName = "check";
            this.dataColumn18.DataType = typeof(bool);
            // 
            // tpBackup
            // 
            this.tpBackup.Controls.Add(txtLog);
            this.tpBackup.Controls.Add(this.groupBox6);
            this.tpBackup.Location = new System.Drawing.Point(4, 22);
            this.tpBackup.Name = "tpBackup";
            this.tpBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tpBackup.Size = new System.Drawing.Size(738, 444);
            this.tpBackup.TabIndex = 3;
            this.tpBackup.Text = "Backup / Restore";
            this.tpBackup.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            txtLog.Location = new System.Drawing.Point(13, 190);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new System.Drawing.Size(713, 246);
            txtLog.TabIndex = 32;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.txtTempoEspera);
            this.groupBox6.Controls.Add(this.btnGfix);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.txtGfix);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.txtServidor);
            this.groupBox6.Controls.Add(this.cbOldDescription);
            this.groupBox6.Controls.Add(this.cbNoTransportable);
            this.groupBox6.Controls.Add(this.cbNoGarbageCollect);
            this.groupBox6.Controls.Add(this.cbNoDatabaseTrigger);
            this.groupBox6.Controls.Add(this.cbMetaDataOnly);
            this.groupBox6.Controls.Add(this.cbIgnoreChecksum);
            this.groupBox6.Controls.Add(this.cbExpand);
            this.groupBox6.Controls.Add(this.cbConvert);
            this.groupBox6.Controls.Add(this.cbIgnoreLimbo);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.txtPortaServidor);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtUsuario);
            this.groupBox6.Controls.Add(this.txtSenha);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(732, 181);
            this.groupBox6.TabIndex = 88;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Download Options";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 152);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 13);
            this.label33.TabIndex = 104;
            this.label33.Text = "Tempo Espera";
            // 
            // txtTempoEspera
            // 
            this.txtTempoEspera.Location = new System.Drawing.Point(83, 149);
            this.txtTempoEspera.Name = "txtTempoEspera";
            this.txtTempoEspera.Size = new System.Drawing.Size(250, 20);
            this.txtTempoEspera.TabIndex = 102;
            // 
            // btnGfix
            // 
            this.btnGfix.Location = new System.Drawing.Point(339, 122);
            this.btnGfix.Name = "btnGfix";
            this.btnGfix.Size = new System.Drawing.Size(32, 22);
            this.btnGfix.TabIndex = 22;
            this.btnGfix.Text = "...";
            this.btnGfix.UseVisualStyleBackColor = true;
            this.btnGfix.Click += new System.EventHandler(this.btnGfix_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 126);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 13);
            this.label32.TabIndex = 101;
            this.label32.Text = "Gfix";
            // 
            // txtGfix
            // 
            this.txtGfix.Location = new System.Drawing.Point(83, 123);
            this.txtGfix.Name = "txtGfix";
            this.txtGfix.Size = new System.Drawing.Size(250, 20);
            this.txtGfix.TabIndex = 21;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 48);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 13);
            this.label31.TabIndex = 99;
            this.label31.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(83, 45);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(250, 20);
            this.txtServidor.TabIndex = 18;
            // 
            // cbOldDescription
            // 
            this.cbOldDescription.AutoSize = true;
            this.cbOldDescription.Location = new System.Drawing.Point(463, 111);
            this.cbOldDescription.Name = "cbOldDescription";
            this.cbOldDescription.Size = new System.Drawing.Size(103, 17);
            this.cbOldDescription.TabIndex = 31;
            this.cbOldDescription.Text = "Old Descriptions";
            this.cbOldDescription.UseVisualStyleBackColor = true;
            // 
            // cbNoTransportable
            // 
            this.cbNoTransportable.AutoSize = true;
            this.cbNoTransportable.Location = new System.Drawing.Point(593, 88);
            this.cbNoTransportable.Name = "cbNoTransportable";
            this.cbNoTransportable.Size = new System.Drawing.Size(108, 17);
            this.cbNoTransportable.TabIndex = 30;
            this.cbNoTransportable.Text = "No Transportable";
            this.cbNoTransportable.UseVisualStyleBackColor = true;
            // 
            // cbNoGarbageCollect
            // 
            this.cbNoGarbageCollect.AutoSize = true;
            this.cbNoGarbageCollect.Location = new System.Drawing.Point(593, 65);
            this.cbNoGarbageCollect.Name = "cbNoGarbageCollect";
            this.cbNoGarbageCollect.Size = new System.Drawing.Size(119, 17);
            this.cbNoGarbageCollect.TabIndex = 29;
            this.cbNoGarbageCollect.Text = "No Garbage Collect";
            this.cbNoGarbageCollect.UseVisualStyleBackColor = true;
            // 
            // cbNoDatabaseTrigger
            // 
            this.cbNoDatabaseTrigger.AutoSize = true;
            this.cbNoDatabaseTrigger.Location = new System.Drawing.Point(593, 42);
            this.cbNoDatabaseTrigger.Name = "cbNoDatabaseTrigger";
            this.cbNoDatabaseTrigger.Size = new System.Drawing.Size(130, 17);
            this.cbNoDatabaseTrigger.TabIndex = 28;
            this.cbNoDatabaseTrigger.Text = "No Database Triggers";
            this.cbNoDatabaseTrigger.UseVisualStyleBackColor = true;
            // 
            // cbMetaDataOnly
            // 
            this.cbMetaDataOnly.AutoSize = true;
            this.cbMetaDataOnly.Location = new System.Drawing.Point(593, 19);
            this.cbMetaDataOnly.Name = "cbMetaDataOnly";
            this.cbMetaDataOnly.Size = new System.Drawing.Size(97, 17);
            this.cbMetaDataOnly.TabIndex = 27;
            this.cbMetaDataOnly.Text = "MetaData Only";
            this.cbMetaDataOnly.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreChecksum
            // 
            this.cbIgnoreChecksum.AutoSize = true;
            this.cbIgnoreChecksum.Location = new System.Drawing.Point(463, 88);
            this.cbIgnoreChecksum.Name = "cbIgnoreChecksum";
            this.cbIgnoreChecksum.Size = new System.Drawing.Size(114, 17);
            this.cbIgnoreChecksum.TabIndex = 26;
            this.cbIgnoreChecksum.Text = "Ignore Checksums";
            this.cbIgnoreChecksum.UseVisualStyleBackColor = true;
            // 
            // cbExpand
            // 
            this.cbExpand.AutoSize = true;
            this.cbExpand.Location = new System.Drawing.Point(463, 65);
            this.cbExpand.Name = "cbExpand";
            this.cbExpand.Size = new System.Drawing.Size(62, 17);
            this.cbExpand.TabIndex = 25;
            this.cbExpand.Text = "Expand";
            this.cbExpand.UseVisualStyleBackColor = true;
            // 
            // cbConvert
            // 
            this.cbConvert.AutoSize = true;
            this.cbConvert.Location = new System.Drawing.Point(463, 42);
            this.cbConvert.Name = "cbConvert";
            this.cbConvert.Size = new System.Drawing.Size(63, 17);
            this.cbConvert.TabIndex = 24;
            this.cbConvert.Text = "Convert";
            this.cbConvert.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreLimbo
            // 
            this.cbIgnoreLimbo.AutoSize = true;
            this.cbIgnoreLimbo.Location = new System.Drawing.Point(463, 19);
            this.cbIgnoreLimbo.Name = "cbIgnoreLimbo";
            this.cbIgnoreLimbo.Size = new System.Drawing.Size(87, 17);
            this.cbIgnoreLimbo.TabIndex = 23;
            this.cbIgnoreLimbo.Text = "Ignore Limbo";
            this.cbIgnoreLimbo.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 88;
            this.label19.Text = "Porta";
            // 
            // txtPortaServidor
            // 
            this.txtPortaServidor.Location = new System.Drawing.Point(83, 19);
            this.txtPortaServidor.Name = "txtPortaServidor";
            this.txtPortaServidor.Size = new System.Drawing.Size(250, 20);
            this.txtPortaServidor.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(83, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 20);
            this.txtUsuario.TabIndex = 19;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(83, 97);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(250, 20);
            this.txtSenha.TabIndex = 20;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // tpAmazon
            // 
            this.tpAmazon.Controls.Add(this.panel2);
            this.tpAmazon.Controls.Add(this.tcAmazon);
            this.tpAmazon.Location = new System.Drawing.Point(4, 22);
            this.tpAmazon.Name = "tpAmazon";
            this.tpAmazon.Padding = new System.Windows.Forms.Padding(3);
            this.tpAmazon.Size = new System.Drawing.Size(738, 444);
            this.tpAmazon.TabIndex = 5;
            this.tpAmazon.Text = "Amazon";
            this.tpAmazon.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txtAWSSecretAccessKey);
            this.panel2.Controls.Add(this.txtAWSAccessKeyId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 70);
            this.panel2.TabIndex = 44;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 44);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Amazon Secret Access Key";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 13);
            this.label24.TabIndex = 41;
            this.label24.Text = "Amazon Access Key Id";
            // 
            // txtAWSSecretAccessKey
            // 
            this.txtAWSSecretAccessKey.Location = new System.Drawing.Point(172, 41);
            this.txtAWSSecretAccessKey.Name = "txtAWSSecretAccessKey";
            this.txtAWSSecretAccessKey.Size = new System.Drawing.Size(287, 20);
            this.txtAWSSecretAccessKey.TabIndex = 36;
            // 
            // txtAWSAccessKeyId
            // 
            this.txtAWSAccessKeyId.Location = new System.Drawing.Point(172, 15);
            this.txtAWSAccessKeyId.Name = "txtAWSAccessKeyId";
            this.txtAWSAccessKeyId.Size = new System.Drawing.Size(287, 20);
            this.txtAWSAccessKeyId.TabIndex = 35;
            // 
            // tcAmazon
            // 
            this.tcAmazon.Controls.Add(this.tpAmazonDownload);
            this.tcAmazon.Controls.Add(this.tpAmazonUpload);
            this.tcAmazon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcAmazon.Location = new System.Drawing.Point(3, 85);
            this.tcAmazon.Name = "tcAmazon";
            this.tcAmazon.SelectedIndex = 0;
            this.tcAmazon.Size = new System.Drawing.Size(732, 356);
            this.tcAmazon.TabIndex = 43;
            // 
            // tpAmazonDownload
            // 
            this.tpAmazonDownload.Controls.Add(this.LabelBytesTransfered);
            this.tpAmazonDownload.Controls.Add(this.groupBox2);
            this.tpAmazonDownload.Controls.Add(this.ProgressBarDownload);
            this.tpAmazonDownload.Controls.Add(this.GroupBox1);
            this.tpAmazonDownload.Location = new System.Drawing.Point(4, 22);
            this.tpAmazonDownload.Name = "tpAmazonDownload";
            this.tpAmazonDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tpAmazonDownload.Size = new System.Drawing.Size(724, 330);
            this.tpAmazonDownload.TabIndex = 0;
            this.tpAmazonDownload.Text = "Download";
            this.tpAmazonDownload.UseVisualStyleBackColor = true;
            // 
            // LabelBytesTransfered
            // 
            this.LabelBytesTransfered.AutoSize = true;
            this.LabelBytesTransfered.Enabled = false;
            this.LabelBytesTransfered.Location = new System.Drawing.Point(293, 229);
            this.LabelBytesTransfered.Name = "LabelBytesTransfered";
            this.LabelBytesTransfered.Size = new System.Drawing.Size(86, 13);
            this.LabelBytesTransfered.TabIndex = 87;
            this.LabelBytesTransfered.Text = "0 bytes / 0 bytes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonAbort);
            this.groupBox2.Controls.Add(this.ButtonDownloadFile);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 82);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progresso";
            // 
            // ButtonAbort
            // 
            this.ButtonAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAbort.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAbort.Image")));
            this.ButtonAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAbort.Location = new System.Drawing.Point(611, 21);
            this.ButtonAbort.Name = "ButtonAbort";
            this.ButtonAbort.Size = new System.Drawing.Size(100, 55);
            this.ButtonAbort.TabIndex = 42;
            this.ButtonAbort.Text = "Cancelar";
            this.ButtonAbort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAbort.UseVisualStyleBackColor = true;
            this.ButtonAbort.Visible = false;
            // 
            // ButtonDownloadFile
            // 
            this.ButtonDownloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDownloadFile.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDownloadFile.Image")));
            this.ButtonDownloadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDownloadFile.Location = new System.Drawing.Point(6, 19);
            this.ButtonDownloadFile.Name = "ButtonDownloadFile";
            this.ButtonDownloadFile.Size = new System.Drawing.Size(100, 55);
            this.ButtonDownloadFile.TabIndex = 41;
            this.ButtonDownloadFile.Text = "Download";
            this.ButtonDownloadFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDownloadFile.UseVisualStyleBackColor = true;
            this.ButtonDownloadFile.Visible = false;
            this.ButtonDownloadFile.Click += new System.EventHandler(this.ButtonDownloadFile_Click);
            // 
            // ProgressBarDownload
            // 
            this.ProgressBarDownload.Location = new System.Drawing.Point(13, 176);
            this.ProgressBarDownload.Name = "ProgressBarDownload";
            this.ProgressBarDownload.Size = new System.Drawing.Size(697, 50);
            this.ProgressBarDownload.TabIndex = 40;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.txtDownloadBucketName);
            this.GroupBox1.Controls.Add(this.txtDownloadKeyName);
            this.GroupBox1.Controls.Add(this.txtDownloadFileName);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(718, 108);
            this.GroupBox1.TabIndex = 88;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Download Options";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(7, 24);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 13);
            this.Label10.TabIndex = 70;
            this.Label10.Text = "Bucket Name";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(7, 50);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(56, 13);
            this.Label11.TabIndex = 71;
            this.Label11.Text = "Key Name";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(8, 76);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(83, 13);
            this.Label12.TabIndex = 72;
            this.Label12.Text = "Local File Name";
            // 
            // txtDownloadBucketName
            // 
            this.txtDownloadBucketName.Location = new System.Drawing.Point(97, 21);
            this.txtDownloadBucketName.Name = "txtDownloadBucketName";
            this.txtDownloadBucketName.Size = new System.Drawing.Size(250, 20);
            this.txtDownloadBucketName.TabIndex = 37;
            // 
            // txtDownloadKeyName
            // 
            this.txtDownloadKeyName.Location = new System.Drawing.Point(97, 47);
            this.txtDownloadKeyName.Name = "txtDownloadKeyName";
            this.txtDownloadKeyName.Size = new System.Drawing.Size(250, 20);
            this.txtDownloadKeyName.TabIndex = 38;
            // 
            // txtDownloadFileName
            // 
            this.txtDownloadFileName.Location = new System.Drawing.Point(97, 73);
            this.txtDownloadFileName.Name = "txtDownloadFileName";
            this.txtDownloadFileName.Size = new System.Drawing.Size(250, 20);
            this.txtDownloadFileName.TabIndex = 39;
            // 
            // tpAmazonUpload
            // 
            this.tpAmazonUpload.Controls.Add(this.groupBox3);
            this.tpAmazonUpload.Controls.Add(this.groupBox4);
            this.tpAmazonUpload.Location = new System.Drawing.Point(4, 22);
            this.tpAmazonUpload.Name = "tpAmazonUpload";
            this.tpAmazonUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tpAmazonUpload.Size = new System.Drawing.Size(724, 330);
            this.tpAmazonUpload.TabIndex = 1;
            this.tpAmazonUpload.Text = "Upload";
            this.tpAmazonUpload.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Label22);
            this.groupBox3.Controls.Add(this.Label21);
            this.groupBox3.Controls.Add(this.CheckBoxUploadMakePublic);
            this.groupBox3.Controls.Add(this.txtUploadContentType);
            this.groupBox3.Controls.Add(this.Label20);
            this.groupBox3.Controls.Add(this.ButtonUploadBrowse);
            this.groupBox3.Controls.Add(this.txtUploadKeyName);
            this.groupBox3.Controls.Add(this.txtUploadBucketName);
            this.groupBox3.Controls.Add(this.txtUploadFileName);
            this.groupBox3.Controls.Add(this.Label9);
            this.groupBox3.Controls.Add(this.Label8);
            this.groupBox3.Controls.Add(this.Label7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(718, 153);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Upload Options";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(351, 105);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(52, 13);
            this.Label22.TabIndex = 93;
            this.Label22.Text = "(Optional)";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(6, 132);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(66, 13);
            this.Label21.TabIndex = 92;
            this.Label21.Text = "Make Public";
            // 
            // CheckBoxUploadMakePublic
            // 
            this.CheckBoxUploadMakePublic.AutoSize = true;
            this.CheckBoxUploadMakePublic.Location = new System.Drawing.Point(95, 133);
            this.CheckBoxUploadMakePublic.Name = "CheckBoxUploadMakePublic";
            this.CheckBoxUploadMakePublic.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxUploadMakePublic.TabIndex = 91;
            this.CheckBoxUploadMakePublic.UseVisualStyleBackColor = true;
            // 
            // txtUploadContentType
            // 
            this.txtUploadContentType.Location = new System.Drawing.Point(95, 102);
            this.txtUploadContentType.Name = "txtUploadContentType";
            this.txtUploadContentType.Size = new System.Drawing.Size(250, 20);
            this.txtUploadContentType.TabIndex = 90;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(6, 105);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(71, 13);
            this.Label20.TabIndex = 89;
            this.Label20.Text = "Content-Type";
            // 
            // ButtonUploadBrowse
            // 
            this.ButtonUploadBrowse.Location = new System.Drawing.Point(351, 22);
            this.ButtonUploadBrowse.Name = "ButtonUploadBrowse";
            this.ButtonUploadBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonUploadBrowse.TabIndex = 83;
            this.ButtonUploadBrowse.Text = "Browse";
            this.ButtonUploadBrowse.UseVisualStyleBackColor = true;
            this.ButtonUploadBrowse.Click += new System.EventHandler(this.ButtonUploadBrowse_Click);
            // 
            // txtUploadKeyName
            // 
            this.txtUploadKeyName.Location = new System.Drawing.Point(95, 76);
            this.txtUploadKeyName.Name = "txtUploadKeyName";
            this.txtUploadKeyName.Size = new System.Drawing.Size(250, 20);
            this.txtUploadKeyName.TabIndex = 85;
            // 
            // txtUploadBucketName
            // 
            this.txtUploadBucketName.Location = new System.Drawing.Point(95, 50);
            this.txtUploadBucketName.Name = "txtUploadBucketName";
            this.txtUploadBucketName.Size = new System.Drawing.Size(250, 20);
            this.txtUploadBucketName.TabIndex = 84;
            // 
            // txtUploadFileName
            // 
            this.txtUploadFileName.Location = new System.Drawing.Point(95, 24);
            this.txtUploadFileName.Name = "txtUploadFileName";
            this.txtUploadFileName.Size = new System.Drawing.Size(250, 20);
            this.txtUploadFileName.TabIndex = 82;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 79);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(56, 13);
            this.Label9.TabIndex = 88;
            this.Label9.Text = "Key Name";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 53);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 13);
            this.Label8.TabIndex = 87;
            this.Label8.Text = "Bucket Name";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 27);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(83, 13);
            this.Label7.TabIndex = 86;
            this.Label7.Text = "Local File Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LabelAction);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.ProgressBarUpload);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.ButtonUploadFile);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(718, 164);
            this.groupBox4.TabIndex = 94;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progresso";
            // 
            // LabelAction
            // 
            this.LabelAction.AutoSize = true;
            this.LabelAction.Enabled = false;
            this.LabelAction.Location = new System.Drawing.Point(302, 72);
            this.LabelAction.Name = "LabelAction";
            this.LabelAction.Size = new System.Drawing.Size(47, 13);
            this.LabelAction.TabIndex = 94;
            this.LabelAction.Text = "Aguarde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "0 bytes / 0 bytes";
            // 
            // ProgressBarUpload
            // 
            this.ProgressBarUpload.Location = new System.Drawing.Point(9, 19);
            this.ProgressBarUpload.Name = "ProgressBarUpload";
            this.ProgressBarUpload.Size = new System.Drawing.Size(703, 50);
            this.ProgressBarUpload.TabIndex = 92;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(612, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 55);
            this.button1.TabIndex = 91;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonUploadFile
            // 
            this.ButtonUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUploadFile.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUploadFile.Image")));
            this.ButtonUploadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUploadFile.Location = new System.Drawing.Point(6, 106);
            this.ButtonUploadFile.Name = "ButtonUploadFile";
            this.ButtonUploadFile.Size = new System.Drawing.Size(100, 55);
            this.ButtonUploadFile.TabIndex = 90;
            this.ButtonUploadFile.Text = "Upload";
            this.ButtonUploadFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUploadFile.UseVisualStyleBackColor = true;
            this.ButtonUploadFile.Visible = false;
            this.ButtonUploadFile.Click += new System.EventHandler(this.ButtonUploadFile_Click);
            // 
            // tpEmail
            // 
            this.tpEmail.Controls.Add(this.groupBox7);
            this.tpEmail.Location = new System.Drawing.Point(4, 22);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmail.Size = new System.Drawing.Size(738, 444);
            this.tpEmail.TabIndex = 4;
            this.tpEmail.Text = "E-Mail";
            this.tpEmail.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txtContaEmail);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.txtEmailDestinatario);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txtSenhaEmitente);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.txtSMTP);
            this.groupBox7.Controls.Add(this.txtPorta);
            this.groupBox7.Controls.Add(this.txtEmailEmitente);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(732, 187);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configurações";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "Usuario Conta";
            // 
            // txtContaEmail
            // 
            this.txtContaEmail.Location = new System.Drawing.Point(108, 73);
            this.txtContaEmail.Name = "txtContaEmail";
            this.txtContaEmail.Size = new System.Drawing.Size(250, 20);
            this.txtContaEmail.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 82;
            this.label17.Text = "E-mail Destinatario";
            // 
            // txtEmailDestinatario
            // 
            this.txtEmailDestinatario.Location = new System.Drawing.Point(108, 154);
            this.txtEmailDestinatario.Name = "txtEmailDestinatario";
            this.txtEmailDestinatario.Size = new System.Drawing.Size(250, 20);
            this.txtEmailDestinatario.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 80;
            this.label16.Text = "Senha Emitente";
            // 
            // txtSenhaEmitente
            // 
            this.txtSenhaEmitente.Location = new System.Drawing.Point(108, 128);
            this.txtSenhaEmitente.Name = "txtSenhaEmitente";
            this.txtSenhaEmitente.PasswordChar = '*';
            this.txtSenhaEmitente.Size = new System.Drawing.Size(250, 20);
            this.txtSenhaEmitente.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "SMTP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "Porta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "E-mail Emitente";
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(108, 21);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(250, 20);
            this.txtSMTP.TabIndex = 43;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(108, 47);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(250, 20);
            this.txtPorta.TabIndex = 44;
            // 
            // txtEmailEmitente
            // 
            this.txtEmailEmitente.Location = new System.Drawing.Point(108, 102);
            this.txtEmailEmitente.Name = "txtEmailEmitente";
            this.txtEmailEmitente.Size = new System.Drawing.Size(250, 20);
            this.txtEmailEmitente.TabIndex = 46;
            // 
            // tpArquivo
            // 
            this.tpArquivo.Controls.Add(this.dgvArquivo);
            this.tpArquivo.Controls.Add(this.panel3);
            this.tpArquivo.Location = new System.Drawing.Point(4, 22);
            this.tpArquivo.Name = "tpArquivo";
            this.tpArquivo.Padding = new System.Windows.Forms.Padding(3);
            this.tpArquivo.Size = new System.Drawing.Size(738, 444);
            this.tpArquivo.TabIndex = 7;
            this.tpArquivo.Text = "Arquivo";
            this.tpArquivo.UseVisualStyleBackColor = true;
            // 
            // dgvArquivo
            // 
            this.dgvArquivo.AllowUserToAddRows = false;
            this.dgvArquivo.AllowUserToDeleteRows = false;
            this.dgvArquivo.AutoGenerateColumns = false;
            this.dgvArquivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArquivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idarquivoDataGridViewTextBoxColumn,
            this.selecionadoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.idplanoDataGridViewTextBoxColumn,
            this.contenttypeDataGridViewTextBoxColumn,
            this.btnDelete});
            this.dgvArquivo.DataMember = "tblArquivo";
            this.dgvArquivo.DataSource = this.dsArquivo;
            this.dgvArquivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArquivo.Location = new System.Drawing.Point(3, 21);
            this.dgvArquivo.Name = "dgvArquivo";
            this.dgvArquivo.ReadOnly = true;
            this.dgvArquivo.Size = new System.Drawing.Size(732, 420);
            this.dgvArquivo.TabIndex = 52;
            this.dgvArquivo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArquivo_CellClick);
            // 
            // idarquivoDataGridViewTextBoxColumn
            // 
            this.idarquivoDataGridViewTextBoxColumn.DataPropertyName = "id_arquivo";
            this.idarquivoDataGridViewTextBoxColumn.HeaderText = "id_arquivo";
            this.idarquivoDataGridViewTextBoxColumn.Name = "idarquivoDataGridViewTextBoxColumn";
            this.idarquivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idarquivoDataGridViewTextBoxColumn.Visible = false;
            // 
            // selecionadoDataGridViewTextBoxColumn
            // 
            this.selecionadoDataGridViewTextBoxColumn.DataPropertyName = "selecionado";
            this.selecionadoDataGridViewTextBoxColumn.FalseValue = "0";
            this.selecionadoDataGridViewTextBoxColumn.HeaderText = "selecionado";
            this.selecionadoDataGridViewTextBoxColumn.Name = "selecionadoDataGridViewTextBoxColumn";
            this.selecionadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.selecionadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selecionadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.selecionadoDataGridViewTextBoxColumn.TrueValue = "1";
            this.selecionadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            this.tamanhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoDataGridViewTextBoxColumn.Width = 150;
            // 
            // idplanoDataGridViewTextBoxColumn
            // 
            this.idplanoDataGridViewTextBoxColumn.DataPropertyName = "id_plano";
            this.idplanoDataGridViewTextBoxColumn.HeaderText = "id_plano";
            this.idplanoDataGridViewTextBoxColumn.Name = "idplanoDataGridViewTextBoxColumn";
            this.idplanoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idplanoDataGridViewTextBoxColumn.Visible = false;
            // 
            // contenttypeDataGridViewTextBoxColumn
            // 
            this.contenttypeDataGridViewTextBoxColumn.DataPropertyName = "content_type";
            this.contenttypeDataGridViewTextBoxColumn.HeaderText = "content_type";
            this.contenttypeDataGridViewTextBoxColumn.Name = "contenttypeDataGridViewTextBoxColumn";
            this.contenttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.contenttypeDataGridViewTextBoxColumn.Width = 220;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Del";
            this.btnDelete.Image = global::AWSBackup.Properties.Resources.icons8_Trash_24;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            // 
            // dsArquivo
            // 
            this.dsArquivo.DataSetName = "NewDataSet";
            this.dsArquivo.Tables.AddRange(new System.Data.DataTable[] {
            this.dtArquivo});
            // 
            // dtArquivo
            // 
            this.dtArquivo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16});
            this.dtArquivo.TableName = "tblArquivo";
            // 
            // dataColumn11
            // 
            this.dataColumn11.AllowDBNull = false;
            this.dataColumn11.AutoIncrement = true;
            this.dataColumn11.AutoIncrementSeed = ((long)(1));
            this.dataColumn11.Caption = "Id";
            this.dataColumn11.ColumnName = "id_arquivo";
            this.dataColumn11.DataType = typeof(int);
            // 
            // dataColumn12
            // 
            this.dataColumn12.Caption = "Selecionado";
            this.dataColumn12.ColumnName = "selecionado";
            this.dataColumn12.DataType = typeof(int);
            // 
            // dataColumn13
            // 
            this.dataColumn13.Caption = "Nome";
            this.dataColumn13.ColumnName = "nome";
            // 
            // dataColumn14
            // 
            this.dataColumn14.Caption = "Tamanho";
            this.dataColumn14.ColumnName = "tamanho";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "id_plano";
            this.dataColumn15.DataType = typeof(int);
            // 
            // dataColumn16
            // 
            this.dataColumn16.Caption = "Tipo Arquivo";
            this.dataColumn16.ColumnName = "content_type";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 18);
            this.panel3.TabIndex = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 470);
            this.Controls.Add(this.TcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWS Backup Firebird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.Move += new System.EventHandler(this.frmPrincipal_Move);
            this.cmsMenu.ResumeLayout(false);
            this.TcPrincipal.ResumeLayout(false);
            this.tpAgenda.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAgenda)).EndInit();
            this.tpBackup.ResumeLayout(false);
            this.tpBackup.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpAmazon.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tcAmazon.ResumeLayout(false);
            this.tpAmazonDownload.ResumeLayout(false);
            this.tpAmazonDownload.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tpAmazonUpload.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tpEmail.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tpArquivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArquivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl TcPrincipal;
        private System.Windows.Forms.TabPage tpBackup;
        private System.Windows.Forms.TabPage tpEmail;
        private System.Windows.Forms.GroupBox groupBox7;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox txtContaEmail;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox txtEmailDestinatario;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtSenhaEmitente;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtSMTP;
        internal System.Windows.Forms.TextBox txtPorta;
        internal System.Windows.Forms.TextBox txtEmailEmitente;
        private System.Windows.Forms.TabPage tpAmazon;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.TextBox txtAWSSecretAccessKey;
        internal System.Windows.Forms.TextBox txtAWSAccessKeyId;
        private System.Windows.Forms.TabControl tcAmazon;
        private System.Windows.Forms.TabPage tpAmazonDownload;
        internal System.Windows.Forms.Label LabelBytesTransfered;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button ButtonAbort;
        internal System.Windows.Forms.Button ButtonDownloadFile;
        internal System.Windows.Forms.ProgressBar ProgressBarDownload;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtDownloadBucketName;
        internal System.Windows.Forms.TextBox txtDownloadKeyName;
        internal System.Windows.Forms.TextBox txtDownloadFileName;
        private System.Windows.Forms.TabPage tpAmazonUpload;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.CheckBox CheckBoxUploadMakePublic;
        internal System.Windows.Forms.TextBox txtUploadContentType;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Button ButtonUploadBrowse;
        internal System.Windows.Forms.TextBox txtUploadKeyName;
        internal System.Windows.Forms.TextBox txtUploadBucketName;
        internal System.Windows.Forms.TextBox txtUploadFileName;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label LabelAction;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ProgressBar ProgressBarUpload;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button ButtonUploadFile;
        private System.Windows.Forms.TabPage tpAgenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckedListBox clbDias;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpHoraBackup;
        private System.Windows.Forms.TextBox txtNumBackup;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtCaminhoBackup;
        internal System.Windows.Forms.Button btnBrowseBanco;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtCaminho;
        internal System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbOldDescription;
        private System.Windows.Forms.CheckBox cbNoTransportable;
        private System.Windows.Forms.CheckBox cbNoGarbageCollect;
        private System.Windows.Forms.CheckBox cbNoDatabaseTrigger;
        private System.Windows.Forms.CheckBox cbMetaDataOnly;
        private System.Windows.Forms.CheckBox cbIgnoreChecksum;
        private System.Windows.Forms.CheckBox cbExpand;
        private System.Windows.Forms.CheckBox cbConvert;
        private System.Windows.Forms.CheckBox cbIgnoreLimbo;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox txtPortaServidor;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.TextBox txtSenha;
        internal System.Windows.Forms.Button btnSalvar;
        internal System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label29;
        private System.Data.DataSet dsAgenda;
        private System.Data.DataTable dtAgenda;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.CheckBox cbAmazon;
        private System.Windows.Forms.TabPage tpArquivo;
        private System.Windows.Forms.Panel panel3;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataSet dsArquivo;
        private System.Data.DataTable dtArquivo;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Windows.Forms.DataGridView dgvArquivo;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label label31;
        internal System.Windows.Forms.TextBox txtServidor;
        internal System.Windows.Forms.Label label32;
        internal System.Windows.Forms.TextBox txtGfix;
        internal System.Windows.Forms.Button btnGfix;
        internal System.Windows.Forms.Label label33;
        internal System.Windows.Forms.TextBox txtTempoEspera;
        internal System.Windows.Forms.Label label30;
        internal System.Windows.Forms.TextBox txtDiretorioBackup;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Data.DataColumn dataColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarquivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn amazonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diabackupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerobackupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diretoriobackupDataGridViewTextBoxColumn;
        private static System.Windows.Forms.TextBox txtLog;
    }
}

