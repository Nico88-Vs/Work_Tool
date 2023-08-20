using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Work_Tool.WorkToll_libreria_di_classi;

namespace Work_Tool.Utility
{
    public class Json_Converter<T>
    {
        public string Path { get; set; }
        public Json_Converter(string path)
        {
            this.Path = path;
        }

        public List<T> ConvertFromPath()
        {
            List<T> topics = new List<T>();

            try
            {
                string jsontxt = File.ReadAllText(this.Path);
                topics = JsonConvert.DeserializeObject<List<T>>(jsontxt)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return topics;
        }

        public List<T> ConvertFromTxt()
        {
            List<T> topics = new List<T>();

            try
            {
                //string jsontxt = File.ReadAllText(this.Path);
                topics = JsonConvert.DeserializeObject<List<T>>(this.Path)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return topics;
        }

    }
}
