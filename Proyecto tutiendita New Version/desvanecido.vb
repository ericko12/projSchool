Module desvanecido
    Public Sub EffectIn(ByVal nom As Form)
        Dim Effect As Double
        For Effect = 0.0 To 1.1 Step 0.1
            nom.Opacity = Effect
            nom.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub EffectOut(ByVal nom As Form)
        Dim Effect As Double
        For Effect = 1.1 To 0.0 Step -0.1
            nom.Opacity = Effect
            nom.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

End Module
