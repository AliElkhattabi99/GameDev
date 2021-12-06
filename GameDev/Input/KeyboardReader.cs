using System;
using System.Collections.Generic;
using System.Text;
using GameDev.Animation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
namespace GameDev.Input
{
    class KeyboardReader : IInputReader
    {
        private Animations animation;

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


            /*if (spY < surface)
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
            if (state.IsKeyDown(Keys.Up))
            {
                click = true;
                direction.Y -= 2;
            }
            if ((click) && (state.IsKeyUp(Keys.Up)))
            {
                direction.Y += 2;
                click = false;
                spY -= jump;
                canJump = false;
                
            }*/

            if (state.IsKeyDown(Keys.Up))
            {

                if (state.IsKeyUp(Keys.Up))
                {
                    direction.Y += 2;
                    /*animation.AddFrame(new AnimationFrame(new Rectangle(32, 64, 32, 32)));
                    animation.AddFrame(new AnimationFrame(new Rectangle(64, 64, 32, 32)));
                    animation.AddFrame(new AnimationFrame(new Rectangle(96, 64, 32, 32)));*/
                };
                direction.Y -= 2;
            }
            /*if (state.IsKeyUp(Keys.Up))
            {
                direction.Y += 2;
                
            }*/
            if (state.IsKeyDown(Keys.Left))
            {
                direction.X -= 1;

                /*animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(32, 0, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(64, 0, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(96, 0, 32, 32)));*/
            }
            if (state.IsKeyDown(Keys.Right))
            {
                direction.X += 1;

                /*animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(32, 32, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(64, 32, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(96, 32, 32, 32)));*/
            }

            if (state.IsKeyDown(Keys.Down))
            {
                direction.Y += 1;/*
                animation.AddFrame(new AnimationFrame(new Rectangle(32, 96, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(64, 96, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(96, 96, 32, 32)));*/
            }

            return direction;
        }

   

        public bool IsDestinationInput => false;
    }
}
