using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao1
{
    public class ServicoEmail
    {
        public void EnviarEmail() 
        {
            Conectar();
            Autenticar();
            Console.WriteLine("Enviando o e-mail");
            Desconectar();
        }

        private void Desconectar()
        {
            throw new NotImplementedException();
        }

        private void Autenticar()
        {
            throw new NotImplementedException();
        }

        private void Conectar()
        {
            throw new NotImplementedException();
        }
    }
}
