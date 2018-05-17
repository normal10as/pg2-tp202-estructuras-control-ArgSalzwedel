Module ejercicio211
    'Utilizando la estructura de repetición más adecuada elaborar un programa que se ingresen valores enteros
    '    hasta que se ingrese cero (descartar negativos). Luego informar cuantos son pares y cuantos impares. 
    '    Si todos son pares o todos son impares informar esta situación particular en lugar de la consigna anterior.

    Sub main()
        Dim x1 As Int16
        Dim x2 As Int16
        Dim y As Int16

        Console.WriteLine("ingrese un numero:")
        x1 = Console.ReadLine()
        Console.WriteLine("ingrese un numero:")
        x2 = Console.ReadLine()
        Do While x1 = 0

            If x1 Mod 2 Then
                Console.WriteLine("los numeros pares son: ")
                Console.WriteLine(x1)

            End If

        Loop

        Do While x1 = 1
            If x1 Mod 3 Then
                Console.WriteLine("los numeros impares son")
                Console.WriteLine(x1)
            End If
        Loop




    End Sub
End Module
