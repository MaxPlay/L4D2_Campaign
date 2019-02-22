using Source.Build.Pipeline.Tools.Settings.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Source.Build.Pipeline.Tools.Settings
{
    public class VbspSettings : ToolSettings
    {
        [SettingsParamOutput("-v")]
        public SettingsParam Verbose { get; set; } = new SettingsParam();

        [SettingsParamOutput("-onlyents")]
        public SettingsParam OnlyEnts { get; set; } = new SettingsParam();

        [SettingsParamOutput("-onlyprops")]
        public SettingsParam OnlyProps { get; set; } = new SettingsParam();

        [SettingsParamOutput("-glview")]
        public SettingsParam GlView { get; set; } = new SettingsParam();

        [SettingsParamOutput("-nodetail")]
        public SettingsParam NoDetail { get; set; } = new SettingsParam();

        [SettingsParamOutput("-nowater")]
        public SettingsParam NoWater { get; set; } = new SettingsParam();

        [SettingsParamOutput("-low")]
        public SettingsParam Low { get; set; } = new SettingsParam();

        [SettingsParamOutput("-vproject {0}")]
        public SettingsParam<string> VProject { get; set; } = new SettingsParam<string>();

        [SettingsParamOutput("-game {0}")]
        public SettingsParam<string> Game { get; set; } = new SettingsParam<string>();

        [SettingsParamOutput("-embed {0}")]
        public SettingsParam<string> Embed { get; set; } = new SettingsParam<string>();

        [SettingsParamOutput("-novconfig")]
        public SettingsParam NoVConfig { get; set; } = new SettingsParam();

        [SettingsParamOutput("-threads {0}")]
        public SettingsParam<int> Threads { get; set; } = new SettingsParam<int>();

        [SettingsParamOutput("-verboseentities")]
        public SettingsParam VerboseEntities { get; set; } = new SettingsParam();

        [SettingsParamOutput("-noweld")]
        public SettingsParam NoWeld { get; set; } = new SettingsParam();

        [SettingsParamOutput("-nocsg")]
        public SettingsParam NoCSG { get; set; } = new SettingsParam();

        [SettingsParamOutput("-noshare")]
        public SettingsParam NoShare { get; set; } = new SettingsParam();

        [SettingsParamOutput("-notjunc")]
        public SettingsParam NoTJunc { get; set; } = new SettingsParam();

        [SettingsParamOutput("-noopt")]
        public SettingsParam NoOpt { get; set; } = new SettingsParam();

        [SettingsParamOutput("-noprune")]
        public SettingsParam NoPrune { get; set; } = new SettingsParam();

        [SettingsParamOutput("-nomerge")]
        public SettingsParam NoMerge { get; set; } = new SettingsParam();

        [SettingsParamOutput("-nomergewater")]
        public SettingsParam NoMergeWater { get; set; } = new SettingsParam();

        [SettingsParamOutput("-micro {0}")]
        public SettingsParam<float> Micro { get; set; } = new SettingsParam<float>();

        [SettingsParamOutput("-fulldetail")]
        public SettingsParam FullDetail { get; set; } = new SettingsParam();

        [SettingsParamOutput("-leaktest")]
        public SettingsParam LeakTest { get; set; } = new SettingsParam();

        [SettingsParamOutput("-bumpall")]
        public SettingsParam BumpAll { get; set; } = new SettingsParam();

        [SettingsParamOutput("-snapaxial")]
        public SettingsParam SnapAxial { get; set; } = new SettingsParam();

        [SettingsParamOutput("-blocks {0}")]
        public SettingsParam<MinMaxVector2> Blocks { get; set; } = new SettingsParam<MinMaxVector2>();

        [SettingsParamOutput("-dumpstaticprops")]
        public SettingsParam DumpStaticProps { get; set; } = new SettingsParam();

        [SettingsParamOutput("-dumpcollide")]
        public SettingsParam DumpCollide { get; set; } = new SettingsParam();

        [SettingsParamOutput("-luxelscale {0}")]
        public SettingsParam<float> LuxelScale { get; set; } = new SettingsParam<float>();

        [SettingsParamOutput("-lightifmissing")]
        public SettingsParam LightIfMissing { get; set; } = new SettingsParam();

        [SettingsParamOutput("-localphysx")]
        public SettingsParam LocalPhysx { get; set; } = new SettingsParam();

        [SettingsParamOutput("-keepstalezip")]
        public SettingsParam KeepStaleZip { get; set; } = new SettingsParam();

        [SettingsParamOutput("-replacematerials")]
        public SettingsParam ReplaceMaterials { get; set; } = new SettingsParam();

        [SettingsParamOutput("-FullMinidumps")]
        public SettingsParam FullMinidumps { get; set; } = new SettingsParam();
    }
}
