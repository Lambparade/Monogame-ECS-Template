using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Utility_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.Player_Entities
{
    public class Player : ActiveEntity
    {
        Hitbox PlayerHitBox;

        public Player (GameTexture PlayerTexture, Position StartPlayerPosition, bool IsClickable, bool isInCameraWorld) : base (IsClickable, isInCameraWorld)
        {
            GamePosition = new Position (StartPlayerPosition.Location.X, StartPlayerPosition.Location.Y);

            Graphic = new Sprite (PlayerTexture, GamePosition, 1.0f);

            EntityUpdater.AddToEntityUpdater (this);
        }

        public override void Update (GameTime gameTime)
        {
            PlayerHitBox = HitboxUpdater.UpdateHitbox(GamePosition,32,32,gameTime);

            bool Click = ClickSystem.IsClickedOn(PlayerHitBox,this.InCameraWorld);

            //Add systems....Movement,
            PlaceGraphic (1, 5);
        }
    }
}