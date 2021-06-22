using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
namespace QuanLyPhuTungXeMay
{
    static class Helper<T> where T : class
    {
        public static T ReadFile(string filename)
        {
            var fullpath = Path.Combine(Common.FilePath, filename);
            var data = "";
            using (StreamReader sr = File.OpenText(fullpath))
            {
                data = sr.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<T>(data);
        }

        public static void WriteFile(string filename, object data)
        {
            var serializeObject = JsonConvert.SerializeObject(data);
            var fullpath = Path.Combine(Common.FilePath, filename);
            using (StreamWriter sw = File.CreateText(fullpath))
            {
                sw.Write(serializeObject);
            }
        }
    }
}
