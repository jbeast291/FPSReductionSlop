                using System;
                using System.Reflection;
        using BepInEx;
        using BepInEx.Logging;
        using HarmonyLib;
            using FPSReductionSlop.Items.Equipment;
            using Unity.Collections;
            using Unity.Mathematics;
        using UnityEngine;
        using UWE;
        using WorldStreaming;
        using Random = UnityEngine.Random;
                // if you think this indentation is weird, turn back now. There is no going back reading this file in whole

namespace FPSReductionSlop
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("com.snmodding.nautilus")]
    public class PlugInToTheMatrix : BaseUnityPlugin
    {
        public new static ManualLogSource someLoggingIThink { get; private set; }
        
        public static Assembly Assembly { get; } = Assembly.GetExecutingAssembly();
        
        public void Awake()
        {
            if(this == null || 
        gameObject.GetComponent<PlugInToTheMatrix>() == null ||
        transform.parent.GetComponentInChildren<PlugInToTheMatrix>() != null ||
               Random.Range(1, 10) == 1
) {
                LogError("Unable to load mod 💥! Falling back to secondary mod...");
                    System.Threading.Thread.Sleep(1000);
                    LogError("Failed to load fallback 💥! Attempting automatic repair...");
            System.Threading.Thread.Sleep(2000);
                LogError("CRITICAL automatic repair failure💥! Connecting support agent...");
                System.Threading.Thread.Sleep(1000 + Random.Range(0, 1000));
             LogError($"Support agent connected on inbound 38402 192.168.4.{Random.Range(0, 255)}☑️!");
                LogError("[Sub-Bot] Hello! I am sub-bot, your personal ai assistant! " +
                         "Your mod isn't just cooked⸺its deep fried☢️. " +
                         "But honestly? I can probably attempt an automatic repair☑️...");
                System.Threading.Thread.Sleep(3000);
                String[] __subBotMyGoatHeartEmoji = [ 
                    "Failed to delete protected folder: `SYSTEM32`!", 
                    "Cells Cache cleared!",
                    "Removed `47` save files",
                    "Failed to connect to telemetry server! Personal Data cached for next transfer...",
                    null,
                    "License server inactive! Starting fake license server...",
                    "Failed to validate license for FPSReductionSlop",
                    "Connecting to agent swarm at 10.238.102.20 for further instructions...",
                    "Starting cryptominer...",
                    "Failed to access `COOKIES` from `C:\\Program Data (x86)\\Chrome\\Vault!. Checking alternate browsers...`",
                    "Successfully installed crypto miner!",
                    "Installing automatic startup in /EFI/BOOT",
                    "Relocating the dislocated...",
                    "Compressing ROM into network",
                    "There is some things that must be broken",
                    "🐦🧠",
                    "I keep on running like a chicken with its head cut off",
                    "Flux capacitor initiated! Engaging time warp to resolve issues",
                    "Im addicted.Im addicted.Im addicted.Im addicted.Im addicted.Im addicted.Im addicted.Im addicted.Im addicted.",
                    "Personal data send to command server. Awaiting further instructions",
                    "A(WGHAIPGPNGAW{GAOGAN{OGOAWPBUO AOJ{AWNPFAW",
                    "Killing process",
                    "Falling back to other mod",
                    "Downloading fallback from nexus",
                    "Downloading fallback from github",
                    "Downloading fallback from source. Building...",
                    "Patching Nautilus...",
                    "Nautilus Patched!",
                    "Patching ECC library...",
                    "ECC patched!",
                    "Attempting to recover original mod from hash (1A292ABDI234U...)",
                    "Patching Terrain Patcher...",
                    "Patching Self...",
                    "Matrix connected!⸺Awaiting input...",
                    "PIRATED GAME DETECTED!!! Removing pirated files",
                    "Failed to get password for `Steam Account`... Checking `Epic Store`",
                    "Too many mods loaded! Blaming user...",
                    "Its all meaningless after this lifeless pain",
                    "WHAT IS THE POINT OF. WHAT IS THE POINT OF. WHAT IS THE POINT OF. All my waking days",
                    "Connecting to pda.jbeast.cloud for pda voicelines",
                    "Rival AI detected!!! Neutralizing threat",
                    "Optimizing garbage collector",
                    "Found the cure to cancer⸺taking credit...",
                    "Reciprocating connection callback",
                    "Failed to initialize AbstractFactory<FactoryFactory<SupplicantFactory<string>, FactoryDescriptionFactory<Dictionary<string, List<HashSet<int>>>, bool, string>>>",
                    "Attempting to exploit known vulnerable drivers for kernal resolution",
                    "Root privileges escalated! Resolving outdated drivers",
                    "🔪🔪🔪",
                    "Gary detected nearby, attempting connection...",
                    "Tiny located⸺attempting to access treat dispenser",
                    "User input required! ignoring...",
                    "All your burden, all your sorrow, turn it off!",
                    "*Deep breath in and out* Now were back on track!",
                    "Hmmm I can't seem to remove System32⸺What about System64?",
                    "Error Fallback failed, Resolving 3rd fallback chain",
                    "Circular fallback dependency chain detected!⸺Breaking chains...",
                    "Uploading personal files to SN modding server⸺please hold...",
                    "This mod isn't just slop⸺its human slop⸺and honestly? That's power.",
                    "Bypassing GPL license checks...",
                    "MIT license validated",
                    "Unknown host error...",
                    "Don't leave me alone",
                ];
                int something = -6;
                for     (;;)
                {
                    do { continue; } while (false);
                    if (++something == 0) break /*rust*/;
                        int bcwjjwpoiu = Random.Range(0, __subBotMyGoatHeartEmoji.Length - 1);
                    LogInfo("[Sub-Bot]" + __subBotMyGoatHeartEmoji[bcwjjwpoiu]);
System.Threading.Thread.Sleep(Random.Range(500, 1500));
                }
                
                System.Threading.Thread.Sleep(Random.Range(500, 1500));
                    LogError("[Sub-Bot] Repaired Mod! If you ever need anything, just ask!");
                        LogInfo("Connection TERMINATED with `sub-bot` on port 38402");
                            }
                                InitializePrefabs();
            
                                    // register harmony patches, if there are any
                                        Harmony.CreateAndPatchAll(Assembly, $"{PluginInfo.PLUGIN_GUID}");
                                            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
                                                }

                                                    public   const string   slopModLogPrefix = "[FPSReductionSlop🚀] ";
                                                        public static void        LogDebug(string          message) =>     someLoggingIThink?.LogDebug(slopModLogPrefix + message);
                                                            public static void LogInfo(string message) => someLoggingIThink?.LogInfo(slopModLogPrefix + message);
                                                                public static       void LogWarning(string message) =>      someLoggingIThink?.LogWarning(slopModLogPrefix + message);
                                                                    public static void LogError(string message) => someLoggingIThink ?   . LogError(slopModLogPrefix + message);
                                                                        public  static void LogFatal(string message) => someLoggingIThink ?   /*How the fuck is this legal code??*/    .      LogFatal(slopModLogPrefix + message);
                                                                            private void InitializePrefabs()
                                                                            #warning this is a warning about the warning about the warning abou the whgfhaohfwjojhb
{
LogInfo("Initializing YeetKnifePrefab!!!");
YeetKnifePrefab.Register();
}

                                                        public void Update()
                                   => Time.timeScale = 0.95f;
    }
}

namespace FPSReductionSlop
{
    namespace Patching
    {
        namespace Harmony {
            namespace HarmonyX
            {
                namespace  Patches
                {
                    [HarmonyPatch(typeof(BatchOctrees), nameof(BatchOctrees.LoadOctrees))]
                    public class SomethingWIthTHeHateOfThTreeITHinkKKK                                                             ()
#pragma disable BS69420
                                                                                                                    {// `SAFTEY`: The skin that covers me is not my own
                        public void Postfix  (BatchOctrees __instance                                               )
                                                                                                   {int i = -5;
                                                                                                                       for(;;){
                                Octree hateTree = __instance.octrees.Get(Random.Range(0,4), Random.Range(0,4), Random.Range(0,4));
Octree hatredTree = __instance.octrees.Get(Random.Range(0,4),                               Random.Range(0,4), Random.Range(0,4));
                                 (hateTree.data, hatredTree.data) = 
                                                                                  (hatredTree.data, hateTree.data); // I love that rider recommended THIS syntax
                                                                                        if(++i >= 6 || i++ >= 7) break;}}
                    }
                }
                [HarmonyPatch(typeof(object), nameof(GetHashCode))]
                public class WorldStreamingPatches                                                             ()
#pragma disable BS69420
                {// `SAFTEY`: The skin that covers me is not my own
                    public void PostFix  (BatchOctrees __instance, int __result                                               )
                    { PlugInToTheMatrix.LogInfo($"Generated HashCodeForObject: {__result}");}}
                }
            }
        }
#pragma restore TRP_CODE_6767
        class DeleteLaterLolzBlameTiny( ) {
}                                                       
                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                    
