using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLib
{
    public class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;

        public Flash(string name, string model, double usbSpeed, double memorySize)
        {
            Name = name;
            Model = model;
            this.usbSpeed = usbSpeed;
            this.memorySize = memorySize;
        }

        public override double GetMemory()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование {dataSize} ГБ данных во Flash. Необходимое время: {dataSize / usbSpeed} секунд.");
        }

        public override double GetFreeSpace()
        {
            return memorySize * 0.1; 
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Флеш накопитель: {Name}, Модель: {Model}, скорость USB: {usbSpeed} ГБ/с, объем памяти: {memorySize} ГБ");
        }
    }
}
