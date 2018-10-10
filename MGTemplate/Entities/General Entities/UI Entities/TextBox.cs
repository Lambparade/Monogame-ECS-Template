using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Managers.Graphics_Managers;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Utility_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.UI_Entities
{
    public class TextBox : ActiveEntity
    {
        Hitbox TextBoxHitBox;

        public bool IsFocused;

        TextInputSystem TextBoxInputSystem = new TextInputSystem ();

        public TextBox (GameTexture TextBoxTexture, Position TextBoxPosition, bool IsClickable, bool isInCameraWorld,int RenderLayer) : base (IsClickable, isInCameraWorld,RenderLayer)
        {
            GamePosition = new Position (TextBoxPosition.Location.X, TextBoxPosition.Location.Y);

            Graphic = new Sprite (TextBoxTexture, GamePosition, 1.0f);

            ActiveEntityDrawManager.AddToRenderQueue (this);
        }

        public override void Update (GameTime GameTime)
        {
            TextBoxHitBox = HitboxUpdater.UpdateHitbox (GamePosition, 100, 32, this.InCameraWorld);

            IsFocused = ClickSystem.IsInFocus (TextBoxHitBox, this.InCameraWorld, IsFocused);

            TextBoxInputSystem.InputTextBox (IsFocused, GameTime, Graphic, TextBoxHitBox);
        }
        
        public override void EditModeUpdate(GameTime gameTime)
        {
            TextBoxHitBox = HitboxUpdater.UpdateHitbox(GamePosition, 100, 32, this.InCameraWorld);

            IsFocused = ClickSystem.IsInFocus(TextBoxHitBox,this.InCameraWorld,IsFocused);

            if (IsFocused && ClickSystem.IsMouseDown())
            {
                MouseState CurrentMouseState = Mouse.GetState();

                PlaceGraphic(CurrentMouseState.X - 5, CurrentMouseState.Y -16);
            }
        }
    }
}