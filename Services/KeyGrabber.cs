using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AdvancedDevelopment.Services
{
    public class KeyGrabber
    {
        private readonly IConfiguration _configuration;


        public KeyGrabber(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetKey(string keyId)
        {
            var key = _configuration.GetValue<string>(keyId);

            return key;
        }
    }
}
