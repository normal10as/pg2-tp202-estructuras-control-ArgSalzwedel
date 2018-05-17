Module sobrecarga
    Sub main()



        Console.WriteLine(sumar(10, 5))
        Console.WriteLine(sumar(10, 5, 7))
    End Sub
    Private Function sumar(a As Int16, b As Int16, c As Int16) As Double
        'return a + b +c 
        Return sumar(sumar(a, b), c)

    End Function

    Private Function sumar(a As Int16, b As Int16) As Double
        Return a + b


    End Function






End Module
