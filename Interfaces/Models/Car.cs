﻿using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
	class Car : AutoMobile, IAutoMobileActions, ICarActions
	{


		public Car()
		{

		}

		public Car(bool IsOn)
		{
			this.IsOn = IsOn;
		}

		public void SteerLeft()
		{
			Console.WriteLine("The car is steering left");
		}

		public void Break()
		{
			Console.WriteLine("The car is breaking");
		}

		public void Reverse()
		{
			Console.WriteLine("The Car is reversing");
		}

		public void SteerRight()
		{
			Console.WriteLine("The Car is steering right");
		}

		public void Steer(bool steerLeft)
		{
			this.Steering = steerLeft;
			if (this.Steering == true)
			{
				Console.WriteLine("The Car is steering left");
			}

			else
				Console.WriteLine("The Car is steering right");


		}


	}
}
