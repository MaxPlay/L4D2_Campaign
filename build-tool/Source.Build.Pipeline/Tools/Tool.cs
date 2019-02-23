using Source.Build.Pipeline.Files;
using Source.Build.Pipeline.Tools.Settings;

namespace Source.Build.Pipeline.Tools
{
    public abstract class Tool
    {
        public string Executable { get; private set; }

        public Tool(string executable)
        {
            Executable = executable;
        }

        public abstract void Run(MapFile mapFile, ToolSettings settings);
    }
}