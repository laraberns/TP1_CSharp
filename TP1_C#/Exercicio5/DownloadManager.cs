using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C_.Exercicio5
{
    internal class DownloadManager
    {
        public event EventHandler DownloadCompleted;

        public void StartDownload(int timeComplete)
        {
            Console.WriteLine("Iniciando o download...");
            Thread.Sleep(timeComplete);
            OnDownloadComplete(EventArgs.Empty);

        }
        protected virtual void OnDownloadComplete(EventArgs e)
        {
            DownloadCompleted?.Invoke(this, e);
        }
    }
}
