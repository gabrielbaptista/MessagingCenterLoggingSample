using MessagingCenterSample.Models;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MessagingCenterSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(ComandoExecucao);
        }

        private void ComandoExecucao(object obj)
        {
            var mensagem = new LogMessage() { Data = DateTime.Now, Mensagem = "Botão de Open Web Acionado" };
            MessagingCenter.Send<LogMessage>(mensagem, "LOG_ALERTA");
        }

        public ICommand OpenWebCommand { get; }
    }
}