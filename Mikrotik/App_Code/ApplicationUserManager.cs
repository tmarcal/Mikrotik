using System;
using System.Configuration;

namespace Mikrotik
{
    /// <summary>
    /// Essa é uma classe customizada para executar as funções no Mikrotik
    /// </summary>
    public class ApplicationUserManager
    {
        /// <summary>
        /// Esse é o Miktorik
        /// </summary>
        MK mikrotik = new MK(ConfigurationManager.AppSettings["Mikrotik.Ip"]);
        
        /// <summary>
        /// Verifica se está logado para executar os comandos
        /// </summary>
        public bool Logado
        {
            get
            {
                if (!mikrotik.Login(ConfigurationManager.AppSettings["Mikrotik.Usuario"], ConfigurationManager.AppSettings["Mikrotik.Senha"]))
                {
                    mikrotik.Close();
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Cadastra um usuário no hotspot
        /// </summary>
        /// <param name="nome">Nome do usuário</param>
        /// <param name="senha">Senha de acesso</param>
        public Resultado CadastrarUsuario(string nome, string senha)
        {
            // Qualquer operação só pode ser realizada se estiver logado no Mikrotik
            try
            {
                if (Logado)
                {

                    // Envia os comandos ao Mikrotik
                    mikrotik.Send("/ip/hotspot/user/add");
                    mikrotik.Send(string.Format("=name={0}", nome));
                    mikrotik.Send(string.Format("=password={0}", senha), true);

                    // Faz a leitura do retorno e retorna
                    Resultado retorno = new Resultado(true);
                    retorno.LeRetorno(mikrotik.Read());
                    return retorno;

                }
                else
                    return new Resultado(false) { Erros = "Usuário não autenticado!" };
            }
            catch (Exception erro)
            {
                return new Resultado(false) { Erros = erro.Message };
            }
        }
    }
}