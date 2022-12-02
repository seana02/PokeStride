﻿using System;
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
        Thickness border;

        public override void Start()
        {
            // Initialization of the script.
            sprite = Entity.Get<UIComponent>().Page.RootElement.FindVisualChildOfType<ImageElement>("characterSprite");
            Log.Info(sprite.ToString());
            xVelocity = 0.1f;
            yVelocity = 0.1f;
            border = sprite.Margin;
            moveable = true;
        }

        public override void Update()
        {
            // Do stuff every new frame
            if (Game.IsRunning)
            {
                if (Input.IsKeyDown(Keys.Left))
                {
                    Log.Info("Moving Left: " + border.Left);
                    border.Left -= xVelocity;
                    border.Right += xVelocity;
                }
                if (Input.IsKeyDown(Keys.Right))
                {
                    Log.Info("Moving Right: " + border.Left);
                    border.Right -= xVelocity;
                    border.Left += xVelocity;
                }
                if (Input.IsKeyDown(Keys.Down))
                {
                    border.Top += yVelocity;
                    border.Bottom -= yVelocity;
                }
                if (Input.IsKeyDown(Keys.Up))
                {
                    border.Top -= yVelocity;
                    border.Bottom += yVelocity;
                }
            }
        }
    }
}
