using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Components
{
    public class Position : Component
    {
        public Vector2 Location
        {
            get;
            set;
        }

        public Position (float X,float Y)
        {
            Location = new Vector2(X,Y);
        }
    }
}