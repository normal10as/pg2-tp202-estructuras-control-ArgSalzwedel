Module module23


    Sub main()
        Dim data1 As Int16 = 30
        Dim data2 As Int16 = 7
        Dim data3 As Int16 = 12
        Dim data4 As Int16 = 5
        Dim data5 As Int16 = 9
        ' 3,7,12,5,9 





        If data1 > data2 And data1 > data3 And data1 > data1 And data1 > data5 Then

            Console.WriteLine("el primer numero ingresado es el mayor:" & data1)


        End If

        If data2 > data1 And data2 > data3 And data2 > data4 And data2 > data5 Then

            Console.WriteLine("el segundo numero ingresado es el mayor" & data2)

        End If

        If data3 > data1 And data3 > data2 And data3 > data4 And data3 > data5 Then

            Console.WriteLine("el tercer numero ingresado es el mayor" & data3)
        End If

        If data4 > data1 And data4 > data2 And data4 > data3 And data4 > data5 Then

            Console.WriteLine("el Cuarto numero ingresado es el mayor" & data4)
        End If

        If data5 > data1 And data5 > data2 And data5 > data3 And data5 > data4 Then

            Console.WriteLine("el Quinto numero ingresado es el mayor" & data5)
        End If


        Console.ReadKey()
    End Sub
End Module
