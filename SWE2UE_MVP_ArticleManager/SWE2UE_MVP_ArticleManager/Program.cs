namespace SWE2UE_MVP_ArticleManager
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

            MainPresenter presenter = new MainPresenter();

            //presenter.Show()
            presenter.Start();
            //presenter.Run()


            //Application.Run(new MainView());
        }
    }
}