Public Class Animations
    Public Shared AnimationIcons As New Dictionary(Of String, HerbIconAnimation)

    Public Class HerbIconAnimation
        Public xcontrol As Object
        Public xstep As Integer = 0
        Public ystep As Integer = 0
        Public startloc As Point
        Public WithEvents animationTimer As New Timer With {.Interval = 200}

        Public Sub Trigger(movex As Integer, movey As Integer)
            xstep = movex
            ystep = movey
            xcontrol.Visible = True
            animationTimer.Start()
            xcontrol.Location = New Point(xcontrol.Location.X + xstep, xcontrol.Location.Y + ystep)
        End Sub

        Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
            If xcontrol.Location.Y > 300 Then
                animationTimer.Stop()
                xcontrol.Location = startloc
                xcontrol.Visible = False
                Exit Sub
            End If
            xcontrol.Location = New Point(xcontrol.Location.X + xstep, xcontrol.Location.Y + ystep)
        End Sub
    End Class

    Public Shared Sub Animation_Initialisation()
        For Each xobj In HERBS.Crafting_vals
            xobj.Visible = False
            AnimationIcons.Add(xobj.Tag.Tag.Name, New HerbIconAnimation With {
                .xcontrol = xobj.Tag.Tag,
                .startloc = xobj.Tag.Tag.Location
            })
        Next
    End Sub
End Class
