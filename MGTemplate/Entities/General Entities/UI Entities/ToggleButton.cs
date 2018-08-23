
using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Utility_System;

using MGTemplate.Managers.Graphics_Managers;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.UI_Entities
{
    public class ToggleButton : ActiveEntity
    {
        Hitbox ButtonHitbox;
        public bool IsClicked;
        public ToggleButton(GameTexture ButtonTexture, Position ButtonPosition, bool IsClickable, bool isInCameraWorld) : base (IsClickable, isInCameraWorld)
        {
            IsClicked = false;
            
            GamePosition = new Position (ButtonPosition.Location.X, ButtonPosition.Location.Y);

            Graphic = new Sprite (ButtonTexture, GamePosition, 1.0f);

            ActiveEntityDrawManager.AddToRenderQueue(this);
        }

        public override void Update(GameTime gamtime)
        {
            ButtonHitbox = HitboxUpdater.UpdateHitbox(GamePosition,32,32,this.InCameraWorld);

            IsClicked = ClickSystem.IsClickedOn(ButtonHitbox,this.InCameraWorld);
        }
    }
}