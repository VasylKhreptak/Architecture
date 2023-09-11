using Newtonsoft.Json;
using Services.Data.Core;
using UnityEngine;

namespace Services.Data
{
    public class DataService : IDataService
    {
        public void Save<T>(T data, string key)
        {
            string jsonData = JsonConvert.SerializeObject(data);

            PlayerPrefs.SetString(key, jsonData);
        }

        public T Load<T>(string key)
        {
            string jsonData = PlayerPrefs.GetString(key);

            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public T Load<T>(string key, T defaultValue)
        {
            string jsonData = PlayerPrefs.GetString(key);

            if (string.IsNullOrEmpty(jsonData))
            {
                return defaultValue;
            }

            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }
    }
}
