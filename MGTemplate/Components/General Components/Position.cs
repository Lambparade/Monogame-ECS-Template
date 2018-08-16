using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestGL.Components
{
    public class Position : Component
    {
        public Vector2 Location
        {
            get;
            set;
        }

        public Position (Vector2 StartPosition)
        {
            Location = new Vector2(StartPosition.X,StartPosition.Y);
        }
    }
}