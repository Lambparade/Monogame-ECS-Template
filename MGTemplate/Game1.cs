using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Entity_System;

using MGTemplate.Managers.Graphics_Managers;

namespace MGTemplate
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            IsMouseVisible = true;
            Window.IsBorderless = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            ContentImages.Load(this);

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

            RenderSprites.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
