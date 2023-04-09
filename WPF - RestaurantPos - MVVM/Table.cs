using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF___RestaurantPos___MVVM
{
    public class Table : INotifyPropertyChanged
    {
        public enum TapleType { Table, Capinet }

        public event PropertyChangedEventHandler? PropertyChanged;

        private string? tableName;

        public bool status { get; set; }


        public string TableName
        {
            get { return tableName; }
            set
            {
                tableName = value;
                OnPropertyRaised();
            }
        }

        public bool Status
        {
            get { return status; }
            set
            {
                status = value;
                OnPropertyRaised();
            }
        }


        public TapleType tapleType;



        private void OnPropertyRaised([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
