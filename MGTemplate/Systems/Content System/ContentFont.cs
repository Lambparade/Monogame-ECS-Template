
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

using MGTemplate;

namespace MGTemplate.Systems.Content_System
{
   public static class ContentFont
   {
      public static SpriteFont SpriteFont { get; set; }

      public static void Load(Game1 CurrentGame)
      {
         SpriteFont = CurrentGame.Content.Load<SpriteFont>("debugfont");

         LoadedTextures.GenerateGameTextures();
      }
   }
}


