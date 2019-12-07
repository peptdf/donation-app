namespace Midleware.Infra.Database
{
    public class Configuration
    {
        private string CatalogContext { get; set; }

        public Configuration()
        {
            CatalogContext = "Data Source=donation.database.windows.net;Initial Catalog=Donation;User ID=donation;Password=Zoeranerverends@1;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";  
        }

        public string getDatabase()
        {
            return CatalogContext;
        }
    }
}
