using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics;

namespace TesteEnvioEmail
{
    public partial class formTesteEnvioEmail : Form
    {
        private static readonly string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            fileConfig = "f0fa8b1b85c3d69145a410aad5ef6594e27b9fc8.txt", // jsonConfig (sha1)
            fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        private string combinedConfigPath = $"{assemblyPath}\\{fileConfig}";
        private Configuracao configuracao;

        public formTesteEnvioEmail()
        {
            InitializeComponent();
            Text = $"Teste de Envio de Emails v{fileVersion}";
            CarregarArquivoConfiguracao();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviaEmail();
        }

        private void EnviaEmail()
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(txtEmailEnvio.Text, txtEmailEnvio.Text);
            mail.To.Add(txtEmailDestinatario.Text);

            SmtpClient client = new SmtpClient();
            client.EnableSsl = chkRequerConexaoSSL.Checked;
            client.Port = string.IsNullOrEmpty(txtPorta.Text) ? 25 : Convert.ToInt16(txtPorta.Text);
            client.Host = txtServidor.Text;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            if (chkRequerAutenticacao.Checked)
            {
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential(txtUsuario.Text, txtSenha.Text);
            }

            client.EnableSsl = chkRequerConexaoSSL.Checked;
            mail.IsBodyHtml = true;
            mail.Body = "Teste de Envio de Email";
            mail.Subject = "Teste de Envio de Email";

            try
            {
                client.Send(mail);
                MessageBox.Show("Solicitação de envio concluida.\nVerifique seu e-mail para confirmação", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                string errorOut = e.Message;

                if (e.InnerException != null)
                    errorOut += $"\n{e.InnerException.Message}";

                MessageBox.Show(errorOut, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnConfiguracao_Click(object sender, EventArgs e) => SalvarConfiguracao(true);

        private void SalvarConfiguracao(bool fromButton = false)
        {
            configuracao = new Configuracao(txtServidor.Text, txtPorta.Text, txtUsuario.Text, txtSenha.Text, txtEmailEnvio.Text,
                txtEmailDestinatario.Text, chkRequerAutenticacao.Checked, chkRequerConexaoSSL.Checked);
            if (File.Exists(combinedConfigPath))
            {
                using (var sw = new StreamWriter(combinedConfigPath))
                    sw.Write(Base64Encode(JsonConvert.SerializeObject(configuracao)));

                if (fromButton)
                    MessageBox.Show("Configuração salva com sucesso.", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                File.Create(combinedConfigPath).Dispose();
                SalvarConfiguracao();
            }
        }

        private void CarregarArquivoConfiguracao()
        {
            if (File.Exists(combinedConfigPath))
            {
                using (var sr = new StreamReader(combinedConfigPath))
                    configuracao = JsonConvert.DeserializeObject<Configuracao>(Base64Decode(sr.ReadToEnd()));
                CarregarConfiguracao();
            }
            else
                SalvarConfiguracao();
        }

        private void CarregarConfiguracao()
        {
            txtServidor.Text = configuracao.Servidor;
            txtPorta.Text = configuracao.Porta;
            txtUsuario.Text = configuracao.Usuario;
            txtSenha.Text = configuracao.Senha;
            txtEmailEnvio.Text = configuracao.EmailEnvio;
            txtEmailDestinatario.Text = configuracao.EmailDestinatario;
            chkRequerAutenticacao.Checked = configuracao.Autenticacao;
            chkRequerConexaoSSL.Checked = configuracao.ConexaoSSL;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
