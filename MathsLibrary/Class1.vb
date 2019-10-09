Public Class Maths
    Public Shared Function Factorial(ByVal no As Integer) As Integer
        Dim i, j As Integer
        j = 1
        For i = 1 To no
            j = j * i
        Next
        Factorial = j
    End Function

    Public Shared Function Collatz(ByVal no As Integer) As Integer
        ' The Collatz function is defined for a positive integer n as follows. 
        'f(n) = 3n+1 if n is odd 
        'n/2 if n is even 
        Return 0
    End Function
    Public Shared Function HCF(ByVal no1 As Integer, ByVal no2 As Integer) As Integer

    End Function

    Public Shared Function LCM(ByVal no1 As Integer, ByVal no2 As Integer) As Integer

    End Function

    Public Shared Function ArmstrongNo(ByVal no As Integer) As Boolean

    End Function


       

End Class
