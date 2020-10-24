using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MessagingCenterSample.Models;

namespace MessagingCenterSample.Droid.Threads
{
    internal class ThreadLogger 
    {
        private static ThreadLogger instance;
        private readonly Thread thread;
        private readonly bool threadEmExecucao;
        private readonly ConcurrentQueue<LogMessage> mensagensLog = new ConcurrentQueue<LogMessage>();
        private ThreadLogger()
        {
            thread = new Thread(ExecutaThreadLogger);
            thread.IsBackground = true;
            threadEmExecucao = true;
            thread.Start();
        }

        private void ExecutaThreadLogger()
        {
            while (threadEmExecucao)
            {
                if (mensagensLog.Count > 0)
                {
                    if (mensagensLog.TryDequeue(out LogMessage log))
                    {
                        Console.WriteLine($"Log: {log.Mensagem} | Data: {log.Data}");
                        Thread.Sleep(5000);
                    }
                }
                Thread.Sleep(1);
            }
        }

        public static ThreadLogger Instance()
        {
            if (instance == null)
                instance = new ThreadLogger();
            return instance;
        }

        internal void GeraLog(LogMessage obj)
        {
            mensagensLog.Enqueue(obj);
        }
    }
}