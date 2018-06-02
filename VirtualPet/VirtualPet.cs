using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet

    // Declare fields
    {
        private int sleep;
        private int hunger;
        private int boredom;
        private bool enoughSleep;
        private bool enoughFood;
        private bool enoughPlay;

        // get-set / paramaters

        public int Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }
        public bool EnoughSleep
        {
            get { return this.enoughSleep; }
            set { this.enoughSleep = value; }
        }
        public bool EnoughFood
        {
            get { return this.enoughFood; }
            set { this.enoughFood = value; }
        }
        public bool EnoughPlay
        {
            get { return this.enoughPlay; }
            set { this.enoughPlay = value; }
        }

        // Constructors

        public VirtualPet()
        {
            // Default Constructor
        }

        public VirtualPet(int sleep, int hunger, int boredom)
        {
            this.Sleep = sleep;
            this.Hunger = hunger;
            this.Boredom = boredom;
        }

        // Methods

        public void Tick() // Tick method
        {
            Sleep--;
            if (Sleep < 1)
            {
                SleepAlert(true);
            }
            else
            {
                SleepAlert(false);
            }

            Hunger++;
            if (Hunger > 9)
            {
                HungerAlert(true);
            }
            else
            {
                HungerAlert(false);
            }

            Boredom++;
            if (Boredom > 9)
            {
                BoredomAlert(true);
            }
            else
            {
                BoredomAlert(false);
            }
        }

        public bool SleepAlert(bool status)
        {
            EnoughSleep = status;
            return EnoughSleep;
        }

        public bool HungerAlert(bool status)
        {
            EnoughFood = status;
            return EnoughFood;
        }

        public bool BoredomAlert(bool status)
        {
            EnoughPlay = status;
            return EnoughPlay;
        }
    }
}