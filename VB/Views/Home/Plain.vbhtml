@Html.DevExpress().RoundPanel( _
    Sub(settings)
            settings.Name = "rp"
            settings.SetContent( _
                Sub()
                        ViewContext.Writer.Write("<table border=""1\""><tr><td>RoundPanel Content Here</td></tr></table>")
                End Sub)
    End Sub).GetHtml()
<br />
@Html.ActionLink("<< Home", "Index")