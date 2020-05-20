﻿using System.Numerics;
using Chroma.Graphics;
using Chroma.Graphics.TextRendering;

namespace Chroma.UI.Controls
{
    public class Label : ChromaControl
    {
        public string Text;
        public Color Color;
        public TrueTypeFont Font;

        public Label(Vector2 position, string text, TrueTypeFont font = null, int fontSize = 12) : base(position, Vector2.One)
        {
            Text = text;
            Color = Color.White;
            Font = font ?? new TrueTypeFont(UiContentLoader.Instance.DefaultFontPath, fontSize);
            Font.Size = fontSize;
        }

        public override void Draw(RenderContext context)
        {
            context.DrawString(Font,
                Text,
                CalculatedPosition,
                (c, i, arg3, arg4) =>
                    new GlyphTransformData(arg3) {Color = Color});

            base.Draw(context);
        }
    }
}