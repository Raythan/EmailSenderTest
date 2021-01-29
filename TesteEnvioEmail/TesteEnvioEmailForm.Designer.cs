namespace TesteEnvioEmail
{
    partial class TesteEnvioEmailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Servidor = new System.Windows.Forms.TextBox();
            this.Porta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailEnvio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RequerAutenticacao = new System.Windows.Forms.CheckBox();
            this.RequerConexaoSSL = new System.Windows.Forms.CheckBox();
            this.EmailDestinatario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor/Host";
            // 
            // Servidor
            // 
            this.Servidor.Location = new System.Drawing.Point(114, 6);
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(411, 20);
            this.Servidor.TabIndex = 2;
            // 
            // Porta
            // 
            this.Porta.Location = new System.Drawing.Point(114, 32);
            this.Porta.Name = "Porta";
            this.Porta.Size = new System.Drawing.Size(411, 20);
            this.Porta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porta";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(114, 58);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(411, 20);
            this.Usuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuário";
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(114, 84);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(411, 20);
            this.Senha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            // 
            // EmailEnvio
            // 
            this.EmailEnvio.Location = new System.Drawing.Point(114, 110);
            this.EmailEnvio.Name = "EmailEnvio";
            this.EmailEnvio.Size = new System.Drawing.Size(411, 20);
            this.EmailEnvio.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email de Envio";
            // 
            // RequerAutenticacao
            // 
            this.RequerAutenticacao.AutoSize = true;
            this.RequerAutenticacao.Location = new System.Drawing.Point(114, 136);
            this.RequerAutenticacao.Name = "RequerAutenticacao";
            this.RequerAutenticacao.Size = new System.Drawing.Size(163, 17);
            this.RequerAutenticacao.TabIndex = 11;
            this.RequerAutenticacao.Text = "Servidor requer autenticação";
            this.RequerAutenticacao.UseVisualStyleBackColor = true;
            // 
            // RequerConexaoSSL
            // 
            this.RequerConexaoSSL.AutoSize = true;
            this.RequerConexaoSSL.Location = new System.Drawing.Point(114, 159);
            this.RequerConexaoSSL.Name = "RequerConexaoSSL";
            this.RequerConexaoSSL.Size = new System.Drawing.Size(165, 17);
            this.RequerConexaoSSL.TabIndex = 12;
            this.RequerConexaoSSL.Text = "Servidor requer conexão SSL";
            this.RequerConexaoSSL.UseVisualStyleBackColor = true;
            // 
            // EmailDestinatario
            // 
            this.EmailDestinatario.Location = new System.Drawing.Point(114, 191);
            this.EmailDestinatario.Name = "EmailDestinatario";
            this.EmailDestinatario.Size = new System.Drawing.Size(411, 20);
            this.EmailDestinatario.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Destinatário";
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
            // TesteEnvioEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 256);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.EmailDestinatario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RequerConexaoSSL);
            this.Controls.Add(this.RequerAutenticacao);
            this.Controls.Add(this.EmailEnvio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Porta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Servidor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TesteEnvioEmailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Envio de Emails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Servidor;
        private System.Windows.Forms.TextBox Porta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailEnvio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox RequerAutenticacao;
        private System.Windows.Forms.CheckBox RequerConexaoSSL;
        private System.Windows.Forms.TextBox EmailDestinatario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviar;
    }
}

