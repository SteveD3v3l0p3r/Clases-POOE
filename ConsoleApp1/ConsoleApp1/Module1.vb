Module Module1

    Sub Main()
        'Pedir la edad y realizar la clasificación: bebé: 0-2, niño: 3-11, adolescente: 12-17, mayor de edad: 18-65, adulto mayor: 66-x'
        Dim edad As SByte
        Console.Write("Digite su edad: ")
        edad = Console.ReadLine()

        If edad <= 2 Then
            Console.WriteLine("Usted es un bebé.")
        ElseIf edad > 2 And edad <= 11 Then
            Console.WriteLine("Usted es un niño")
        ElseIf edad > 11 And edad <= 17 Then
            Console.WriteLine("Usted es un adolescente")
        ElseIf edad > 17 And edad <= 65 Then
            Console.WriteLine("Usted es un mayor de edad")
        ElseIf edad > 65 And edad <= 80 Then
            Console.WriteLine("Usted es un adulto mayor")
        ElseIf edad > 80 Then
            Console.WriteLine("Usted es un larga vida")
        End If
        Console.ReadKey()
    End Sub

End Module
