'Brayden Peck
'RCET0265
'Spring 2021
'Better Calculator
'https://github.com/PeckBray/BetterCalculator
Option Explicit On
Option Strict On
Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String
        Dim problem As Boolean = True
        Dim operation As Integer
        While userInput <> "Q" And userInput <> "q"
            Console.WriteLine("Please enter two numbers. Enter ""Q"" any time to quit")
            problem = True
            While problem = True And userInput <> "Q" And userInput <> "q"
                Console.WriteLine("Please enter the first number")
                Try
                    userInput = (Console.ReadLine())
                    problem = False
                    firstNumber = CInt(userInput)
                Catch e As Exception
                    If userInput <> "Q" And userInput <> "q" Then
                        problem = True
                        Console.WriteLine($"You entered ""{userInput}"". Please enter a whole number")
                    End If
                End Try
                If problem = False Then
                    Console.WriteLine($"you entered ""{userInput}""")
                End If
            End While

            problem = True

            While problem = True And userInput <> "Q" And userInput <> "q"
                Console.WriteLine("Please enter the second number")
                Try
                    userInput = (Console.ReadLine())
                    problem = False
                    secondNumber = CInt(userInput)
                Catch e As Exception
                    problem = True
                    If userInput <> "Q" And userInput <> "q" Then
                        Console.WriteLine($"You entered ""{userInput}"". Please enter a whole number")
                    End If
                End Try
                If problem = False Then
                    Console.WriteLine($"you entered ""{userInput}""")
                End If
            End While

            problem = True

            While problem = True And userInput <> "Q" And userInput <> "q"
                Console.WriteLine("Choose on of the following options" & vbNewLine & "1. Add" & vbNewLine & "2. Subtract" & vbNewLine & "3. Multiply" & vbNewLine & "4. Divide")
                Try
                    userInput = Console.ReadLine()
                    operation = CInt(userInput)
                    Console.WriteLine($"you entered ""{userInput}""")
                    problem = False
                Catch e As Exception
                    problem = True
                End Try
                If userInput = "Q" Then

                ElseIf userInput = "q" Then

                ElseIf operation = 1 Then
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
                ElseIf operation = 2 Then
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
                ElseIf operation = 3 Then
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
                ElseIf operation = 4 Then
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
                Else
                    problem = True
                End If
            End While
        End While
        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")
        Console.Read()
    End Sub

End Module
