Module ejercicio_210

    'For y Do Loop. Crear un módulo para resolver el siguiente problema: 
    'con dos valores numéricos enteros cualquiera, el primero menor al segundo
    '    , calcular cuantos números múltiplos de cinco hay entre ellos e informar. 
    '    Repetir esta solución en el mismo módulo con las diferentes alternativas las estructuras de repetición 
    '    “do while … loop”, “do until … loop”, “do … loop while”, “do … loop until y “for” 
    Sub main()
        Dim num1 As Int16
        Dim num2 As Int16
        Dim x As Byte
        Dim y As Byte = 1
        Console.WriteLine("ingrese un numero")
        num1 = Console.ReadLine()
        Console.WriteLine("ingrese un numero mayor al anterior")
        num2 = Console.ReadLine()


        Do While num1 <= y
            If num1 Mod 5 Then
                Console.WriteLine("hay multiplos de 5 :" & num1)

            ElseIf num2 Mod 5 Then
                Console.WriteLine("hay multiplos de 5:" & num2)

            End If

            y = y + 1
        Loop

        Do Until num1 = y

            If num1 Mod 5 Then
                Console.WriteLine("hay multiplos de 5 :" & num1)

            ElseIf num2 Mod 5 Then
                Console.WriteLine("hay multiplos de 5:" & num2)

            End If
        Loop







    End Sub
End Module
