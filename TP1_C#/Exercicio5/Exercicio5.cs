namespace TP1_C_.Exercicio5
{
    internal class Exercicio5
    {
        static void Main(string[] args)
        {
            DownloadManager manager = new DownloadManager();

            manager.DownloadCompleted += Manager_DownloadCompleted;

            // Inicia o "download"
            manager.StartDownload(1000);
        }

        private static void Manager_DownloadCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Download concluído com sucesso!");
        }
    }
}
