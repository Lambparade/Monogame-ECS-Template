using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

using MGTemplate;

namespace MGTemplate.Systems.Content_System
{
    public static class ContentImages
    {
        public static Texture2D SpriteSheet { get; set; }

        public static void Load(Game1 CurrentGame)
        {
            SpriteSheet = CurrentGame.Content.Load<Texture2D>("TestSpriteSheet");

            LoadedTextures.GenerateGameTextures();
        }
    }
}