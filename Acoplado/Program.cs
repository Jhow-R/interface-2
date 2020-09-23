using System;

namespace Acoplado
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistraOcorrencias registraOcorrencias = new RegistraOcorrencias();

            registraOcorrencias.RegistrarNoConsole("Registro no console");
            registraOcorrencias.RegistrarNoArquivo(@"C:\teste.txt", "Registro no arquivo");
            
            Console.ReadLine();
        }
    }
}
