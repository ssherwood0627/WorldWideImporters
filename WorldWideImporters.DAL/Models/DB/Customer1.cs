using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace WorldWideImporters.DAL.Models.DB
{
    public partial class Customer1
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCategoryName { get; set; }
        public string PrimaryContact { get; set; }
        public string AlternateContact { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string BuyingGroupName { get; set; }
        public string WebsiteUrl { get; set; }
        public string DeliveryMethod { get; set; }
        public string CityName { get; set; }
        public Geometry DeliveryLocation { get; set; }
        public string DeliveryRun { get; set; }
        public string RunPosition { get; set; }
    }
}
