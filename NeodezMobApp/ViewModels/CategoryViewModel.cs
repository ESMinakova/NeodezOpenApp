using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NeodezMobApp.ViewModels
{
    public enum CategoryViewModel
    {
        [Display(Name = "Уничтожение насекомых")]
        Desinsection,

        [Display(Name = "Уничтожение микробов и вирусов")]
        Desinfection,

        [Display(Name = "Уничтожение грызунов")]
        Deratisation,

        [Display(Name = "Уничтожение грибка и плесени")]
        Desmicology,

        [Display(Name = "Уничтожение клещей")]
        Acaricid,

        [Display(Name = "Уборка квартир")]
        CommonCleaning,

        [Display(Name = "Уборка после ремонта")]
        AfterRefitCleaning,

        [Display(Name = "Химчистка")]
        DryCleaning
    }
}
