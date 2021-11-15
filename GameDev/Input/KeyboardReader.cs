using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
namespace GameDev.Input
{
    class KeyboardReader : IInputReader
    {

        public Vector2 ReadInput()
        {
            KeyboardState state = Keyboard.GetState();
            Vector2 direction = Vector2.Zero;
            Vector2 position;

            //jump nog niet klaar
            int gravity = 2;
            int jump = 50;
            int spX = 20;
            int spY = 20;
            int surface = 200;
            bool click = false;
            bool canJump = true;


            if (spY < surface)
            {
                spY += gravity;
            }
            else
            {
                if (spY == surface)
                {
                    canJump = true;
                }
            }
            if (state.IsKeyDown(Keys.Space))
            {
                click = true;
                direction.Y -= 2;
            }
            if ((click) && (state.IsKeyUp(Keys.Space)))
            {
                direction.Y += 2;
                click = false;
                spY -= jump;
                canJump = false;
                
            }


            if (state.IsKeyDown(Keys.Left))
            {
                direction.X -= 1;
            }
            if (state.IsKeyDown(Keys.Right))
            {
                direction.X += 1;
            }
            if (state.IsKeyDown(Keys.Up))
            {
                direction.Y -= 1;
            }
            if (state.IsKeyDown(Keys.Down))
            {
                direction.Y += 1;
            }
            return direction;
        }

   

        public bool IsDestinationInput => false;
    }
}
