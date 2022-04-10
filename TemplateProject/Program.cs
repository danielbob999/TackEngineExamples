using System;

using TackEngineLib.Engine;

namespace TemplateProject {
    internal class Program {
        static void Main(string[] args) {
            // Start a new TackEngineLib instance
            TackEngine.Init(
                800,                    // window width
                600,                    // window height
                60,                     // update loop runs per second
                60,                     // render loop runs per second
                true,                   // should vsync be enabled?
                                        //      - if true, update/render runs per second are set to the vsync rate
                "Template Project",     // window name
                App.Start,              // your app start method
                App.Update,             // your app update method
                App.GUI,                // your app GUI method (CURRENTLY NOT USED)
                App.Close);             // your app close method
        }
    }
}
