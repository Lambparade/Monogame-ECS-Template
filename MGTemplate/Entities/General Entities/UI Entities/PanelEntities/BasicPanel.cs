using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;

using MGTemplate.Managers.Graphics_Managers;
using MGTemplate.Managers.UI_Managers;

using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Utility_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.UI_Entities.PanelEntities
{
    //Panel is made up of multiple UI elements. A Container for UI elements.
    public class BasicPanel : UserControl
    {
        Hitbox PanelHitbox;
        public bool IsClicked;

        public BasicPanel(GameTexture PanelTexture, Position PanelPosition, bool isInCameraWorld, int RenderLayer, int ControlID) : base(isInCameraWorld, RenderLayer, ControlID)
        {
            GamePosition = new Position(PanelPosition.Location.X, PanelPosition.Location.Y);

            Graphic = new Sprite(PanelTexture, GamePosition, 4.0f);

            ActiveEntityDrawManager.AddToRenderQueue(this);

            UIManager.AddUIControl(this);
        }

        public override void Update(GameTime gameTime)
        {
            return;
        }

        public override void EditModeUpdate(GameTime gameTime)
        {
            PanelHitbox = HitboxUpdater.UpdateHitbox(GamePosition, 32 * 4, 32 * 4, this.InCameraWorld);

            IsFocused = ClickSystem.IsInFocus(PanelHitbox, this.InCameraWorld, IsFocused);

            if (IsFocused && ClickSystem.IsMouseDown())
            {
                MouseState CurrentMouseState = Mouse.GetState();

                PlaceGraphic(CurrentMouseState.X - 5, CurrentMouseState.Y - 16);
            }
        }
    }
}