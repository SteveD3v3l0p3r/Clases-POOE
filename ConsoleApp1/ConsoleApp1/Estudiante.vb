Public Class Estudiante
    'Se desea conocer el promedio final de los alumnos de programación si se sabe que sus notas se conforman de 4 actividades donde 3 actividades valen 20% y la última'
    'vale el 40%, pedir datos generales del alumno más notas.'

    Private nombre, apellidos, codigo, carrera, materia As String
    Private nota1, nota2, nota3, nota4, notaFinal As Double

    Public Sub setNombre(ByVal nombre As String)
        Me.nombre = nombre
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function
    Public Sub setApellidos(ByVal apellidos As String)
        Me.apellidos = apellidos
    End Sub
    Public Function getApellidos() As String
        Return apellidos
    End Function

    Public Sub setCodigo(ByVal codigo As String)
        Me.codigo = codigo
    End Sub
    Public Function getCodigo() As String
        Return codigo
    End Function

    Public Sub setCarrera(ByVal carrera As String)
        Me.carrera = carrera
    End Sub

    Public Function getCarrera() As String
        Return carrera
    End Function

    Public Sub setMateria(ByVal materia As String)
        Me.materia = materia
    End Sub
    Public Function getMateria() As String
        Return materia
    End Function

    'Insertamos notas'

    Public Sub setNota1(ByVal nota1 As Double)
        If nota1 >= 0.0 And nota1 <= 10.0 Then
            Me.nota1 = nota1
        Else
            Console.WriteLine("Digite solo notas con valores entre 0.0 y 10.0, NO se aceptan valores negativos.")
        End If

    End Sub
    Public Function getNota1() As Double
        Return nota1
    End Function
    Public Sub setNota2(ByVal nota2 As Double)
        If nota2 >= 0.0 And nota2 <= 10.0 Then
            Me.nota2 = nota2
        Else
            Console.WriteLine("Digite solo notas con valores entre 0.0 y 10.0, NO se aceptan valores negativos.")
        End If
    End Sub
    Public Function getNota2() As Double
        Return nota2
    End Function
    Public Sub setNota3(ByVal nota3 As Double)
        If nota3 >= 0.0 And nota3 <= 10.0 Then
            Me.nota3 = nota3
        Else
            Console.WriteLine("Digite solo notas con valores entre 0.0 y 10.0, NO se aceptan valores negativos.")
        End If

    End Sub
    Public Function getNota3() As Double
        Return nota3
    End Function
    Public Sub setNota4(ByVal nota4 As Double)
        If nota4 >= 0.0 And nota4 <= 10.0 Then
            Me.nota4 = nota4
        Else
            Console.WriteLine("Digite solo notas con valores entre 0.0 y 10.0, NO se aceptan valores negativos.")
        End If

    End Sub
    Public Function getNota4() As Double
        Return nota4
    End Function

    Public Sub setNotaFinal(ByVal notaFinal As Double)
        Me.notaFinal = notaFinal
    End Sub
    Public Function getNotaFinal() As Double
        Return ((nota1 * 0.2) + (nota2 * 0.2) + (nota3 * 0.2) + (nota4 * 0.4))
    End Function

End Class
