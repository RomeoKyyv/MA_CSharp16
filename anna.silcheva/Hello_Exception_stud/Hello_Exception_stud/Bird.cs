using System;

namespace  Hello_Exception_stud
{
    //Create the Bird class with the fields, properties, constructors and the method
    class Bird
    {
        public int[] FlySpeed = { 5, 15, 25, 35 };
        public int NormalSpeed { get; set; }
        protected string Nick {  get; set; }
        private bool BirdFlewAway;
        public Bird() { }
        public Bird(string name, int speed)
        {
            NormalSpeed = speed;
            Nick = name;
        }

        //The public void FlyAway( int incrmnt ) method generates custom exception 
        //Create fields and properties

        //Create constructors

        //Implement Method public void FlyAway( int incrmnt ) which check Bird state by reading field  BirdFlewAway

        // check BirdFlewAway
        // if true 

        // write the message to console
        // else

        // increment the Bird speed by method argument
        public void FlyAway(int incrmnt)
        {
            if (BirdFlewAway == true)
            {
                Console.WriteLine(" the message");
            }
            else
            {
                NormalSpeed += incrmnt;
                if (NormalSpeed >= FlySpeed[3])
                {
                    BirdFlewAway = true;
                    throw new BirdFlewAwayException(string.Format("{0} flew with incredible speed!", Nick), "Oh! Startle.", DateTime.Now);
                }
                else
                {
                    Console.WriteLine(FlySpeed);
                }
            }
        }
        }
 

 
    // check the condition (NormalSpeed >= FlySpeed[3]) 
    // If it's true 
    // BirdFlewAway = true and we generate custom exception    BirdFlewAwayException(string.Format("{0} flew with incredible speed!", Nick), "Oh! Startle.", DateTime.Now)
    // with HelpLink = "http://en.wikipedia.org/wiki/Tufted_titmouse" else  console.writeline about Bird speed 


}
