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
                spritebatch.Draw(s.SpriteTexture, new Vector2((int)s.Position.Location.X, (int)s.Position.Location.Y), s.Source, Color.White, 0, Vector2.Zero,
                         s.Scale, SpriteEffects.None, 0);
            }

            spritebatch.End();

        }
    }
}