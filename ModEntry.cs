using StardewModdingAPI; //can't exactly mod without asking SMAPI for permission, unless you're a criminal--
using StardewValley; //can't really mod without hooking into the proper APIs unless you're a criminal--

namespace ExamplesForWiki
{
    internal class ModEntry : Mod
    {
        internal static IModHelper ModHelper { get; set; } = null!;
        internal static IMonitor ModMonitor { get; set; } = null!;
        internal static IManifest Manifest { get; set; } = null!;

        public override void Entry(IModHelper helper)
        {
            /*
            this is where you set your variables
            like:
            ModHelper = helper;
            ModMonitor = Monitor;
            Manifest = ModManifest;

            etc etc, however which way you want to name them
            IManifest Manifest turns into ModManifest
            IMonitor ModMonitor turns into Monitor
            so if you make other classes you can call them like:
            Monitor.Log(VARIABLE HERE, LogLevel.Alert);
             */
        }
    }
}
