using System;
using System.Linq; 
class GradingKineme {
    static void Main() {
        Console.WriteLine("Enter 5 grades separated by new lines: ");
        double[] grades = new double[5];

        for (int i = 0; i < grades.Length; i++) {
            while (true) {
                Console.Write($"G- {i + 1}: ");
                string input = Console.ReadLine();
                
                try {
                    grades[i] = Convert.ToDouble(input);
                    break; 
                } catch (FormatException) {
                    Console.WriteLine("Oops!, That's invalid. Please input correct grade");
                }
            }
        }
        double final = grades.Average();
        int roundedAverage = (int)Math.Round(final);
        Console.WriteLine($"The average of the grades is {final:F2}. Rounded off, it's {roundedAverage}.");
    }
}