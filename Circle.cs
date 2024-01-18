using System.DirectoryServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OO_2
{
    public class Circle
    {
        protected Texture2D texture; 

        protected Vector2 posistion; 

        protected Circle radius;

        protected Color color; 

        public Circle(Texture2D texture, Vector2 startPosition){
            this.texture=texture;
            posistion=startPosition;
            radius= new Circle (0,0,30,50);
            color=Color.White;
        }

        
    }
}