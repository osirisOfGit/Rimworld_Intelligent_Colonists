using System.Reflection;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace IntelligentColonists
{
	public class IntelligentColonists : Mod
    {
        public IntelligentColonists(ModContentPack content) : base(content)
        {
            Log.Message("Started!");
            var harmony = new Harmony("rimworld.osirisofrimworld.intelligentcolonists");
            harmony.PatchAll();
        }

        // public static Settings? Settings;

        // public static void Save()
        // {
        //     LoadedModManager.GetMod<IntelligentColonists>().GetSettings<Settings>().Write();
        // }

        public override string SettingsCategory()
        {
            return "IntelligentColonists";
        }

        // public override void DoSettingsWindowContents(Rect inRect)
        // {
        //     Settings.DoSettingsWindowContents(inRect);
        // }
    }
}
