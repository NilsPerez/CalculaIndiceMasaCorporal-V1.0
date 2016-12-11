Module Module1

    Sub Main()
        Dim peso, talla, IMC As Double
        Console.WriteLine("Ingrese Talla en Metros:")
        Double.TryParse(Console.ReadLine, talla)
        Console.WriteLine("Ingrese Peso en Kg:")
        Double.TryParse(Console.ReadLine, peso)
        If peso > 0 And talla > 0 Then
            IMC = peso / (talla * talla)
            Console.WriteLine("Su Indice Masa Coporal es:")
            Console.WriteLine(IMC)
            If IMC > 18.5 And IMC < 24.9 Then
                Console.WriteLine("Riesgo segun su IMC es: PROMEDIO")
            ElseIf IMC > 25 And IMC < 29.9 Then
                Console.WriteLine("Riesgo segun su IMC es: AUMENTADO")
            ElseIf IMC > 30 And IMC < 44.9 Then
                Console.WriteLine("Riesgo segun su IMC es: MODERADO")
            ElseIf IMC > 35 And IMC < 39.9 Then
                Console.WriteLine("Riesgo segun su IMC es: SEVERO  ")
            ElseIf IMC >= 40 Then
                Console.WriteLine("Riesgo segun su IMC es: MUY SEVERO")
            End If
        Else
            Console.WriteLine("Datos incorrectos, No se puede calcular su IMC")

        End If

        Console.ReadKey()

    End Sub

End Module
