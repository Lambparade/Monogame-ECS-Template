using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Managers.Graphics_Managers;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Utility_System.UISystems;
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

        BasicUISystem UserControlSystem = new BasicUISystem();

        public Player(GameTexture PlayerTexture, Position StartPlayerPosition, bool isInCameraWorld, int RenderLayer) : base(isInCameraWorld, RenderLayer)
        {
            GamePosition = new Position(StartPlayerPosition.Location.X, StartPlayerPosition.Location.Y);

            Graphic = new Sprite(PlayerTexture, GamePosition, 1.0f);

            ActiveEntityDrawManager.AddToRenderQueue(this);
        }

        public override void Update(GameTime gameTime)
        {
            PlayerHitBox = HitboxUpdater.UpdateHitbox(GamePosition, 32, 32, this.InCameraWorld);

            //bool Click = ClickSystem.IsClickedOn(PlayerHitBox, this.InCameraWorld);

            bool IsToggleButtonOn = UserControlSystem.ToggleControl(201);

            if (IsToggleButtonOn)
            {
                Graphic.GraphicColor = Color.BlueViolet;
            }
            else
            {
                Graphic.GraphicColor = Color.White;
            }

            PlaceGraphic(1, 5);
        }

        public override void EditModeUpdate(GameTime gameTime)
        {

        }
    }
}