using Infragistics.Windows.DataPresenter;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KB13270_WpfApp1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        var firstRecord = xamDataGrid1.Records.FirstOrDefault(record => record.IsDataRecord == true) as DataRecord;
        if (firstRecord != null)
        {
            firstRecord.Cells[0].IsActive = true;
            xamDataGrid1.ExecuteCommand(DataPresenterCommands.StartEditMode);
        }
    }
}