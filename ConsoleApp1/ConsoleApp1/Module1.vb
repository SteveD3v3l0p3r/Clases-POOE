Module Module1

    Sub Main()
        'Lab1 = 30%, Lab2 = 30%, P = 40% = NF COMPUTO'
        Dim lab1, lab2, parcial, nf_computo As Double

        Console.Write("Digite la nota del laboratorio 1: ")
        lab1 = Console.ReadLine()

        Console.Write("Digite la nota del laboratorio 2: ")
        lab2 = Console.ReadLine()

        Console.Write("Digite la nota del parcial: ")
        parcial = Console.ReadLine()

        nf_computo = (lab1 * 0.3 + lab2 * 0.3 + parcial * 0.4)
        Console.Write("Su nota final del computo es: " & nf_computo)
        Console.ReadKey()
    End Sub

End Module
