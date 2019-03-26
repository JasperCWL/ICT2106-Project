using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Repository
{
    public class MedicineRepository : IMedicineLog
    {
        PainTrackerPTContext context = new PainTrackerPTContext();
        DbSet<MedicineLog> data = null;

        public MedicineRepository()
        {
            this.data = context.Set<MedicineLog>();
        }

        public MedicineLog GetLogAt(DateTime dt)
        {            
            var dbEntry = context.MedicineLog.FirstOrDefault(acc => acc.timeStamp == dt);
            return dbEntry;
        }

        public IEnumerable<MedicineLog> SelectAll()
        {
            return data.ToList();
        }

        public void Insert(MedicineLog obj)
        {
            data.Add(obj);
            context.SaveChanges();
        }

        public MedicineLog GetLogFromTo(DateTime start_dt, DateTime end_dt)
        {
            throw new NotImplementedException();
        }
    }
}
