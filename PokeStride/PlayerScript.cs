using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;

namespace PokeStride
{
    public class PlayerScript : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        float velocity;

        public override void Start()
        {
            velocity = 0.1f;
        }

        public override void Update()
        {
            if (Game.IsRunning) {
                
                if (Input.IsKeyDown(Keys.Left)) {
                    this.Entity.Transform.Position.X -= velocity;
                }
                
                if (Input.IsKeyDown(Keys.Right)) {
                    this.Entity.Transform.Position.X += velocity;
                }
                
                if (Input.IsKeyDown(Keys.Up)) {
                    this.Entity.Transform.Position.Y += velocity;
                }
                
                if (Input.IsKeyDown(Keys.Down)) {
                    this.Entity.Transform.Position.Y -= velocity;
                }
        }}
    }
}
