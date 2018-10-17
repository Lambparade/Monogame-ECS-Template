using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Render_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Entity_System.PlayerMovementSystems
{
    public class BasicMovementSystem
    {
        Position CurrentGamePosition;
        Sprite CurrentGraphic;

        int XSpeed = 5;

        int YSpeed = 5;

        public BasicMovementSystem(Position gamePosition, Sprite currentGraphic)
        {
            CurrentGamePosition = gamePosition;

            CurrentGraphic = currentGraphic;
        }

        public void MoveLeft()
        {
            MoveGraphic(-XSpeed,0);
        }
        public void MoveRight()
        {
            MoveGraphic(XSpeed,0);
        }
        public void MoveUp()
        {
            MoveGraphic(0,-YSpeed);
        }
        public void MoveDown()
        {
            MoveGraphic(0,YSpeed);
        }

        private void MoveGraphic(float x, float y)
        {
            CurrentGamePosition = new Position(CurrentGamePosition.Location.X + x, CurrentGamePosition.Location.Y + y);

            CurrentGraphic.Position = CurrentGamePosition;
        }
    }
}