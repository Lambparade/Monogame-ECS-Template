using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Components
{
    public class Hitbox : Component
    {
        public Rectangle Bounds;

        public Hitbox(Rectangle DesiredBounds)
        {
            Bounds = DesiredBounds;
        }
    }
}