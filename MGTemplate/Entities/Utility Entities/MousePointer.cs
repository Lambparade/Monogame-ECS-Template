using MGTemplate.Components;
using MGTemplate.Entities.General_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.Utility_Entities
{
    public class MousePointer : ActiveEntity
    {
        public Hitbox MouseHitbox;
        public MousePointer(Rectangle HitBoxBounds, Position StartingPosition)
        {
            MouseHitbox = new Hitbox(HitBoxBounds);

            GamePosition = StartingPosition;
        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}