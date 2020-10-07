using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajustes_Fragen.Modelos
{
    public class AjustesDatabaseSettings : IAjustesDatabaseSettings
    { 
        public string AjustesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IAjustesDatabaseSettings
    {
        string AjustesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
