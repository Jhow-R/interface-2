using System;
using System.IO;

namespace Acoplado
{
    class RegistraOcorrencias
    {
        public void RegistrarNoConsole(string mensagem)
        {
            Console.WriteLine($"{mensagem} - {DateTime.Now} ");
        }

        public void RegistrarNoArquivo(string arquivo, string mensagem)
        {
            using(var streamWriter = new StreamWriter(arquivo, true))
            {
                streamWriter.WriteLine($"{mensagem} - {DateTime.Now} ");
            }
        }

        public void RegistrarNoJson(string arquivo, string mensagem)
        {
            // Code here
        }
    }
}
