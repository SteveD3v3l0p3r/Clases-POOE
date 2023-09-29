Public Class Ejercicios
    Public Sub secuenciaFibonacci()
        Console.Write("Valor maximo de la secuencia: ")
        Dim max = Console.ReadLine()

        Dim i As Integer
        Dim a = 1, b = 0, c = 1
        While c <= max
            c = a + b
            Console.WriteLine(a.ToString() & " + " & b.ToString() & " = " & c.ToString())
            b = a
            a = c
        End While
    End Sub

    'Determinar el mayor de 5 numeros'
    Public Function getMayor()
        Dim num_mayor = 0
        Dim i = 1

        While i <= 5
            Console.Write("Ingresa un numero: ")
            Dim num = Console.ReadLine()

            If num > num_mayor Then
                num_mayor = num
            End If
            i += 1
        End While

        Return num_mayor
    End Function
End Class
