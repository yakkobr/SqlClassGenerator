using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SqlClassGenerator.DataObjects;

namespace SqlClassGenerator.Global
{
    public static class ConfigManager
    {
        /// <summary>
        /// Gets the mapping data
        /// </summary>
        /// <returns>The mapping data</returns>
        public static List<MappingModel> GetData()
        {
            var file = Path.Combine(Helper.GetBaseFolder(), "Mapping.json");

            // Check if the file exists. If not, return an empty list
            if (!File.Exists(file))
                return new List<MappingModel>();

            var jsonString = File.ReadAllText(file);

            return JsonConvert.DeserializeObject<List<MappingModel>>(jsonString);
        }
        /// <summary>
        /// Writes the mapping data
        /// </summary>
        /// <param name="data">The data</param>
        /// <returns>true if successful, otherwise false</returns>
        public static bool WriteData(object data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var file = Path.Combine(Helper.GetBaseFolder(), "Mapping.json");

            var jsonString = JsonConvert.SerializeObject(data);

            File.WriteAllText(file, jsonString);

            return File.Exists(file);
        }
    }
}
