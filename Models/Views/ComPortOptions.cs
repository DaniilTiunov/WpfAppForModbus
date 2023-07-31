﻿using System.IO.Ports;
using WpfAppForModbus.Enums;

namespace WpfAppForModbus.Models.Views {
    public class ComPortOptions {
        public ParityValues? SelectedParity { get; set; } = null;
        public StopBitsValues? SelectedStopBits { get; set; } = null;
        public HandshakeValues? SelectedHandshake { get; set; } = null;
        public SerialDataReceivedEventHandler Handler { get; set; } = null!;
        public int SelectedDataBits { get; set; } = -1;
        public int SelectedBaudRate { get; set; } = -1;
        public string? SelectedPort { get; set; } = null;

        public ParityValues ParityValues
        {
            get => default;
            set
            {
            }
        }

        public StopBitsValues StopBitsValues
        {
            get => default;
            set
            {
            }
        }

        public HandshakeValues HandshakeValues
        {
            get => default;
            set
            {
            }
        }

        public bool IsValid() {
            return SelectedParity != null &&
                   SelectedStopBits != null &&
                   SelectedHandshake != null &&
                   SelectedDataBits > -1 &&
                   SelectedBaudRate > -1 &&
                   !string.IsNullOrEmpty(SelectedPort) &&
                   Handler != null;
        }
    }
}
