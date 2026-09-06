namespace Subnautica.Events.Patches.Fixes.Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection.Emit;

    using HarmonyLib;

    using Subnautica.API.Features;
    using Subnautica.Client.Extensions;

    [HarmonyPatch]
    public static class ProtobufSerializer
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(global::ProtobufSerializer), nameof(global::ProtobufSerializer.SerializeGameObject))]
        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            return ProtobufSerializer.TranspileSerializeGameObject(instructions);
        }

        /**
         *
         * Transpiler uygular.
         *
         
         *
         */
        public static IEnumerable<CodeInstruction> TranspileSerializeGameObject(IEnumerable<CodeInstruction> instructions)
        {
            var codes = instructions.ToList();

            for (int i = 0; i < codes.Count; i++)
            {
                if (codes[i].opcode == OpCodes.Callvirt && codes[i].operand != null && codes[i].operand.ToString().Contains("set_Id"))
                {
                    codes.Insert(i, new CodeInstruction(OpCodes.Ldarg_0));
                    codes.Insert(i + 1, new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(ProtobufSerializer), nameof(ProtobufSerializer.GetSerializeGameObjectId), new Type[] { typeof(string), typeof(global::ProtobufSerializer) })));
                    i += 2;
                }
                else if (codes[i].opcode == OpCodes.Call && codes[i].operand != null && codes[i].operand.ToString().Contains("GetParentId"))
                {
                    codes.Insert(i, new CodeInstruction(OpCodes.Ldarg_0));
                    codes[i + 1] = new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(ProtobufSerializer), nameof(ProtobufSerializer.GetSerializeGameObjectParentId), new Type[] { typeof(global::UniqueIdentifier), typeof(bool), typeof(global::ProtobufSerializer) }));
                    i += 1;
                }
            }

            return codes.AsEnumerable();
        }

        /**
         *
         * UniqueId Değerini döner.
         *
         
         *
         */
        public static string GetSerializeGameObjectId(string id, global::ProtobufSerializer serializer)
        {
            if (Network.IsMultiplayerActive && serializer.IsIdIgnoreModeActive())
            {
                try
                {
                    return Serializer.GetUniqueId(id);
                }
                catch (Exception ex)
                {
                    Log.Error($"Transpiler, GetSerializeGameObject Exception: {ex}");
                }
            }

            return id;
        }

        /**
         *
         * ParentId Değerini döner.
         *
         
         *
         */
        public static string GetSerializeGameObjectParentId(global::UniqueIdentifier uid, bool useParent, global::ProtobufSerializer serializer)
        {
            if (!Network.IsMultiplayerActive || !useParent || !serializer.IsIdIgnoreModeActive())
            {
                return global::ProtobufSerializer.GetParentId(uid, useParent);
            }

            var parent = uid.transform.parent;
            if (parent == null)
            {
                return null;
            }

            var component = parent.GetComponent<global::UniqueIdentifier>();
            if (component == null)
            {
                return null;
            }

            try
            {
                return Serializer.GetUniqueId(component.Id);
            }
            catch (Exception ex)
            {
                Log.Error($"Transpiler, GetSerializeGameObjectParentId Exception: {ex}");
            }
            
            return null;
        }
    }
}