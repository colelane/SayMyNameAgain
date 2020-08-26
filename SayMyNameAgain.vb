Option Strict On
Option Explicit On

'Lane Coleman
'RCET0265
'Spring 2020
'Say My Name Again
'https://github.com/colelane/SayMyNameAgain.git
Module SayMyNameAgain

    Sub Main()
        Dim userInput As String
        Console.WriteLine("What is your name?")
        userInput = Console.ReadLine()
        If userInput = "Emily" Then Console.WriteLine("Hi Emily.")
        If userInput = "Joe" Then Console.WriteLine("Hi Joe.")
        If userInput = "Lane" Then Console.WriteLine("Bruh")
        If userInput = "Tim" Then Console.WriteLine("Rossiter?  The man, the myth, the legend?")
        Console.ReadLine()


    End Sub

End Module
