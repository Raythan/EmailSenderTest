namespace TesteEnvioEmail
{
    partial class formTesteEnvioEmail
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
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmailEnvio = new System.Windows.Forms.TextBox();
            this.lblEmailEnvio = new System.Windows.Forms.Label();
            this.chkRequerAutenticacao = new System.Windows.Forms.CheckBox();
            this.chkRequerConexaoSSL = new System.Windows.Forms.CheckBox();
            this.txtEmailDestinatario = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(12, 9);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(73, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor/Host";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(114, 6);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(411, 20);
            this.txtServidor.TabIndex = 2;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(114, 32);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(411, 20);
            this.txtPorta.TabIndex = 4;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(12, 35);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(32, 13);
            this.lblPorta.TabIndex = 3;
            this.lblPorta.Text = "Porta";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(114, 58);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(411, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 61);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(114, 84);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(411, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 87);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha";
            // 
            // txtEmailEnvio
            // 
            this.txtEmailEnvio.Location = new System.Drawing.Point(114, 110);
            this.txtEmailEnvio.Name = "txtEmailEnvio";
            this.txtEmailEnvio.Size = new System.Drawing.Size(411, 20);
            this.txtEmailEnvio.TabIndex = 10;
            // 
            // lblEmailEnvio
            // 
            this.lblEmailEnvio.AutoSize = true;
            this.lblEmailEnvio.Location = new System.Drawing.Point(12, 113);
            this.lblEmailEnvio.Name = "lblEmailEnvio";
            this.lblEmailEnvio.Size = new System.Drawing.Size(77, 13);
            this.lblEmailEnvio.TabIndex = 9;
            this.lblEmailEnvio.Text = "Email de Envio";
            // 
            // chkRequerAutenticacao
            // 
            this.chkRequerAutenticacao.AutoSize = true;
            this.chkRequerAutenticacao.Location = new System.Drawing.Point(114, 136);
            this.chkRequerAutenticacao.Name = "chkRequerAutenticacao";
            this.chkRequerAutenticacao.Size = new System.Drawing.Size(163, 17);
            this.chkRequerAutenticacao.TabIndex = 11;
            this.chkRequerAutenticacao.Text = "Servidor requer autenticação";
            this.chkRequerAutenticacao.UseVisualStyleBackColor = true;
            // 
            // chkRequerConexaoSSL
            // 
            this.chkRequerConexaoSSL.AutoSize = true;
            this.chkRequerConexaoSSL.Location = new System.Drawing.Point(114, 159);
            this.chkRequerConexaoSSL.Name = "chkRequerConexaoSSL";
            this.chkRequerConexaoSSL.Size = new System.Drawing.Size(165, 17);
            this.chkRequerConexaoSSL.TabIndex = 12;
            this.chkRequerConexaoSSL.Text = "Servidor requer conexão SSL";
            this.chkRequerConexaoSSL.UseVisualStyleBackColor = true;
            // 
            // txtEmailDestinatario
            // 
            this.txtEmailDestinatario.Location = new System.Drawing.Point(114, 191);
            this.txtEmailDestinatario.Name = "txtEmailDestinatario";
            this.txtEmailDestinatario.Size = new System.Drawing.Size(411, 20);
            this.txtEmailDestinatario.TabIndex = 14;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(12, 194);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(63, 13);
            this.lblDestinatario.TabIndex = 13;
            this.lblDestinatario.Text = "Destinatário";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(450, 226);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Location = new System.Drawing.Point(369, 226);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(75, 23);
            this.btnConfiguracao.TabIndex = 16;
            this.btnConfiguracao.Text = "Salvar";
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // formTesteEnvioEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 256);
            this.Controls.Add(this.btnConfiguracao);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEmailDestinatario);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.chkRequerConexaoSSL);
            this.Controls.Add(this.chkRequerAutenticacao);
            this.Controls.Add(this.txtEmailEnvio);
            this.Controls.Add(this.lblEmailEnvio);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "formTesteEnvioEmail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Envio de Emails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmailEnvio;
        private System.Windows.Forms.Label lblEmailEnvio;
        private System.Windows.Forms.CheckBox chkRequerAutenticacao;
        private System.Windows.Forms.CheckBox chkRequerConexaoSSL;
        private System.Windows.Forms.TextBox txtEmailDestinatario;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnConfiguracao;
    }
}

