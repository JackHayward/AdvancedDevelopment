//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.Extensions.Configuration;

//namespace AdvancedDevelopment.Services
//{
//    public class AuthMessageSenderOptions
//    {
//        private readonly KeyGrabber _keyGrabber;
//        private readonly IConfiguration _configuration;
//        public string SendGridUser { get; }
//        public string SendGridKey { get; }

//        public AuthMessageSenderOptions(IConfiguration configuration)
//        {
//            _configuration = configuration;
//            _keyGrabber = new KeyGrabber(configuration);

//            SendGridUser = new string(_keyGrabber.GetKey("SendGridUser"));
//            SendGridKey = new string(_keyGrabber.GetKey("SendGridKey"));
//        }

//        //public string SendGridUser = ;
//        //public string SendGridKey = "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";
        

//        //public string SendGridUser = "ImJackHayward";
//        //public string SendGridKey = "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";
//    }
//}
