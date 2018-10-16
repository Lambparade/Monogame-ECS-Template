using MGTemplate.Managers.Graphics_Managers;
using MGTemplate.Managers.UI_Managers;
using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Render_System;
using MGTemplate.Systems.Utility_System;

using MGTemplate.Systems.Utility_System.GameKeyboard;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


using static MGTemplate.GameObject.GameObjects;

namespace MGTemplate
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;

        SpriteBatch spriteBatch;

        SpriteFont debugfont;

        ActiveEntityDrawManager DrawManager = new ActiveEntityDrawManager();

        UIManager MasterUIManger = new UIManager();

        GameKeyboardSystem GameKeybaord = new GameKeyboardSystem();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = 288 * 2;
            graphics.PreferredBackBufferWidth = 512*2;

            Content.RootDirectory = "Content";

            IsMouseVisible = true;

            Window.IsBorderless = true;

            GameStateManager.ChangeGameState(GameStateManager.GameState.MainMenu);
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

            Debugger.AddDebug(GameStateManager.CurrentGameState.ToString());

            GameKeybaord.Update(gameTime);

            EntityUpdater.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            DrawManager.SendToRenderSystem();

            RenderSprites.Draw(spriteBatch, GraphicsDevice);

            base.Draw(gameTime);
        }
    }
}