using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using GameDev.Input;

namespace GameDev.Movement
{
    interface IMovable
    {
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public IInputReader InputReader { get; set; }

    }
}
