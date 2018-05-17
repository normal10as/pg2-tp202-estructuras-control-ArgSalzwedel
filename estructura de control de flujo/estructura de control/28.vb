Module ejercicio28
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

        '        Elabore un programa que indique cuantos días tiene un mes respetando las siguientes condiciones:     
        '             El flujo normal solo se ingresa el número de mes a evaluar y validar con una enumeración.
        '         En el caso de febrero ingresar el año y tener en cuenta que un año bisiesto tiene 29 días. 
        'Un año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando es múltiplo de 400. Por ejemplo, 
        '        el año 2000 si bisiesto pero el 2100 no lo es. 

        Dim dias As Byte
        Dim anio As Int16
        Dim operation As Int16
        Console.WriteLine("ingrese un mes 1-12")
        dias = Console.ReadLine()
        Select Case dias
            Case 1
                Console.WriteLine("el mes es enero tiene 31 dias")
            Case 2
                Console.WriteLine("ingrese un anio")
                anio = Console.ReadLine()
                If anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0 Then

                    Console.WriteLine("el mes es febrero y tiene 29 dias")
                Else
                    Console.WriteLine("el mes es febrero y tiene 28 dias")
                End If
            Case 3
                Console.WriteLine("el mes es marzo y tiene 31 dias")
            Case 4
                Console.WriteLine("el mes es de abril y tiene 30 dias")
            Case 5
                Console.WriteLine("el mes es de mayo y tiene 31 dias")
            Case 6
                Console.WriteLine("el mes es de junio y tiene 30 dias")
            Case 7
                Console.WriteLine("el mes es de julio y tiene 31 dias")
            Case 8
                Console.WriteLine("el mes es de agosto y tiene 31 dias")
            Case 9
                Console.WriteLine("el mes es de septiembre y tiene 30 dias")
            Case 10
                Console.WriteLine("el mes es de octubre y tiene 31 dias")
            Case 11
                Console.WriteLine("el mes es de noviembre y tiene 30 dias")
            Case 12
                Console.WriteLine("el mes es de diciembre y tiene 31 dias")
        End Select







    End Sub
End Module
