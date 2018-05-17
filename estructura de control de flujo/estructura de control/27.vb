Module ejercicio27
    Sub main()
        'Agudo si es menor a 90° Recto 
        '    si es igual a 90° Obtuso 
        '    si es mayor que 90° pero menor que 180° 
        '    Llano si es igual a 180°
        '    Cóncavo si es mayor que 180° pero menor que 360° Error 
        '    Si el valor es menor a 0º o mayor de 360º 
        Dim tamañoang As Int16

        Console.WriteLine("introduzca el tamaño del angulo")
        tamañoang = Console.ReadLine()

        Select Case tamañoang

            Case < 90
                Console.WriteLine("el angulo es agudo")
            Case = 90
                Console.WriteLine("el angulo es Recto")
            Case < 90 And tamañoang < 180
                Console.WriteLine("el angulo es Obtuso")
            Case = 180
                Console.WriteLine("el angulo es llano")
            Case > 180 And tamañoang < 360
                Console.WriteLine("el angulo es concavo")
            Case < 0 And tamañoang > 360
                Console.WriteLine("Error")

        End Select




    End Sub
End Module
