Module Module1

    Sub Main()
        Dim objEstudiante1 = New Estudiante()
        Dim respuesta As Char

        Console.WriteLine("***** UNIVERSIDAD GERADO BARRIOS *****")

        Console.Write("¿Desea ingresar notas? Si (s) No (n)")
        Console.WriteLine()
        respuesta = Console.ReadLine().ToLower()
        While respuesta = "s"
            Console.Write("Carrera: ")
            objEstudiante1.setCarrera(Console.ReadLine().ToString())
            Console.Write("Apellidos: ")
            objEstudiante1.setApellidos(Console.ReadLine().ToString())
            Console.Write("Nombres: ")
            objEstudiante1.setNombre(Console.ReadLine().ToString())
            Console.Write("Codigo: ")
            objEstudiante1.setCodigo(Console.ReadLine().ToString())
            Console.Write("Materia: ")
            objEstudiante1.setMateria(Console.ReadLine().ToString())
            Console.WriteLine("*************************************")

            Console.Write("Digite su nota 1: ")
            objEstudiante1.setNota1(Console.ReadLine())
            Console.Write("Digite su nota 2: ")
            objEstudiante1.setNota2(Console.ReadLine())
            Console.Write("Digite su nota 3: ")
            objEstudiante1.setNota3(Console.ReadLine())
            Console.Write("Digite su nota 4: ")
            objEstudiante1.setNota4(Console.ReadLine())

            Console.WriteLine("*************************************")
            Console.WriteLine("Alumno: " & objEstudiante1.getApellidos() & " " & objEstudiante1.getNombre())
            Console.WriteLine("Codigo de alumno: " & objEstudiante1.getCodigo())
            Console.WriteLine("Carrera: " & objEstudiante1.getCarrera())
            Console.WriteLine("Materia: " & objEstudiante1.getMateria())
            Console.WriteLine("Nota final de la materia: " & objEstudiante1.getNotaFinal())

            Console.Write("¿Desea ingresar notas? Si (s) No (n)")
            Console.WriteLine()
            respuesta = Console.ReadLine().ToLower()
        End While
        Console.ReadKey()
    End Sub

End Module

