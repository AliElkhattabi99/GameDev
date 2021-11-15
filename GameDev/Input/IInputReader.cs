using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
namespace GameDev.Input
{
    interface IInputReader
    {
        Vector2 ReadInput();
        public bool IsDestinationInput { get; }
    }
}
