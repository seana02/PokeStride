using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using System.Runtime.CompilerServices;
using Stride.Rendering.Sprites;
using Stride.Graphics;
using Stride.UI;
using Stride.UI.Controls;

namespace PokeStride
{
    public class MovementScript : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        bool moveable;
        float xVelocity, yVelocity;
        ImageElement sprite;

        public override void Start()
        {
            // Initialization of the script.
            sprite = Entity.Get<UIComponent>().Page.RootElement.FindVisualChildOfType<ImageElement>("characterSprite");
            Log.Info(sprite.ToString());
            xVelocity = 0.1f;
            yVelocity = 0.1f;
            moveable = true;
        }

        public override void Update()
        {
            // Do stuff every new frame
            if (Game.IsRunning)
            {
                if (Input.IsKeyDown(Keys.Left))
                {
                    this.Entity.Transform.Position.X -= xVelocity;
                    Log.Info("Moving Left: " + this.Entity.Transform.Position.X);
                }
                if (Input.IsKeyDown(Keys.Right))
                {
                    this.Entity.Transform.Position.X += xVelocity;
                    Log.Info("Moving Right: " + this.Entity.Transform.Position.X);
                }
                if (Input.IsKeyDown(Keys.Down))
                {
                    this.Entity.Transform.Position.Y -= yVelocity;
                }
                if (Input.IsKeyDown(Keys.Up))
                {
                    this.Entity.Transform.Position.Y -= yVelocity;
                }
            }
        }
    }
}
