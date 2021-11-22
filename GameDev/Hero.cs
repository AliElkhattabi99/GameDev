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
    class Hero : IInputReader
    {
        private Texture2D texture;
        //private Rectangle deelRectangle;
        private Animations animation;
        private Vector2 position = new Vector2(0, 0);
        private Vector2 speed = new Vector2(1, 1);
        private Vector2 versnelling = new Vector2(0.1f, 0.1f);
        private IInputReader inputReader;
        KeyboardState state = Keyboard.GetState();

        public bool IsDestinationInput => inputReader.IsDestinationInput;

        public Hero(Texture2D texture, IInputReader inputReader)
        {
            this.texture = texture;
            animation = new Animations();
            animation.GetFramesFromTextureProperties(texture.Width, texture.Height,  3, 1);
            //animation.GetFramesFromTextureProperties(texture.Width, texture.Height, 8, 1);
            this.inputReader = inputReader;
            position = new Vector2(1, 1);
            speed = new Vector2(2, 2);
            versnelling = new Vector2(0.1f, 0.1f);

            //deelRectangle = new Rectangle(schuifOp_X, 0, 180, 247);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, animation.CurrentFrame.SourceRectangle, Color.White);

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
