using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Managers.Graphics_Managers;
using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Utility_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.UI_Entities
{
    public class BasicButton : ActiveEntity
    {
        Hitbox ButtonHitbox;

        public bool IsClicked;
        public bool IsFocused;

        public BasicButton(GameTexture ButtonTexture, Position ButtonPosition, bool IsClickable, bool isInCameraWorld) : base(IsClickable, isInCameraWorld)
        {
            IsClicked = false;

            GamePosition = new Position(ButtonPosition.Location.X, ButtonPosition.Location.Y);

            Graphic = new Sprite(ButtonTexture, GamePosition, 1.0f);

            ActiveEntityDrawManager.AddToRenderQueue(this);
        }

        public override void Update(GameTime GameTime)
        {
            ButtonHitbox = HitboxUpdater.UpdateHitbox(GamePosition, 32, 32, this.InCameraWorld);

            IsClicked = ClickSystem.IsClickedOn(ButtonHitbox, this.InCameraWorld);

            if (IsClicked)
            {
                Graphic.GraphicColor = new Color(Color.OrangeRed, 255);
            }
            else
            {
                Graphic.GraphicColor = new Color(Color.White, 255);
            }
        }

        public override void EditModeUpdate(GameTime gameTime)
        {
            ButtonHitbox = HitboxUpdater.UpdateHitbox(GamePosition, 32, 32, this.InCameraWorld);

            IsFocused = ClickSystem.IsInFocus(ButtonHitbox, this.InCameraWorld, IsFocused);

            if (IsFocused && ClickSystem.IsMouseDown())
            {
                MouseState CurrentMouseState = Mouse.GetState();

                PlaceGraphic(CurrentMouseState.X - 5, CurrentMouseState.Y - 16);
            }
        }
    }
}