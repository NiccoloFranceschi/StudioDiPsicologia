﻿namespace StudioDiPsicologia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAppuntamenti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedici = new System.Windows.Forms.Label();
            this.lblPazienti = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.PanelHome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbOrario = new System.Windows.Forms.ProgressBar();
            this.lblData = new System.Windows.Forms.Label();
            this.lblOra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Orologio = new System.Windows.Forms.Timer(this.components);
            this.PanelPaziente = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbxPazienti = new System.Windows.Forms.ListBox();
            this.btnRimuoviPaziente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAggiungiPaziente = new System.Windows.Forms.Button();
            this.dtpPaziente = new System.Windows.Forms.DateTimePicker();
            this.txtIbanPaziente = new System.Windows.Forms.TextBox();
            this.txtCognomePaziente = new System.Windows.Forms.TextBox();
            this.txtNomePaziente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelMedico = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbxMedici = new System.Windows.Forms.ListBox();
            this.btnRimuoviMedico = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtIDMedico = new System.Windows.Forms.TextBox();
            this.nFineMedico = new System.Windows.Forms.NumericUpDown();
            this.nInizioMedico = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSpecializzazioneMedico = new System.Windows.Forms.TextBox();
            this.btnAggiungiMedico = new System.Windows.Forms.Button();
            this.txtCognomeMedico = new System.Windows.Forms.TextBox();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelAppuntamento = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbxAppuntamenti = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbPaziente = new System.Windows.Forms.ComboBox();
            this.txtMotivazione = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudOrario = new System.Windows.Forms.NumericUpDown();
            this.dtpAppuntamento = new System.Windows.Forms.DateTimePicker();
            this.btnAggiungiAppuntamento = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.PanelHome.SuspendLayout();
            this.PanelPaziente.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelMedico.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFineMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInizioMedico)).BeginInit();
            this.PanelAppuntamento.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.lblAppuntamenti);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblMedici);
            this.panel3.Controls.Add(this.lblPazienti);
            this.panel3.Controls.Add(this.lblHome);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1590, 40);
            this.panel3.TabIndex = 14;
            // 
            // lblAppuntamenti
            // 
            this.lblAppuntamenti.AutoSize = true;
            this.lblAppuntamenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppuntamenti.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAppuntamenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppuntamenti.ForeColor = System.Drawing.Color.White;
            this.lblAppuntamenti.Location = new System.Drawing.Point(250, 0);
            this.lblAppuntamenti.Name = "lblAppuntamenti";
            this.lblAppuntamenti.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblAppuntamenti.Size = new System.Drawing.Size(156, 30);
            this.lblAppuntamenti.TabIndex = 12;
            this.lblAppuntamenti.Text = "Appuntamenti";
            this.lblAppuntamenti.Click += new System.EventHandler(this.lblAppuntamenti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1359, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Studio Psicology";
            // 
            // lblMedici
            // 
            this.lblMedici.AutoSize = true;
            this.lblMedici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMedici.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMedici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedici.ForeColor = System.Drawing.Color.White;
            this.lblMedici.Location = new System.Drawing.Point(169, 0);
            this.lblMedici.Name = "lblMedici";
            this.lblMedici.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblMedici.Size = new System.Drawing.Size(81, 30);
            this.lblMedici.TabIndex = 11;
            this.lblMedici.Text = "Medici";
            this.lblMedici.Click += new System.EventHandler(this.lblMedici_Click);
            // 
            // lblPazienti
            // 
            this.lblPazienti.AutoSize = true;
            this.lblPazienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPazienti.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPazienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPazienti.ForeColor = System.Drawing.Color.White;
            this.lblPazienti.Location = new System.Drawing.Point(72, 0);
            this.lblPazienti.Name = "lblPazienti";
            this.lblPazienti.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPazienti.Size = new System.Drawing.Size(97, 30);
            this.lblPazienti.TabIndex = 8;
            this.lblPazienti.Text = "Pazienti";
            this.lblPazienti.Click += new System.EventHandler(this.lblPazienti_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(0, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblHome.Size = new System.Drawing.Size(72, 30);
            this.lblHome.TabIndex = 9;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // PanelHome
            // 
            this.PanelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.PanelHome.Controls.Add(this.label3);
            this.PanelHome.Controls.Add(this.pbOrario);
            this.PanelHome.Controls.Add(this.lblData);
            this.PanelHome.Controls.Add(this.lblOra);
            this.PanelHome.Controls.Add(this.label2);
            this.PanelHome.Location = new System.Drawing.Point(12, 59);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(945, 424);
            this.PanelHome.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 32);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(586, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "↑ Seleziona una delle sezioni per iniziare";
            // 
            // pbOrario
            // 
            this.pbOrario.Location = new System.Drawing.Point(300, 232);
            this.pbOrario.Maximum = 24;
            this.pbOrario.Name = "pbOrario";
            this.pbOrario.Size = new System.Drawing.Size(270, 10);
            this.pbOrario.Step = 1;
            this.pbOrario.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbOrario.TabIndex = 19;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(294, 194);
            this.lblData.Name = "lblData";
            this.lblData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblData.Size = new System.Drawing.Size(80, 33);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Data";
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOra.ForeColor = System.Drawing.Color.White;
            this.lblOra.Location = new System.Drawing.Point(294, 245);
            this.lblOra.Name = "lblOra";
            this.lblOra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOra.Size = new System.Drawing.Size(67, 33);
            this.lblOra.TabIndex = 17;
            this.lblOra.Text = "Ora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 129);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(290, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Studio di Psicologia";
            // 
            // Orologio
            // 
            this.Orologio.Enabled = true;
            this.Orologio.Tick += new System.EventHandler(this.Orologio_Tick);
            // 
            // PanelPaziente
            // 
            this.PanelPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.PanelPaziente.Controls.Add(this.groupBox6);
            this.PanelPaziente.Controls.Add(this.groupBox1);
            this.PanelPaziente.Controls.Add(this.label4);
            this.PanelPaziente.Location = new System.Drawing.Point(963, 59);
            this.PanelPaziente.Name = "PanelPaziente";
            this.PanelPaziente.Size = new System.Drawing.Size(642, 424);
            this.PanelPaziente.TabIndex = 21;
            this.PanelPaziente.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.lbxPazienti);
            this.groupBox6.Controls.Add(this.btnRimuoviPaziente);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(353, 67);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(286, 341);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gestione Pazienti";
            // 
            // lbxPazienti
            // 
            this.lbxPazienti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxPazienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.lbxPazienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPazienti.ForeColor = System.Drawing.Color.White;
            this.lbxPazienti.FormattingEnabled = true;
            this.lbxPazienti.ItemHeight = 24;
            this.lbxPazienti.Location = new System.Drawing.Point(6, 19);
            this.lbxPazienti.Name = "lbxPazienti";
            this.lbxPazienti.Size = new System.Drawing.Size(274, 244);
            this.lbxPazienti.TabIndex = 26;
            // 
            // btnRimuoviPaziente
            // 
            this.btnRimuoviPaziente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRimuoviPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnRimuoviPaziente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRimuoviPaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRimuoviPaziente.ForeColor = System.Drawing.Color.Transparent;
            this.btnRimuoviPaziente.Location = new System.Drawing.Point(6, 275);
            this.btnRimuoviPaziente.Name = "btnRimuoviPaziente";
            this.btnRimuoviPaziente.Size = new System.Drawing.Size(274, 43);
            this.btnRimuoviPaziente.TabIndex = 40;
            this.btnRimuoviPaziente.Text = "Rimuovi Paziente";
            this.btnRimuoviPaziente.UseVisualStyleBackColor = false;
            this.btnRimuoviPaziente.Click += new System.EventHandler(this.btnRimuoviPaziente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnAggiungiPaziente);
            this.groupBox1.Controls.Add(this.dtpPaziente);
            this.groupBox1.Controls.Add(this.txtIbanPaziente);
            this.groupBox1.Controls.Add(this.txtCognomePaziente);
            this.groupBox1.Controls.Add(this.txtNomePaziente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 341);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aggiungi Paziente";
            // 
            // btnAggiungiPaziente
            // 
            this.btnAggiungiPaziente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnAggiungiPaziente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAggiungiPaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiPaziente.ForeColor = System.Drawing.Color.Transparent;
            this.btnAggiungiPaziente.Location = new System.Drawing.Point(72, 275);
            this.btnAggiungiPaziente.Name = "btnAggiungiPaziente";
            this.btnAggiungiPaziente.Size = new System.Drawing.Size(185, 43);
            this.btnAggiungiPaziente.TabIndex = 30;
            this.btnAggiungiPaziente.Text = "Aggiungi";
            this.btnAggiungiPaziente.UseVisualStyleBackColor = false;
            this.btnAggiungiPaziente.Click += new System.EventHandler(this.btnAggiungiPaziente_Click);
            // 
            // dtpPaziente
            // 
            this.dtpPaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaziente.Location = new System.Drawing.Point(11, 171);
            this.dtpPaziente.Name = "dtpPaziente";
            this.dtpPaziente.Size = new System.Drawing.Size(307, 20);
            this.dtpPaziente.TabIndex = 29;
            // 
            // txtIbanPaziente
            // 
            this.txtIbanPaziente.Location = new System.Drawing.Point(11, 225);
            this.txtIbanPaziente.Name = "txtIbanPaziente";
            this.txtIbanPaziente.Size = new System.Drawing.Size(307, 20);
            this.txtIbanPaziente.TabIndex = 28;
            this.txtIbanPaziente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIbanPaziente_KeyPress);
            // 
            // txtCognomePaziente
            // 
            this.txtCognomePaziente.Location = new System.Drawing.Point(11, 115);
            this.txtCognomePaziente.Name = "txtCognomePaziente";
            this.txtCognomePaziente.Size = new System.Drawing.Size(307, 20);
            this.txtCognomePaziente.TabIndex = 26;
            this.txtCognomePaziente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCognomePaziente_KeyPress);
            // 
            // txtNomePaziente
            // 
            this.txtNomePaziente.Location = new System.Drawing.Point(11, 60);
            this.txtNomePaziente.Name = "txtNomePaziente";
            this.txtNomePaziente.Size = new System.Drawing.Size(307, 20);
            this.txtNomePaziente.TabIndex = 25;
            this.txtNomePaziente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomePaziente_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 197);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "IBAN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cognome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 142);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Data di Nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(136, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Paziente";
            // 
            // PanelMedico
            // 
            this.PanelMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.PanelMedico.Controls.Add(this.groupBox5);
            this.PanelMedico.Controls.Add(this.groupBox2);
            this.PanelMedico.Controls.Add(this.label13);
            this.PanelMedico.Location = new System.Drawing.Point(12, 489);
            this.PanelMedico.Name = "PanelMedico";
            this.PanelMedico.Size = new System.Drawing.Size(703, 424);
            this.PanelMedico.TabIndex = 22;
            this.PanelMedico.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.lbxMedici);
            this.groupBox5.Controls.Add(this.btnRimuoviMedico);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(353, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 341);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gestione Medici";
            // 
            // lbxMedici
            // 
            this.lbxMedici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxMedici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.lbxMedici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMedici.ForeColor = System.Drawing.Color.White;
            this.lbxMedici.FormattingEnabled = true;
            this.lbxMedici.ItemHeight = 24;
            this.lbxMedici.Location = new System.Drawing.Point(7, 19);
            this.lbxMedici.Name = "lbxMedici";
            this.lbxMedici.Size = new System.Drawing.Size(297, 244);
            this.lbxMedici.TabIndex = 26;
            // 
            // btnRimuoviMedico
            // 
            this.btnRimuoviMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRimuoviMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnRimuoviMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRimuoviMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRimuoviMedico.ForeColor = System.Drawing.Color.Transparent;
            this.btnRimuoviMedico.Location = new System.Drawing.Point(6, 275);
            this.btnRimuoviMedico.Name = "btnRimuoviMedico";
            this.btnRimuoviMedico.Size = new System.Drawing.Size(298, 43);
            this.btnRimuoviMedico.TabIndex = 40;
            this.btnRimuoviMedico.Text = "Rimuovi Medico";
            this.btnRimuoviMedico.UseVisualStyleBackColor = false;
            this.btnRimuoviMedico.Click += new System.EventHandler(this.btnRimuoviMedico_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtIDMedico);
            this.groupBox2.Controls.Add(this.nFineMedico);
            this.groupBox2.Controls.Add(this.nInizioMedico);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtSpecializzazioneMedico);
            this.groupBox2.Controls.Add(this.btnAggiungiMedico);
            this.groupBox2.Controls.Add(this.txtCognomeMedico);
            this.groupBox2.Controls.Add(this.txtNomeMedico);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 341);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggiungi Medico";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(227, 201);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label23.Size = new System.Drawing.Size(34, 25);
            this.label23.TabIndex = 35;
            this.label23.Text = "ID";
            // 
            // txtIDMedico
            // 
            this.txtIDMedico.Location = new System.Drawing.Point(227, 229);
            this.txtIDMedico.Name = "txtIDMedico";
            this.txtIDMedico.Size = new System.Drawing.Size(91, 20);
            this.txtIDMedico.TabIndex = 34;
            // 
            // nFineMedico
            // 
            this.nFineMedico.Location = new System.Drawing.Point(123, 228);
            this.nFineMedico.Name = "nFineMedico";
            this.nFineMedico.Size = new System.Drawing.Size(98, 20);
            this.nFineMedico.TabIndex = 32;
            // 
            // nInizioMedico
            // 
            this.nInizioMedico.Location = new System.Drawing.Point(11, 229);
            this.nInizioMedico.Name = "nInizioMedico";
            this.nInizioMedico.Size = new System.Drawing.Size(106, 20);
            this.nInizioMedico.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(118, 199);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(103, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "Ora Fine";
            // 
            // txtSpecializzazioneMedico
            // 
            this.txtSpecializzazioneMedico.Location = new System.Drawing.Point(11, 173);
            this.txtSpecializzazioneMedico.Name = "txtSpecializzazioneMedico";
            this.txtSpecializzazioneMedico.Size = new System.Drawing.Size(307, 20);
            this.txtSpecializzazioneMedico.TabIndex = 30;
            this.txtSpecializzazioneMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpecializzazioneMedico_KeyPress);
            // 
            // btnAggiungiMedico
            // 
            this.btnAggiungiMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnAggiungiMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAggiungiMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiMedico.ForeColor = System.Drawing.Color.Transparent;
            this.btnAggiungiMedico.Location = new System.Drawing.Point(72, 275);
            this.btnAggiungiMedico.Name = "btnAggiungiMedico";
            this.btnAggiungiMedico.Size = new System.Drawing.Size(185, 43);
            this.btnAggiungiMedico.TabIndex = 33;
            this.btnAggiungiMedico.Text = "Aggiungi";
            this.btnAggiungiMedico.UseVisualStyleBackColor = false;
            this.btnAggiungiMedico.Click += new System.EventHandler(this.btnAggiungiMedico_Click);
            // 
            // txtCognomeMedico
            // 
            this.txtCognomeMedico.Location = new System.Drawing.Point(11, 115);
            this.txtCognomeMedico.Name = "txtCognomeMedico";
            this.txtCognomeMedico.Size = new System.Drawing.Size(307, 20);
            this.txtCognomeMedico.TabIndex = 26;
            this.txtCognomeMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCognomeMedico_KeyPress);
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(11, 60);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(307, 20);
            this.txtNomeMedico.TabIndex = 25;
            this.txtNomeMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeMedico_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ora Inizio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cognome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 142);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(190, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Specializzazione";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(115, 33);
            this.label13.TabIndex = 20;
            this.label13.Text = "Medico";
            // 
            // PanelAppuntamento
            // 
            this.PanelAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.PanelAppuntamento.Controls.Add(this.groupBox4);
            this.PanelAppuntamento.Controls.Add(this.groupBox3);
            this.PanelAppuntamento.Controls.Add(this.label20);
            this.PanelAppuntamento.Location = new System.Drawing.Point(721, 489);
            this.PanelAppuntamento.Name = "PanelAppuntamento";
            this.PanelAppuntamento.Size = new System.Drawing.Size(884, 424);
            this.PanelAppuntamento.TabIndex = 23;
            this.PanelAppuntamento.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.lbxAppuntamenti);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(370, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 341);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gestione Appuntamenti";
            // 
            // lbxAppuntamenti
            // 
            this.lbxAppuntamenti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAppuntamenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.lbxAppuntamenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAppuntamenti.ForeColor = System.Drawing.Color.White;
            this.lbxAppuntamenti.FormattingEnabled = true;
            this.lbxAppuntamenti.ItemHeight = 24;
            this.lbxAppuntamenti.Location = new System.Drawing.Point(6, 19);
            this.lbxAppuntamenti.Name = "lbxAppuntamenti";
            this.lbxAppuntamenti.Size = new System.Drawing.Size(493, 244);
            this.lbxAppuntamenti.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(6, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(493, 43);
            this.button2.TabIndex = 40;
            this.button2.Text = "Rimuovi Appuntamento";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.cmbMedico);
            this.groupBox3.Controls.Add(this.cmbPaziente);
            this.groupBox3.Controls.Add(this.txtMotivazione);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.nudOrario);
            this.groupBox3.Controls.Add(this.dtpAppuntamento);
            this.groupBox3.Controls.Add(this.btnAggiungiAppuntamento);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 341);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aggiungi Appuntamento";
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(11, 115);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(307, 21);
            this.cmbMedico.TabIndex = 42;
            // 
            // cmbPaziente
            // 
            this.cmbPaziente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaziente.FormattingEnabled = true;
            this.cmbPaziente.Location = new System.Drawing.Point(11, 59);
            this.cmbPaziente.Name = "cmbPaziente";
            this.cmbPaziente.Size = new System.Drawing.Size(307, 21);
            this.cmbPaziente.TabIndex = 41;
            // 
            // txtMotivazione
            // 
            this.txtMotivazione.Location = new System.Drawing.Point(11, 228);
            this.txtMotivazione.Name = "txtMotivazione";
            this.txtMotivazione.Size = new System.Drawing.Size(307, 20);
            this.txtMotivazione.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 200);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(139, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "Motivazione";
            // 
            // nudOrario
            // 
            this.nudOrario.Location = new System.Drawing.Point(237, 173);
            this.nudOrario.Name = "nudOrario";
            this.nudOrario.Size = new System.Drawing.Size(81, 20);
            this.nudOrario.TabIndex = 35;
            // 
            // dtpAppuntamento
            // 
            this.dtpAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppuntamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppuntamento.Location = new System.Drawing.Point(11, 173);
            this.dtpAppuntamento.Name = "dtpAppuntamento";
            this.dtpAppuntamento.Size = new System.Drawing.Size(220, 20);
            this.dtpAppuntamento.TabIndex = 34;
            // 
            // btnAggiungiAppuntamento
            // 
            this.btnAggiungiAppuntamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnAggiungiAppuntamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAggiungiAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiAppuntamento.ForeColor = System.Drawing.Color.Transparent;
            this.btnAggiungiAppuntamento.Location = new System.Drawing.Point(72, 275);
            this.btnAggiungiAppuntamento.Name = "btnAggiungiAppuntamento";
            this.btnAggiungiAppuntamento.Size = new System.Drawing.Size(185, 43);
            this.btnAggiungiAppuntamento.TabIndex = 40;
            this.btnAggiungiAppuntamento.Text = "Aggiungi";
            this.btnAggiungiAppuntamento.UseVisualStyleBackColor = false;
            this.btnAggiungiAppuntamento.Click += new System.EventHandler(this.btnAggiungiAppuntamento_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 32);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(104, 25);
            this.label16.TabIndex = 21;
            this.label16.Text = "Paziente";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(6, 87);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(88, 25);
            this.label18.TabIndex = 22;
            this.label18.Text = "Medico";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(6, 142);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(126, 25);
            this.label19.TabIndex = 23;
            this.label19.Text = "Data e Ora";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Left;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(215, 33);
            this.label20.TabIndex = 20;
            this.label20.Text = "Appuntamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1614, 917);
            this.Controls.Add(this.PanelAppuntamento);
            this.Controls.Add(this.PanelMedico);
            this.Controls.Add(this.PanelPaziente);
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Psicology";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.PanelPaziente.ResumeLayout(false);
            this.PanelPaziente.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelMedico.ResumeLayout(false);
            this.PanelMedico.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFineMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInizioMedico)).EndInit();
            this.PanelAppuntamento.ResumeLayout(false);
            this.PanelAppuntamento.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrario)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtIDMedico;
        private System.Windows.Forms.Label label23;

        private System.Windows.Forms.ComboBox cmbPaziente;
        private System.Windows.Forms.ComboBox cmbMedico;

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRimuoviMedico;
        private System.Windows.Forms.Button btnRimuoviPaziente;
        private System.Windows.Forms.ListBox lbxPazientilb;

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox txtMotivazione;

        private System.Windows.Forms.Panel PanelAppuntamento;
        private System.Windows.Forms.ListBox lbxAppuntamenti;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudOrario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAggiungiAppuntamento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpAppuntamento;

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAppuntamenti;
        private System.Windows.Forms.Label lblMedici;
        private System.Windows.Forms.Label lblPazienti;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelHome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Orologio;
        private System.Windows.Forms.ProgressBar pbOrario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelPaziente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAggiungiPaziente;
        private System.Windows.Forms.DateTimePicker dtpPaziente;
        private System.Windows.Forms.TextBox txtIbanPaziente;
        private System.Windows.Forms.TextBox txtCognomePaziente;
        private System.Windows.Forms.TextBox txtNomePaziente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxPazienti;
        private System.Windows.Forms.Panel PanelMedico;
        private System.Windows.Forms.ListBox lbxMedici;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nFineMedico;
        private System.Windows.Forms.NumericUpDown nInizioMedico;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSpecializzazioneMedico;
        private System.Windows.Forms.Button btnAggiungiMedico;
        private System.Windows.Forms.TextBox txtCognomeMedico;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

