using System;
using System.Collections.Generic;

using MGTemplate.Entities.General_Entities;

using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Entity_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.Player_Entities
{
    public class Player : ActiveEntity
    {

        public Player(GameTexture PlayerTexture, Position StartPlayerPosition)
        {
            GamePosition = new Position(StartPlayerPosition.Location.X,StartPlayerPosition.Location.Y);

            Graphic = new Sprite(PlayerTexture, GamePosition, 1.0f);
        }

        public override void Update(GameTime gameTime)
        {
            MoveGraphic(1,5);
        }
    }
}