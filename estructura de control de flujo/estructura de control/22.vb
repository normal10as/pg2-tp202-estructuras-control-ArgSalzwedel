Module ejercicio22
    Sub main()
        Dim numm1 As Int16
        Dim numm2 As Int16
        Dim numm3 As Int16
        Console.WriteLine("ingrese un numero")
        numm1 = Console.ReadLine()
        Console.WriteLine("ingrese un numero")
        numm2 = Console.ReadLine()


        If numm1 > numm2 And numm2 > numm3 Then
            Console.WriteLine("el mayor es: " & numm1)

        ElseIf numm2 > numm1 And numm1 > numm3 Then
            Console.WriteLine("el mayor es: " & numm2)

        ElseIf numm3 > numm2 And numm2 > numm1 Then
            Console.WriteLine("el mayor es: " & numm3)
        End If

        If numm1 < numm2 And numm2 < numm3 Then
            Console.WriteLine("el menor es: " & numm1)

        ElseIf numm2 < numm1 And numm1 < numm3 Then
            Console.WriteLine("el menor es: " & numm2)

        ElseIf numm3 < numm2 And numm2 < numm1 Then
            Console.WriteLine("el menor es: " & numm3)
        End If

    End Sub
End Module
