Imports System

Module Program
    Sub Main(args As String())
        'Variables => Allocate Space in Memory - a bucket of value

        'Declare variables - Dim is short for Dimension a variable - Telling the size of data type.
        Dim x As Integer
        Dim y As Integer

        'Assignment
        x = 7
        y = x + 3

        Console.WriteLine(y)

        'Dim avenger As String
        'avenger = "Ironman"

        Dim avenger As String = "Thor"
        Console.WriteLine(avenger)

        Dim youngAvenger = "spiderman"
        Console.WriteLine(youngAvenger)

        Dim age As Integer = 7
        Dim gurdian As String = "Groot"

        'implicit conversion
        Dim gurdianAge As String = gurdian & CStr(age)
        Console.WriteLine(gurdianAge)
        Console.ReadLine()

    End Sub
End Module
