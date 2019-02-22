using System;

namespace Source.Build.Pipeline.Tools.Settings.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class SettingsParamGameAttribute : Attribute
    {
        public string Game { get; set; }

        public SettingsParamGameAttribute(string game)
        {
            Game = game;
        }
    }
}