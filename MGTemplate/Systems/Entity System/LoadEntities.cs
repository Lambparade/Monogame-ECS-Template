using System;
using System.Collections.Generic;

using MGTemplate.Components;

using MGTemplate.Systems.Content_System;

using MGTemplate.Managers.Graphics_Managers;

using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Entities.General_Entities.Player_Entities;
using MGTemplate.Entities.General_Entities.UI_Entities;
using MGTemplate.Entities.General_Entities.UI_Entities.PanelEntities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Entity_System
{
    public static class LoadEntities
    {
        public static void LoadPlayer()
        {
            Player Player1 = new Player(LoadedTextures.RedBlock, new Position(10, 10), true, 1);

            Player Player2 = new Player(LoadedTextures.RedBlock, new Position(100, 10), true, 1);

            BasicPanel Panel = new BasicPanel(LoadedTextures.RedBlock, new Position(225, 118), false, 1, 401);

            BasicButton Button1 = new BasicButton(LoadedTextures.BlueBlock, new Position(25, 50), false, 1, 101);

            BasicButton Button2 = new BasicButton(LoadedTextures.BlueBlock, new Position(25, 118), false, 1, 102);

            ToggleButton ToggleButton = new ToggleButton(LoadedTextures.BlueBlock, new Position(25, 84), false, 1, 201);

            TextBox Box = new TextBox(LoadedTextures.WhiteBlock, new Position(125, 84), false, 1, 301);

            TextBox Boxd = new TextBox(LoadedTextures.WhiteBlock, new Position(125, 118), false, 1, 302);
        }

        public static void LoadEntity()
        {

        }
    }
}