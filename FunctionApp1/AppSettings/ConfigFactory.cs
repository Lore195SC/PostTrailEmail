namespace FunctionApp.AppSettings
{
    internal static class ConfigFactory
    {
        public static MailSettings GetTestSettings()
        {
            return new MailSettings
            {
                Email = "email",
                Password = "Pw"
            };
        }
    }
}
