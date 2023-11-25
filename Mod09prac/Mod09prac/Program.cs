using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using StorageLib;

namespace Mod09prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[]
            {
            new Flash("FlashDrive1", "Kingston", 3, 64),
            new DVD("DVD", "Sony", 0.01, "односторонний"),
            new HDD("HDD", "Seagate", 1, 2, 500)
            };

            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemory();
            }
            Console.WriteLine($"Барлық құрылғылардың ортақ жады: {totalMemory} ГБ");

            double dataSize = 565;
            double dataSize2 = 8;
            foreach (var device in devices)
            {
                if (device is DVD)
                {
                    device.CopyData(dataSize2);
                }
                else
                {
                    device.CopyData(dataSize);
                }            
            }

            
            double fileSize = 0.78; 
            int requiredDevices = (int)Math.Ceiling(dataSize / fileSize);
            Console.WriteLine($"Қажетті деректерді тасымалдау құрылғылары: {requiredDevices}");

            
            foreach (var device in devices)
            {
                Console.WriteLine($"Бос орын қосулы {device.Name}: {device.GetFreeSpace()} ГБ");
            }

            
            foreach (var device in devices)
            {
                device.GetDeviceInfo();
            }

            Console.ReadLine();
        }
    }
}
