using MelonLoader;
using HarmonyLib;

[assembly: MelonInfo(typeof(Lillys_Level_Uncapper.Core), "Lillys Level Uncapper", "1.0.0", "Lilly", null)]
[assembly: MelonGame("KisSoft", "ATLYSS")]

namespace Lillys_Level_Uncapper
{
    public class Core : MelonMod
    {
        [HarmonyPatch(typeof(GameManager), "Start")]
        public static class gamemanager
        {
            private static void Postfix(ref GameManager __instance)
            {
                try
                {
                    __instance._statLogics._maxMainLevel = 10000;
                }
                catch (Exception e)
                {
                    MelonLogger.Msg(e);
                }
            }
        }
    }
}