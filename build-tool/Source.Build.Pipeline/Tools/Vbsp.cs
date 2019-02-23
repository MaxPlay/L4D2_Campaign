using System;
using System.Collections.Generic;
using System.Text;
using Source.Build.Pipeline.Files;
using Source.Build.Pipeline.Pipelines;
using Source.Build.Pipeline.Tools.Settings;

namespace Source.Build.Pipeline.Tools
{
    public class Vbsp : Tool, IPipelineElement
    {
        public Vbsp(string executable) : base(executable)
        {
        }

        public override void Run(MapFile mapFile, ToolSettings settings)
        {

        }
    }
}
