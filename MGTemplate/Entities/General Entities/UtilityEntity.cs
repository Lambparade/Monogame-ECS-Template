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
    public abstract class UtilityEntity : Entity
    {
        public Position GamePosition;

        public UtilityEntity()
        {

        }

        public abstract void Update(GameTime gameTime);
        
    }
}