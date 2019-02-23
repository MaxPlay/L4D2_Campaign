using System;
using System.Collections.Generic;
using System.Text;
using Source.Build.Pipeline.Files;
using Source.Build.Pipeline.Pipelines;
using Source.Build.Pipeline.Tools.Settings;

namespace Source.Build.Pipeline.Tools
{
    public class Vvis : Tool, IPipelineElement
    {
        public Vvis(string executable) : base(executable)
        {
        }

        public override void Run(MapFile mapFile, ToolSettings settings)
        {

        }
    }
}
