using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace WorldWideImporters.DAL.Models.DB
{
    public partial class Country
    {
        public Country()
        {
            StateProvinces = new HashSet<StateProvince>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string FormalName { get; set; }
        public string IsoAlpha3Code { get; set; }
        public int? IsoNumericCode { get; set; }
        public string CountryType { get; set; }
        public long? LatestRecordedPopulation { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public Geometry Border { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
    }
}
