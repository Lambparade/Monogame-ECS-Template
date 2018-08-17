using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Systems.Render_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Managers.Graphics_Managers
{
    public static class ActiveEntityDrawManager
    {
        static List<ActiveEntity> EntitiesToManage = new List<ActiveEntity>();


        //Will maybe use manager type later for a more modular system
        public enum ManagerType
        {
            Basic
        }

        private static ManagerType CurrentType = new ManagerType();

        public static void AddToRenderQueue(ActiveEntity EntityToRender)
        {
            EntitiesToManage.Add(EntityToRender);
        }

        public static void SendToRenderSystem()
        {
            foreach (ActiveEntity s in EntitiesToManage)
            {
                RenderSprites.AddToLayer(RenderSprites.Layer1, s.Graphic);
            }
        }
    }
}