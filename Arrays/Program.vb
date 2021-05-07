Imports System

Module Program
    Sub Main(args As String())

        'Dim numbers(0 To 4) As Integer

        'Dim numbersArrayTwo(4) As Integer

        'numbers(0) = 4
        'numbers(1) = 8
        'numbers(2) = 16
        'numbers(3) = 32
        'numbers(4) = 64

        'shorthand intialized
        Dim numbers() As Integer = {4, 8, 15, 16, 23}

        For index = 0 To numbers.Length - 1
            Console.WriteLine(numbers(index))
        Next

        Dim pirates() As String = {"Luffy", "Ace", "Black Beard", "Kaido", "Shanks"}
        For Each pirate As String In pirates
            Console.WriteLine(pirate)
        Next

        'Line continuation on to next line
        Dim luffysDream As String = "To Find the one piece and " &
            "be crowned king of the pirates."
        Console.WriteLine(luffysDream)

        Dim charArray() As Char = luffysDream.ToCharArray()

        Array.Reverse(charArray)

        For Each myChar As Char In charArray
            Console.Write(myChar)
        Next


        Console.ReadLine()

    End Sub
End Module
