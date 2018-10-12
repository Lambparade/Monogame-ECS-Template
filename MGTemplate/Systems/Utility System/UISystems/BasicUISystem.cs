using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Render_System;

using MGTemplate.Managers.UI_Managers;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Utility_System.UISystems
{
    public class BasicUISystem
    {
        public BasicUISystem()
        {

        }

        public bool ToggleControl(int ControlID)
        {
            return UIManager.CheckToggleControl(ControlID);
        }
    }
}