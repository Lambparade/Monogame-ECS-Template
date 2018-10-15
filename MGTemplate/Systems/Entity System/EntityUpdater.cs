using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Entity_System
{
    public static class EntityUpdater
    {
        public static List<Entity> Entities = new List<Entity>();

        public static void AddToEntityUpdater(Entity EntitytoAdd)
        {
            Entities.Add(EntitytoAdd);
        }

        public static void Update(GameTime gameTime)
        {
            RemoveUnusedEntities();

            if (GameStateManager.CurrentGameState != GameStateManager.GameState.EditMode)
            {
                foreach (ActiveEntity e in Entities)
                {
                    e.Update(gameTime);
                }
            }
            else
            {
                foreach (ActiveEntity e in Entities)
                {
                    e.EditModeUpdate(gameTime);
                }
            }
        }

        private static void RemoveUnusedEntities()
        {
            foreach (ActiveEntity e in Entities.ToArray())
            {
                if (e.ToBeRemoved)
                {
                    Entities.Remove(e);
                }
            }

        }
    }
}
