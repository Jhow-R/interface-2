using System;

namespace Desacoplado
{
    class RegistraOcorrencia
    {
        private readonly IRegistro _registro;
        
        public RegistraOcorrencia(IRegistro  registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo(mensagem);
        }
    }
}
