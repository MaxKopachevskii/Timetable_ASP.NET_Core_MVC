using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Timetable.Models
{
    public static class SampleData
    {
        public static void Initialize(TimetableDbContext context)
        {
            if (!context.Timetables.Any())
            {
                Timetable t1 = new Timetable { Name = "АН-2", FlyFrom = "New York", FlyTo = "Kyiv", DepartureTime = "10:15", ArrivalTime = "15:40" };
                Timetable t2 = new Timetable { Name = "АН-24", FlyFrom = "Kyiv", FlyTo = "Hamburg", DepartureTime = "14:00", ArrivalTime = "17:00" };
                Timetable t3 = new Timetable { Name = "ТУ-154", FlyFrom = "Rio", FlyTo = "Kyiv", DepartureTime = "8:30", ArrivalTime = "13:45" };
                context.Timetables.Add(t1);
                context.Timetables.Add(t2);
                context.Timetables.Add(t3);
                context.SaveChanges();
            }
        }
    }
}
