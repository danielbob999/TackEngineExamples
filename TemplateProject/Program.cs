using System;

using TackEngineLib.Engine;

namespace TemplateProject {
    internal class Program {
        static void Main(string[] args) {
            TackEngine.Init(800, 600, 60, 60, true, "Template Project", App.Start, App.Update, App.GUI, App.Close);
        }
    }
}
