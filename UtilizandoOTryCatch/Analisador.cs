using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace UtilizandoOTryCatch
{
    public class Analisador
    {
        private static Stopwatch stopwatch = new Stopwatch();

        public static void AnalisarGravarUsuario(int qtdRepeticoes)
        {
            Usuario usuarioComErrosDeCadastro = new Usuario()
            {
                Nome = null,
                Idade = 21
            };

            bool utilizarTryCatchNaValidacao = true;
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < qtdRepeticoes; i++)
            {
                usuarioComErrosDeCadastro.Gravar(utilizarTryCatchNaValidacao);
            }
            stopwatch.Start();
            TimeSpan tempoValidacaoComTryCatch = stopwatch.Elapsed;

            stopwatch.Reset();
            utilizarTryCatchNaValidacao = false;
            stopwatch.Start();
            for (int i = 0; i < qtdRepeticoes; i++)
            {
                usuarioComErrosDeCadastro.Gravar(utilizarTryCatchNaValidacao);
            }
            stopwatch.Stop();
            TimeSpan tempoValidacaoSemTryCatch = stopwatch.Elapsed;

            Console.WriteLine(String.Format("Tempo de validação UTILIZANDO o try catch, repetindo o processo {0} vezes: {1}",
                qtdRepeticoes, tempoValidacaoComTryCatch));
            Console.WriteLine(String.Format("Tempo de validação NÃO UTILIZANDO o try catch, repetindo o processo {0} vezes: {1}",
                qtdRepeticoes, tempoValidacaoSemTryCatch));
            Console.WriteLine(String.Format("Utilizando o try catch, a validação se tornou {0} vezes mais lenta em {1} repetições.",
                tempoValidacaoComTryCatch.Ticks / tempoValidacaoSemTryCatch.Ticks, qtdRepeticoes));
        }
    }
}
