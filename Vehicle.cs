

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    class Vehicle
    {


        private string _Vehicle;
        private string _registernumber;
        private string _color;
        private int _numberOfWheels;
        private double _weight;


        public Vehicle(string vehicle)
        {
            _Vehicle = vehicle;
        }

        public Vehicle(string vehicle, string regnumber, string color, int numberofwheels, double weight)
        {
            _Vehicle = vehicle;
            _registernumber = regnumber;
            _color = color;
            _numberOfWheels = numberofwheels;
            _weight = weight;
        }

        public string Vehicle1
        {
            get
            {
                return _Vehicle;
            }

            set
            {
                _Vehicle = value;
            }

        }

        public string RegisterNumber
        {
            get
            {
                return _registernumber;
            }

            set
            {
                _registernumber = value;
            }
        }


        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }


        public int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }
            set
            {
                _numberOfWheels = value;
            }
        }


        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public virtual string Stats()
        {
            return $"Registernumber: {RegisterNumber}\nColor: {Color}\nNumber of wheels: {NumberOfWheels}\nWeight: {Weight}kg";
        }

    }
}