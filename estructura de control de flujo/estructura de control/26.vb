Module ejercicio26


    Sub main()

        'Se ingresan dos valores relativos a un producto en venta
        'cantidad y precio unitario. Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, 
        'si es entre 51 y 250 el descuento es del 10% y 
        '    si es 251 o más el descuento es del 20%. 
        '    Informar subtotal(cantidad por precio unitario),
        '    porcentaje de descuento aplicado,
        '    monto descontado y el total (subtotal – monto descontado). 


        Dim producto As Byte
        Dim preciounitario As Single
        Dim interess As Single
        Dim operation As Single
        Dim subtotal As Single
        Console.WriteLine("ingrese precio unitario")
        preciounitario = Console.ReadLine()
        Console.WriteLine("ingrese la cantidad de productos")
        producto = Console.ReadLine()


        Select Case producto
            Case 10 To 50
                interess = 0.5
            Case 51 To 250
                interess = 0.1
            Case > 251
                interess = 0.2

        End Select
        subtotal = producto * preciounitario
        Console.WriteLine("el subtotal es:" & subtotal)
        Console.WriteLine("el porcentaje aplicado es de : " & interess * 100 & "%")
        operation = ((producto * preciounitario) * interess)
        Console.WriteLine("el monto descontado es de:" & operation)
        Console.WriteLine("el total es de:" & operation - subtotal)


        Console.ReadKey()

    End Sub
End Module
