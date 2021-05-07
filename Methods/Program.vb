Imports System

Module Program
    Sub Main(args As String())
        'Call DisplayTheMessage()
        'DisplayTheMessage()

        Console.WriteLine(SuperSecretFormula("Luffy"))
        Console.ReadLine()
    End Sub

    Sub DisplayTheMessage()
        Console.WriteLine("From Display The Message.")
    End Sub

    Function SuperSecretFormula() As String

        Return "Hello Nike!"
    End Function

    Function SuperSecretFormula(ByVal name As String) As String
        Return String.Format("Hello {0}!", name)
    End Function

End Module
