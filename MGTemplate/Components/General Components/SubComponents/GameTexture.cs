using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestGL.Components.General_Components.SubComponents
{
    public class GameTexture : Component
    {
        public Texture2D ContentTexture;

        public Rectangle ContentSource;

        public GameTexture (Texture2D ContentImage,Rectangle SourceRectangle)
        {
            ContentTexture = ContentImage;

            ContentSource = SourceRectangle;
        }
    }
}