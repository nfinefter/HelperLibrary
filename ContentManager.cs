using Microsoft.Xna.Framework.Graphics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{ 
    public class ContentManager<T> where T : Enum
    {
        public Texture2D this[T wantedTexture]
        {
            get
            {
                return Textures[wantedTexture];
            }
            set
            {
                Textures[wantedTexture] = value;
            }
        }

        private Dictionary<T, Texture2D> Textures = new Dictionary<T, Texture2D>();
        
        private ContentManager()
        {
            
        }
        public static ContentManager<T> Instance { get;} = new ContentManager<T>();

    }
}
