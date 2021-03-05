﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WorldWideImporters.DAL.Models.DB
{
    public partial class VehicleTemperature
    {
        public long VehicleTemperatureId { get; set; }
        public string VehicleRegistration { get; set; }
        public int ChillerSensorNumber { get; set; }
        public DateTime RecordedWhen { get; set; }
        public decimal Temperature { get; set; }
        public bool IsCompressed { get; set; }
        public string FullSensorData { get; set; }
        public byte[] CompressedSensorData { get; set; }
    }
}