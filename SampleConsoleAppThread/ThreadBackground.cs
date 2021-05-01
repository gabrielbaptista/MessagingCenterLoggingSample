using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SampleConsoleAppThread
{
    class ThreadBackground
    {
        private  Thread thread;
        private bool ativa;

        public void Inicializa()
        {
            ativa = true;
            thread = new Thread(new ThreadStart(Execucao));
            thread.IsBackground = true;
            thread.Start();
        }

        private void Execucao()
        {
            int valor = 0;
            while (ativa)
            {
                valor = valor + 1;
                if (valor > 10)
                {
                    valor = 0;
                }
            }
        }

        public void AguardaEncerrar()
        {
            ativa = false;
            thread.Join();
        }
    }
}
