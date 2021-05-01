using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SampleConsoleAppThread
{
    class ThreadSoma
    {
        private  Thread thread ;

        public void Inicializa()
        {
            thread = new Thread(new ThreadStart(Execucao));
            thread.Start();
        }

        private void Execucao()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (AreaCompartilhada.lockOject)
                {
                    AreaCompartilhada.Valor = AreaCompartilhada.Valor + 1;
                }
                Thread.Sleep(1);
            }
        }

        public void AguardaEncerrar()
        {
            thread.Join();
        }
    }
}
