using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace car_card_game
{
    internal class car_card
    {

        public string id { get; set; }
        public string name {  get; set; }
        public int maxSpeed { get; set; }
        public double zerotosixty { get; set; }

        public int horsepower { get; set; }

        public int cubiccentimeters {  get; set; }

        public int cylinders { get; set; }

        public int rpm { get; set; }

        public car_card(string id, string name, int maxSpeed, double zerotosixty, int horsepower, int cubiccentimeters, int cylinders, int rpm)
        {
           this.id = id.ToUpper();
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.zerotosixty = zerotosixty;
            this.horsepower = horsepower;
            this.cubiccentimeters = cubiccentimeters;
            this.cylinders = cylinders;
            this.rpm = rpm;
        }

        public car_card compare(car_card other, catagory c)
        {
            if (other == null)
                return this;
            if (c == catagory.maxspeed )
            {
                if (maxSpeed > other.maxSpeed)
                return this;
                else return other;
            }
            
            if (c == catagory.zerotosixty )
            {
               if (zerotosixty < other.zerotosixty)
                return this;
               else return other;
            }
            
            if (c == catagory.horsepower )
            {
                if (horsepower > other.horsepower)
                return this;
                else return other;
            }
            
            if (c == catagory.cubiccentimeters )
            {
              if (cubiccentimeters > other.cubiccentimeters)
                return this;
              else return other;
            }
           
            if (c == catagory.cylinders)
            {
                if (cylinders > other.cylinders)
                    return this;
                else return other;
            }
           
            if (c == catagory.rpm )
            {
                if (rpm > other.rpm)
                return this;
                else return other;
            }
           

            return null;
        }

        public override string ToString()
        {
            return name + ";\n" + maxSpeed + ";\n" + zerotosixty +";\n" + horsepower  + ";\n" + cubiccentimeters + ";\n" + cylinders + ";\n" + rpm;
        }

        public enum catagory
        {
            maxspeed, zerotosixty, horsepower, cubiccentimeters, cylinders, rpm
        }
    }
}
