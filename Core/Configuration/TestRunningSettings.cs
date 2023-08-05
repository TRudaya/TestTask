using NUnit.Framework;

namespace TestTask.Core.Configuration
{
    public static class TestRunningSettings
    {
        public static string Get(string setting) => TestContext.Parameters.Get(setting);

        public static T GetAsEnum<T>(string setting) where T : IComparable, IFormattable, IConvertible
        {
            return EnumUtils.ParseEnum<T>(Get(setting));
        }

        public static int GetAsInt(string setting)
        {
            return Convert.ToInt32(Get(setting));
        }

        public static bool GetAsBool(string setting)
        {
            return Convert.ToBoolean(Get(setting));
        }

        public static string GetEnvironment()
        {
            return Get("Environment");
        }

        public static string GetEnvironmentalSetting(string setting)
        {
            string environmentalSetting = $"{GetEnvironment()}{setting}";
            return Get(environmentalSetting);
        }
    }
}
