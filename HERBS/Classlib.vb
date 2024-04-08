Public Class Classlib
    Public Class Herb_type
        Public type As String = ""
        Public potency As String = ""

        Public Function Type_checker(xtype As String) As Boolean
            If type.Contains(xtype) Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class

    Public Class HerbstoragebyType
        Public typeamount As Integer = 0
        Public herbamount As New List(Of String)
    End Class

    Public Class CraftableMedicines
        Public craftable_amount As Integer = 0
        Public _herbrecipe As New Dictionary(Of String, List(Of String))
        Public ReadOnly Property Herbrecipe As Dictionary(Of String, List(Of String))
            Get
                If _herbrecipe.Count = 0 Then
                    Dim xx As New Dictionary(Of String, List(Of String))
                    For Each xlevel In HERBS.Medicine_level
                        xx.Add(xlevel, New List(Of String))
                    Next
                    _herbrecipe = xx
                End If

                Return _herbrecipe
            End Get
        End Property
    End Class

    Public Class Medicine_info
        Public info As String
        Public effect As String
    End Class
End Class
