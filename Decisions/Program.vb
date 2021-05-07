Imports System

Module Program
    Sub Main(args As String())


        Console.WriteLine("Enter a avenger name to get identiy")
        Dim userGivenAvenger As String
        userGivenAvenger = Console.ReadLine()
        Console.WriteLine("Avenger alter Ego:" & userGivenAvenger)

        'If userGivenAvenger = "spiderman" Then
        '    Console.WriteLine("Peter Parker")
        'ElseIf userGivenAvenger = "captain america" Then
        '    Console.WriteLine("Steve Rogers")
        'ElseIf userGivenAvenger = "hulk" Then
        '    Console.WriteLine("Bruce Banner")
        'ElseIf userGivenAvenger = "black widow" Then
        '    Console.WriteLine("Natasha Romanoff")
        'Else
        '    Console.WriteLine("Unknown Identity")
        'End If

        'If Function - ternary statement
        Dim message As String = IIf(userGivenAvenger = "spiderman", "Peter Parker", "Unknown Identity")
        Console.WriteLine("Alter Ego: {1} ... Real Identity {0}!", message, userGivenAvenger)
        Console.ReadLine()


    End Sub
End Module
