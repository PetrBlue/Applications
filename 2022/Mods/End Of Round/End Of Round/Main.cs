using Assets.Scripts.Simulation.Towers.Weapons;
using Harmony;
using MelonLoader;
using NKHook6;
using NKHook6.Api;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using Assets.Scripts.Models.Store.Loot;

namespace End_Of_Round
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnLoaderInitialized();
            MelonLogger.Msg("End Of Round mod had loaded! Well done!");

        }
    }
    [HarmonyLib.HarmonyPatch(typeof(Simulation), "OnRoundEnd")]
    public class SimulationOnRoundEnd_Patch
    {

        [HarmonyLib.HarmonyPostfix]
        public static void Postfix()
        {
            InGame.instance.addCash(1000);
        }
    }
}
