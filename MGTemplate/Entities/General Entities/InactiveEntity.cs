using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Entity_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.General_Entities
{
    public abstract class InActiveEntity : Entity
    {
        public abstract Sprite Graphic {get;set;}

        public Position GamePosition;

        public InActiveEntity()
        {
            //EntityUpdater.AddToEntityUpdater(this);
        }
    }
}