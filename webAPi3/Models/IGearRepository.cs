using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPi3.Models
{
    public interface IGearRepository
    {
        Gear GetGear(int Id);
        IEnumerable<Gear> GetAllGear();
        Gear Add(Gear gear);
        Gear Update(Gear gearChanges);
        Gear Delete(int id);
    }
}
