using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public sealed class GameFont : GameObject
    {
        SpriteFont Font; 
        public string Text;

        public override Vector2 Origin => throw new NotImplementedException();

        public override Rectangle? SourceRectangle => throw new NotImplementedException();

        public GameFont(SpriteFont font, string text, Rectangle pos, Color color, float rotation)
            : base(pos, color, rotation)
        {
            Font = font;
            Text = text;
        }

        public void DrawString(SpriteBatch sb)
        {
            sb.DrawString(Font, Text, new Vector2(Pos.X, Pos.Y), Color);
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
