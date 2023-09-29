Public Class Ejercicios
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

    Public Sub num_par()
        Dim num As Integer
        Dim resp As String

        Console.WriteLine("Desea conocer los numeros pares o impares: (si/s o no/n)")
        resp = Console.ReadLine().ToLower()

        While resp = "s"
            Console.Write("Digite un numero: ")
            num = Console.ReadLine()

            If num Mod 2 = 0 Then
                Console.WriteLine("El numero: " & num & " es un numero par.")
            Else
                Console.WriteLine("El numero: " & num & " es un numero impar.")
            End If

            Console.WriteLine("Desea conocer los numeros pares o impares: (si/s o no/n)")
            resp = Console.ReadLine().ToLower()
        End While

    End Sub

    Public Sub tabla_multiplicar()
        Dim num, i As Integer
        i = 1
        Console.Write("Ingrese la tabla de multiplicar que desee: ")
        num = Console.ReadLine()

        While i <= 10
            Console.WriteLine(num & " X " & i & " = " & (num * i))
            i += 1
        End While
    End Sub

    Public Sub fibonnacci()
        Dim a, b, c, max As Integer
        a = 1
        b = 0
        c = 1

        Console.Write("Digite el valor maximo de la secuencia: ")
        max = Console.ReadLine()

        While c <= max
            c = a + b
            Console.WriteLine(a.ToString() & " + " & b.ToString() & " = " & c.ToString())
            b = a
            a = c
        End While

    End Sub
End Class
