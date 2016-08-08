using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.productName = productName;

            this.ProductId = productId;

            this.description = description;

        }
        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductCode => ProductId + "-" + ProductName.Trim().Replace(" ","-");
        //Auto-Implemented Properties.
        public int ProductId { get; set; }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private Vendor vendor;

        public Vendor Vendor
        {
            get
            {
                if (this.vendor == null)
                {
                    this.vendor = new Vendor();
                }
                return vendor;
            }
            set { vendor = value; }
        }

        private DateTime? availabilityDate;

        public DateTime? AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }

        public string SayHello()
        {
            var vendor = this.Vendor;
            vendor.SendWelcomeEmail("Message from sayHello");
            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("test", this.ProductName, "f1178899@gmail.com");
            var result = LoggingService.LogAction("saying Hello");
            return "Hello " + productName + ProductId + " Available on: " + this.AvailabilityDate?.ToShortDateString();
        }


    }
}
