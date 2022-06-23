using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPi3.Models
{
    public class MockGearRepository : IGearRepository
    {
        private List<Gear> _gearList;

        public MockGearRepository()
        {
            _gearList = new List<Gear>()
            {
                new Gear() { Id = 1, name = "spur", price = "5000", stock = true },
                new Gear() { Id = 2, name = "spiral", price = "6000", stock = true },
                new Gear() { Id = 3, name = "rack", price = "7000", stock = true }
            };
        }
        public Gear Add(Gear gear)
        {
            throw new NotImplementedException();
        }

        public Gear Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gear> GetAllGear()
        {
            throw new NotImplementedException();
        }

        public Gear GetGear(int Id)
        {
            throw new NotImplementedException();
        }

        public Gear Update(Gear gearChanges)
        {
            throw new NotImplementedException();
        }
    }

}
