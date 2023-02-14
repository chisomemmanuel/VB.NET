'CREATED BY JETSWIFT INC... PLEASE, DO NOT SELL THIS CONTENT © 2023

Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello, i want to calculate the product of 3 numbers")
        ' USING CAMEL NOTATION TO DECLARE VARIABLES, ALL IN SINGLE LINE... '
        ' DIM(DIMENSION) IS A CONVECTION USED FOR DECLARING VARIABLES IN MICROSOFT VISUAL BASIC.NET. '
        Dim firstNumber, secondNumber, thirdNumber As Double
        
        Console.Write("Enter first number: ")
        ' BELOW LINE ACCEPTS THE FIRST INPUT AND READS IT IN A SINGLE-LINE, IT ALSO PREVENT THE ACCEPTANCE OF STRINGS BY ITERATING(WHILE-LOOP) TO READ ONLY NUMBERS'
        While (NOT Double.TryParse(Console.ReadLine(), firstNumber))
            Console.WriteLine("First input should neither be empty, nor a string. But must be a number...")
            Console.Write("Please, enter first number: ")
        End While
        ' NOW A NUMBER HAS BEEN INPUTED, ACCEPT 2ND AND 3RD NUMBERS. THEN CALCULATE'
        Console.Write("Enter second number: ")
        ' BELOW LINE ACCEPTS THE SECOND INPUT AND READS IT IN A SINGLE-LINE, IT ALSO PREVENT THE ACCEPTANCE OF STRINGS BY ITERATING(WHILE-LOOP) TO READ ONLY NUMBERS'
        While (NOT Double.TryParse(Console.ReadLine(), secondNumber))
            Console.WriteLine("Second input should neither be empty, nor a string. But must be a number...")
            Console.Write("Please, enter second number: ")
        End While
        Console.Write("Enter last number: ")
        ' BELOW LINE ACCEPTS THE THIRD INPUT AND READS IT IN A SINGLE-LINE, IT ALSO PREVENT THE ACCEPTANCE OF STRINGS BY ITERATING(WHILE-LOOP) TO READ ONLY NUMBERS'
        While (NOT Double.TryParse(Console.ReadLine(), thirdNumber))
            Console.WriteLine("Last input should neither be empty, nor a string. But must be a number...")
            Console.Write("Please, enter last number: ")
        End While
        ' PARSING THE NUMBERS AS DOUBLE... (THIS IS NOT NECESSARY)
        firstNumber = Double.parse(firstNumber)
        secondNumber = Double.parse(secondNumber)
        thirdNumber = Double.parse(thirdNumber)
        ' COMPUTING THE PRODUCT OF THE NUMBERS...
        Dim product As Double = firstNumber * secondNumber * thirdNumber
        ' PRINT VALUES OF VARIABLES TO CONSOLE, BY STARTING FROM INDEX 0 i.e {0}, {1}, {2}, {3} ...
        Console.WriteLine("The product of {0}, {1} and {2} is: {3}",firstNumber, secondNumber, thirdNumber, product)
        System.Console.WriteLine("Press any key to exit...")
        ' BELOW LINE ALLOWS YOU TO PURPOSEFULLY EXIT OUT OF THE PROGRAM ONCE IT FINISHES IT'S EXECUTION. ESPECIALLY IN WINDOWS COMMAND PROMPTS ETC
        Console.ReadKey()

    End Sub
End Module
