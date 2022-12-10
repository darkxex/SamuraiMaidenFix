using BepInEx;
using BepInEx.IL2CPP;


namespace MaidenFix
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        public static BepInEx.Logging.ManualLogSource log;
        public Plugin() {
             log = Log;
        }
        public override void Load()
        {
            // Plugin startup logic
            Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            AddComponent<Uncensor>();
           
        }
        
    }
}
