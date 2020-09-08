'Calvin Coxen
'RCET0265
'Fall 2020
'Say My Name Again
'https://github.com/CalvinAC/SayMyNameAgain/blob/master/SayMyNameAgain/SayMyNameAgain.vb

Option Compare Text


Module SayMyNameAgain

    Sub Main()
        'Function used to set the users input as a variable
        Dim userNameInput As String

        'Text greeting the user and prompting them to input their name
        Console.WriteLine("Hello, and welcome to jurassic park")
        Console.WriteLine("Please enter your name:")
        userNameInput = Console.ReadLine()

        'If statement used to output different text depending on what the user inputs
        If userNameInput = "Emily" Then
            Console.WriteLine("Hello There!")
            Console.WriteLine("Enjoy your stay, " + userNameInput)
        ElseIf userNameInput = "Joe" Then
            Console.WriteLine("Who's joe?")
            Console.ReadLine()
            Console.WriteLine("Joe Mama! ")
        ElseIf userNameInput = "Calvin" Then
            Console.WriteLine("User has stolen creators identity, who am I?")
        ElseIf userNameInput <> "Emily" Or userNameInput <> "Joe" Or userNameInput <> "Calvin" Then
            Console.WriteLine("Enjoy your stay, " + userNameInput)
        End If

        Console.ReadLine()


    End Sub

End Module
