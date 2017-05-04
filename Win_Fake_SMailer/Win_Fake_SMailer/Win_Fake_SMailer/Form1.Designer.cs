namespace Win_Fake_SMailer
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
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.testomessaggio1 = new System.Windows.Forms.RichTextBox();
            this.mittente1 = new System.Windows.Forms.TextBox();
            this.destinatario1 = new System.Windows.Forms.TextBox();
            this.oggetto1 = new System.Windows.Forms.TextBox();
            this.impostaServer = new System.Windows.Forms.Button();
            this.serverPop1 = new System.Windows.Forms.TextBox();
            this.serverSmtp1 = new System.Windows.Forms.TextBox();
            this.resettaTutto1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.chiudiTutto = new System.Windows.Forms.Button();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.EventoMessaggio = new System.Windows.Forms.Label();
            this.ExtraPanel = new System.Windows.Forms.Panel();
            this.nullAction = new System.Windows.Forms.RadioButton();
            this.consoleMsdos = new System.Windows.Forms.RadioButton();
            this.visualizzaComando = new System.Windows.Forms.RadioButton();
            this.Info = new System.Windows.Forms.Button();
            this.ListaServerPop = new System.Windows.Forms.ComboBox();
            this.ListaServerSmtp = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listFile = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExtraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(346, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(479, 55);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "WIN FAKE SMAILER";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1028, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 135);
            this.button1.TabIndex = 1;
            this.button1.Text = "&INVIO FAKE MAIL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MITTENTE---->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESTINATARIO---->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "OGGETTO---->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SERVER SMTP ---->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SERVER POP---->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DESCRIZIONE DEL MESSAGGIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "IMMETTI QUI IL MESSAGGIO DA INVIARE---->";
            // 
            // testomessaggio1
            // 
            this.testomessaggio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testomessaggio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testomessaggio1.Location = new System.Drawing.Point(266, 310);
            this.testomessaggio1.Name = "testomessaggio1";
            this.testomessaggio1.Size = new System.Drawing.Size(674, 248);
            this.testomessaggio1.TabIndex = 9;
            this.testomessaggio1.Text = ".... inserisci il testo qui ....";
            this.testomessaggio1.Click += new System.EventHandler(this.testomessaggio1_Click);
            // 
            // mittente1
            // 
            this.mittente1.Location = new System.Drawing.Point(356, 86);
            this.mittente1.Name = "mittente1";
            this.mittente1.Size = new System.Drawing.Size(368, 20);
            this.mittente1.TabIndex = 10;
            // 
            // destinatario1
            // 
            this.destinatario1.Location = new System.Drawing.Point(356, 130);
            this.destinatario1.Name = "destinatario1";
            this.destinatario1.Size = new System.Drawing.Size(368, 20);
            this.destinatario1.TabIndex = 11;
            // 
            // oggetto1
            // 
            this.oggetto1.Location = new System.Drawing.Point(356, 193);
            this.oggetto1.Name = "oggetto1";
            this.oggetto1.Size = new System.Drawing.Size(368, 20);
            this.oggetto1.TabIndex = 12;
            // 
            // impostaServer
            // 
            this.impostaServer.Location = new System.Drawing.Point(829, 227);
            this.impostaServer.Name = "impostaServer";
            this.impostaServer.Size = new System.Drawing.Size(193, 55);
            this.impostaServer.TabIndex = 13;
            this.impostaServer.Text = "Imposta &Server";
            this.impostaServer.UseVisualStyleBackColor = true;
            this.impostaServer.Click += new System.EventHandler(this.impostaServer_Click);
            // 
            // serverPop1
            // 
            this.serverPop1.Location = new System.Drawing.Point(374, 229);
            this.serverPop1.Name = "serverPop1";
            this.serverPop1.Size = new System.Drawing.Size(223, 20);
            this.serverPop1.TabIndex = 14;
            // 
            // serverSmtp1
            // 
            this.serverSmtp1.Location = new System.Drawing.Point(374, 262);
            this.serverSmtp1.Name = "serverSmtp1";
            this.serverSmtp1.Size = new System.Drawing.Size(223, 20);
            this.serverSmtp1.TabIndex = 15;
            // 
            // resettaTutto1
            // 
            this.resettaTutto1.Location = new System.Drawing.Point(1028, 227);
            this.resettaTutto1.Name = "resettaTutto1";
            this.resettaTutto1.Size = new System.Drawing.Size(118, 55);
            this.resettaTutto1.TabIndex = 16;
            this.resettaTutto1.Text = "&Resetta Tutto";
            this.resettaTutto1.UseVisualStyleBackColor = true;
            this.resettaTutto1.Click += new System.EventHandler(this.resettaTutto1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(356, 156);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(368, 31);
            this.progressBar1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "BROWSER PER GLI ALLEGATI";
            // 
            // chiudiTutto
            // 
            this.chiudiTutto.Location = new System.Drawing.Point(12, 530);
            this.chiudiTutto.Name = "chiudiTutto";
            this.chiudiTutto.Size = new System.Drawing.Size(176, 28);
            this.chiudiTutto.TabIndex = 20;
            this.chiudiTutto.Text = "CHIUDI TUTTO";
            this.chiudiTutto.UseVisualStyleBackColor = true;
            this.chiudiTutto.Click += new System.EventHandler(this.chiudiTutto_Click);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolsPanel.Location = new System.Drawing.Point(738, 86);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(283, 135);
            this.ToolsPanel.TabIndex = 21;
            // 
            // EventoMessaggio
            // 
            this.EventoMessaggio.AutoSize = true;
            this.EventoMessaggio.Font = new System.Drawing.Font("NEW ACADEMY", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventoMessaggio.ForeColor = System.Drawing.Color.Black;
            this.EventoMessaggio.Location = new System.Drawing.Point(12, 165);
            this.EventoMessaggio.Name = "EventoMessaggio";
            this.EventoMessaggio.Size = new System.Drawing.Size(219, 28);
            this.EventoMessaggio.TabIndex = 22;
            this.EventoMessaggio.Text = ".......................";
            // 
            // ExtraPanel
            // 
            this.ExtraPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExtraPanel.Controls.Add(this.nullAction);
            this.ExtraPanel.Controls.Add(this.consoleMsdos);
            this.ExtraPanel.Controls.Add(this.visualizzaComando);
            this.ExtraPanel.Location = new System.Drawing.Point(12, 196);
            this.ExtraPanel.Name = "ExtraPanel";
            this.ExtraPanel.Size = new System.Drawing.Size(247, 98);
            this.ExtraPanel.TabIndex = 23;
            // 
            // nullAction
            // 
            this.nullAction.AutoSize = true;
            this.nullAction.Checked = true;
            this.nullAction.Location = new System.Drawing.Point(16, 61);
            this.nullAction.Name = "nullAction";
            this.nullAction.Size = new System.Drawing.Size(99, 17);
            this.nullAction.TabIndex = 2;
            this.nullAction.TabStop = true;
            this.nullAction.Text = "NO FUNCTION";
            this.nullAction.UseVisualStyleBackColor = true;
            // 
            // consoleMsdos
            // 
            this.consoleMsdos.AutoSize = true;
            this.consoleMsdos.Location = new System.Drawing.Point(16, 38);
            this.consoleMsdos.Name = "consoleMsdos";
            this.consoleMsdos.Size = new System.Drawing.Size(126, 17);
            this.consoleMsdos.TabIndex = 1;
            this.consoleMsdos.Text = "Apri Console MSDOS";
            this.consoleMsdos.UseVisualStyleBackColor = true;
            this.consoleMsdos.CheckedChanged += new System.EventHandler(this.consoleMsdos_CheckedChanged);
            // 
            // visualizzaComando
            // 
            this.visualizzaComando.AutoSize = true;
            this.visualizzaComando.Location = new System.Drawing.Point(16, 15);
            this.visualizzaComando.Name = "visualizzaComando";
            this.visualizzaComando.Size = new System.Drawing.Size(155, 17);
            this.visualizzaComando.TabIndex = 0;
            this.visualizzaComando.Text = "Visualizza Stringa Comando";
            this.visualizzaComando.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(194, 530);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(65, 28);
            this.Info.TabIndex = 24;
            this.Info.Text = "INFO APP";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // ListaServerPop
            // 
            this.ListaServerPop.FormattingEnabled = true;
            this.ListaServerPop.Items.AddRange(new object[] {
            "Nessun Server",
            "pop.tiscali.it",
            "in.alice.it",
            "box.tin.it",
            "pop3.aruba.it",
            "popmail.blu.it",
            "pop3.ciaoweb.it",
            "popmail.email.it",
            "pop.fastwebnet.it",
            "pop.gmail.com",
            "popmail.inwind.it",
            "popmail.iol.it",
            "pop.jumpy.it",
            "pop.katamail.com",
            "popmail.libero.it",
            "pop.lycos.it",
            "pop1.mail.com",
            "mail.mclink.it",
            "popnew.ngi.it",
            "mail.nopay.it",
            "relay.poste.it",
            "pop3.postino.it",
            "mail.supereva.it",
            "pop.tele2.it",
            "pop.tiscali.it",
            "pop.tin.it",
            "in.virgilio.it",
            "pop.mail.yahoo.it",
            "pop.mail.yahoo.com",
            "in.pop.mail.yahoo.com"});
            this.ListaServerPop.Location = new System.Drawing.Point(603, 228);
            this.ListaServerPop.Name = "ListaServerPop";
            this.ListaServerPop.Size = new System.Drawing.Size(220, 21);
            this.ListaServerPop.TabIndex = 25;
            this.ListaServerPop.Text = "Seleziona un server POP";
            // 
            // ListaServerSmtp
            // 
            this.ListaServerSmtp.FormattingEnabled = true;
            this.ListaServerSmtp.Items.AddRange(new object[] {
            "Nessun Server",
            "out.alice.it",
            "mail.tin.it",
            "smtp.aruba.it",
            "smtp.tuosito.xy",
            "mail.blu.it",
            "mail.ciaoweb.it",
            "smtp.email.it",
            "smtp.fastwebnet.it",
            "smtp.gmail.com",
            "mail.inwind.it",
            "mail.iol.it",
            "mail.jumpy.it",
            "smtp.katamail.com",
            "mail.libero.it ",
            "smtp.lycos.it",
            "smtp1.mail.com",
            "mail.mclink.it",
            "smtp.ngi.it",
            "mail.nopay.it",
            "relay.poste.it",
            "smtp.postino.it",
            "mail.supereva.it",
            "smtp.tele2.itsmtp.tiscali.itsmtp.tin.it",
            "out.virgilio.it",
            "smtp.mail.yahoo.com",
            "smtp.mail.yahoo.com",
            "in.smtp.mail.yahoo.com "});
            this.ListaServerSmtp.Location = new System.Drawing.Point(603, 261);
            this.ListaServerSmtp.Name = "ListaServerSmtp";
            this.ListaServerSmtp.Size = new System.Drawing.Size(220, 21);
            this.ListaServerSmtp.TabIndex = 26;
            this.ListaServerSmtp.Text = "Seleziona un server SMTP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win_Fake_SMailer.Properties.Resources.fake_mail;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::Win_Fake_SMailer.Properties.Resources.fake_mail;
            this.pictureBox1.Location = new System.Drawing.Point(54, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "c:\\";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "\\";
            // 
            // listFile
            // 
            this.listFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listFile.Location = new System.Drawing.Point(12, 361);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(247, 163);
            this.listFile.TabIndex = 28;
            this.listFile.UseCompatibleStateImageBehavior = false;
            this.listFile.View = System.Windows.Forms.View.Details;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(946, 310);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 248);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1158, 570);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListaServerSmtp);
            this.Controls.Add(this.ListaServerPop);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ExtraPanel);
            this.Controls.Add(this.EventoMessaggio);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.chiudiTutto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.resettaTutto1);
            this.Controls.Add(this.serverSmtp1);
            this.Controls.Add(this.serverPop1);
            this.Controls.Add(this.impostaServer);
            this.Controls.Add(this.oggetto1);
            this.Controls.Add(this.destinatario1);
            this.Controls.Add(this.mittente1);
            this.Controls.Add(this.testomessaggio1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win_Fake_SMailer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ExtraPanel.ResumeLayout(false);
            this.ExtraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox testomessaggio1;
        private System.Windows.Forms.TextBox mittente1;
        private System.Windows.Forms.TextBox destinatario1;
        private System.Windows.Forms.TextBox oggetto1;
        private System.Windows.Forms.Button impostaServer;
        private System.Windows.Forms.TextBox serverPop1;
        private System.Windows.Forms.TextBox serverSmtp1;
        private System.Windows.Forms.Button resettaTutto1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button chiudiTutto;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Label EventoMessaggio;
        private System.Windows.Forms.Panel ExtraPanel;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.ComboBox ListaServerPop;
        private System.Windows.Forms.ComboBox ListaServerSmtp;
        private System.Windows.Forms.RadioButton consoleMsdos;
        private System.Windows.Forms.RadioButton visualizzaComando;
        private System.Windows.Forms.RadioButton nullAction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListView listFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

