using Source.Build.Pipeline.Tools.Settings;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Source.Build.CMD
{
    public static class Program
    {
        static void Main(string[] args)
        {
            VbspSettings settings = new VbspSettings()
            {
                Blocks = new SettingsParam<MinMaxVector2>()
                {
                    Enabled = true,
                    Value = new MinMaxVector2()
                    {
                        MaxX = 1,
                        MaxY = 2,
                        MinX = 3,
                        MinY = 4
                    }
                },
                Low = new SettingsParam()
                {
                    Enabled = true
                }
            };

            Console.WriteLine(ToolSettings.GetToolSettingsString(settings));
            Console.Read();
        }
    }
}
