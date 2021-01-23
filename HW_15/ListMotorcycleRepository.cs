using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW_15
{
    class ListMotorcycleRepository : IMotorcycleRepository <Motorcycle>
    {
        List<Motorcycle> _motorcycles = new List<Motorcycle>();

        public Motorcycle GetMotorcycleByID(Guid id)
        {
            var result = _motorcycles.Find(moto => moto.Id == id);
            Log.Information("{Motorcycle} with ID: {Id} read.", result.Name, result.Id);
            return result; 
        }

        public List<Motorcycle> GetMotorcycles()
        {
            Log.Information("All {Count} motorcycles from List read.", _motorcycles.Count);
            return _motorcycles;
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            _motorcycles.Add(motorcycle);
            Log.Information("{Motorcycle} with ID: {Id} created.", motorcycle.Name, motorcycle.Id);
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            _motorcycles.Remove(_motorcycles.Find(moto => moto.Id == motorcycle.Id));
            _motorcycles.Add(motorcycle);
            Log.Information("{Motorcycle} with ID: {Id} updated.", motorcycle.Name, motorcycle.Id);
        }

        public void DeleteMotorcycle(Guid id)
        {
            var result = _motorcycles.Find(moto => moto.Id == id);
            Log.Information("{Motorcycle} with ID: {Id} deleted.", result.Name, result.Id);
            _motorcycles.Remove(result);
        }
    }
}
