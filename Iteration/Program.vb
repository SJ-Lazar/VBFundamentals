Imports System

Module Program
    Sub Main(args As String())

        'looping
        For index = 1 To 10
            If index = 7 Then
                Console.WriteLine("Found Seven!")
                Exit For
            End If
            Console.WriteLine(index)
        Next


        For index = 10 To 5 Step -1
            Console.WriteLine(index)
        Next

        Console.ReadLine()

    End Sub
End Module
