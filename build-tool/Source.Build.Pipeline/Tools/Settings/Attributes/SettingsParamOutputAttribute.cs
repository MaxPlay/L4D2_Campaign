using System;

namespace Source.Build.Pipeline.Tools.Settings.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SettingsParamOutputAttribute : Attribute
    {
        public string OutputText { get; set; }

        public SettingsParamOutputAttribute(string outputText)
        {
            OutputText = outputText;
        }
    }
}