using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using TestGL.Components.General_Components.SubComponents;

namespace TestGL.Systems.Content_System
{
    static public class ContentTexture
    {
        public static GameTexture RedBlock
        {
            get;
            set;
        }
        public static GameTexture BlueBlock
        {
            get;
            set;
        }
        public static GameTexture WhiteBlock
        {
            get;
            set;
        }

        public static void GenerateGameTextures()
        {

            RedBlock = new GameTexture(ContentImages.SpriteSheet,new Rectangle(32,0,32,32));

        }
    }
}