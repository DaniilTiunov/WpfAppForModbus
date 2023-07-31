﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WpfAppForModbus.Domain.Entities {
    public class Sensor {
        [Key]
        public int SensorId {
            get; set;
        }

        [NotNull]
        [Required]
        public required string SensorName {
            get; set;
        }
    }
}
