using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities
    {
        public class ActiveEntity : Entity
        {
            public Sprite Graphic;

            public Position GamePosition;

            public ActiveEntity ()
            {

            }

            public virtual void Update (GameTime gameTime)
            {

            }

            public void MoveGraphic (float x, float y)
            {
                GamePosition = new Position (GamePosition.Location.X + x, GamePosition.Location.Y + y);

                Graphic.Position = GamePosition;
            }

            public void PlaceGraphic (float x, float y)
            {
                GamePosition = new Position(x,y);

                Graphic.Position = GamePosition;
            }
        }
    }