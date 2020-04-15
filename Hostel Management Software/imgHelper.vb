Imports System.Drawing
Public Class imgHelper

    ' image to byte array from file name
    Public Shared Function ImgToByteArray(imgFile As String, imgFormat As ImageFormatConverter) As Byte()

    End Function

    ' the one above
    Public Shared Function ImgToByteArray(img As Image, imgFormat As ImageFormatConverter) As Byte()

        Dim tmpData As Byte

    End Function

    ' going the other way Bytes() --> Image
    Public Shared Function ImgFromByteArray(b As Byte()) As Image

    End Function

    ' shrink img and scale it
    Public Shared Function ImgToThumb(img As Image, maxSize As Size) As Image

    End Function

End Class
