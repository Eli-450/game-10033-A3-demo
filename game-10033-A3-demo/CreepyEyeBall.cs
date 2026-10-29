

using System.ComponentModel.Design;
using System.Numerics;
using MohawkGame2D;

namespace MohawkGame2D
{
    public class CreepyEyeBall
    {
       
        public void setup()
        {

            Color randomColor = Random.Color();
            Draw.FillColor = randomColor;
            



        }
        public void update()
        {
            Color randomColor = Random.Color();
            Draw.FillColor = randomColor;




            DrawCreepyEyeBall();

            }
        void DrawCreepyEyeBall()
        {
            
            int bigHeight = 50;
            int mediumHeight = 25;
            int smallHeight = 10;
            Vector2 offset = new Vector2(0, -bigHeight);

            Vector2 mousePosition = Input.GetMousePosition();
            Vector2 mouseOffset = new Vector2(mousePosition.X - 200, mousePosition.Y - 150);

            
            Draw.LineSize = 4;

            Vector2 BigCirclePosition = new Vector2( mousePosition.X, mousePosition.Y );
            BigCirclePosition += offset;

            Vector2 BigCircleSize = new Vector2(bigHeight);
            Draw.Circle(BigCirclePosition, bigHeight);

            
            Draw.LineSize = 3;

            Vector2 mediumCirclePosition2 = new Vector2( mousePosition.X, mousePosition.Y );
            mediumCirclePosition2 += offset;
            Draw.Circle(mediumCirclePosition2, mediumHeight);

            

            Vector2 smallCirclePosition2 = new Vector2( mousePosition.X, mousePosition.Y );
            smallCirclePosition2 += offset;
            Draw.Circle(smallCirclePosition2, smallHeight);

            
            Draw.LineSize = 4;

            Vector2 mousePosition2 = Input.GetMousePosition();
            Vector2 mouseOffset2 = new Vector2(mousePosition2.X  - 250 , mousePosition2.Y + 150);

            BigCirclePosition = new Vector2(mousePosition2.X - 250, mousePosition2.Y + 150);
            BigCirclePosition += offset;
            Draw.Circle(BigCirclePosition, bigHeight);

           
            Draw.LineSize = 3;

            mediumCirclePosition2 = new Vector2(mousePosition2.X  - 250, mousePosition2.Y + 150);
            mediumCirclePosition2 += offset;
            Draw.Circle(mediumCirclePosition2, mediumHeight);

            

            smallCirclePosition2 = new Vector2(mousePosition2.X  - 250, mousePosition2.Y +  150);
            smallCirclePosition2 += offset;
            Draw.Circle(smallCirclePosition2, smallHeight);

           
            

        }
    }
}
