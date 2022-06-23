using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPi3.Models
{
    public class SqlGearRepository : IGearRepository
    {
        private readonly AppDBContext context;
        public SqlGearRepository(AppDBContext context)
        {
            this.context = context;
        }
        public Gear Add(Gear gear)
        {
            context.Gears.Add(gear);
            context.SaveChanges();
            return gear;
        }

        public Gear Delete(int id)
        {
            Gear gear = context.Gears.Find(id);
            if(gear != null)
            {
                context.Gears.Remove(gear);
                context.SaveChanges();
            }
            return gear;
        }

        public IEnumerable<Gear> GetAllGear()
        {
            return context.Gears;
        }

        public Gear GetGear(int Id)
        {
            return context.Gears.Find(Id);
        }

        public Gear Update(Gear gearChanges)
        {
            var gear = context.Gears.Attach(gearChanges);
            gear.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return gearChanges;
        }
    }
}
