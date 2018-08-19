using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Entity_System
{
    static public class HitboxUpdater
    {
        public static Hitbox UpdateHitbox (Position EntityPosition, int HitboxWidth, int HitboxHeight, GameTime gameTime)
        {
            Hitbox UpdatedHitbox = new Hitbox (new Rectangle ((int) EntityPosition.Location.X, (int) EntityPosition.Location.Y, HitboxWidth, HitboxHeight));

            return UpdatedHitbox;
        }
    }
}