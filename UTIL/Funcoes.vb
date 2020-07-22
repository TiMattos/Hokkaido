Imports System.IO
Imports System.Drawing


Public Module Funcoes

    Public Function imgToByteArray(ByVal img As Image) As Byte()
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function
    'convert bytearray to image
    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function

    Public Function ImageToArrayByte(ByVal pbinImagem As System.Drawing.Image) As Byte()
        'Converte uma imagem em um array de bytes
        Dim lobjMS As System.IO.MemoryStream = Nothing
        Try
            lobjMS = New System.IO.MemoryStream
            pbinImagem.Save(lobjMS, pbinImagem.RawFormat)
            'pbinImagem.Save(lobjMS, pObjCodec, pObjParams)
            Return lobjMS.ToArray()
        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(lobjMS) Then
                lobjMS.Close()
                lobjMS = Nothing
            End If
        End Try
    End Function


    Public Function ArrayByteToImage(ByVal objImagem As Byte()) As System.Drawing.Image
        Dim lmsImagem As System.IO.MemoryStream
        Dim lobjRetorno As Bitmap
        Try
            'Armazenando array de bytes(imagem) em memorystream
            lmsImagem = New System.IO.MemoryStream(objImagem)
            'Fechando memorystream
            lobjRetorno = New Bitmap(lmsImagem)
            Return lobjRetorno
        Catch lobjErro As Exception
            Throw lobjErro
        Finally
            lobjRetorno = Nothing
            'If Not IsNothing(lmsImagem) Then
            '    lmsImagem.Close()
            '    lmsImagem.Dispose()
            '    lmsImagem = Nothing
            'End If
        End Try
    End Function

    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer
        'Transformar letras minusculas em Maiúsculas
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        ' Intercepta um código ASCII recebido e admite somente letras
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SoLETRAS = 0
        Else
            SoLETRAS = KeyAscii
        End If

        ' teclas adicionais permitidas
        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter
        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace
    End Function


    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
                'Case 32
                'SoNumeros = Keyascii
        End Select
    End Function



End Module
