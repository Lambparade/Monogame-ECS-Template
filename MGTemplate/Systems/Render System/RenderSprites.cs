using System;
using System.Collections.Generic;

using MGTemplate.Components;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Render_System
{
    public static class RenderSprites
    {
        public static List<Sprite> Layer1 { get; set; } = new List<Sprite>();

        public static void AddToLayer(List<Sprite> DesiredLayer, Sprite SpriteToAdd)
        {
            DesiredLayer.Add(SpriteToAdd);
        }

        private static void ClearLayers()
        {
            Layer1.Clear();
        }

        public static void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();

            foreach (Sprite s in Layer1)
            {



            }

            spritebatch.End();

        }
    }
}