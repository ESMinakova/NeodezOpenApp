using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NeodezMobApp
{
    internal static class EmailInfoManager
    {
        private static string emailInfo = "mypass";
        private static string fileName = "emailInfo"; 
        private static string path = FileSystem.AppDataDirectory;
        internal static string GetEmailInfo()
        {            
            var filePath = Path.Combine(path, fileName);
            if (!File.Exists(filePath))
            {
                var serializedData = JsonSerializer.Serialize(emailInfo);
                File.WriteAllText(filePath, serializedData);
            }
                
            var rawData = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<string>(rawData);
        }
    }
}
