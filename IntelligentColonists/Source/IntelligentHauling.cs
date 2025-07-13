using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarmonyLib;
using Verse;
using Verse.AI;

namespace IntelligentColonists
{
    class IntelligentHauling
    {
        [HarmonyPatch(typeof(Pawn_JobTracker), "StartJob")]
        static class Pawn_JobTracker_StartJob_IntelligentColonistsPatch
        {
            internal static bool Prefix(Job newJob)
            {
                Log.Message("Starting a job!");
                return true;
            }
        }
    }
}
