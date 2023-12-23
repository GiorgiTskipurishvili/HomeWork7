using System;
using System.Linq;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1 
            /*1.	მოცემულია კვადრატი და კვადრატში ჩახატული წრე . ამ წრეში ჩახატულია კიდევ ერთი სხვა კვადრატი .
            დაწერეთ პროგრამა რომელიც იპოვის სხვაობას დიდი და პატარა კვადრატის  ფართობებს შორის .
            Input : 5  (რადიუსი )
            Output : 50*/

            Console.WriteLine("Wnter radius of circle: ");
            var radius = double.Parse(Console.ReadLine());

            //side of big square 
            var sideOfbigSquare = 2 * radius;

            //area of big square
            var areaOfBigSquare = Math.Pow(sideOfbigSquare, 2);


            //side of small square
            //radius is almost diagonal in small square
            //Pithagora theorem sqrt/r^2+r^2 = sqrt/2r^2 = r sqrt/2 
            var sideOfSmallSquare = radius * Math.Sqrt(2);

            //area of small square
            var areaOfSmallSquare = sideOfSmallSquare * sideOfSmallSquare;

            //diference of both area of squares (big - small) 
            var answer = areaOfBigSquare - areaOfSmallSquare;

            Console.WriteLine($"between the squares is : {answer}");

            #endregion


            #region Task 2 
            /*2.	დაწერეთ პროგრამა რომელიც შეამოწმებს ამოუვიდა
             * თუ არა იუზერს ჯეკპოტი*/

            //Console.WriteLine("enter symbol ");


            //for

            #endregion


            #region Task3
            /*3.	დაწერეთ პროგრამა რომელიც დათვლის ჯამში რამდენი ქულა დააგროვა საფეხბურთო გუნდმა
                a.	მოგება - 3 
                b.	ფრე = 1 
                c.	წაგება = 0
                */

            Console.WriteLine("Enter ur team's results (win, draw and lose)");
            int pointOfWin = 3;
            int pointOfDraw = 1;
            int pointOfLose = 0;

            Console.Write("number of wins: ");
            int win = int.Parse(Console.ReadLine());
            int resultOfWin = win * pointOfWin;

            Console.Write("number of draws: ");
            int draw = int.Parse(Console.ReadLine());
            int resaltOfDraw = draw * pointOfDraw;

            Console.Write("number of losses: ");
            int lose = int.Parse(Console.ReadLine());
            int resaltOfLose = lose * pointOfLose;


            int points = resultOfWin + resaltOfDraw + resaltOfLose;

            Console.WriteLine($"football team collected {points} points");

            #endregion



            #region Task4
            /*დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1 კვირის განმავლობაში .
                გაითვალისწინეთ

                a.	დღეში თანამშრომელი მუშაობს 8 საათს და  საათში იღებს 10 $
                b.	ოვერთაიმის შემთხვევაში საათში იღებს დამატებით 5$
                c.	შაბათ/კვირას მუშაობის შემთხვევაში იღებს გაორმაგებულ ხელფასს*/

            double hourlyRate = 10;
            double overtimeRate = 15;
            double weekendRate = 20;
            double weekendOvertimeRate = 30;

            int[] hoursWorked = new int[7];
            Console.WriteLine("enter hours worked for each day with seperated by ',' :");
            string[] hoursOfWeek = Console.ReadLine().Split(',');

            for (int i = 0; i < hoursWorked.Length; i++)
            {
                hoursWorked[i] = int.Parse(hoursOfWeek[i]);
            }

            double totalSalary = 0;

            for (int i = 0; i < hoursWorked.Length; i++)
            {
                if (i < 5) // Monday to Friday
                {
                    if (hoursWorked[i] <= 8)
                    {
                        totalSalary += hoursWorked[i] * hourlyRate;
                    }
                    else
                    {
                        totalSalary += hoursWorked[i] * hourlyRate + ((hoursWorked[i] - 8) * overtimeRate);
                    }
                }
                else if (i == 5 || i == 6) // Saturday and Sunday
                {
                    //totalSalary += hoursWorked[i] * weekendRate;
                    if (hoursWorked[i] <= 8)
                    {
                        totalSalary += hoursWorked[i] * weekendRate;
                    }
                    else
                    {
                        totalSalary += hoursWorked[i] * weekendRate + ((hoursWorked[i] - 8) * weekendOvertimeRate);
                    }
                }
            }

            Console.WriteLine($"Total salary is: {totalSalary}$");



            #endregion



            #region Task5
            /*5.	გიორგი მარათონისთვის ემზადება ის ყოველ დღიურად  ვარჯიშობს .
             * შეამოწმეთ აქვს თუ არა გიორგის პროგრესი ყოველ დღიურად და გამოიტანეთ
             * იმ დღეების რაოდენობა როდესაც მან შედეგი გააუმჯობესა.*/



            Console.WriteLine("enter Giorgi's training results for each day (seperated by ',' ):");
            string[] inputResults = Console.ReadLine().Split(',');


            int[] trainingResults = Array.ConvertAll(inputResults, int.Parse);


            int improvementDays = 0;

            for (int i = 1; i < trainingResults.Length; i++)
            {
                if (trainingResults[i] > trainingResults[i - 1])
                {
                    improvementDays++;
                }
            }

            Console.WriteLine($"Number of improve: {improvementDays}");


            #endregion


            #region Task6
            /*6.	დაწერეთ პროგრამა რომელიც ამობეჭდავს N სიგრძის მქონდე ელემენტს მასივიდან*/

            Console.WriteLine("enter");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string[] inputArray = { "Hello", "World", "Programming", "communication" };

            var result = inputArray.Where(word => word.Length >= userInput);

            if (result.Any())
            {
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No elements found");
            }

            #endregion


            Console.ReadKey();
        }
    }
}
