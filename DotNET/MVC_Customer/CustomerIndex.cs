@model IEnumerable<WB_Customer.Models.Customer>

@{
    ViewData["Title"] = "Index";
}

<h1>Index</h1>

<p>
    <a asp-action="Create">Create New</a>
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.CustomerId)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.CustomerName)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.MobileNo)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.BillAmount)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
@foreach (var item in Model) {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.CustomerId)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.CustomerName)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.MobileNo)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.BillAmount)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", new { id=item.CustomerId }) |
                    @Html.ActionLink("Details", "Details", new { id=item.CustomerId }) |
                    @Html.ActionLink("Delete", "Delete", new { id=item.CustomerId })
            </td>
        </tr>
}
    </tbody>
</table>
