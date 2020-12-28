using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOP_LAB_5
{
    public static class Serializer
    {
        public static void Serialization(List<DisciplineInfo> list,string path)
        {
            string jsonResult = JsonConvert.SerializeObject(list);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonResult);
            }
        }

        public static void Deserialization(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string result = String.Empty;
                while (!sr.EndOfStream)
                {
                    result += sr.ReadLine();
                }

                InfoCollection.list = JsonConvert.DeserializeObject<List<DisciplineInfo>>(result);
            }
        }


    }
}
