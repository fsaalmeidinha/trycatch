using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilizandoOTryCatch
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public List<string> Gravar(bool utilizarTryCatch)
        {
            List<string> erros = null;
            if (utilizarTryCatch)
            {
                erros = ValidarUtilizandoTryCatch(this);
            }
            else
            {
                erros = ValidarNaoUtilizandoTryCatch(this);
            }

            if (erros.Count == 0)
            {
                //Gravar o usuário
            }

            return erros;
        }

        private static List<string> ValidarUtilizandoTryCatch(Usuario usuario)
        {
            List<string> erros = new List<string>();

            try
            {
                if (usuario.Nome.Length > 100)
                {
                    throw new Exception("");
                }
            }
            catch
            {
                erros.Add("O nome do usuário é nulo ou tem mais de 100 caracteres, informe um nome válido.");
            }

            return erros;
        }

        private static List<string> ValidarNaoUtilizandoTryCatch(Usuario usuario)
        {
            List<string> erros = new List<string>();

            if (usuario.Nome == null)
            {
                erros.Add("O nome do usuário deve ser informado.");
            }
            else if (usuario.Nome.Length > 100)
            {
                erros.Add("O nome do usuário tem mais de 100 caracteres, informe um nome válido.");
            }

            return erros;
        }
    }
}
