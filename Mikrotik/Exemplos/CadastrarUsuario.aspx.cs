using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mikrotik.Exemplos
{
    public partial class CadastrarUsuario : System.Web.UI.Page
    {
        /// <summary>
        /// Adiciona o usuário no Mikrotik
        /// </summary>
        protected void AdicionaUsuarioNoMikrotik(object sender, EventArgs e)
        {
            try
            {
                // Acesso a funções base
                var manager = new ApplicationUserManager();

                // Cria o usuário
                Resultado resultado = manager.CadastrarUsuario(Nome.Text, Senha.Text);
                if (resultado.Sucesso)
                    ErrorMessage.Text = "Usuário cadastrado com sucesso!";
                else
                    ErrorMessage.Text = resultado.Erros;
            }
            catch (Exception erro)
            {
                ErrorMessage.Text = erro.Message;
            }

        }
    }
}