using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Entities;
using MGTemplate.Entities.General_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Render_System
{
    public static class CameraSystem
    {
      static float CameraZoom; // Camera Zoom
      public static Matrix CameraTransform; // Matrix Transform
      public static Vector2 CameraPosition; // Camera Position
      static float CameraRotation; // Camera Rotation

      static public float DefaultZoom { get; } = 4;
      static public Vector2 DefaultCameraPos { get; set; }
      public static void StartCamera2d(GraphicsDeviceManager graphics)
      {
         CameraZoom = 4.0f;
         CameraRotation = 0.0f;
         CameraPosition = new Vector2(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight / 2);
         DefaultCameraPos = CameraPosition;
      }

      public static float Zoom
      {
         get { return CameraZoom; }
         set { CameraZoom = value; if (CameraZoom < 0.1f) CameraZoom = 0.1f; } // Negative zoom will flip image
      }

      public static float Rotation
      {
         get { return CameraRotation; }
         set { CameraRotation = value; }
      }

      // Auxiliary function to move the camera
      public static void Move(float X, float Y)
      {
          Vector2 amount = new Vector2(X,Y);

         CameraPosition += amount;
      }
      // Get set position
      public static Vector2 Pos
      {
         get { return CameraPosition; }
         set { CameraPosition = value; }
      }
      public static Matrix get_transformation(GraphicsDevice graphicsDevice)
      {
         CameraTransform =       
           Matrix.CreateTranslation(new Vector3((int)-CameraPosition.X, (int)-CameraPosition.Y, (int)0)) *
                                      Matrix.CreateRotationZ((int)Rotation) *
                                      Matrix.CreateScale(new Vector3(Zoom / 4, Zoom / 4, 1)) *
                                      Matrix.CreateTranslation(new Vector3((int)graphicsDevice.Viewport.Width * 0.5f, (int)graphicsDevice.Viewport.Height * 0.5f, 0));
         return CameraTransform;
      }
    }
}