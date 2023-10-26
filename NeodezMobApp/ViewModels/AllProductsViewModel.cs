using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NeodezMobApp.ViewModels
{    
    public class AllProductsViewModel
    {
        public ObservableCollection<ProductViewModel> Products { get; set; }
        private string fileName = "allproducts";
        private string path = FileSystem.AppDataDirectory;

        public AllProductsViewModel()
        {
            Products = new ObservableCollection<ProductViewModel>();
            var filePath = Path.Combine(path, fileName);
            if (!File.Exists(filePath))            
                CreateNewFile(filePath);
            else
            {                
                var rawData = File.ReadAllText(filePath);
                Products = JsonSerializer.Deserialize<ObservableCollection<ProductViewModel>>(rawData);
            }
        }

        private void CreateNewFile(string filePath)
        {
            Products = new ObservableCollection<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    Id = 1,
                    Name = "Уничтожение насекомых",
                    Category = CategoryViewModel.Desinsection,
                    IconImagePath = "cockroach.png",
                    ProductImagePath = "insect_main.jpg",
                    Description = "У нас многолетний опыт и научные знания в борьбе с любыми видами насекомых. Иногда достаточно " +
                    "просто спросить у нас совета и проблема будет решена. \n"   +
                    "Стоимость услуги от 2500 руб."
                },

                new ProductViewModel()
                {
                    Id = 2,
                    Name = "Уничтожение микробов, вирусов",
                    Category = CategoryViewModel.Desinfection,
                    IconImagePath = "microb.png", 
                    ProductImagePath = "desinfection_main.jpg",
                    Description = "Иногда возникает проблема – избавиться от невидимых врагов. Нет ничего проще – обращайтесь. \n"   +
                    "Стоимость услуги от 2000 руб."
                },

                new ProductViewModel()
                {
                    Id = 3,
                    Name = "Уничтожение грызунов",
                    Category = CategoryViewModel.Deratisation,
                    IconImagePath = "rat.png",
                    ProductImagePath = "deratisation_main.jpg",
                    Description = "Избавим от любых грызунов, поможем избежать рецидивов, защитить здоровье и имущество.\n"   +
                    "Стоимость услуги от 2000 руб."

                },

                new ProductViewModel()
                {
                    Id = 4,
                    Name = "Уничтожение грибка и плесени",
                    Category = CategoryViewModel.Desmicology,
                    IconImagePath = "fungi.png",
                    ProductImagePath = "fungi_main.png",
                    Description = "С виду безобидная культура грибка на объектах окружающей среды может сильно навредить \n"   +
                    "Стоимость услуги от 2200 руб."
                },

                new ProductViewModel()
                {
                    Id = 5,
                    Name = "Уничтожение клещей",
                    Category = CategoryViewModel.Acaricid,
                    IconImagePath = "acaricid.png",
                    ProductImagePath = "acaricid_main.jpg",
                    Description = "Поможем обезопасить места, где вам приятно отдыхать. Акарицидная обработка - лучшая профилактика встречи с клещами.\n"   +
                    "Стоимость услуги от 1000 руб./сотка"
                },

                new ProductViewModel()
                {
                    Id = 6,
                    Name = "Уборка квартир",
                    Category = CategoryViewModel.CommonCleaning,
                    IconImagePath = "cleaning.png",
                    ProductImagePath = "cleaning_main.jpg",
                    Description = "Мы умеем профессионально делать чисто. Не пожалеете.\n"   +
                    "Стоимость услуги от 5000 руб."
                },

                new ProductViewModel()
                {
                    Id = 7,
                    Name = "Химчистка",
                    Category = CategoryViewModel.DryCleaning,
                    IconImagePath = "dry_cleaning.png",
                    ProductImagePath = "drycleaning_main.jpg",
                    Description = "Почистим, постараемся вернуть прежний вид и сделать «как новым» любой вид мягкой мебели или ковров.\n"   +
                    "Стоимость услуги от 2000 руб."
                },

                new ProductViewModel()
                {
                    Id = 8,
                    Name = "Уборка после ремонта",
                    Category = CategoryViewModel.AfterRefitCleaning,
                    IconImagePath = "hard_cleaning.png",
                    ProductImagePath = "poslestroy_main.jpg",
                    Description = "Лучше доверьте эту работу нам! Трудная задача, но мы справимся, ведь за плечами такой опыт.\n"   +
                    "Стоимость услуги от 7000 руб."
                },
            };

            var serializedData = JsonSerializer.Serialize(Products);
            File.WriteAllText(filePath, serializedData);
        }
    }
}
