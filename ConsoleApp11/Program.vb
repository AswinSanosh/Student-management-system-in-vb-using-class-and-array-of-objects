Module studentprog
    Public Class Student
        Public Sub New()
            Console.WriteLine("Student Mangement System.")
            Console.WriteLine()
        End Sub

        Public Name As String
        Public Rollno As Integer
        Public Marks(3) As Single

        Public Sub NewStudent(ByVal stdno As Integer)
            Dim newStudent As New Student()
            Console.WriteLine("Enter Name:")
            newStudent.Name = Console.ReadLine()
            Console.WriteLine("Enter Roll Number:")
            newStudent.Rollno = Integer.Parse(Console.ReadLine())
            students(stdno) = newStudent
        End Sub

        Public Sub EnterMarks(ByVal stdno As Integer)
            Console.WriteLine("Enter marks for Student " & students(stdno).Name & ":")
            For i As Integer = 0 To 2
                Console.WriteLine("Enter mark " & (i + 1) & ":")
                students(stdno).Marks(i) = Single.Parse(Console.ReadLine())
            Next
        End Sub

    End Class
    Public students(10) As Student
    Sub Main()
        Dim studentSystem As New Student()
        Dim opt As Integer
        Dim stdn As Integer = 0
        Dim j As String = "Yes"

        While j = "Yes"
            Console.WriteLine("Press 1 to add new Student.")
            Console.WriteLine("Press 2 to add marks of Student.")
            Console.WriteLine("Press 3 to Update details of Student.")
            Console.WriteLine("Press 4 to Exit.")
            Console.Write("Enter here: ")

            opt = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()


            Select Case opt
                Case 1
                    students(stdn) = New Student()
                    students(stdn).NewStudent(stdn)
                    stdn += 1
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()

                Case 2
                    Dim no As Integer
                    For i As Integer = 0 To stdn - 1
                        Console.WriteLine(i & " " & students(i).Name)
                    Next
                    Console.Write("Enter Student Number: ")
                    no = Console.ReadLine()
                    students(no).EnterMarks(no)
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                Case 3
                    Dim no As Integer
                    For i As Integer = 0 To stdn - 1
                        Console.WriteLine()
                        Console.WriteLine(i & " Name: " & students(i).Name)
                        Console.WriteLine("Mark 1" & students(i).Marks(0))
                        Console.WriteLine("Mark 2" & students(i).Marks(1))
                        Console.WriteLine("Mark 1" & students(i).Marks(2))
                        Console.WriteLine()
                    Next
                    Console.Write("Enter Student Number: ")
                    no = Console.ReadLine()
                    students(no).NewStudent(no)
                    students(no).EnterMarks(no)
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                Case 4
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                    Exit While
            End Select
        End While
    End Sub
End Module
