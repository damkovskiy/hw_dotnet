using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HW_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.Console()
               .WriteTo.File(Path(), rollingInterval: RollingInterval.Hour)
               .CreateLogger();

            Log.Information("Application started " + typeof(Program).ToString());
            
            Motorcycle motorcycle1 = new Motorcycle("Minsk", "Model1", 2021, 0);
            Motorcycle motorcycle2 = new Motorcycle("Gomel", "Model2", 2020, 200);
            Motorcycle motorcycle3 = new Motorcycle("Mogilev", "Model3", 2015, 20000);
            Motorcycle motorcycle4 = new Motorcycle("Brest", "Model4", 2014, 40000);
            Motorcycle motorcycle5 = new Motorcycle("Grodno", "Model5", 2012, 30000);

            //Add to List<T>

            Log.Information("CRUD for list started.");
            ListMotorcycleRepository list = new ListMotorcycleRepository();

            list.CreateMotorcycle(motorcycle1);
            list.CreateMotorcycle(motorcycle2);
            list.CreateMotorcycle(motorcycle3);
            list.CreateMotorcycle(motorcycle4);
            list.CreateMotorcycle(motorcycle5);
          
            Motorcycle motorcycleReadFromList = list.GetMotorcycleByID(motorcycle1.Id);
            
            List<Motorcycle> motorcyclesFromList = list.GetMotorcycles();
            
            motorcycle1.Odometer = 5000;
            list.UpdateMotorcycle(motorcycle1);
            
            list.DeleteMotorcycle(motorcycle2.Id);

            // Add to File

            Log.Information("CRUD for File started.");
            FileMotorcycleRepository file = new FileMotorcycleRepository();

            file.CreateMotorcycle(motorcycle1);
            file.CreateMotorcycle(motorcycle2);
            file.CreateMotorcycle(motorcycle3);
            file.CreateMotorcycle(motorcycle4);
            file.CreateMotorcycle(motorcycle5);

            Motorcycle motorcycleReadFromFile = file.GetMotorcycleByID(motorcycle1.Id);

            List<Motorcycle> motorcyclesFromFile = file.GetMotorcycles();

            motorcycle1.Odometer = 3000;
            file.UpdateMotorcycle(motorcycle1);

            file.DeleteMotorcycle(motorcycle3.Id);

            Log.Information("Application completed!");
        }
        static string Path()
        {
            string path = ".\\Logs\\";

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
                directoryInfo.Create();

            return $"{path}Log.txt";
        }
    }
}
