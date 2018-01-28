Module Module1

    Sub Main()
        'TASK 1.1

        Dim MemberName As String = ""
        Dim MemberIdNumber As String = ""
        Dim AddMoreRecords As String = "Y"

        FileOpen(1, "C:\Users\zunair\Downloads\Computer Science A levels\Filing\Task11.txt", OpenMode.Output)


        While UCase(AddMoreRecords) = "Y"

            Console.WriteLine("Enter the name of the Sports Club's Member ")
            MemberName = Console.ReadLine

            Console.WriteLine("Enter ID Number of the Sports Club Member  ")
            MemberIdNumber = Console.ReadLine


            WriteLine(1, MemberName)
            WriteLine(1, MemberIdNumber)
            Console.WriteLine("Do you want to add another record? Y/N") : AddMoreRecords = Console.ReadLine


            While UCase(AddMoreRecords) <> "Y" And UCase(AddMoreRecords) <> "N"
                Console.WriteLine("Please enter Y or N") : AddMoreRecords = Console.ReadLine
            End While


        End While
        FileClose(1)


        FileOpen(1, "C:\Users\zunair\Downloads\Computer Science A levels\Filing\Task11.txt", OpenMode.Input)

        While Not EOF(1)

            Input(1, MemberName)
            Input(1, MemberIdNumber)

            Console.WriteLine("Member Name : " & MemberName)
            Console.WriteLine("Member ID Number : " & MemberIdNumber)



        End While
        FileClose(1)
        Console.ReadKey()

    End Sub

End Module
