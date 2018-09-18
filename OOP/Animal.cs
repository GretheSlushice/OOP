namespace OOP
{
    //Superklassen alle dyr arver fra
    public class Animal
    {
        public string name;
        public int birthYear;
        protected bool tame;

        public bool Tame
        {
            get { return tame; }
            set
            {
                if (tame == true) tame = true;
                if (tame == false) tame = value;
            }
        }
    }
}