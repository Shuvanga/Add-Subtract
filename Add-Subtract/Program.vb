Imports System

Module Program
    Sub Main()
        Dim num1, num2, add, subtract, press As Integer
        Dim ContDig As Integer
        Do Until ContDig = 2
            Console.WriteLine("Enter two numbers:")
            num1 = Console.ReadLine
            num2 = Console.ReadLine
            add = Addition(num1, num2)
            subtract = Subtraction(num1, num2)
            Console.WriteLine("If add then press 1 or 0 for subtract!")
            press = Console.ReadLine
            If press = 1 Then
                Console.WriteLine(add)
            Else
                Console.WriteLine(subtract)
            End If
            Console.WriteLine("Enter 1 to continue!")
            ContDig = Console.ReadLine
            If ContDig = 1 Then
                Console.WriteLine("Now,")
            Else
                Console.WriteLine("Bye")
            End If
        Loop
        Console.ReadKey()
    End Sub

    Function Addition(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim sum As Integer
        sum = num1 + num2
        Return sum
    End Function

    Function Subtraction(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim diff As Integer
        diff = num1 - num2
        Return diff
    End Function
End Module
