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
        public static List<Sprite> CameraLayer1 { get; set; } = new List<Sprite>();
        public static List<Sprite> CameraLayer2 { get; set; } = new List<Sprite>();
        public static List<Sprite> CameraLayer3 { get; set; } = new List<Sprite>();
        public static List<Sprite> CameraLayer4 { get; set; } = new List<Sprite>();
        public static List<Sprite> CameraLayer5 { get; set; } = new List<Sprite>();

        public static List<Sprite> HudLayer1 { get; set; } = new List<Sprite>();
        public static List<Sprite> HudLayer2 { get; set; } = new List<Sprite>();
        public static List<Sprite> HudLayer3 { get; set; } = new List<Sprite>();
        public static List<Sprite> HudLayer4 { get; set; } = new List<Sprite>();
        public static List<Sprite> HudLayer5 { get; set; } = new List<Sprite>();

        public static void AddToLayer(List<Sprite> DesiredLayer, Sprite SpriteToAdd)
        {
            DesiredLayer.Add(SpriteToAdd);
        }

        private static void ClearLayers()
        {
            CameraLayer1.Clear();
            CameraLayer2.Clear();
            CameraLayer3.Clear();
            CameraLayer4.Clear();
            CameraLayer5.Clear();

            HudLayer1.Clear();
            HudLayer2.Clear();
            HudLayer3.Clear();
            HudLayer4.Clear();
            HudLayer5.Clear();
        }

        public static void Draw(SpriteBatch spritebatch, GraphicsDevice MainDevice)
        {
            DrawCameraWorld(spritebatch, MainDevice);

            DrawOnHud(spritebatch);

            Debugger.DrawDebugStrings(spritebatch);

            ClearLayers();
        }

        private static void DrawCameraWorld(SpriteBatch spritebatch, GraphicsDevice MainGraphicsDevice)
        {
            spritebatch.Begin(SpriteSortMode.Deferred,
         BlendState.AlphaBlend,
         SamplerState.PointClamp,
         null,
         null,
         null,
         CameraSystem.get_transformation(MainGraphicsDevice));


            DrawLayer(CameraLayer1, spritebatch);
            DrawLayer(CameraLayer2, spritebatch);
            DrawLayer(CameraLayer3, spritebatch);
            DrawLayer(CameraLayer4, spritebatch);
            DrawLayer(CameraLayer5, spritebatch);

            spritebatch.End();
        }

        private static void DrawOnHud(SpriteBatch spritebatch)
        {
            spritebatch.Begin(SpriteSortMode.Deferred,
         BlendState.AlphaBlend,
         SamplerState.PointClamp,
         null,
         null,
         null,
         null);

            DrawLayer(HudLayer1, spritebatch);
            DrawLayer(HudLayer2, spritebatch);
            DrawLayer(HudLayer3, spritebatch);
            DrawLayer(HudLayer4, spritebatch);
            DrawLayer(HudLayer5, spritebatch);

            spritebatch.End();
        }

        private static void DrawLayer(List<Sprite> LayerToDraw, SpriteBatch spritebatch)
        {
            if (LayerToDraw.Count > 0)
            {
                foreach (Sprite s in LayerToDraw)
                {
                    spritebatch.Draw(s.SpriteTexture, new Vector2((int)s.Position.Location.X, (int)s.Position.Location.Y), s.Source, s.GraphicColor, 0, Vector2.Zero,
                             s.Scale, SpriteEffects.None, 0);
                }
            }
        }
    }
}
