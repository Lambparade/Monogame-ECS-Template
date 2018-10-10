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
    public class ActiveEntityDrawManager
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

        public void SendToRenderSystem()
        {
            foreach (ActiveEntity s in EntitiesToManage)
            {
                if (s.InCameraWorld)
                {
                    AssignCameraLayers(s);
                }
                else
                {
                    AssignHudLayers(s);
                }
            }
        }

        private void AssignCameraLayers(ActiveEntity EntityToRender)
        {
            switch (EntityToRender.CurrentRenderLayer)
            {
                case 1:
                    RenderSprites.AddToLayer(RenderSprites.CameraLayer1, EntityToRender.Graphic);
                    break;

                case 2:
                    RenderSprites.AddToLayer(RenderSprites.CameraLayer2, EntityToRender.Graphic);
                    break;

                case 3:
                    RenderSprites.AddToLayer(RenderSprites.CameraLayer3, EntityToRender.Graphic);
                    break;

                case 4:
                    RenderSprites.AddToLayer(RenderSprites.CameraLayer4, EntityToRender.Graphic);
                    break;

                case 5:
                    RenderSprites.AddToLayer(RenderSprites.CameraLayer5, EntityToRender.Graphic);
                    break;

                default:
                    RenderSprites.AddToLayer(RenderSprites.CameraLayer1, EntityToRender.Graphic);
                    break;
            }
        }

        private void AssignHudLayers(ActiveEntity EntityToRender)
        {
            switch (EntityToRender.CurrentRenderLayer)
            {
                case 1:
                    RenderSprites.AddToLayer(RenderSprites.HudLayer1, EntityToRender.Graphic);
                    break;

                case 2:
                    RenderSprites.AddToLayer(RenderSprites.HudLayer2, EntityToRender.Graphic);
                    break;

                case 3:
                    RenderSprites.AddToLayer(RenderSprites.HudLayer3, EntityToRender.Graphic);
                    break;

                case 4:
                    RenderSprites.AddToLayer(RenderSprites.HudLayer4, EntityToRender.Graphic);
                    break;

                case 5:
                    RenderSprites.AddToLayer(RenderSprites.HudLayer5, EntityToRender.Graphic);
                    break;

                default:
                    RenderSprites.AddToLayer(RenderSprites.HudLayer1, EntityToRender.Graphic);
                    break;
            }
        }
    }
}