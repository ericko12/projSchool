Imports System.Math
Public Class convernum

    '*******************************************
    ' Convierte un número  del 1 al 9 en texto. *
    '*******************************************
    Dim Pointer1 As Integer = 0
    Dim Pointer2 As Integer = 0

    Function GetDigit(ByVal Digit)
        Select Case Val(Digit)
            Case 1 : GetDigit = "Un"
            Case 2 : GetDigit = "Dos"
            Case 3 : GetDigit = "Tres"
            Case 4 : GetDigit = "Cuatro"
            Case 5 : GetDigit = "Cinco"
            Case 6 : GetDigit = "Seis"
            Case 7 : GetDigit = "Siete"
            Case 8 : GetDigit = "Ocho"
            Case 9 : GetDigit = "Nueve"
            Case Else : GetDigit = ""
        End Select
    End Function

    '*********************************************
    ' Convierte números de 10 a 99 a texto. *
    '*********************************************
    Function GetTens(ByVal TensText)
        Dim Result As String

        Result = ""           'anula el valor temporal de la funcion
        If Val(Microsoft.VisualBasic.Left(TensText, 1)) = 1 Then   ' si el valor esta entre 10-19
            Select Case Val(TensText)
                Case 10 : Result = "Diez"
                Case 11 : Result = "Once"
                Case 12 : Result = "Doce"
                Case 13 : Result = "Trece"
                Case 14 : Result = "Catorce"
                Case 15 : Result = "Quince"
                Case 16 : Result = "Dieciseis"
                Case 17 : Result = "Diecisiete"
                Case 18 : Result = "Dieciocho"
                Case 19 : Result = "Diecinueve"
                Case Else
            End Select
        Else    ' Si el valor esta entre 20-99
            Select Case Val(Microsoft.VisualBasic.Left(TensText, 1))
                Case 2 : Result = "Veinte "
                Case 3 : Result = "Treinta "
                Case 4 : Result = "Cuarenta "
                Case 5 : Result = "Cincuenta "
                Case 6 : Result = "Sesenta "
                Case 7 : Result = "Setenta "
                Case 8 : Result = "Ochenta "
                Case 9 : Result = "Noventa "
                Case Else
            End Select
            Result = Result & GetDigit _
       (Microsoft.VisualBasic.Right(TensText, 1))  'Retrae el lugar
        End If
        GetTens = Result
    End Function
    '*******************************************
    ' Convierte los números de 100-999 a texto *
    '*******************************************
    Function GetHundreds(ByVal MyNumber)
        Dim Result As String
        Dim Quinien As String
        Dim Quinien2 As String

        If Val(MyNumber) = 0 Then Exit Function
        MyNumber = Microsoft.VisualBasic.Right("000" & MyNumber, 3)

        'Converte el lugar de las centenas
        Quinien2 = " Cientos "
        If Mid(MyNumber, 1, 1) <> "0" Then
            Quinien = GetDigit(Mid(MyNumber, 1, 1))
            If Quinien = "Cinco" Then
                Quinien = "Quinientos "
                Quinien2 = ""
            End If
            If Quinien = "Uno" Then
                Quinien = ""
                Quinien2 = "Ciento "
            End If
            If Quinien = "Nueve" Then
                Quinien = "Nove"
                Quinien2 = "cientos "
            End If
            If Quinien = "Siete" Then
                Quinien = "Sete"
                Quinien2 = "cientos "
            End If
            Result = Quinien & Quinien2 ' aca le agrega al numero la palabra
        End If

        'Convierte el lugar de los miles
        If Mid(MyNumber, 2, 1) <> "0" Then
            Quinien = GetTens(Mid(MyNumber, 2))
            If Pointer1 = 0 Then
                Pointer1 = 1
                Quinien = Replace(Quinien, " ", " y ")
            End If

            Result = Result & Quinien
        Else
            Quinien = GetDigit(Mid(MyNumber, 3))
            Result = Result & Quinien
        End If

        GetHundreds = Result
    End Function
    '****************
    ' Function Principal *
    '****************
    Function SpellNumber(ByVal MyNumber) As String
        Dim OtroNumero As String = MyNumber
        Dim Dolares, Centavos, Temp As String
        Dim DecimalPlace, Count

        Dim Place(9) As String
        Place(2) = " Mil "
        Place(3) = " Millones "
        Place(4) = " Billones "
        Place(5) = " Trillones "

        ' String representa la cantidad
        MyNumber = Trim(Str(MyNumber))

        ' el lugar de la posicion decimal ) si ninguno
        DecimalPlace = InStr(MyNumber, ".")

        'Convierte Centavos and set MyNumber a la cantidad en dolares
        If DecimalPlace > 0 Then
            OtroNumero = Microsoft.VisualBasic.Left(MyNumber, DecimalPlace - 1)
            Centavos = GetTens(Microsoft.VisualBasic.Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2))
            MyNumber = Trim(Microsoft.VisualBasic.Left(MyNumber, DecimalPlace - 1))
        Else
            OtroNumero = MyNumber
        End If

        Dim enta, hacer As String
        Dim BuscaEspacio As Integer
        enta = CStr(MyNumber)
        hacer = ""
        If enta.Length = 2 And (Microsoft.VisualBasic.Right(enta, 1) = "0") Then
            hacer = "cero"
        End If

        Count = 1
        Do While MyNumber <> ""
            Temp = GetHundreds(Microsoft.VisualBasic.Right(MyNumber, 3))
            If Temp <> "" Then Dolares = Temp & Place(Count) & Dolares
            If Len(MyNumber) > 3 Then
                If Len(OtroNumero) = 4 And Microsoft.VisualBasic.Left(OtroNumero, 1) = "1" Then
                    Pointer2 = 1
                End If
                MyNumber = Microsoft.VisualBasic.Left(MyNumber, Len(MyNumber) - 3)
            Else
                MyNumber = ""
            End If
            Count = Count + 1
        Loop

        If Pointer2 = 1 Then
            Dolares = Microsoft.VisualBasic.Right(Dolares, Len(Dolares) - 3)
        End If

        If hacer = "cero" Then
            BuscaEspacio = InStr(Dolares, " ")
            Dolares = Microsoft.VisualBasic.Left(Dolares, BuscaEspacio - 1)
        End If


        Select Case Dolares
            Case ""
                Dolares = "Ningún Peso"
            Case "One"
                Dolares = "Un Peso"
                MsgBox("sopas")
            Case Else
                Dolares = Dolares & " Pesos"
        End Select


        Centavos = Replace(Centavos, " ", " y ")
        Select Case Centavos
            Case ""
                Centavos = " "
            Case Else
                Centavos = " con " & Centavos & " Centavos"
        End Select

        SpellNumber = Dolares & Centavos
        Return SpellNumber
    End Function


    Function EnLetras(ByVal Valor As Object, Optional ByVal Tipo As Byte = 2) As String ' Funcion Principal '
        If Not IsNumeric(Valor) Then
            EnLetras = "¡ La referencia no es valor o... 'excede' la precisión !!!" : Exit Function
        End If : Dim Moneda As String, Fracs As String, Cents As Integer
        If Int(Abs(Valor)) = 1 Then Moneda = " peso" Else Moneda = " pesos"
        If Right(Letras(Abs(Int(Valor))), 6) = "illón " Or Right(Letras(Abs(Int(Valor))), 8) = "illones " Then Moneda = "de" & Moneda
        Cents = Math.Round(Abs(Valor) - Int(Abs(Valor)), 2) * 100
        If Cents = 1 Then Fracs = " centavo" Else Fracs = " centavos"
        If Cents = 0 Then Fracs = "" Else Fracs = " con " & Letras(Cents) & Fracs
        EnLetras = Letras(Int(Abs(Valor))) & Moneda & Fracs
        If Valor < 0 Then EnLetras = "menos " & EnLetras
        If Tipo = 2 Then EnLetras = UCase(EnLetras) ' TODO EN MAYUSCULAS '
        If Tipo = 3 Then EnLetras = StrConv(EnLetras, vbProperCase) ' Todo Como Nombre Propio '
        If Tipo = 4 Then EnLetras = UCase(Left(EnLetras, 1)) & Mid(EnLetras, 2) ' Primer letra en mayuscula SOLAMENTE '
        EnLetras = "(" & EnLetras & ")"
    End Function
    Private Function Letras(Valor) As String ' Función Auxiliar [uso 'exclusivo' de la funcion 'principal'] '
        Select Case Int(Valor)
            Case 0 : Letras = "cero"
            Case 1 : Letras = "un"
            Case 2 : Letras = "dos"
            Case 3 : Letras = "tres"
            Case 4 : Letras = "cuatro"
            Case 5 : Letras = "cinco"
            Case 6 : Letras = "seis"
            Case 7 : Letras = "siete"
            Case 8 : Letras = "ocho"
            Case 9 : Letras = "nueve"
            Case 10 : Letras = "diez"
            Case 11 : Letras = "once"
            Case 12 : Letras = "doce"
            Case 13 : Letras = "trece"
            Case 14 : Letras = "catorce"
            Case 15 : Letras = "quince"
            Case Is < 20 : Letras = "dieci" & Letras(Valor - 10)
            Case 20 : Letras = "veinte"
            Case Is < 30 : Letras = "veinti" & Letras(Valor - 20)
            Case 30 : Letras = "treinta"
            Case 40 : Letras = "cuarenta"
            Case 50 : Letras = "cincuenta"
            Case 60 : Letras = "sesenta"
            Case 70 : Letras = "setenta"
            Case 80 : Letras = "ochenta"
            Case 90 : Letras = "noventa"
            Case Is < 100 : Letras = Letras(Int(Valor \ 10) * 10) & " y " & Letras(Valor Mod 10)
            Case 100 : Letras = "cien"
            Case Is < 200 : Letras = "ciento " & Letras(Valor - 100)
            Case 200, 300, 400, 600, 800 : Letras = Letras(Int(Valor \ 100)) & "cientos"
            Case 500 : Letras = "quinientos"
            Case 700 : Letras = "setecientos"
            Case 900 : Letras = "novecientos"
            Case Is < 1000 : Letras = Letras(Int(Valor \ 100) * 100) & " " & Letras(Valor Mod 100)
            Case 1000 : Letras = "mil"
            Case Is < 2000 : Letras = "mil " & Letras(Valor Mod 1000)
            Case Is < 1000000 : Letras = Letras(Int(Valor \ 1000)) & " mil"
                If Valor Mod 1000 Then Letras = Letras & " " & Letras(Valor Mod 1000)
            Case 1000000 : Letras = "un millón "
            Case Is < 2000000 : Letras = "un millón " & Letras(Valor Mod 1000000)
            Case Is < 1000000000000.0# : Letras = Letras(Int(Valor / 1000000)) & " millones "
                If (Valor - Int(Valor / 1000000) * 1000000) _
                  Then Letras = Letras & Letras(Valor - Int(Valor / 1000000) * 1000000)
            Case 1000000000000.0# : Letras = "un billón "
            Case Is < 2000000000000.0#
                Letras = "un billón " & Letras(Valor - Int(Valor / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Letras = Letras(Int(Valor / 1000000000000.0#)) & " billones "
                If (Valor - Int(Valor / 1000000000000.0#) * 1000000000000.0#) _
                  Then Letras = Letras & " " & Letras(Valor - Int(Valor / 1000000000000.0#) * 1000000000000.0#)
        End Select
    End Function
End Class
