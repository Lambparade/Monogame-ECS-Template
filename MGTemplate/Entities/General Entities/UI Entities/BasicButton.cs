using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;

using MGTemplate.Managers.Graphics_Managers;
using MGTemplate.Managers.UI_Managers;

using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Utility_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.UI_Entities
{
    public class BasicButton : UserControl
    {
        Hitbox ButtonHitbox;

        int HitBoxWidth = 32;

        int HitBoxHeight = 32;

        public bool IsClicked;

        public BasicButton(GameTexture ButtonTexture, Position ButtonPosition, bool isInCameraWorld, int RenderLayer, int ControlID) : base(isInCameraWorld, RenderLayer,ControlID)
        {
            GamePosition = new Position(ButtonPosition.Location.X, ButtonPosition.Location.Y);

            Graphic = new Sprite(ButtonTexture, GamePosition, 1.0f);

            ActiveEntityDrawManager.AddToRenderQueue(this);

            UIManager.AddUIControl(this);
        }

        public override void Update(GameTime GameTime)
        {
            ButtonHitbox = HitboxUpdater.UpdateHitbox(GamePosition, HitBoxWidth, HitBoxHeight, this.InCameraWorld);

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