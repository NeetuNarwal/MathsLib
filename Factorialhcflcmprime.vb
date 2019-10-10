Module Module1

    MustInherit Class MathsLib

        Public MustOverride Function Prime(ByVal no As Integer) As Boolean

        Public MustOverride Function Factorial(ByVal no As Integer) As Integer

        Public MustOverride Function LCM(ByVal no As Integer, ByVal no2 As Integer) As Integer

        Public MustOverride Function HCF(ByVal no As Integer, ByVal no2 As Integer) As Integer
    End Class

    Public Class Mylib : Inherits MathsLib
        Public Overrides Function Factorial(ByVal no As Integer) As Integer
            Dim i, fact As Integer
            fact = 1

            For i = 1 To no
                fact *= i
                i = i + 1

            Next
            Return fact

        End Function

        Public Overrides Function Prime(ByVal no As Integer) As Boolean
            Dim i As Integer
            For i = 2 To (no - 1) / 2
                If no Mod i = 0 Then
                    Return False
                End If
            Next
            Return True
        End Function

        Public Overrides Function HCF(ByVal x As Integer, ByVal y As Integer) As Integer
            Dim a, b, r As Integer

            If x < y Then
                a = System.Math.Abs(x)
                b = System.Math.Abs(y)

            Else
                b = System.Math.Abs(x)

                a = System.Math.Abs(y)
            End If
            Do
                r = a Mod b
                If r = 0 Then Exit Do
                a = b
                b = r
            Loop
            Return b

        End Function

        Public Overrides Function LCM(ByVal x As Integer, ByVal y As Integer) As Integer
            Return (x * y) / HCF(x, y)

        End Function
    End Class

    Sub Main()
        Dim obj As New Mylib()

        Console.WriteLine(obj.Prime(4))
        Console.WriteLine(obj.Factorial(5))
        Console.WriteLine(obj.HCF(6, 8))
        Console.WriteLine(obj.LCM(2, 4))

        Console.ReadKey()

    End Sub


End Module
