using System.Numerics;

namespace MohawkGame2D
{
    public class smartphone1
    {
        public void setup()
        {
            Window.SetSize(400, 380);
            Window.SetTitle("happy halloween");
        }
        int runCount = 0;
        public void update()
        {
            DrawSmartphone();


        }
        void DrawSmartphone()
        {
            

            Draw.FillColor = Color.Black;
            Draw.Rectangle(270, 60, 75, 175);

            Draw.FillColor = Color.White;
            Draw.Rectangle(276, 73, 63, 140);

            Draw.FillColor = Color.White;
            Draw.Circle(new Vector2(307, 224), 4);

            if (Input.IsMouseButtonPressed(MouseButton.Left))
            {
                Vector2 mouse = Input.GetMousePosition();

                if (mouse.X > 270 && mouse.X < 345 && mouse.Y > 60 && mouse.Y < 235)
                {
                    runCount++;
                }

            }
            Draw.FillColor = Color.Black;

            for (int i = 0; i < runCount && i < 7; i++)
            {
                Text.Size = 12;
                Text.Draw("RUN!", new Vector2(280, 80 + i * 20));
            }
        }

    }
 
}
