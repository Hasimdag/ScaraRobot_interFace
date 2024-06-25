using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robtek_V1._1
{
    public class SerialPortSingleton
    {
        private static SerialPortSingleton instance;
        private SerialPort serialPort;

        private SerialPortSingleton()
        {
            // Yeni bir SerialPort nesnesi oluştur
            serialPort = new SerialPort();
        }

        // Singleton örneğini almak için metot
        public static SerialPortSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new SerialPortSingleton();
            }
            return instance;
        }

        // SerialPort nesnesine erişim metotları
        public SerialPort GetSerialPort()
        {
            return serialPort;
        }

        public bool IsPortOpen()
        {
            return serialPort.IsOpen;
        }
    }
}
