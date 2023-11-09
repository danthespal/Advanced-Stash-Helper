using NLog;

namespace Advanced_Stash_Helper
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
            Application.Run(new MainForm());
        }

        // keep track of the opened forms
        public static class FormManager
        {
            public static List<Form> OpenForms { get; } = new List<Form>();

            public static void AddForm(Form form) 
            {
                OpenForms.Add(form);
            }

            public static void RemoveForm(Form form) 
            {
                OpenForms.Remove(form);
            }
        }
    }
}