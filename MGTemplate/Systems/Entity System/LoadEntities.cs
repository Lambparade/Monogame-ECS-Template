using System;
using System.Collections.Generic;

using MGTemplate.Components;

using MGTemplate.Systems.Content_System;

using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Entities.General_Entities.Player_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Entity_System
{
    public static class LoadEntities
    {
        public static void LoadPlayer()
        {
            Player Player1 = new Player(ContentTexture.RedBlock,new Position(10,10));
        }
    }
}