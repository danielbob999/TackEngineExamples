using System;
using TackEngineLib.Engine;

namespace FlappyBirdGameExample {
    internal class Program {
        static void Main(string[] args) {
            TackEngine.Init(800, 600, 60, 60, true, "Flappy Bird Game", App.Start, App.Update, App.GUI, App.Close);
        }
    }
}
