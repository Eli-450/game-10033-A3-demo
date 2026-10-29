using System.Numerics;

namespace MohawkGame2D
{
    public class Bats
    {
        float speed = 200;
        Vector2 direction = new Vector2(0, 0);

        float x = 200;
        float y = 200;

        public void setup()
        {
            speed = Random.Float(50, 350);

            x = Random.Float(50, 350);
            randomizeNewBats();



        }
        public void update()
        {
            x += speed * Time.DeltaTime;

            if      (x > 450)
            {
                x = -50;

                randomizeNewBats();
            }
           
            

            DrawBat();
        }
        void randomizeNewBats()
        {
            
            y = Random.Float(50, 350);
        }
        void DrawBat()
        {
            int height = 10;
            Vector2 offset = new Vector2(0, -height);

            Draw.LineSize = 0;
            Draw.FillColor = Color.Black;

            Vector2 TopCirclePosition = new Vector2(x, y);
            TopCirclePosition += offset;

            Vector2 TopCircleSize = new Vector2(height);
            Draw.Circle(TopCirclePosition, height);

            Vector2 MiddleCirclePosition = new Vector2(x, y + 20);
            MiddleCirclePosition += offset;

            Vector2 MiddleCircleSize = new Vector2(height);
            Draw.Circle(MiddleCirclePosition, height);

            Vector2 BottomCirclePosition = new Vector2(x, y + 30);
            BottomCirclePosition += offset;

            Vector2 BottomCircleSize = new Vector2(height);
            Draw.Circle(BottomCirclePosition, height);

            Vector2 BottomCirclePosition2 = new Vector2(x, y + 40);
            BottomCirclePosition2 += offset;

            Vector2 BottomCircleSize2 = new Vector2(height);
            Draw.Circle(BottomCirclePosition2, height);

            Draw.FillColor = Color.Black;

            Vector2 BottomTriangle = new Vector2(x, y + 40);
            Draw.Triangle(new Vector2(x - 35, y + 50), new Vector2(x + 10, y + 20), new Vector2(x, y + 35));

            Vector2 TopLeftTriangle = new Vector2(x - 5, y - 5);
            Draw.Triangle(new Vector2(x - 15, y - 15), new Vector2(x - 25, y - 5), new Vector2(x - 5, y - 5));

            Vector2 TopRightTriangle = new Vector2(x + 5, y - 5);
            Draw.Triangle(new Vector2(x + 15, y - 15), new Vector2(x + 25, y - 5), new Vector2(x + 5, y - 5));
        }
    }
}
