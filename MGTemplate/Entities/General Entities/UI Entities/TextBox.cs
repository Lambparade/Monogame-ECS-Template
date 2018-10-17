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
    public class TextBox : UserControl
    {
        Hitbox TextBoxHitBox;

        int HitBoxWidth = 100;
        int HitBoxHeight = 32;

        TextInputSystem TextBoxInputSystem = new TextInputSystem();

        public string TextBoxInput;

        public TextBox(GameTexture TextBoxTexture, Position TextBoxPosition, bool isInCameraWorld, int RenderLayer,int ControlID) : base(isInCameraWorld,RenderLayer,ControlID)
        {
            GamePosition = new Position(TextBoxPosition.Location.X, TextBoxPosition.Location.Y);

            Graphic = new Sprite(TextBoxTexture, GamePosition, 1.0f);

            ActiveEntityDrawManager.AddToRenderQueue(this);

            UIManager.AddUIControl(this);
        }

        public override void Update(GameTime gameTime)
        {
            TextBoxHitBox = HitboxUpdater.UpdateHitbox(GamePosition,HitBoxWidth, HitBoxHeight, this.InCameraWorld);

            IsFocused = ClickSystem.IsInFocus(TextBoxHitBox, this.InCameraWorld, IsFocused);

            TextBoxInputSystem.InputTextBox(IsFocused, gameTime, Graphic, TextBoxHitBox);

            TextBoxInput = TextBoxInputSystem.TextStringReturned;
        }

        public override void EditModeUpdate(GameTime gameTime)
        {
            TextBoxHitBox = HitboxUpdater.UpdateHitbox(GamePosition, 100, 32, this.InCameraWorld);

            IsFocused = ClickSystem.IsInFocus(TextBoxHitBox, this.InCameraWorld, IsFocused);

            if (IsFocused && ClickSystem.IsMouseDown())
            {
                MouseState CurrentMouseState = Mouse.GetState();

                PlaceGraphic(CurrentMouseState.X - 5, CurrentMouseState.Y - 16);
            }
        }
    }
}