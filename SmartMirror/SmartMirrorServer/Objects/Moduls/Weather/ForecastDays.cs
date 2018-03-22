﻿using System;

namespace SmartMirrorServer.Objects.Moduls.Weather
{
    internal class ForecastDays
    {
        public string City { get; set; }

        public int CityId { get; set; }

        public DateTime Date { get; set; }

        public double Temperature { get; set; }

        public double MinTemp { get; set; }

        public double MaxTemp { get; set; }

        public string Icon { get; set; }
    }
}