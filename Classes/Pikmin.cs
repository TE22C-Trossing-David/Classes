using Raylib_cs;
using System.Numerics;
using System.Reflection.Metadata;

public class Pikmin
{
    public string type = "";
    public int damage;
    public int throwLength;
    public int speed;
    public Texture2D currentImage;
    public int posX;
    public int posY;

    public Texture2D Blue = Raylib.LoadTexture("BluePikmin.png");
    public Rectangle pikminRect = new Rectangle();
    public Vector2 pikminPos = new Vector2();
    public void TypeAdvantage()
    {

        if (type == "TypeBlue")
        {
            currentImage = Blue;
            damage = 1;
            throwLength = 2;
            speed = 1;
        }



    }

    public void Update()
    {
        posX = 50;
        posY = 100;
    }

    public void Draw()
    {
        pikminPos = new Vector2(posX, posY);
        pikminRect = new Rectangle(0, 0, Blue.Width, Blue.Height);
        Raylib.DrawTextureRec(currentImage, pikminRect, pikminPos, Color.Blank);
    }
}