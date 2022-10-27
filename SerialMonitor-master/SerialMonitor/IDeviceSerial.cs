using CommunityToolkit.Mvvm.Input;
using LiveCharts;
using System.IO.Ports;

namespace SerialMonitor
{
    internal interface IDeviceSerial
    {
        RelayCommand CloseButtonCommand { get; }
        RelayCommand OpenButtonCommand { get; }
        string ReceiveData { get; set; }
        SeriesCollection SeriesCollection { get; set; }

        bool Close();
        bool Connect(int portName, int baudRate = 9600, int DataBits = 8, Parity parity = Parity.None, StopBits stopBits = StopBits.One);
    }
}