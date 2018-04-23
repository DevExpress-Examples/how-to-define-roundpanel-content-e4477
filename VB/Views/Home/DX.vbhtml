@Html.DevExpress().RoundPanel( _
    Sub(settings)
            settings.Name = "rp"
            settings.SetContent( _
                Sub()
                        Html.DevExpress().Label( _
                            Sub(lbl)
                                    lbl.Name = "lbl"
                                    lbl.Text = "DevExpress Label - Some Text"
                            End Sub).Render()
                End Sub)
    End Sub).GetHtml()
<br />
@Html.ActionLink("<< Home", "Index")