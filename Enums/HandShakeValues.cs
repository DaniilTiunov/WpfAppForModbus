using System.IO.Ports;
using WpfAppForModbus.Interfaces;

namespace WpfAppForModbus.Enums {
    public class HandshakeValues : IComboBoxObjects {
        public required string Name {
            get; set;
        }
        public Handshake Type {
            get; set;
        }

        public IComboBoxObjects IComboBoxObjects
        {
            get => default;
            set
            {
            }
        }
    }
}
