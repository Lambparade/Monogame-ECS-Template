using System;
using System.Collections.Generic;

using MGTemplate.Components;

using MGTemplate.Systems.Content_System;

using MGTemplate.Managers.Graphics_Managers;

using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Entities.General_Entities.Player_Entities;
using MGTemplate.Entities.General_Entities.UI_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Entity_System
{
    public static class LoadEntities
    {
        public static void LoadPlayer()
        {
            Player Player1 = new Player(ContentTexture.RedBlock, new Position(10, 10),true,true);

            BasicButton Button1 = new BasicButton(ContentTexture.BlueBlock,new Position(25,50),true,false);
            BasicButton Button2 = new BasicButton(ContentTexture.BlueBlock,new Position(25,118),true,false);

            ToggleButton ToggleButton = new ToggleButton(ContentTexture.BlueBlock,new Position(25,84),true,false);
        }

        public static void LoadEntity()
        {

        }
    }
}