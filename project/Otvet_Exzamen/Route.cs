using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Route
    {
        private int number;
        private int quantity;
        private int time;

        public int Number { get => number; set => number = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Time { get => time; set => time = value; }

        public Route(int number, int quantity, int time)
        {
            this.Number = number;
            this.Quantity = quantity;
            this.Time = time;
        }
        public Route()
        {
            this.Number = 0;
            this.Quantity = 0;
            this.Time = 0;
        }
        public override string ToString()
        {
            return "Номер маршрута:" + Number + "\nКоличестово остановок:" + Quantity + "\nВремя в пути:" + Time + "\n";
        }
    }
}
