using System;

namespace Week1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            //String myName = "Jeroen";
            //String variabele1 = "C";
            //int number1 = 123;
            //Double number2 = 1.5;
            //Boolean status = false;

            //var rest = number1 % number2;

            //Console.WriteLine("Hello " + myName);
            //Console.WriteLine(variabele1 + " " + number1 + " " + number2 + " " + status);
            //Console.WriteLine("De restwaarde is: " + rest);

            //Console.ReadKey();

            //int temperature;
            //Console.WriteLine("Geef een temperatuur in Celsius: ");


            //temperature = Convert.ToInt32(Console.ReadLine());

            //var temperatureCalculation = temperature * 1.8 + 32;
            //Console.WriteLine(temperatureCalculation);

            //Console.Clear();

            //int euro;
            //Console.WriteLine("Converteer euro in dollar: ");

            //euro = Convert.ToInt32(Console.ReadLine());

            //var euroCalculation = euro * 1.16;

            //Console.WriteLine(euro + " euro in dollars is: " + euroCalculation);

            //Console.ReadKey();

            //Console.Clear();

            Console.WriteLine("What is the language you're speaking? (Dutch or English): ");
            String chosenLanguage = Console.ReadLine();
            chosenLanguage = chosenLanguage.ToUpper();

            int lengthInCm;
            int circumference;
            int acceptedgender = 0;

            String gender = Console.ReadLine();

            switch (chosenLanguage)
            {
                case "DUTCH":

                    Console.WriteLine("Bent u een man of een vrouw");
                    gender = Console.ReadLine();
                    gender = gender.ToUpper();

                    while (acceptedgender != 1)
                    {
                        if (gender == "MAN")
                        {
                            acceptedgender++;
                            Console.WriteLine("Hoe lang bent u? (in centimeters): ");
                            lengthInCm = Convert.ToInt32(Console.ReadLine());
                            var calculationMan = (lengthInCm - 100) * 0.9;
                            Console.WriteLine("Het ideale lichaamsgewicht voor u is: " + calculationMan);

                        }
                        else if (gender == "VROUW")
                        {
                            acceptedgender++;
                            Console.WriteLine("Hoe lang bent u? (in centimeters): ");
                            lengthInCm = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Wat is uw pols omtrek? (in centimeters):  ");
                            circumference = Convert.ToInt32(Console.ReadLine());
                            var calculationVrouw = (lengthInCm + 4 * circumference - 100) / 2;
                            Console.WriteLine("Het ideale lichaamsgewicht voor u is: " + calculationVrouw);
                        }
                        else
                        {
                            Console.WriteLine("U moet kiezen uit Man of Vrouw. Probeer het opnieuw: ");
                            gender = Console.ReadLine();
                            gender = gender.ToUpper();
                        }
                    }
                    break;
                case "ENGLISH":

                    Console.WriteLine("Are you a male or a female?");
                    gender = Console.ReadLine();
                    gender = gender.ToUpper();

                    while (acceptedgender != 1)
                    {
                        if (gender == "MALE")
                        {
                            acceptedgender++;
                            Console.WriteLine("How tall are you? (in centimeters): ");
                            lengthInCm = Convert.ToInt32(Console.ReadLine());
                            var calculationMan = (lengthInCm - 100) * 0.9;
                            Console.WriteLine("The ideal weight for you is: " + calculationMan);

                        }
                        else if (gender == "FEMALE")
                        {
                            acceptedgender++;
                            Console.WriteLine("How tall are you? (in centimeters): ");
                            lengthInCm = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("What is your wrist width?:  ");
                            circumference = Convert.ToInt32(Console.ReadLine());
                            var calculationVrouw = (lengthInCm + 4 * circumference - 100) / 2;
                            Console.WriteLine("The ideal weight for you is: " + calculationVrouw);
                        }
                        else
                        {
                            Console.WriteLine("You have to choose a gender. Please try again: ");
                            gender = Console.ReadLine();
                            gender = gender.ToUpper();
                        }
                    }
                    break;



            }
        }
    }
}
