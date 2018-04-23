@Html.DevExpress().RoundPanel( _
    Sub(settings)
            settings.Name = "rp"
            settings.SetContent( _
                Sub()
                        'Raw HTML
                        ViewContext.Writer.Write("<table border=""1""><tr><td>Content From Raw <b>HTML</b> Table Here...</td></tr></table>")
                        ViewContext.Writer.Write("<br/>")

                        'Action Method
                        Html.RenderAction("SeparateAction")
                        ViewContext.Writer.Write("<br/>")
                        ViewContext.Writer.Write("<br/>")

                        'Partial View with Html.BeginForm
                        Html.RenderPartial("SeparatePartialView")
                        ViewContext.Writer.Write("<br/>")
                        ViewContext.Writer.Write("<br/>")

                        'Html Helper
                        ViewContext.Writer.Write(Html.TextBox("txtName").ToHtmlString())
                        ViewContext.Writer.Write("<br/>")
                        ViewContext.Writer.Write("<br/>")
        
                        'Conditional
                        ViewContext.Writer.Write("Content From Conditional Rendering Block:")
                        ViewContext.Writer.Write("<br/>")
                        Dim condition As Boolean = DateTime.Now.Year = 2014
                        If (condition) Then
                            ViewContext.Writer.Write("<b>Condition Passed</b>")
                        Else
                            ViewContext.Writer.Write("<b>Condition Failed</b>")
                        End If
                        ViewContext.Writer.Write("<br/>")
                        ViewContext.Writer.Write("<br/>")
        
                        'DevExpress MVC Extensions
                        Html.DevExpress().Label( _
                            Sub(lbl)
                                    lbl.Name = "lbl"
                                    lbl.Text = "Content From DevExpress Label Here..."
                            End Sub).Render()
                End Sub)
    End Sub).GetHtml()
<br />
@Html.ActionLink("<< Home", "Index")