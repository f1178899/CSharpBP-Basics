using Acme.Common;
using System;

namespace Acme.Biz
{
    /// <summary>
    /// 
    /// </summary>
    public class Product
    {
        public const double InchPerMeter = 12.22;
        public Product()
        {
            Console.WriteLine("instance created");
        }
        /// <summary>
        /// overloading constructor
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="productName"></param>
        /// <param name="description"></param>
        public Product(int productId, string productName, string description) : this()
        {
            ProductName = productName;
            ProductId = productId;
            Description = description;

        }

        public string ProductName { get; set; }

        public string ProductCode => ProductId + "-" + ProductName.Trim().Replace(" ", "-");
        //Auto-Implemented Properties.
        public int ProductId { get; set; }
        public string Description { get; set; }

        private Vendor _vendor;

        public Vendor Vendor
        {
            get { return _vendor ?? (_vendor = new Vendor()); }
            set { _vendor = value; }
        }

        public DateTime? AvailabilityDate { get; set; }

        public string SayHello()
        {
            var vendor = Vendor;
            vendor.SendWelcomeEmail("Message from sayHello");
            var emailService = new EmailService();
            emailService.SendMessage("test", ProductName, "f1178899@gmail.com");
            LoggingService.LogAction("saying Hello");
            return "Hello " + ProductName + ProductId + " Available on: " + AvailabilityDate?.ToShortDateString();
        }


    }
}
