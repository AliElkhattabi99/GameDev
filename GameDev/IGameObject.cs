using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    interface IGameObject
    {
        void Update(GameTime gametime);
        void Draw(SpriteBatch spriteBatch);

    }
}
