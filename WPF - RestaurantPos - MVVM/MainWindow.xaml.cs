using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF___RestaurantPos___MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Table> Tables { get; set; }
        public ObservableCollection<Table> TempTables { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            Tables = new ObservableCollection<Table>
            {
                new Table {TableName = "Table 1" , status=true ,tapleType=Table.TapleType.Table },
                new Table {TableName = "Table 2" , status=true , tapleType=Table.TapleType.Table},
                new Table {TableName = "Table 3" , status = true, tapleType=Table.TapleType.Table},
                new Table {TableName = "Table 4" , status = true, tapleType=Table.TapleType.Table},
                new Table {TableName = "Table 5" , status = true, tapleType=Table.TapleType.Table},
                new Table {TableName = "Table 6" , status = true, tapleType=Table.TapleType.Table},
                new Table {TableName = "Table 7" , status = true, tapleType=Table.TapleType.Table},
                new Table {TableName = "Table 8" , status = true, tapleType=Table.TapleType.Table},
                new Table {TableName = "Table 9" , status = true, tapleType=Table.TapleType.Table},
                new Table {TableName = "Table 10" , status = true, tapleType=Table.TapleType.Table}
            };


        }


        private void CloseImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

    }
}
