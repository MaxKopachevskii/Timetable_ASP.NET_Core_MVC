using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Timetable.Models
{
    public class Timetable
    {
        [Display(Name = "№")]
        public int Id { get; set; }

        [Display(Name = "Самолеты")]
        public string Name { get; set; }

        [Display(Name = "Место вылета")]
        public string FlyFrom { get; set; }

        [Display(Name = "Место прибытия")]
        public string FlyTo { get; set; }

        [Display(Name = "Время вылета")]
        public string DepartureTime { get; set; }

        [Display(Name = "Время прибытия")]
        public string ArrivalTime { get; set; }
    }
}
