namespace Midleware.Infra.Database
{
    public class Configuration
    {
        private string CatalogContext { get; set; }

        public Configuration()
        {
            CatalogContext = "";  // ConfigurationManager.ConnectionStrings["CatalogContext"].ConnectionString;
        }

        public string getDatabase()
        {
            return CatalogContext;
        }
    }
}
