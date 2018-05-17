Module ejercicio212
    'Utilizando la estructura de repetición más adecuada elaborar 
    '    Los números de Fibonacci constituyen una secuencia que empieza con 0 y 1; 
    '    el número que sigue a éstos se calcula sumando los dos anteriores y así sucesivamente.
    '    Utilizando la estructura de repetición más adecuada elaborar un algoritmo
    '    que imprima los 20 primeros números de la secuencia. 
    Sub main()

        Dim fibonacci As Int16
        Dim data1 As Int16
        Dim data2 As Int16 = 1
        Dim data3 As Int16

        For fibonacci = 1 To 19

            data3 = data1 + data2
            data1 = data2
            data2 = data3

            Console.WriteLine("los numeros fibonachis son:" & data3)
        Next





        Console.ReadKey()
    End Sub
End Module
