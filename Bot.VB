Imports System

Public Class Program
    Public Shared Sub Main()
        Console.Write("Thank-you note bot")
        Console.Write(vbLf)
        Console.Write("Version 1.0.0")
        Console.Write(vbLf)
        Console.Write(Fionn's Version)
        Dim attempts As Integer = 0
        Dim done As Boolean = False

        While Not done

            If attempts > 1 Then
                Console.Write("You have redone this section " & attempts & " times.")
                Console.Write(vbLf)
            End If

            Console.Write(vbLf)
            Console.Write("Who are you writing to?")
            Console.Write(vbLf)
            Dim reciever As String = Console.ReadLine()
            Console.Write(vbLf)
            Console.Write("What gift did you get from " & reciever & "?")
            Console.Write(vbLf)
            Dim gift As String = Console.ReadLine()
            Console.Write(vbLf)
            Console.Write("What party did you invite " & reciever & " to? (Just write the noun with no connectors)")
            Console.Write(vbLf)
            Dim party As String = Console.ReadLine()
            Console.Write(vbLf)
            Console.Write("Here is your letter so far:")
            Console.Write(vbLf)
            Console.Write("Dear " & reciever & "," & vbLf & vbLf & "Thank you so much for coming to my " & party & ". Thank you so much for the " & gift & ".")
            Console.Write(vbLf)
            Console.Write(vbLf)
            Console.Write("Do you like it so far? Type in ""yes"" or ""no"". " & vbLf & "Typing in ""no"" will restart this part of the creation process, and typing in ""yes"" will move you on to the next part of the creation process. " & vbLf)
            Dim continue1 As String = Console.ReadLine()
            Console.Write(vbLf)

            Select Case continue1
                Case "yes"
                    done = True
                Case "no"
                    done = False
                    Console.Clear()
                    attempts += 1
                    Console.Write("You have redone this section 1 time.")
                    Console.Write(vbLf)
                    Console.Write(vbLf)
            End Select
        End While
    End Sub
End Class
