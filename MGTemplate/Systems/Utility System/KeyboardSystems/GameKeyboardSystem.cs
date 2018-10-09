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

namespace MGTemplate.Systems.Utility_System.GameKeyboard
{
    public class GameKeyboardSystem
    {
        static KeyboardState OldKeyboardState = Keyboard.GetState();

        KeyboardState CurrentKeyboardState;

        public GameKeyboardSystem()
        {

        }

        public void Update(GameTime gameTime)
        {
            CurrentKeyboardState = Keyboard.GetState();

            if (IsKeyHeldDown(Keys.LeftControl))
            {
                if (IsKeyPressed(Keys.D))
                {
                    GameStateManager.ChangeGameState(GameStateManager.GameState.DebugMode);
                }
                if (IsKeyPressed(Keys.E))
                {
                    GameStateManager.ChangeGameState(GameStateManager.GameState.EditMode);
                }
                if (IsKeyPressed(Keys.A))
                {
                    GameStateManager.ChangeGameState(GameStateManager.GameState.Active);
                }
                if (IsKeyPressed(Keys.P))
                {
                    GameStateManager.ChangeGameState(GameStateManager.GameState.Pause);
                }
                if (IsKeyPressed(Keys.O))
                {
                    GameStateManager.ChangeGameState(GameStateManager.GameState.Options);
                }
                if (IsKeyPressed(Keys.M))
                {
                    GameStateManager.ChangeGameState(GameStateManager.GameState.MainMenu);
                }
            }

            OldKeyboardState = CurrentKeyboardState;
        }

        private bool IsKeyPressed(Keys SelectedKey)
        {
            bool isPressed = false;

            if (CurrentKeyboardState.IsKeyDown(SelectedKey) && OldKeyboardState.IsKeyUp(SelectedKey))
            {
                isPressed = true;
            }

            return isPressed;
        }

        private bool IsKeyHeldDown(Keys SelectedKey)
        {
            bool isPressed = false;

            if (CurrentKeyboardState.IsKeyDown(SelectedKey))
            {
                isPressed = true;
            }

            return isPressed;
        }
    }
}