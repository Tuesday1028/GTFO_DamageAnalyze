﻿using System.Collections.Generic;
using TheArchive.Core;
using TheArchive.Core.Attributes;
using TheArchive.Core.Localization;

namespace Hikaria.DamageAnalyzer
{
    [ArchiveDependency(Core.PluginInfo.GUID)]
    [ArchiveModule(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
    public class EntryPoint : IArchiveModule
    {
        public void Init()
        {
            Instance = this;
            Logs.LogMessage("OK");
        }

        public void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
        }

        public void OnLateUpdate()
        {
        }

        public void OnExit()
        {
        }

        public static EntryPoint Instance { get; private set; }

        public bool ApplyHarmonyPatches => false;

        public bool UsesLegacyPatches => false;

        public ArchiveLegacyPatcher Patcher { get; set; }

        public string ModuleGroup => "Damage Analyzer";

        public Dictionary<Language, string> ModuleGroupLanguages => new()
        {
            { Language.Chinese, "伤害分析器" },
            { Language.English, "Damage Analyzer" }
        };
    }
}