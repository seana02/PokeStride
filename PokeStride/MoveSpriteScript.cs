using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.UI.Controls;
using Stride.UI;

namespace PokeStride
{
    public class MoveSpriteScript : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        bool moveable;
        float xVelocity, yVelocity;

        public override void Start()
        {
            // Initialization of the script.
            xVelocity = 0.1f;
            yVelocity = 0.1f;
        }

        public override void Update()
        {
            // Do stuff every new frame
            if (Game.IsRunning)
            {
                if (Input.IsKeyDown(Keys.Left))
                {
                    this.Entity.Transform.Position.X -= xVelocity;
                }
                if (Input.IsKeyDown(Keys.Right))
                {
                    this.Entity.Transform.Position.X += xVelocity;
                }
                if (Input.IsKeyDown(Keys.Down))
                {
                    this.Entity.Transform.Position.Y -= yVelocity;
                }
                if (Input.IsKeyDown(Keys.Up))
                {
                    this.Entity.Transform.Position.Y += yVelocity;
                }


            }
        }
    }
}
