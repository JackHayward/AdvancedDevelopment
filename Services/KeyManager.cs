using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Kms.V1;
using Microsoft.Extensions.Configuration;

namespace AdvancedDevelopment.Services
{
    public class KeyManager
    {
        public KeyManager(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public string GetKey(string keyValue)
        {
            var key = Configuration.GetValue<string>(keyValue);

            return key;
        }

    }
}
