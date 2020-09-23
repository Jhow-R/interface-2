using System;

namespace Desacoplado
{
    class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"{mensagem} - {DateTime.Now} ");
        }
    }
}
