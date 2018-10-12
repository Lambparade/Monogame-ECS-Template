using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Systems.Render_System;
using MGTemplate.Entities.General_Entities.UI_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Managers.UI_Managers
{
    //UI manager speaks with UI system. UI system pulls buttons from UI manager. Detects if button is presed or toggled. Returns a bool to entity who called the system. Must assign correct ID!
    public class UIManager
    {
        static List<UserControl> ActiveUserControls = new List<UserControl>();

        //Will maybe use manager type later for a more modular system

        public static void AddUIControl(UserControl EntityToRender)
        {
            ActiveUserControls.Add(EntityToRender);
        }

        public static bool CheckToggleControl(int ControlID)
        {
            bool ControlToggled = false;

            foreach (UserControl Control in ActiveUserControls)
            {
                if (Control.UserControlID == ControlID)
                {
                    ControlToggled = (Control as ToggleButton).IsToggled;
                }
            }

            return ControlToggled;
        }
    }
}