namespace odevtakipuygulaması
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            edit12 form = new edit12();
            var cevap = form.ShowDialog();//bloklanýyor ve cevap bekleniyor

            if (cevap == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}