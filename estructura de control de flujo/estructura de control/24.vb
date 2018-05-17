Module ejercicio24

    Sub main()

        Dim producto1 As Int16
        Dim Preciounit As Single
        Dim operacion As Single
        Dim operacion2 As Single
        Dim operacion3 As Single
        Dim subtotal As Single
        Console.WriteLine("ingrese la cantidad de productos :")
        producto1 = Console.ReadLine()

        Console.WriteLine("ingrese el precio ")
        Preciounit = Console.ReadLine()

        If producto1 >= 10 And producto1 <= 50 Then               '5%
            subtotal = producto1 * Preciounit
            Console.WriteLine("el subtotal es " & subtotal)
            operacion = (((producto1 * Preciounit) * 5) / 100)
            Console.WriteLine("el porcentaje de descuento aplicado es 5%:")
            Console.WriteLine("el monto descontado es:" & operacion)
            Console.WriteLine("el subtotal es :" & subtotal - operacion)

        End If
        If producto1 >= 51 And producto1 <= 250 Then
            subtotal = producto1 * Preciounit                              '10%
            Console.WriteLine("el subtotal es " & subtotal)
            operacion2 = (((producto1 * Preciounit) * 10) / 100)
            Console.WriteLine("el porcentaje de descuento aplicado es 10%:")
            Console.WriteLine("el monto descontado es:" & operacion2)
            Console.WriteLine("el total es :" & subtotal - operacion2)

        End If
        If producto1 >= 251 Then           '20%
            subtotal = producto1 * Preciounit
            Console.WriteLine("el subtotal es " & subtotal)
            operacion3 = (((producto1 * Preciounit) * 20) / 100)
            Console.WriteLine("el porcentaje de descuento aplicado es 20%:")
            Console.WriteLine("el monto descontado es:" & operacion3)
            Console.WriteLine("el total es :" & subtotal - operacion3)





        End If
        Console.ReadKey()




        'Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario.
        'Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, 
        'si es entre 51 y 250 el descuento es del 10% y 
        'si es 251 o más el descuento es del 20%
        'Informar 

        '*subtotal(cantidad por precio unitario),
        '*porcentaje de descuento aplicado,
        'monto descontado
        '*total(subtotal – monto descontado). 2
        '



    End Sub






End Module
