using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Utility_System;

using MGTemplate.Managers.Graphics_Managers;

using static MGTemplate.GameObject.GameObjects;

namespace MGTemplate
{
   public class Game1 : Game
   {
      GraphicsDeviceManager graphics;

      SpriteBatch spriteBatch;

      SpriteFont debugfont;

      public Game1()
      {
         graphics = new GraphicsDeviceManager(this);
         Content.RootDirectory = "Content";
         graphics.IsFullScreen = false;
         graphics.PreferredBackBufferHeight = 288;
         graphics.PreferredBackBufferWidth = 512;
         IsMouseVisible = true;
         Window.IsBorderless = true;
      }

      protected override void Initialize()
      {
         CameraSystem.StartCamera2d(graphics);

         base.Initialize();
      }

      protected override void LoadContent()
      {
         spriteBatch = new SpriteBatch(GraphicsDevice);

         debugfont = Content.Load<SpriteFont>("debugfont");

         ContentImages.Load(this);

         ContentFont.Load(this);

         AssignGameWindow(Window);

         AssignGraphicsDevice(GraphicsDevice);

         Debugger.StartDebugger(debugfont);

         LoadEntities.LoadPlayer();
      }

      protected override void Update(GameTime gameTime)
      {
         if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

         EntityUpdater.Update(gameTime);

         base.Update(gameTime);
      }

      protected override void Draw(GameTime gameTime)
      {
         GraphicsDevice.Clear(Color.Black);

         ActiveEntityDrawManager.SendToRenderSystem();

         RenderSprites.Draw(spriteBatch, GraphicsDevice);

         base.Draw(gameTime);
      }
   }
}
