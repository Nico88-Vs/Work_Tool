using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Work_Tool.Utility
{
    public class Json_Converter
    {
        public Json_Converter(string path)
        {
        }

        public List<Topic> Convert(string path)
        {
            List<Topic> topics = new List<Topic>();

            try
            {
                string jsontxt = File.ReadAllText(path);
                topics = JsonConvert.DeserializeObject<List<Topic>>(jsontxt)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return topics;
        }

       
    }
}
