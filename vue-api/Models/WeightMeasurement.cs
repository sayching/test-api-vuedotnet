using System;
using System.ComponentModel.DataAnnotations;

namespace WeightTrackerOkta.Models
{
    public class WeightMeasurement
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public DateTime MeasuredAt { get; set; }
    }
}