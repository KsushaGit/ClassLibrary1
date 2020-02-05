using System.Configuration;

namespace ClassLibrary1.helper
{
    public static class Utills
    {
        public static string GetConfigurationValue(string settingKey)// создаем метод, который будет нам возвращать по ключу значение из конфига
        {
            return ConfigurationManager.AppSettings[settingKey]; // если Config возвращает null. то нам вернется string empty, a не excp
        }    
    }
}
