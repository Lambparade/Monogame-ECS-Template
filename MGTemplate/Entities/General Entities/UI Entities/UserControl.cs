using System;
using System.Collections.Generic;

using MGTemplate.Components;

using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Utility_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities.UI_Entities
{
    public abstract class UserControl : ActiveEntity
    {
        public int UserControlID { get; protected set; } = 0;
        public UserControl(bool isInCameraWorld, int RenderLayer,int ControlID) : base(isInCameraWorld, RenderLayer)
        {
            UserControlID = ControlID;
        }
    }
}