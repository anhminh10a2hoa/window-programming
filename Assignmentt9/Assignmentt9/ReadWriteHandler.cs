using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignmentt9
{
    class ReadWriteHandler
    {
        public static void WriteJson(string filePath, List<Flight> flightCollection)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Flight>), serializingSettings);
            FileStream fileWriter = new FileStream(filePath, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, flightCollection);
            fileWriter.Close();
        }
        // Read JSON
        public static List<Flight> ReadJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                string jsonData = reader.ReadToEnd();
                List<Flight> items = JsonConvert.DeserializeObject<List<Flight>>(jsonData);
                reader.Close();
                if (items == null)
                {
                    return new List<Flight>();
                }
                return items;
            }
            return new List<Flight>();
        }
    }
}
