Public Class Clean_Code

    'Fail Fast
    Public Function GetPromedio_Dirty(suma As String, total As Integer)

        Dim promedio As Decimal = 0

        If total > 0 Then
            promedio = suma / total
        Else
            Throw New DivideByZeroException
        End If

        Return total

    End Function


    'Fail Fast
    Public Function GetPromedio_Clean(suma As String, total As Integer)

        If total = 0 Then Throw New DivideByZeroException
        Return suma / total

    End Function


    'Return Early'
    Public Function RegistrarBeca_Dirty(notas() As Integer)

        Dim contadorDesaprobados As Integer = 0
        For i As Integer = 0 To notas.Count - 1
            If notas(i) < 12 Then
                contadorDesaprobados = contadorDesaprobados + 1
            End If
        Next i

        If contadorDesaprobados = 0 Then
            'Registro la beca
            Return True
        Else
            MsgBox("No se puede registrar beca porque el alumno tiene cursos " & contadorDesaprobados & "  jalados.")
            Return False
        End If

    End Function

    'Return Early'
    Public Function RegistrarBeca_Clean(notas() As Integer)

        If notas.Where(Function(e) e < 12).Count > 0 Then Return False
        'Registro la beca

    End Function


End Class
