<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Q559000/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Q559000/Controllers/HomeController.vb))
* [_GridViewPartial.cshtml](./CS/Q559000/Views/Home/_GridViewPartial.cshtml)
* [Index.cshtml](./CS/Q559000/Views/Home/Index.cshtml)
<!-- default file list end -->
# OBSOLETE - GridView - How to implement date range filtering using a custom editor in the AutoFilterRow
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5038)**
<!-- run online end -->


<p><strong>UPDATED:</strong><br><br>Starting with version v2015 vol 2 (v15.2), this functionality is available out of the box. Simply set the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebGridViewDataColumnHeaderFilterSettings_Modetopic">MVCxGridViewColumn.SettingsHeaderFilter.Mode</a> property to <strong>DateRangePicker</strong> to activate it. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2015/11/10/asp-net-grid-view-data-range-filter-adaptivity-and-more-coming-soon-in-v15-2.aspx">ASP.NET Grid View - Data Range Filter, Adaptivity and More (Coming soon in v15.2)</a> blog post and the <a href="http://demos.devexpress.com/MVCxGridViewDemos/Filtering/DateRangeHeaderFilter">Date Range Header Filter</a> demo for more information.<br>If you have version v15.2+ available, consider using the built-in functionality instead of the approach detailed below.</p><p><br><strong>For Older Versions: </strong></p><p>This example demonstrates how to implement date range filtering in the GridView extension.<br> Use the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcMVCxGridViewColumn_SetFilterTemplateContenttopic"><u>MVCxGridViewColumn.SetFilterTemplateContent</u></a><u> </u> method to create a custom editor and assign a delegate method to the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcGridViewSettings_ProcessColumnAutoFiltertopic"><u>GridViewSettings.ProcessColumnAutoFilter</u></a> property to process a custom filter expression sent from the client side.<br> <br><strong>See Also:<br> </strong><a href="https://www.devexpress.com/Support/Center/p/E1990">E1990: OBSOLETE - Date Range Filtering in the Filter Row</a></p>

<br/>


