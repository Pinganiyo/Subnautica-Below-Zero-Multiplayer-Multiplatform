namespace Subnautica.Events.Patches.Fixes.Creatures.MonoBehaviours
{
    using Subnautica.API.Features;
    using Subnautica.API.Extensions;

    using HarmonyLib;

    using System.Collections.Generic;
    using System.Reflection.Emit;
    using System.Linq;

    [HarmonyPatch]
    public class LeviathanMeleeAttack
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(global::LeviathanMeleeAttack), nameof(global::LeviathanMeleeAttack.ReleaseVehicle))]
        private static void ReleaseVehicle_Postfix(global::LeviathanMeleeAttack __instance)
        {
            if (Network.IsMultiplayerActive)
            {
                if (Network.Creatures.IsMine(__instance.gameObject))
                {
                    __instance.useRigidbody.SetNonKinematic();
                }
                else
                {
                    __instance.useRigidbody.SetKinematic();
                }
            }
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(global::LeviathanMeleeAttack), nameof(global::LeviathanMeleeAttack.ReleaseVehicle))]
        private static void ReleaseVehicle_Prefix(global::LeviathanMeleeAttack __instance)
        {
            if (__instance.holdingVehicle)
            {
                if (!Network.IsMultiplayerActive || __instance.heldSeatruck?.IsPiloted() == true || global::Player.main.playerAnimator.GetBool(__instance.playerStartSeatruckAttackAnimation))
                {
                    global::Player.main.playerAnimator.SetBool(__instance.playerStartSeatruckAttackAnimation, false);
                    global::Player.main.playerAnimator.SetBool(__instance.playerEndSeatruckAttackAnimation, false);
                }
            }
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(global::LeviathanMeleeAttack), nameof(global::LeviathanMeleeAttack.ReleaseVehicle))]
        private static IEnumerable<CodeInstruction> ReleaseVehicle_Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator il)
        {
            var codes  = instructions.ToList();
            
            var index  = codes.FindIndex(q => q.opcode == OpCodes.Ldfld && q.operand.ToString().Contains("playerAnimator"));
            if (index > -1 && index - 1 >= 0 && index - 1 + 12 <= codes.Count)
            {
                // Search for the branch target BEFORE removing instructions so both indices are valid
                var index2 = codes.FindLastIndex(q => q.opcode == OpCodes.Ldfld && q.operand.ToString().Contains("exosuitAttackLoopSfx"));

                codes.RemoveRange(index - 1, 12);

                // After RemoveRange the code list has shifted — recalculate index2 relative to the new list
                if (index2 > -1)
                {
                    // index2 was after the removed block, so shift it back by 12
                    int adjustedIndex2 = index2 - 12;
                    if (adjustedIndex2 > -1 && adjustedIndex2 < codes.Count)
                    {
                        var label = il.DefineLabel();
                        codes[adjustedIndex2].labels.Add(label);

                        // The branch instruction should be placed at index - 1 (now the first instruction after removal)
                        // Clamp to valid range
                        int branchIndex = index - 1;
                        if (branchIndex >= 0 && branchIndex < codes.Count)
                        {
                            codes[branchIndex] = new CodeInstruction(OpCodes.Brfalse_S, label);
                        }
                    }
                }
            }

            return codes.AsEnumerable();
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(global::LeviathanMeleeAttack), nameof(global::LeviathanMeleeAttack.FinishSeatruckAttack))]
        private static bool FinishSeatruckAttack(global::LeviathanMeleeAttack __instance)
        {
            if (!Network.IsMultiplayerActive)
            {
                return true;
            }

            __instance.animator.SetBool("seatruck_attack_end", true);
            __instance.seatruckAttackEndSfx.Play();

            if (__instance.heldSeatruck)
            {
                __instance.heldSeatruck.animator.SetBool(__instance.seatruckEndAttackAnimation, true);

                if (__instance.heldSeatruck.IsPiloted())
                {
                    global::Player.main.playerAnimator.SetBool(__instance.playerEndSeatruckAttackAnimation, true);
                }
            }

            return false;
        }
    }
}
