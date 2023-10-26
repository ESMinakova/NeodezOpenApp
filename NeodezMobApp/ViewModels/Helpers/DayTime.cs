using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeodezMobApp.ViewModels.Helpers
{
    public enum DayTime
    {
        [Display(Name = "В рабочее время")]
        workingTime,

        [Display(Name = "Вечером или в выходной день")]
        holidayTime
    }
}
