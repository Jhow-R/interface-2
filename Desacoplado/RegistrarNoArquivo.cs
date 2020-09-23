using System;
using System.IO;

namespace Desacoplado
{
    class RegistrarNoArquivo : IRegistro
    {
        private readonly string _caminhoArquivo;
        public RegistrarNoArquivo(string arquivo)
        {
            _caminhoArquivo = arquivo;
        }

        public void RegistraInfo(string mensagem)
        {
            using (var streamWriter = new StreamWriter(_caminhoArquivo, true))
            {
                streamWriter.WriteLine($"{mensagem} - {DateTime.Now} ");
            }
        }
    }
}
