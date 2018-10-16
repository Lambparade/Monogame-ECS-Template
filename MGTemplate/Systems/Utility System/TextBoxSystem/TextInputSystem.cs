using System;
using System.Collections.Generic;

using MGTemplate.Components;
using MGTemplate.Components.General_Components.SubComponents;
using MGTemplate.Entities.General_Entities;

using MGTemplate.Systems.Content_System;
using MGTemplate.Systems.Entity_System;
using MGTemplate.Systems.Render_System;
using MGTemplate;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using static MGTemplate.GameObject.GameObjects;

namespace MGTemplate.Systems.Utility_System
{
    public class TextInputSystem
    {
        EventHandler<TextInputEventArgs> onTextEntered;

        private string CurrentTextEntered = string.Empty;

        public string TextStringReturned = string.Empty;
        

        public bool IsTextBoxInfocus { get; set; }

        Cursor TestCursor;

        public int StringLength { get; set; }

        private GraphicsDevice InputSystemGraphicsDevice;

        public TextInputSystem()
        {
            TestCursor = new Cursor(Color.White, GetGameGraphicsDevice());

            IsTextBoxInfocus = false;

            AssignTextEvents(GetGameWindow());

            InputSystemGraphicsDevice = GetGameGraphicsDevice();
        }

        public void InputTextBox(bool IsInFocused, GameTime gametime, Sprite TextBoxSprite, Hitbox TextBoxHitbox)
        {
            IsTextBoxInfocus = IsInFocused;

            TestCursor.BlinkAnimation(gametime);

            RenderTarget2D TextboxGraphic = new RenderTarget2D(InputSystemGraphicsDevice, 100, 32);

            InputSystemGraphicsDevice.SetRenderTarget(TextboxGraphic);

            InputSystemGraphicsDevice.Clear(Color.Purple);

            SpriteBatch RenderSpriteBatch = new SpriteBatch(InputSystemGraphicsDevice);

            RenderSpriteBatch.Begin();

            RenderSpriteBatch.DrawString(ContentFont.SpriteFont,CurrentTextEntered, new Vector2(0, 8), Color.White);

            if (IsTextBoxInfocus)
            {
                RenderSpriteBatch.Draw(TestCursor.Texture, new Rectangle(StringLength, (int)TestCursor.CursorPosition.Y, 1, 32), Color.White);
            }

            RenderSpriteBatch.End();

            InputSystemGraphicsDevice.SetRenderTarget(null);

            Vector2 size = ContentFont.SpriteFont.MeasureString(CurrentTextEntered);

            StringLength = (int)size.X;

            TextBoxSprite.SpriteTexture = TextboxGraphic as Texture2D;
        }

        private void AssignTextEvents(GameWindow Window)
        {
            Window.TextInput += TextEntered;
            onTextEntered += HandleInput;
        }

        private void TextEntered(object sender, TextInputEventArgs e)
        {
            if (onTextEntered != null)
                onTextEntered.Invoke(sender, e);
        }

        private void HandleInput(object sender, TextInputEventArgs e)
        {
            if (IsTextBoxInfocus)
            {
                char charEntered = e.Character;

                if (e.Character == '\t')
                {
                    return;
                }
                if (e.Key == Keys.Escape)
                {
                    return;
                }
                else if (e.Character == '\b')
                {
                    DeleteChar();
                }
                else if (e.Character == '\r')
                {
                    TextStringReturned = CurrentTextEntered;
                    return;
                }
                else
                {
                    BuildString(charEntered);
                }
            }
        }

        private void BuildString(char CharEntered)
        {
            CurrentTextEntered += CharEntered.ToString();
        }

        private void DeleteChar()
        {
            if (!string.IsNullOrEmpty(CurrentTextEntered))
            {
                char LastKey = CurrentTextEntered[CurrentTextEntered.Length - 1];

                string NewText = CurrentTextEntered.Substring(0, CurrentTextEntered.Length - 1);

                CurrentTextEntered = NewText;
            }
        }
    }

    public class Cursor
    {
        public Texture2D Texture { get; set; }

        public Color CursorColor;

        public Vector2 CursorPosition { get; set; }

        private double TimeTillBlink = 0;

        private double BlinkSpeed = 530;

        public Cursor(Color Color, GraphicsDevice GD)
        {
            Texture = new Texture2D(GD, 1, 1);

            CursorPosition = new Vector2(0, 0);

            CursorColor = Color;

            SetColor(CursorColor);
        }

        private void BlinkCursor()
        {
            if (this.CursorColor == Color.Black)
            {
                this.CursorColor = Color.White;
                SetColor(CursorColor);
            }
            else
            {
                this.CursorColor = Color.Black;
                SetColor(CursorColor);
            }
        }

        private void SetColor(Color NewColor)
        {
            Texture.SetData(new[] { NewColor });
        }

        private void MoveCursor(float x, float y)
        {
            this.CursorPosition = new Vector2(CursorPosition.X + x, CursorPosition.Y + y);
        }

        internal void BlinkAnimation(GameTime gametime)
        {
            TimeTillBlink += gametime.ElapsedGameTime.TotalMilliseconds;

            if (TimeTillBlink > BlinkSpeed)
            {
                this.BlinkCursor();

                TimeTillBlink = 0;
            }
        }
    }
}
