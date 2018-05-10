Module Module21

    Sub Main()

        Dim num1 As Int16
        Dim num2 As Int16

        Console.WriteLine("ingrese un numero")
        num1 = Console.ReadLine()
        Console.WriteLine("ingrese un numero")
        num2 = Console.ReadLine()


        If num1 > num2 Then
            Console.WriteLine("el numero mayor es:" & num1)
        Else
            Console.WriteLine("el numero menor es:" & num1)

        End If
        If num2 > num1 Then

            Console.WriteLine("el numero mayor es:" & num2)
        Else
            Console.WriteLine("el numero menor es:" & num2)
        End If
        If num1 = num2 Then
            Console.WriteLine("los numeros son iguales:")
        Else
            Console.WriteLine("los numeros no son iguales:")

        End If


        Console.ReadKey()
    End Sub

End Module
