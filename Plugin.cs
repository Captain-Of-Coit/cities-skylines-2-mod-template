using System.IO.Compression;
using System.IO;
using System;
using System.Linq;
using System.Reflection;
using BepInEx.Unity.Mono;
using BepInEx;
using HarmonyLib;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace MyCoolMod
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

            var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID + "_Cities2Harmony");
            var patchedMethods = harmony.GetPatchedMethods().ToArray();

            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} made patches! Patched methods: " + patchedMethods.Length);

            foreach (var patchedMethod in patchedMethods) {
                Logger.LogInfo($"Patched method: {patchedMethod.Module.Name}:{patchedMethod.Name}");
            }
        }

        private void OnGUI() {
            GUI.Label(new Rect(10, 10, 300, 20), $"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
