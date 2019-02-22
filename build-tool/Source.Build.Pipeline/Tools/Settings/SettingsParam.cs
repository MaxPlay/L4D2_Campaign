namespace Source.Build.Pipeline.Tools.Settings
{
    public class SettingsParam
    {
        public bool Enabled { get; set; } = false;
    }

    public class SettingsParam<T> : SettingsParam
    {
        public T Value { get; set; } = default(T);
    }
}