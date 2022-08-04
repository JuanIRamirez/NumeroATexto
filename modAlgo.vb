Module ModAlgo
   '
   Function Numero_a_Texto(ByVal nNumero As Double, Optional ByVal Miles As Boolean = False, Optional ByVal conDec As Boolean = True, Optional ByVal Mayusculas As Boolean = False, Optional ByVal MayMin As Boolean = True) As String
      '
      Dim cNumero As String = ""
      '
      Dim Entero As String = ""
      Dim cDecim As String = ""
      '
      Dim Unidad As String = ""
      Dim Decena As String = ""
      Dim Centena As String = ""
      Dim Millones As Integer
      Dim Billones As Integer

      Entero = CStr(Int(nNumero))

      If Len(Entero) > 16 Then
         'Dim dec = Double.Parse(nNumero.ToString)
         Return "Número demasiado grande"
      End If
      '
      If Len(Entero) > 12 Then
         Billones = Left(Entero, Len(Entero) - 12)
         Entero = Right(Entero, 12)
      End If
      If Len(Entero) > 6 Then
         Millones = Left(Entero, Len(Entero) - 6)
      End If
      Entero = Right(Entero, 6)
      '
      If Val(Entero) = 0 And Millones = 0 And Billones = 0 Then
         cNumero = "Cero "
      End If
      '
      If Billones > 0 Then cNumero = Numero_a_Texto(Billones, True, False,, False) & " billon" & IIf(Billones > 1, "es ", " ")
      If Millones > 0 Then cNumero += Numero_a_Texto(Millones, True, False,, False) & " millon" & IIf(Millones > 1, "es ", " ")
      If Val(Entero) > 999 Then cNumero += Numero_a_Texto(Val(Entero) / 1000, True, False,, False) + " mil "
      If Val(Entero) > 99 Then Centena = Left(Right(Entero, 3), 1)
      If Val(Right(Entero, 2)) < 16 Then
         Unidad = Right(Entero, 2)
      Else
         Decena = Left(Right(Entero, 2), 1)
         Unidad = Right(Entero, 1)
      End If
      '
      If Centena <> "" Then cNumero = cNumero & Centenas(Val(Centena), Val(Decena), Val(Unidad))
      '
      If Decena <> "" Then
         cNumero = cNumero & Decenas(Val(Decena), Val(Unidad))
      End If
      If Unidad <> "" Then cNumero = cNumero & Unidades(Val(Unidad), Miles)
      '
      If Not Miles Then
         If conDec Then
            If nNumero - Int(nNumero) > 0 Then
               cDecim = " c/" & Format((nNumero - Int(nNumero)) * 100, "00") & " Cvs."
            End If
         End If
      End If
      '
      If Mayusculas Then
         cNumero = UCase(cNumero)
         cDecim = UCase(cDecim)
      Else
         If Not MayMin Then
            cNumero = LCase(cNumero)
            cDecim = LCase(cDecim)
         End If
      End If
      '
      Return Trim(cNumero) & cDecim
      '
   End Function
   '
   Function Unidades(ByVal nUnidad As Integer, ByVal Miles As Boolean) As String
      '
      Select Case nUnidad
         Case 1
            Unidades = IIf(Miles, "Un ", "Uno ")
         Case 2
            Unidades = "Dos "
         Case 3
            Unidades = "Tres "
         Case 4
            Unidades = "Cuatro "
         Case 5
            Unidades = "Cinco "
         Case 6
            Unidades = "Seis "
         Case 7
            Unidades = "Siete "
         Case 8
            Unidades = "Ocho "
         Case 9
            Unidades = "Nueve "
         Case 10
            Unidades = "Diez "
         Case 11
            Unidades = "Once "
         Case 12
            Unidades = "Doce "
         Case 13
            Unidades = "Trece "
         Case 14
            Unidades = "Catorce "
         Case 15
            Unidades = "Quince "
         Case Else
            Unidades = ""
      End Select
      '
   End Function
   '
   Function Decenas(ByVal nDecena As Integer, ByVal nUnidad As Integer) As String
      '
      Select Case nDecena
         Case 1
            Decenas = "Dieci"
         Case 2
            Decenas = IIf(nUnidad = 0, "Veinte ", "Veinti")
         Case 3
            Decenas = "Treinta "
         Case 4
            Decenas = "Cuarenta "
         Case 5
            Decenas = "Cincuenta "
         Case 6
            Decenas = "Sesenta "
         Case 7
            Decenas = "Setenta "
         Case 8
            Decenas = "Ochenta "
         Case 9
            Decenas = "Noventa "
         Case Else
            Decenas = ""
      End Select

      If nDecena > 2 And nUnidad > 0 Then
         Decenas = Decenas & "y "
      End If
      '
   End Function
   '
   Function Centenas(ByVal nCentenas As Integer, ByVal nDecenas As Integer, ByVal nUnidades As Integer) As String
      '
      Select Case nCentenas
         Case 1
            Centenas = IIf(nDecenas + nUnidades = 0, "Cien ", "Ciento ")
         Case 2
            Centenas = "Doscientos "
         Case 3
            Centenas = "Trescientos "
         Case 4
            Centenas = "Cuatrocientos "
         Case 5
            Centenas = "Quinientos "
         Case 6
            Centenas = "Seiscientos "
         Case 7
            Centenas = "Setecientos "
         Case 8
            Centenas = "Ochocientos "
         Case 9
            Centenas = "Novecientos "
         Case Else
            Centenas = ""
      End Select
      '
   End Function
   '
   Sub SoloNumeros(ByRef key As Integer, Optional ByVal Punto As Boolean = False, Optional ByVal Texto As String = "", Optional ByVal ChrAdic As String = "")
      SoloNumeros(ChrW(key), Punto, Texto, ChrAdic)
   End Sub
   '
   Sub SoloNumeros(ByRef Key As Char, Optional ByVal Punto As Boolean = False, Optional ByVal Texto As String = "", Optional ByVal ChrAdic As String = "")
      '
      Dim i As Integer
      Dim j As Integer
      Dim c As String = ""
      '
      If Texto = "" Then
         If Not Punto Then
            If Key = "." Then
               Key = ""
            End If
         End If
         If Key > " " And (Key < "0" Or Key > "9") And Key <> ChrAdic Then
            If Key <> "." Then
               Key = ""
            End If
         End If
      Else
         For i = 1 To Len(Texto)
            If Asc(Mid(Texto, i, 1)) >= 48 And Asc(Mid(Texto, i, 1)) <= 57 Then
               c = c & Mid(Texto, i, 1)
            End If
         Next i
         Texto = c
         If Punto Then
            Texto = ""
            For i = Len(c) To 1 Step -3
               j = j + 1
               If Len(c) - (3 * j) + 1 > 1 Then
                  Texto = "." & Mid(c, Len(c) - (3 * j) + 1, 3) & Texto
               Else
                  Texto = Mid(c, 1, Len(c) - (j - 1) * 3) & Texto
               End If
            Next i
         End If
      End If
      '
   End Sub
   '
   Function Capitalize(Palabra As String) As String
      Dim c As String = ""
      Dim d As String = ""
      If Palabra.Length > 0 Then
         c = UCase(Left(Palabra, 1))
         If Len(Palabra) > 1 Then
            d = LCase(Right(Palabra, Len(Palabra) - 1))
         End If
      End If
      Return c + d
   End Function

End Module
