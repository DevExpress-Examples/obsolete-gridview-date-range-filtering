@Imports DevExpress.Data.Filtering

@Code
Dim grid = Html.DevExpress().GridView(Sub(settings) 
        settings.Name = "GridView"
        settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}
        settings.CommandColumn.ClearFilterButton.Visible = True
		settings.KeyFieldName = "OrderID" 
       settings.CommandColumn.ShowClearFilterButton = True
		settings.CommandColumn.Visible = True
		settings.SettingsPager.Visible = True
		settings.Settings.ShowGroupPanel = True
		settings.Settings.ShowFilterRow = True
		settings.SettingsBehavior.AllowSelectByRowClick = False
		settings.Columns.Add("OrderID")
        settings.Columns.Add(Sub(column)
            column.FieldName = "OrderDate"
            column.SetFilterTemplateContent(Sub(content)                              
                  Html.DevExpress().DropDownEdit(Sub(sts)                 
                    sts.Name = "dde"
                    sts.SetDropDownWindowTemplateContent(Sub(c)                   
                        Html.DevExpress().Label(Sub(s)                       
                            s.Name = "L1"
                            s.Text = "From:"
                        End Sub).Render()
                        Html.DevExpress().DateEdit(Sub(s)                         
                            s.Name = "dFrom"
                            s.Date = new DateTime(1996, 1, 1)
                        End Sub).Render()
                        Html.DevExpress().Label(Sub(s)                       
                            s.Name = "L2"
                            s.Text = "To:"
                        End Sub).Render()
                        Html.DevExpress().DateEdit(Sub(s)                  
                            s.Name = "dTo"
                            s.Date = new DateTime(1997, 1, 1)
                        End Sub).Render()
                        Html.DevExpress().Button(Sub(s)                      
                            s.Name = "btn"
                            s.UseSubmitBehavior = false
                            s.ClientSideEvents.Click = "function (s, e) { ApplyFilter( dFrom, dTo ); }"
                            s.Text = "Apply"
                        End Sub).Render()
                    End Sub)
                End Sub).Render()
            End Sub)
        End Sub)
        settings.ClientSideEvents.EndCallback = "EndCallback"
        settings.ProcessColumnAutoFilter = Sub(s, e)      
            If e.Value = "|" Then
	            Return
             End If
			If e.Column.FieldName <> "OrderDate" Then
				Return
			End If
			If e.Kind = GridViewAutoFilterEventKind.CreateCriteria Then
				Dim dates() As String = e.Value.Split("|"c)
				Dim dateFrom As DateTime = Convert.ToDateTime(dates(0)), dateTo As DateTime = Convert.ToDateTime(dates(1))
				e.Criteria = (New OperandProperty("OrderDate") >= dateFrom) And (New OperandProperty("OrderDate") <= dateTo)
			End If
        End Sub
        settings.CustomJSProperties = Sub(s, e)       
            Dim g As MVCxGridView = TryCast(s, MVCxGridView)
			If g.FilterExpression.Contains("OrderDate") Then
				e.Properties("cpFilter") = "filter"
			Else
				e.Properties("cpFilter") = Nothing
			End If
        End Sub
        settings.Columns.Add("ShipName")
        settings.Columns.Add("ShipCity")
        settings.Columns.Add("ShipCountry")
    End Sub)
End Code
@Code
grid.Bind(Model).GetHtml()
End Code