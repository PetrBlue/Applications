using MelonLoader;
using Harmony;
using NKHook6.Api;
using Assets.Scripts.Simulation.Towers.Weapons;
using NKHook6;

namespace BluesHypersonicMod
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnLoaderInitialized();
            MelonLogger.Msg("Blues Hypersonic mod had loaded! Well done!");

        }
    }
    [HarmonyLib.HarmonyPatch(typeof(Weapon), "Initialise")]
    public class WeaponInitialise_Patch
    {
        [HarmonyLib.HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            __instance.weaponModel.rate = 0;
        }
    }
}
