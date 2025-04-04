﻿using HarmonyLib;
using UnityEngine;

[HarmonyPatch(typeof(IceSawValuable), "Start")]
public static class IceSawValuable_Patch
{
    [HarmonyPostfix]
    public static void Postfix(IceSawValuable __instance)
    {
        if (__instance.hurtCollider == null)
        {
            var existing = __instance.GetComponentInChildren<HurtCollider>();
            if (existing != null)
            {
                __instance.hurtCollider = existing;
            }
            else
            {
                __instance.hurtCollider = __instance.gameObject.AddComponent<HurtCollider>();
            }
        }
    }
}
