Public Class Conversor
    Public etiquetas As String()() = {
        New String() {"Dolar", "Euro", "Quetzal", "Lempiras", "Colón SV", "Córdobas", "Colón CR"},'Monedas
        New String() {"Metros", "Centimetros", "Pulgadas", "Pies", "Varas", "Yardas", "Kilometros", "Millas"},'Longitud
        New String() {"Dias", "Segundos", "Minutos", "Horas", "Semanas", "Meses", "Años", "Decadas", "Siglos"}'Tiempo
    }

    Public valores As Double()() = {
        New Double() {1, 0.96, 7.84, 24.83, 8.74, 36.6, 532.1},'Monedas
        New Double() {1, 100, 39.3701, 3.28084, 1.1963081929167, 1.09361, 0.001, 0.000621371},'Longitud
        New Double() {1, 86400, 1440, 24, 0.142857, 0.0328767, 0.00273973, 0.000273973, 0.000027397} 'Tiempo
    }

    Public Function convertir(ByVal tipo As SByte, ByVal de As SByte, ByVal a As SByte, ByVal cantidad As Double)
        Return valores(tipo)(a) / valores(tipo)(de) * cantidad
    End Function
End Class
