using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;
using MGTemplate.Systems.Entity_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGTemplate.Systems.Utility_System.EntityKeyboard
{
    public class EntityKeyboardSystem
    {
        KeyboardState OldKeyboardState = Keyboard.GetState();

        KeyboardState CurrentKeyboardState;

        public void Update()
        {
            CurrentKeyboardState = Keyboard.GetState();
        }

        public void UpdateKeyBoardState()
        {
            OldKeyboardState = CurrentKeyboardState;
        }

        public bool IsKeyPressed(Keys SelectedKey)
        {
            bool isPressed = false;

            if (CurrentKeyboardState.IsKeyDown(SelectedKey) && OldKeyboardState.IsKeyUp(SelectedKey))
            {
                isPressed = true;
            }



            return isPressed;
        }

        public bool IsKeyHeldDown(Keys SelectedKey)
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