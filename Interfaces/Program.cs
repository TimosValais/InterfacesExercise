using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // NO NO can't have instances of an abstract class or interface
            //AutoMobile auto = new AutoMobile();

            Console.WriteLine("car");
            Car car = new Car(true);
            car.Start();
            car.SteerLeft();
            car.SteerRight();
            car.Steer(false);
            car.Steer(true);
            car.Reverse();
            car.Break();
            car.Stop();

            Console.WriteLine("moto");

            MotorBike moto = new MotorBike(true);
            moto.Start();
            moto.SteerLeft();
            moto.SteerRight();
            moto.Steer(false);
            moto.Steer(true);
            moto.Break();
            moto.Stop();

            Console.WriteLine("boat");

            Boat boat = new Boat(true);
            boat.Start();
            boat.SteerLeft();
            boat.SteerRight();
            boat.Steer(false);
            boat.Steer(true);
            boat.Reverse();
            boat.Stop();


            //Console.WriteLine("car car");
            //Car car = new Car();
            //Console.WriteLine(car.IsOn);
            //car.Start();
            //car.SteerLeft();
            //Console.WriteLine(car.IsOn);

            //// with private set doesn't work
            ////car.IsOn = false;

            //car.Stop();
            //Console.WriteLine(car.IsOn);

            //Console.WriteLine("motorbike moto");
            //MotorBike moto = new MotorBike();
            //moto.Start();
            //moto.SteerLeft();
            //Console.WriteLine(moto.IsOn);

            //Console.WriteLine("motorbike moto2");
            //MotorBike moto2 = new MotorBike(true);
            //Console.WriteLine(moto2.IsOn);
            //moto2.SteerLeft();
            //moto2.Stop();
            //Console.WriteLine(moto2.IsOn);
            //car.Steer(true);
            //moto.Steer(false);



            Console.ReadLine();

        }
    }
}
