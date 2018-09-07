using System;
using System.Collections.Generic;
using System.Text;
using MGTemplate;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.GameObject
{
   public static class GameObjects
   {
      private static GameWindow MainGameWindow { get; set; }

      private static GraphicsDevice MainGraphicDevice { get; set; }

      public static void AssignGameWindow(GameWindow gameWindow)
      {
         MainGameWindow = gameWindow;
      }

      public static void AssignGraphicsDevice(GraphicsDevice graphicsDevice)
      {
         MainGraphicDevice = graphicsDevice;
      }

      public static GameWindow GetGameWindow()
      {
         return MainGameWindow;
      }

      public static GraphicsDevice GetGameGraphicsDevice()
      {
         return MainGraphicDevice;
      }
   }
}



