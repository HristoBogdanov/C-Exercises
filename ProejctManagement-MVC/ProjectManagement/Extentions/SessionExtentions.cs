using Microsoft.AspNetCore.Http;
using ProjectManagement.Entities;
using System.Text.Json;

namespace ProjectManagement.Extentions
{
    public static class SessionExtentions
    {
        public static void SetObejct<T>(this ISession session,string key, T data)
            where T : class
        {
            string jsonData=JsonSerializer.Serialize(data);
            session.SetString(key, jsonData);
        }

        public static T GetObject<T>(this ISession session, string key)
            where T : class
        {
            string jsonData=session.GetString(key);

            if (jsonData == null)
            {
                return null;
            }

            T result=JsonSerializer.Deserialize<T>(jsonData);

            return result;
        }
    }
}
