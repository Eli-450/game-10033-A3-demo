// Include the namespaces (code libraries) you need below.
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
   
    public class Game
    {
        Bats bats1 = new Bats();

        Bats bats2 = new Bats();
        Bats bats3 = new Bats();

        Bats bats4 = new Bats();

        smartphone1 phone = new smartphone1();

        CreepyEyeBall eye = new CreepyEyeBall();


        public void Setup()
        {
            
            Window.SetTitle("happy halloween");

            bats1.setup();
            bats2.setup();
            bats3.setup();
            bats4.setup();
            phone.setup();
            eye.setup();
            eye.setup();
        }

       
        public void Update()

        {
            Window.ClearBackground(Color.DarkGray);

            bats1.update();
            bats2.update();
            bats3.update();
            bats4.update();
            phone.update();
            eye.update();
            eye.update();


        }



    }
}
