using System;

namespace BasicClassMembers_03
{
    /// <summary>
    /// Based on demo sample of David Kadlec
    /// </summary>
    public class ClassExample
    {
        // fields
        
        /// <summary>
        /// Privatni datovy clen (field) tridy bez inicializace, bude inicializovan na defaultni hodnotu -> default(int);
        /// </summary>
        private int mMyIntValue;


        /// <summary>
        /// Defaultni hodnota kazdeho referenciho typu je null.
        /// </summary>
        private Random mRandom;


        /// <summary>
        /// Privatni datovy clen tridy, inicializovan na hodnotu true.
        /// </summary>
        private bool mMyBoolValue = true;


        // Default values
        // http://msdn.microsoft.com/en-us/library/83fhsxwc.aspx


        /// <summary>
        /// Konstanta, musi byt inicializovana uz pri kompilaci a chova se jako staticky clen.
        /// </summary>
        public const int MYCONST = 123;


        /// <summary>
        /// Readonly modifikator zpusobi to, ze je mozne hodnotu teto promenne zmenit pouze pri inicializaci nebo v konstruktoru. 
        /// </summary>
        private readonly int mMyReadOnlyInt = 42;
        private readonly bool mMyReadOnlyBool;
        private readonly Random mMyReadOnlyRandom = new Random();
        



        // properties

        /// <summary>
        /// Public int property
        /// </summary>
        public int MyAutoIntegerProperty { get; set; }


        /// <summary>
        /// Ma privatni setter
        /// </summary>
        public int MyAutoIntergerProperty2 { get; private set; }

        /// <summary>
        /// C# 6.0 feature - property auto initialization
        /// </summary>
        public int MyAutoIntergerProperty3 { get; private set; } = 42;
        public DateTime TimeStamp { get; } = DateTime.UtcNow;

        /// <summary>
        /// Property se specifikovanym gettrem a settrem a kontrola, ze nejsme pod absolutni nulou :)
        /// </summary>
        private int mTemperatureC;
        public int TemperatureC
        {
            get
            {
                if (mTemperatureC < -274)
                {
                    return -274;
                }

                return mTemperatureC;
            }
            set
            {
                if (value < -274)
                {
                    value = -274;
                }

                mTemperatureC = value;
            }
        }


        /// <summary>
        /// CTOR
        /// </summary>
        public ClassExample()
        {
        }


        /// <summary>
        /// Konstruktory lze pretezovat.
        /// </summary>
        public ClassExample(Random mRandom) //: base(...) kdyby bylo treba napr. predat parametry bazove tride
        {
            mMyReadOnlyRandom = mRandom;
        }


        /// <summary>
        /// Konstruktory lze retezit.
        /// Po zavolani tohoto konstruktoru se zavola predchozi a preda se mu jeden z parametru.
        /// Klicove slovo this.
        /// </summary>
        public ClassExample(int mMyReadOnlyInt, Random random)
            : this(random) 
        {
            // Takto radsi ne, vznika tak spusta chyb, jmena parametru by se mely lisit od jmen ve tride
            // Ke clenu tridy se da pristupovat pres klicove slovo this
            this.mMyReadOnlyInt = mMyReadOnlyInt;
        }



        // methods

        /// <summary>
        /// Privatni instancni metoda, ktera lze volat jen v nestaticke clenu teto tridy,
        /// </summary>
        private void DoSomething()
        {
            Console.WriteLine("Doing...");
        }


        /// <summary>
        /// Public instancni metoda, ktera lze volat zevnitr v nestatickem clenu teto tridy, nebo zvenku na instanci teto tridy.
        /// ClassExample a = new ClassExample();
        /// a.DoMagic();
        /// </summary>
        public void DoMagic()
        {
            DoSomething();
        }


        /// <summary>
        /// new in C# 6.0 Expression bodied functions
        /// </summary>
        public void LogTemperature() => Console.WriteLine($"Current temperature is: {this.TemperatureC}, time: {this.TimeStamp.ToShortTimeString()}");

        /// <summary>
        /// s expression bodied functions lze pracovat jako s normalnimi funkcemi, jedna se pouze o syntakticky cukr (nemusi se uvadet return, atd...)
        /// </summary>
        /// <returns></returns>
        public string LogWithParam(DateTime time) => $"Current temperature is: {this.TemperatureC}, time: {this.TimeStamp.ToShortTimeString()}";



        // Staticke cleny tridy jsou takove cleny, ke kterym lze pristupovat rovnou pres typ tridy, neni potreba vytvaret instanci.
        // Ve statickych clenech nemam samozrejme pristup k instancim clenum, ktere jsou vzdy vazany k urcite instanci.
        // Staticke datove polozky jsou sdileny mezi vsemy instancemi tridy.

        /// <summary>
        /// Staticky konstruktor, ktery je vyvolan jednou a to typicky pri (prvnim) pristupu k nejakemu statickemu clenu tridy.
        /// </summary>
        static ClassExample()
        {
            Console.WriteLine("Static constructor called");
        }


        /// <summary>
        /// Staticka metoda.
        /// </summary>
        public static void WriteMoreInfo()
        {
            Console.WriteLine("In class ClassExample");
        }


        /// <summary>
        /// Staticka property.
        /// </summary>
        public static int MyStaticInt
        {
            get
            {
                return mMyStaticInt;
            }
        }


        /// <summary>
        /// Privatni staticka datova polozka.
        /// </summary>
        private static int mMyStaticInt = 42;


        // Pretezovani metod

        public void WriteText()
        {
            Console.WriteLine();
        }


        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
