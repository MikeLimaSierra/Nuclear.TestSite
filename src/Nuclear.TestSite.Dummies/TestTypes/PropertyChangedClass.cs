using System;
using System.ComponentModel;

namespace Nuclear.TestSite.TestTypes {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class PropertyChangedClass : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        private Boolean _value1;

        private Boolean _value2;

        public Boolean Value1 {
            get => _value1;
            set {
                _value1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value1"));
            }
        }

        public Boolean Value2 {
            get => _value2;
            set {
                _value2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value2"));
            }
        }

        public Boolean Value1And2 {
            set {
                Value1 = value;
                Value2 = value;
            }
        }

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
