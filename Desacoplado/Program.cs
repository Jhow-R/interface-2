using System;

namespace Desacoplado
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistraOcorrencia registraOcorrencia = new RegistraOcorrencia(new RegistrarNoConsole());
            registraOcorrencia.Registrar("Registrar no console");

            registraOcorrencia = new RegistraOcorrencia(new RegistrarNoArquivo(@"C:\teste.txt"));
            registraOcorrencia.Registrar("Registrar no arquivo");

            Console.ReadLine();
        }
    }
}
