using System;

class Answer {
    static void getDecimals(){
        int number=0;
        while (number<=100 || number>999){
            Console.Write("Enter three-digit number:\t");
            number= int.Parse(Console.ReadLine());
        }
        int decimals = (number % 100)/10;
        Console.WriteLine("Decimal number from " + number +" is " + decimals +"\n"); 
        Console.WriteLine("-------------------------------------------------------------\n");
    }
    
    static void getThirdNumber(){
        Console.Write("Enter any number:\t");
        string number= Console.ReadLine();

        if (number.Length < 3){
            Console.WriteLine("There is no third number!");
        } else {
            Console.WriteLine("Third number is " + number[2]);
        }
        Console.WriteLine("now using `while` loop....");
        int num = int.Parse(number);
        while (num > 1000){
            num = num / 10; 
        }
        int answer = num % 10;
        Console.WriteLine("Third number is " + answer + "\n");
        Console.WriteLine("-------------------------------------------------------------\n");
    }
    
    static void getWeekend(){
        int dayNumber=0;
        string word = null;//new string[];
        //word = 0;
        while (dayNumber<1 || dayNumber>7){
            Console.Write("Enter the number of the day:\t");
            dayNumber= int.Parse(Console.ReadLine());
        }
        if (dayNumber < 6){
            word = " not";
        }
        Console.WriteLine("Day " + dayNumber + " is" + word + " a weekend!");     
        Console.WriteLine("-------------------------------------------------------------\n");
    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        Console.WriteLine("Task1. Getting decimals from three-digit number.\n");
        getDecimals();

        Console.WriteLine("Task2. Getting third number .\n");
        getThirdNumber();

        Console.WriteLine("Task3. Getting weekend number .\n");
        getWeekend();
    }
}