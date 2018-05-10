Module _25
    Enum mes
        enero
        marzo
        abril
        mayo
        junio
        julio
        agosto
        septiembre
        octubre
        noviembre
        diciembre
    End Enum
    Sub main()

        'Crear un programa con una enumeración para los meses del año. 
        '  Ingresar un valor numérico y mostrar a que mes corresponde. 
        '  Si el valor es inválido mostrar el mensaje correspondiente. 
        Dim x As Byte

        Console.WriteLine("ingrese un numero para obtener un mes:")
        x = Console.ReadLine()
        Select Case x
            Case 1
                Console.WriteLine("el mes es enero")
            Case 2
                Console.WriteLine("el mes es febrero")
            Case 3
                Console.WriteLine("el mes es marzo")
            Case 4
                Console.WriteLine("el mes es abril ")
            Case 5
                Console.WriteLine("el mes es mayo")
            Case 6
                Console.WriteLine("el mes es junio")
            Case 7
                Console.WriteLine("el mes es julio")
            Case 8
                Console.WriteLine("el mes es agosto")
            Case 9

                Console.WriteLine("el mes septiembre")
            Case 10
                Console.WriteLine("el mes es octubre")
            Case 11
                Console.WriteLine("el mes es noviembre")
            Case 12
                Console.WriteLine("el mes es diciembre")
            Case Else
                Console.WriteLine("el dato ingresado es incorrecto")
        End Select


        Console.ReadKey()
    End Sub
End Module
