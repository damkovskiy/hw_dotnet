using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HW_15
{
    public class FileMotorcycleRepository : IMotorcycleRepository<Motorcycle>
    {
        private readonly string _pathOfFile = ".\\Motorcycles\\";

        public FileMotorcycleRepository()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_pathOfFile);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        public Motorcycle GetMotorcycleByID(Guid id)
        {
            string path = $"{_pathOfFile}ID_{id}.json";

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                var result = JsonConvert.DeserializeObject<Motorcycle>(File.ReadAllText(path));
                Log.Information("{Motorcycle} with ID: {Id} read.", result.Name, result.Id);
                return result;
            }
            else
            {
                Console.WriteLine("File not found!");
                return new Motorcycle();
            }
        }

        public List<Motorcycle> GetMotorcycles()
        {
            List<Motorcycle> motorcycles = new List<Motorcycle>();

            DirectoryInfo directoryInfo = new DirectoryInfo(_pathOfFile);
            FileInfo[] filesInfo = directoryInfo.GetFiles();

            for (int i = 0; i < filesInfo.Length; i++)
            {
                if (filesInfo[i].Extension.Equals(".json", StringComparison.OrdinalIgnoreCase))
                    motorcycles.Add(JsonConvert.DeserializeObject<Motorcycle>(File.ReadAllText(filesInfo[i].FullName)));
            }

            Log.Information("All {Count} motorcycles from List read.", motorcycles.Count);
            return motorcycles;
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            string path = $"{_pathOfFile}ID_{motorcycle.Id}.json";

            File.WriteAllText(path, JsonConvert.SerializeObject(motorcycle));

            Log.Information("{Motorcycle} with ID: {Id} created.", motorcycle.Name, motorcycle.Id);
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            string path = $"{_pathOfFile}ID_{motorcycle.Id}.json";

            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
            {
                Console.WriteLine("File not found!");
            }
            else
            {
               File.WriteAllText(path, JsonConvert.SerializeObject(motorcycle));
               Log.Information("{Motorcycle} with ID: {Id} updated.", motorcycle.Name, motorcycle.Id);
            } 
        }

        public void DeleteMotorcycle(Guid id)
        {
            string path = $"{_pathOfFile}ID_{id}.json";

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                Log.Information("Motorcycle with ID: {Id} deleted.", id);
                fileInfo.Delete();
            }
            else
                Console.WriteLine("File not found!");
        }
    }
}
