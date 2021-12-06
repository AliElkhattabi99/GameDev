using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
using GameDev.Animation;
using GameDev.Input;

namespace GameDev
{
    class Hero : IGameObject
    {
        private Texture2D texture;
        private Rectangle deelRectangle;
        private Animations animation;
        private Vector2 position = new Vector2(0, 0);
        private Vector2 speed = new Vector2(1, 1);
        private Vector2 versnelling = new Vector2(0.1f, 0.1f);
        private IInputReader inputReader;
        



        public bool IsDestinationInput => inputReader.IsDestinationInput;

        public Hero(Texture2D texture, IInputReader inputReader)
        {
            this.texture = texture;
            animation = new Animations();
            //animation.GetFramesFromTextureProperties(texture.Width, texture.Height,  5, 5);
           // deelRectangle = new Rectangle(0, 0, 32, 32);
            animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 32, 32)));
            //animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 38, 28)));
            //animation.GetFramesFromTextureProperties(texture.Width, texture.Height, 8, 1);
            
            
            this.inputReader = inputReader;
            position = new Vector2(1, 1);
            speed = new Vector2(2, 2);
            versnelling = new Vector2(0.1f, 0.1f);

            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, animation.CurrentFrame.SourceRectangle, Color.White);
            //spriteBatch.Draw(texture, position, deelRectangle, Color.White);

        }

        public void Update(GameTime gametime)
        {
            Move();
            animation.Update(gametime);
        }

        private Vector2 Limit(Vector2 v, float max)
        {
            if (v.Length() > max)
            {
                var ratio = max / v.Length();
                v.X *= ratio;
                v.Y *= ratio;
            }
            return v;
        }

        private void Move()
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Up))
            {
                
            animation.AddFrame(new AnimationFrame(new Rectangle(32, 64, 32, 32)));
                    animation.AddFrame(new AnimationFrame(new Rectangle(64, 64, 32, 32)));
                    animation.AddFrame(new AnimationFrame(new Rectangle(96, 64, 32, 32)));
                
            }
            if (state.IsKeyDown(Keys.Left))
            {
                
                animation.AddFrame(new AnimationFrame(new Rectangle(32, 0, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(64, 0, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(96, 0, 32, 32)));
                 /*animation.AddFrame(new AnimationFrame(new Rectangle(25, 112, 38, 28)));
                animation.AddFrame(new AnimationFrame(new Rectangle(50, 112, 38, 28)));
                animation.AddFrame(new AnimationFrame(new Rectangle(75, 112, 38, 28)));*/
            }
            if (state.IsKeyDown(Keys.Right))
            {
                
                animation.AddFrame(new AnimationFrame(new Rectangle(32, 32, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(64, 32, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(96, 32, 32, 32)));
            }

            if (state.IsKeyDown(Keys.Down))
            {
               
                animation.AddFrame(new AnimationFrame(new Rectangle(32, 96, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(64, 96, 32, 32)));
                animation.AddFrame(new AnimationFrame(new Rectangle(96, 96, 32, 32)));
            }
            

            var direction = inputReader.ReadInput();

            if (inputReader.IsDestinationInput)
            {
                direction -= position;
                direction.Normalize();
            }

            direction *= speed;
            position += direction;

            
        }

        public void ChangeInput(IInputReader inputReader)
        {
            this.inputReader = inputReader;
        }

        public Vector2 ReadInput()
        {
            return inputReader.ReadInput();
        }
    }
    }
