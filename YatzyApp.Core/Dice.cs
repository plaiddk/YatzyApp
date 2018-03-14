using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzyApp.Core
{
   public class Dice
    {

  
        //Felt

        private int _value;

        public int Value
        {
            get { return this._value; }
            private set { 
                //Log
                //Sikkerhed
                //Validering
                //Read only egenskab fordi dene r private
                if (value < 1 || value > 6)
                {
                    value = 1;
                }

                this._value = value; }
        }
        private static System.Random rnd = new Random();

        public string DiceValue()
        {
            return "[" + this.Value + "]";
        }

        public void RollDice()
        {
            this.Value = rnd.Next(1,7);

        }

        public Dice()
        {
            this.RollDice();
        }

        public Dice(int diceValue)
        {
           
            this.Value = diceValue;
        }
    }
}
