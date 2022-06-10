
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Car audi = new Car("Car", "Audi", "Gas", "fhr462", "White", 4, 3000);
            Car volvo = new Car("Car", "Volvo", "Gas", "tnx978", "Darkblue", 4, 3200);
            Car renault = new Car("Car", "Renault", "Gas", "opr614", "Red", 4, 2850);

            Airplane Boeing = new Airplane("Airplane", 80, "op5533", "White", 4, 300000);
            Airplane RyanAir = new Airplane("Airplane", 75, "lk8421", "Grey", 4, 25000);
            Airplane Lufthansa = new Airplane("Airplane", 70, "xz3756", "White", 4, 192850);*/


            //Garage<Vehicle> garage = new Garage<Vehicle>(10);

            //garage[0] = audi;
            //garage[1] = renault;
            //garage[2] = RyanAir;
            //garage[3] = Boeing;
            //garage[4] = volvo;
            //garage[5] = Lufthansa;




            GarageHandler garageHandler = new GarageHandler();


            //garageHandler.SetCapacity(10);

            //int input = garageHandler.TextMenu();


            Console.Clear();

            garageHandler.MainMenu();


        }
    }
}









/*
 * 
 * GarageHandler
 *  public Garage<Vehicle> SetCapacity(int capacity)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(capacity);
            return garage;
        }


        public Garage<Vehicle> RemoveVehicle(Garage<Vehicle> garage, string Reg_Number)
        {
            List<Vehicle> garageList = new List<Vehicle>();

            foreach (var i in garage)
                if (i.RegisterNumber != Reg_Number)
                    garageList.Add(i);

            Garage<Vehicle> garage2 = new Garage<Vehicle>(garageList.Count);
            for(var i = 0; i < garage2.Count; i++)
                garage2[i] = garageList[i]; 
                
            return garage2;
        }
*/
