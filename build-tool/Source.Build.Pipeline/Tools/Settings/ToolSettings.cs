using Source.Build.Pipeline.Tools.Settings.Attributes;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Source.Build.Pipeline.Tools.Settings
{
    public abstract class ToolSettings
    {
        public static string GetToolSettingsString<T>(T settings, string game = Games.LEFT4DEAD2) where T : ToolSettings
        {
            Type parameterType = typeof(SettingsParam);

            var sb = new StringBuilder();
            foreach (var property in typeof(T).GetProperties())
            {
                if (property.GetCustomAttributes(typeof(SettingsParamGameAttribute), true).Count() > 0 && !property.GetCustomAttributes(typeof(SettingsParamGameAttribute), true).Any(c => ((SettingsParamGameAttribute)c).Game == game))
                    continue;

                if (property.PropertyType != parameterType && property.PropertyType.BaseType != parameterType)
                    continue;

                var param = property.GetValue(settings) as SettingsParam;

                if (!param.Enabled)
                    continue;

                string output = (property.GetCustomAttributes(typeof(SettingsParamOutputAttribute), true).FirstOrDefault() as SettingsParamOutputAttribute)?.OutputText;

                if (output == null)
                    continue;

                if (param.GetType().IsGenericType)
                {
                    var genericProp = param.GetType().GetProperty(nameof(SettingsParam<int>.Value));
                    object value = genericProp.GetValue(param);
                    sb.Append(" ").AppendFormat(output, value);
                }
                else
                    sb.Append(" ").Append(output);
            }
            return sb.ToString();
        }
    }
}