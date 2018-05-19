@CODE
    ViewBag.Title = "Index"
End Code

<h2>How to implement date range filtering in the AutoFilterRow</h2>
  <script type="text/javascript">      
      var filterString="";
      function ApplyFilter(dateFrom, dateTo) {
          var d1 = dateFrom.GetText();
          var d2 = dateTo.GetText();
          if (d1 == "" || d2 == "")
              return;
          filterString = d1 + "|" + d2;        
          GridView.AutoFilterByColumn("OrderDate", d1 + "|" + d2);
      }      
      function EndCallback(s, e) {
          if (filterString != "" && s.cpFilter == "filter") {
              dde.SetText(filterString);
          }
          else
              filterString = "";
      }
    </script>
@Html.Action("GridViewPartial")
