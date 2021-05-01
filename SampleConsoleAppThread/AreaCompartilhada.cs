using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleAppThread
{
    class AreaCompartilhada
    {
        public static object lockOject = new object();
        public static int Valor { get; set; }
    }
}
