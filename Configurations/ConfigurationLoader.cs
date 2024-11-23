using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Configurations
{
    internal class ConfigurationLoader
    {
        public IConfiguration Configuration { get; }
        public ConfigurationLoader()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath("D:\\Fastfood_Kiosk_v2\\Configurations")
                .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }
}
