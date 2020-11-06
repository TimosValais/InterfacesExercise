using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
    class Boat : AutoMobile, IAutoMobileActions, IBoatActions
    {

        public Boat()
        {

        }

        public Boat(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        public void SteerLeft()
        {
            Console.WriteLine("The Boat is steering left");
        }

        public void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }

        public void SteerRight()
        {
            Console.WriteLine("The Boat is steering right");
        }

        public void Steer(bool steerLeft)
        {
            this.Steering = steerLeft;
            if (this.Steering == true)
            {
                Console.WriteLine("The Boat is steering left");
            }

            else
                Console.WriteLine("The Boat is steering right");

        }
    }
}
