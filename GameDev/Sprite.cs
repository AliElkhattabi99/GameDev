using GameDev.Animation;
using GameDev.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameDev
{
    class Sprite
    {
 

    /*protected AnimationManager _animationManager;

        protected Dictionary<string, Animations> _animations;

        protected Vector2 _position;

        protected Texture2D _texture;




        KeyboardState state = Keyboard.GetState();

        public Vector2 Position
        {
            get { return _position; }
            set
            {
                _position = value;

                if (_animationManager != null)
                    _animationManager.Position = _position;
            }
        }

        public float Speed = 1f;

        public Vector2 Velocity;

   

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (_texture != null)
                spriteBatch.Draw(_texture, Position, Color.White);
            else if (_animationManager != null)
                _animationManager.Draw(spriteBatch);
            else throw new Exception("This ain't right..!");
        }

        public virtual void Move()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                Velocity.Y = -Speed;
            else if (Keyboard.GetState().IsKeyDown(Keys.Down))
                Velocity.Y = Speed;
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                Velocity.X = -Speed;
            else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                Velocity.X = Speed;
        }

        protected virtual void SetAnimations()
        {
            if (Velocity.X > 0)
                _animationManager.Play(_animations["run-Sheet"]);
            else if (Velocity.X < 0)
                _animationManager.Play(_animations["long-jump"]);
            else if (Velocity.Y > 0)
                _animationManager.Play(_animations["WalkDown"]);
            else if (Velocity.Y < 0)
                _animationManager.Play(_animations["WalkUp"]);
            else _animationManager.Stop();
        }

        public Sprite(Dictionary<string, Animations> animations)
        {
            _animations = animations;
            _animationManager = new AnimationManager(_animations.First().Value);
        }

        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }

        public virtual void Update(GameTime gameTime, List<Sprite> sprites)
        {
            Move();

            SetAnimations();

            _animationManager.Update(gameTime);

            Position += Velocity;
            Velocity = Vector2.Zero;
        }

        */
    }
}
