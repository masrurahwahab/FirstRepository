// Write a program to that prompts the user to enter two numbers, if the two numbers are even, output the average of the two
//    numbers however, if the two numbers are odd, output the   between the numbers. Do nothing if one of the 
//    numbers is even and the other is odd.

// Console.WriteLine("Enter your first number");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter your second number");
// int num2 = int.Parse(Console.ReadLine());
// if(num1 % 2 == 0 && num2 % 2 == 0)
// {
//     int average = num1 + num2 / 2;
//     Console.WriteLine($"{average} is an even number");
// }
// else if (num1 % 2 != 0 && num2 % 2 != 0)
// {
//     int difference = num1 - num2;
//     Console.WriteLine($"{difference}is an odd number");
// }
// else
// {
//     Console.WriteLine($"This is a even number and a odd number");
// }
// . Sarah's favorite numbers are numbers between 10 and 50 (inclusive) which are divisible by 2 and 5 without remainders.
//    Write a program that reads an integer from the user and output the cube of the number if it is one of Sarah's favorite
//    otherwise output the square of the number.

// Console.WriteLine("Input your number");
// int num1 =int.Parse(Console.ReadLine());
// if (num1 >= 10 && num1 <= 50 && num1% 2==0 && num1 % 5 ==0 )
// {
//     int nm =num1 * num1 * num1;
//     Console.WriteLine($"{nm} is one  of sarahs favourites number");
// }
// else 
// {
//     int ns = num1 * num1;
//     Console.WriteLine($"{ns} is not one of sarah's favourites number");
// }


//  John clocks 20 years today and he wishes to play a game with his celebrants with the winners rewarded with gifts. 
//    The game is to guess two numbers that their sum or product equals John's age. Write a program that prompts the user to 
//    enter two integers and determine if a user is a winner.

// Console.WriteLine("Enter your first number");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter your second number");
// int num2 = int.Parse(Console.ReadLine());
// int sum = num1 +num2 ;
// Console.WriteLine(sum);
// int product = num1 * num2;
// Console.WriteLine(product);
// if(sum == 20 || product == 20)
// {
//     Console.WriteLine($"Congratulations , you are the winner of the game");
// }
// else
// {
//     Console.WriteLine($"ooops , you guess it wrong");
// }

//  Write a program that prompts the user to enter the ages of five students and output the average of all their ages if all
//    the ages are valid otherwise outputs Invalid input if any of the students' age is not valid. A valid age is between 10 and
//    50 (inclusive)

// Console.WriteLine("Enter the first student age");
// int age1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the second student age");
// int age2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the third student age");
// int age3 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the fourth student age");
// int age4= int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the fifth student age");
// int age5 = int.Parse(Console.ReadLine());
// if ((age1 >= 10 && age1 <= 50) && age)
// {
//     int average = age1 + age2 + age3 + age4 + age5 / 2;
//     Console.WriteLine($"The{average} is valid");
// }
// else
// {
//     Console.WriteLine($"invalid input");
// }

// 7. Write a program to calculate the smallest of three numbers entered by a user.

// Console.WriteLine("Enter your first number");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter your second number");
// int num2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter yourthird number");
// int num3 = int.Parse(Console.ReadLine());
// if(num1 < num2 && num1 < num3)
// {
//     Console.WriteLine($"{num1} is the smallest number");
// }
// else if (num2 < num1 && num2 < num3 )
// {
//     Console.WriteLine($"{num2} is the smallest number");
// }
// else
// {
//     Console.WriteLine($"{num3} is th smallest number");
// }

//  Write a program that prompts the user to enter the ages of three students and outputs the year of birth of the youngest
//    student.

// Console.WriteLine("Enter the age of the first student");
// int age1 =int.Parse(Console.ReadLine());

// Console.WriteLine("Enter the age of the second student");
// int age2 =int.Parse(Console.ReadLine());

// Console.WriteLine("Enter the age of the third student");
// int age3 =int.Parse(Console.ReadLine());
// if(age1 < age2  && age1 < age3  && age1 % 4 == 0 )
// {
//     Console.WriteLine($"{age1} the year of birth");
// }
// else if (age2 < age1 && age2 < age3 && age2 % 4 == 0 )
// {
//     Console.WriteLine($"{age2} the year of birth");
// }
// else
// {
//     Console.WriteLine($"{age3} the year of birth");
// }



Console.WriteLine("Input your number ranging from one to seven");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1 :
    Console.WriteLine($"Sunday.");
    goto case 2;

    case 2 :
    Console.WriteLine($"Monday.");
    goto case 3;

    case 3 :
        Console.WriteLine($"Tuesday");
        goto case 4;

    case 4 :
    Console.WriteLine($"Wednesday.");
    goto case 5;

    case 5 :
     Console.WriteLine($"Thursday.");
    goto case 6;

    case 6 :
     Console.WriteLine($"friday.");
    goto case 7;

    case 7 :
     Console.WriteLine($"Saturday.");
    break;

    default:
    Console.WriteLine($"Invalid number.");
    break;
}
