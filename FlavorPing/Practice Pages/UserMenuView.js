@model IEnumerable<FlavorPing.Models.MenuItems>

@{
    ViewBag.Title = "Index";
}

<h2>Index</h2>



@foreach (var item in Model) {
    <tr>
        <td>
            @Html.DisplayFor(modelItem => item.ItemName)
    <label>
        <input id="item.ItemName" type="checkbox" class="checkboxExample1"  />item.ItemName
    </label>
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.Description)
        </td>
        
    </tr>
}

</table>