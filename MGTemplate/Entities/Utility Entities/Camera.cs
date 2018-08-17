using MGTemplate.Components;
using MGTemplate.Entities.General_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Entities.Utility_Entities
{
    public class Camera : UtilityEntity
    {
        public float Zoom;
        
        public float Rotation;

        public float DefaultZoom;

        public float DefaultRotation;

        public Position DefaultGamePoistion;

        public Camera()
        {

        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}