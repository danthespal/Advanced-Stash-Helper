namespace Advanced_Stash_Helper.Modules
{
    internal class FormManager
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
