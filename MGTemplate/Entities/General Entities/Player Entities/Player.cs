using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Managers.Graphics_Managers;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Utility_System.UISystems;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Entity_System.PlayerMovementSystems;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Utility_System;
using MGTemplate.Systems.Utility_System.EntityKeyboard;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.Player_Entities
{
    public class Player : ActiveEntity
    {
        Hitbox PlayerHitBox;

        int HitBoxWidth = 32;

        int HitBoxHeight = 32;

        BasicUISystem UserControlSystem = new BasicUISystem();

        EntityKeyboardSystem KeyboardSystem = new EntityKeyboardSystem();

        BasicMovementSystem MovementSystem;

        public Player(GameTexture PlayerTexture, Position StartPlayerPosition, bool isInCameraWorld, int RenderLayer) : base(isInCameraWorld, RenderLayer)
        {
            GamePosition = new Position(StartPlayerPosition.Location.X, StartPlayerPosition.Location.Y);

            Graphic = new Sprite(PlayerTexture, GamePosition, 1.0f);

            ActiveEntityDrawManager.AddToRenderQueue(this);

            MovementSystem = new BasicMovementSystem(GamePosition,Graphic);
        }

        public override void Update(GameTime gameTime)
        {
            PlayerHitBox = HitboxUpdater.UpdateHitbox(GamePosition,HitBoxWidth, HitBoxHeight, this.InCameraWorld);

            bool IsToggleButtonOn = UserControlSystem.ToggleControl(201);

            Movement();
        }

        public override void EditModeUpdate(GameTime gameTime)
        {

        }

        private void Movement()
        {
            KeyboardSystem.Update();

            if (KeyboardSystem.IsKeyHeldDown(Keys.Right))
            {
                MovementSystem.MoveRight();
            }
            if (KeyboardSystem.IsKeyHeldDown(Keys.Left))
            {
                MovementSystem.MoveLeft();
            }
            if (KeyboardSystem.IsKeyHeldDown(Keys.Up))
            {
                MovementSystem.MoveUp();
            }
            if (KeyboardSystem.IsKeyHeldDown(Keys.Down))
            {
                MovementSystem.MoveDown();
            }

            KeyboardSystem.UpdateKeyBoardState();
        }
    }
}