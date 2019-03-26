using PainTrackerPT.Models.Medicine;
using PainTrackerPT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineService
    {
        MedicineLog GetLogAt(DateTime dt);
        MedicineLog GetLogFromTo(DateTime start_dt, DateTime end_dt);
        IEnumerable<MedicineLog> SelectAll();
        void Insert(MedicineLog obj);
    }
}
