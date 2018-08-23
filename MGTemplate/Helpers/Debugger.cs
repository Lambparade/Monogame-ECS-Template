using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate
{
    class Debugger
    {
        static SpriteFont font;
        static Texture2D Pixel;
        static List<string> debugstrings = new List<string>();
        static List<string> debugstringsConsistant = new List<string>();
        static List<Rectangle> debugbounds = new List<Rectangle>();
        static public bool EnableDebugger { get; set; }


        static public void StartDebugger(SpriteFont debugfont)
        {
            EnableDebugger = true;
            font = debugfont;
        }

        public static void DrawDebugStrings(SpriteBatch spritebatch)
        {
            spritebatch.Begin();

            for (int i = 0; i < debugstrings.Count; i++)
            {
                spritebatch.DrawString(font, debugstrings[i], new Vector2(260, 5 + (15 * i)), Color.White);
            }

            for (int i = 0; i < debugstringsConsistant.Count; i++)
            {
                spritebatch.DrawString(font, debugstringsConsistant[i], new Vector2(400, 5 + (15 * i)), Color.Blue);
            }

            spritebatch.End();

            debugstrings.Clear();
        }

        public static void AddDebug(string adebugstring)
        {
            debugstrings.Add(adebugstring);
        }

        public static void AddDebugConsistant(string adebugstring)
        {
            debugstringsConsistant.Add(adebugstring);
        }

        public static void ClearConsistantDebug()
        {
            debugstringsConsistant.Clear();
        }
    }
}