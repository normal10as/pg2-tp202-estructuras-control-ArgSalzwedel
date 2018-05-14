Module _29
    '    Elabore un algoritmo que permita hacer conversiones de equivalencias entre metros, centímetros, yardas, pies y pulgadas:
    '         Presentar un menú y preguntar que unidad de medida desea convertir, 
    '    el valor a convertir y después mostrar las equivalencias.  
    '         Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 
    '1 pulgada = 2.54 cm, 1 metro = 100 cm.   Ejemplo: si escogió metros, debe solicitar y 
    '        leer el número de metros a convertir, 
    '        luego imprimir la equivalencia en centímetros, pies, yardas y pulgadas.

    Sub main()
        Dim metros As Int16
        Dim centimetros As Int16
        Dim yardas As Int16
        Dim pies As Int16
        Dim pulgadas As Int16
        Dim x As Byte
        Console.WriteLine("ingresar valor en metros:")
        metros = Console.ReadLine()
        Console.WriteLine("ingresar valor en centimetros")
        centimetros = Console.ReadLine
        Console.WriteLine("ingrese valor en yardas")
        yardas = Console.ReadLine()
        Console.WriteLine("ingresar valor en pies")
        pies = Console.ReadLine()
        Console.WriteLine("ingresar valor en pulgadas")
        pulgadas = Console.ReadLine

        Console.WriteLine("ingrese que valor quiere convertir sabiendo que:1-metros-2centimetros-3yardas-4pies-5pulgadas")
        x = Console.ReadLine()
        Select Case x

            Case 1

                Console.WriteLine("a que medida desea convertir?-centimetros-3yardas-4pies-5pulgadas")
                x = Console.ReadLine()
                Select Case x
                    Case 2
                        Console.WriteLine("el resultado de la conversion" & metros / 100)
                    Case 3
                        Console.WriteLine("el resultado de la conversion es " & metros / 0, 9144)
                    Case 4
                        Console.WriteLine("el resultado de la conversion es " & metros / 27, 8635)
                    Case 5
                        Console.WriteLine("el resultado de la conversion es" & metros / 23, 22)
                End Select
            Case 2

                Console.WriteLine("a que medida desea convertir?-2metros-3yardas-4pies-5pulgadas")
                x = Console.ReadLine()
                Select Case x
                    Case 2
                        Console.WriteLine("el resultado de la conversion" & metros / 100)
                    Case 3
                        Console.WriteLine("el resultado de la conversion es " & metros / 0, 9144)
                    Case 4
                        Console.WriteLine("el resultado de la conversion es " & metros / 27, 8635)
                    Case 5
                        Console.WriteLine("el resultado de la conversion es" & metros / 23, 22)

                End Select


        End Select
    End Sub
End Module
