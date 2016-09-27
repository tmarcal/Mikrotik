using System.Collections.Generic;

namespace Mikrotik
{
    /// <summary>
    /// Resultado de uma operação
    /// </summary>
    public class Resultado
    {
        /// <summary>
        /// Indica se há sucesso na operação
        /// </summary>
        public bool Sucesso { get; set; }

        /// <summary>
        /// Armazena os erros encontrados
        /// </summary>
        public string Erros { get; set; }

        /// <summary>
        /// Inicializa o objeto
        /// </summary>
        public Resultado(bool sucesso)
        {
            Sucesso = sucesso;
        }

        /// <summary>
        /// Lê a lista de retornos que são enviadas e faz o devido tratamento
        /// </summary>
        public void LeRetorno(List<string> retornos)
        {
            // Por padrão, não existe erros
            Sucesso = true;

            // Para cada retorno, faz a análise
            foreach (var item in retornos)
            {
                if (item.Substring(0, 5) == "!done")
                    break;
                Sucesso = false;
                if (item.Contains("message=failure"))
                    Erros = item.Replace("message=failure:", "").Trim();
                else
                    Erros = item.Trim();
            }
        }

    }
}