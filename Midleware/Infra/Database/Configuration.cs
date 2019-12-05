using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Donation.Midleware.Infra.Database
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
