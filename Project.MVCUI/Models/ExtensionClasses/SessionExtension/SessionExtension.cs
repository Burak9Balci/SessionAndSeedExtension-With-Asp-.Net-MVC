using Newtonsoft.Json;

namespace Project.MVCUI.Models.ExtensionClasses.SessionExtension
{
    public static class SessionExtension
    {

        public static T GetObject<T>(this ISession session,string key) where T : class
        {
            string jsonValue = session.GetString(key);
            if (jsonValue != null)
            {
               T value =  JsonConvert.DeserializeObject<T>(jsonValue);
               return value;
            }
            return null;
        }

        public static void SetObject(this ISession session,string key,object value)
        {
            string jsonValue = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonValue);
        }
    }
}
