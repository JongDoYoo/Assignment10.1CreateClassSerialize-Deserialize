using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10._1CreateClassSerialize_Deserialize
{
    internal class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
        private bool _isElectric;                   //backing field  if you're going to make get set manual, you need a backing field/ private _name
        public bool IsElectric
        {
            get { return _isElectric; }
            set { _isElectric = value; }
        }
        public double Price { get; set; }

        public Car()   //this is my contructor 
        {
            Make = "Tesla";
            Model = "ModelY";
            Year = 2024;
            IsElectric = true;
            Price = 50000;
        }
    }  
}
