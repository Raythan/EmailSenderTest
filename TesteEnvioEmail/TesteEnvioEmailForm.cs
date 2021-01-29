using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace TesteEnvioEmail
{
    public partial class TesteEnvioEmailForm : Form
    {
        public TesteEnvioEmailForm() => InitializeComponent();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviaEmail();
        }

        private void EnviaEmail()
        {
            MailMessage mail = new MailMessage();
            
            mail.From = new MailAddress(EmailEnvio.Text, EmailEnvio.Text);
            mail.To.Add(EmailDestinatario.Text);

            SmtpClient client = new SmtpClient();
            client.EnableSsl = RequerConexaoSSL.Checked;
            client.Port = string.IsNullOrEmpty(Porta.Text) ? 25 : Convert.ToInt16(Porta.Text);
            client.Host = Servidor.Text;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            if (RequerAutenticacao.Checked)
            {
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential(Usuario.Text, Senha.Text);
            }

            if (RequerConexaoSSL.Checked)
                client.EnableSsl = true;

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

    }
}
