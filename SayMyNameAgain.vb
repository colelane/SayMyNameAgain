Option Strict On
Option Explicit On
Option Compare Text

'Lane Coleman
'RCET0265
'Fall 2020
'Say My Name Again
'https://github.com/colelane/SayMyNameAgain.git
Module SayMyNameAgain

    Sub Main()
        Dim userInput As String

        Console.WriteLine("What is your name?")
        userInput = Console.ReadLine()

        'individual reactions for specific names
        If userInput = "Emily" Then
            Console.WriteLine("Hi Emily.")
        ElseIf userInput = "Joe" Then
            Console.WriteLine("Joe mama.")
        ElseIf userInput = "Lane" Then
            Console.WriteLine("Bruh")
        ElseIf userInput = "Tim" Then
            Console.WriteLine("Rossiter?  Uh oh... uhm, I gotta go")
        Else
            'Else will cover anything that didn't evaluate to True above - TJR
            Console.WriteLine("Go away")
        End If

        Console.ReadLine()

    End Sub
End Module
