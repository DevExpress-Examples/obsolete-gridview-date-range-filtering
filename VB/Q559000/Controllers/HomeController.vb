Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxEditors

Namespace Q559000.Controllers
	Public Class HomeController
		Inherits Controller
		'
		' GET: /Home/

		Public Function Index() As ActionResult
			Return View()
		End Function
		Private db As New Q559000.Models.NorthwindDataContext()

		<ValidateInput(False)> _
		Public Function GridViewPartial() As ActionResult
			Dim model = db.Orders
			Return PartialView("_GridViewPartial", model)
		End Function

	End Class
End Namespace
