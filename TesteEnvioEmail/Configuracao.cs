using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteEnvioEmail
{
    public class Configuracao
    {
        public string Servidor { get; set; }
        public string Porta { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string EmailEnvio { get; set; }
        public string EmailDestinatario { get; set; }
        public bool Autenticacao { get; set; }
        public bool ConexaoSSL { get; set; }
        public Configuracao() { }
        public Configuracao(string servidor = null, string porta = null, string usuario = null, 
            string senha = null, string emailEnvio = null, string emailDestinatario = null, bool? autenticacao = null, 
            bool? conexaoSSL = null) 
        {
            Servidor = servidor;
            Porta = porta;
            Usuario = usuario;
            Senha = senha;
            EmailEnvio = emailEnvio;
            EmailDestinatario = emailDestinatario;
            Autenticacao = autenticacao ?? Autenticacao;
            ConexaoSSL = conexaoSSL ?? ConexaoSSL;
        }
    }
}
