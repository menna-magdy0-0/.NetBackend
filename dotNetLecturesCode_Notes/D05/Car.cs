using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class Car :IComparable,ICloneable
    {
        int id;
        string model;
        int currentSpeed;

        /// <summary>
        ///  if no user defined ctor exists, compiler will generate empty parameterless ctor (do nothing)
        ///  public car(){}
        ///  if any user defined ctor(with any signature ) exists , compiler will no longer generate empty parameterless ctor  
        /// </summary>
        public Car(int _id,string _Name , int _cSpeed)
        {
            id = _id;
            model = _Name;
            currentSpeed = _cSpeed;
        }
        public Car(int _id, string _Name)
            :this( _id, _Name, 60)
        {
            //id = _id;
            //model = _Name;
            //currentSpeed = 60;
        }
        public Car(int _id)
            :this(_id , "FIAT",60)
        {
            //id = _id;
            //model = "FIAT";
            //currentSpeed = 60;
        }
        public Car(Car Oldc)
        {
            id=Oldc.id;
            model = Oldc.model;
            currentSpeed = Oldc.currentSpeed;   
        }
        public int Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public int CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }
        public override string ToString()
        {
            return $"{id}::{model}::{currentSpeed}";
        }

        public int CompareTo(object? obj)
        {
            Car Right=(Car)obj;
            return currentSpeed.CompareTo(Right?.currentSpeed);
        }

        public object Clone()
        {
            return new Car(this);
            //return new Car(id, model, currentSpeed);
        }
    }
}
