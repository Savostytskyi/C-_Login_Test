using System.Configuration;

namespace Cdp_ctc.com.epam.cantire.commons.data.provider
{
    class TestDataProvider
    {
        public static string getDataByKey(string key)
        {
            AppSettingsReader appSettingsReader = new AppSettingsReader();
            return (string)appSettingsReader.GetValue(key, typeof(string));
        }
    }
}
