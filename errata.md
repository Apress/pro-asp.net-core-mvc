#Errata for *Pro ASP.NET Core MVC*

On **page 40** `IsValue` should be `IsValid` (2 times):

The Controller base class provides a property called ModelState that provides information about the
conversion of HTTP request data into C# objects. If the ModelState.**IsValue** property returns true , then I know that MVC has been able to satisfy the validation constraints I specified through the attributes on the GuestResponse class. When this happens, I render the Thanks view, just as I did previously.

If the ModelState.**IsValue** property returns false , then I know that there are validation errors. Theobject returned by the ModelState property provides details of each problem that has been encountered, but I don�t need to get into that level of detail, because I can rely on a useful feature that automates the process of asking the user to address any problems by calling the View method without any parameters.

***

**Table 5-2**. Chapter Summary:

In the first row of the table in the "Solution" column, the text reads, "Use an @Model expression to define the model type and @model expressions to access the model object". This should read "Use an **@model** expression to define the model type and **@Model** expressions to access the model object".

***

**Figure 7-8** Figure shows the nutget.org package source unchecked. Both of the package sources shown in the figure should be checked, otherwise Visual Studio will not be able to download and install the Microsoft packages required for the examples.

***

On **page 298** `table` should be `product`:

This view contains a table that has a row for each product with cells that contains the name of the **product**,
the price, and buttons that will allow the product to be edited or deleted by sending requests to  Edit  and Delete  actions.

***

On **page 773** the contents of **Listing 24-20** should be:

    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using Cities.Models;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    namespace Cities.Infrastructure.TagHelpers {
        [HtmlTargetElement("select", Attributes = "model-for")]
        public class SelectOptionTagHelper : TagHelper {
            private IRepository repository;
            public SelectOptionTagHelper(IRepository repo) {
                repository = repo;
            }
            public ModelExpression ModelFor { get; set; }
            public override async Task ProcessAsync(TagHelperContext context, 
                    TagHelperOutput output) {

                output.Content.AppendHtml(
                    (await output.GetChildContentAsync(false)).GetContent());

                string selected = ModelFor.Model as string;

                PropertyInfo property = typeof(City)
                    .GetTypeInfo().GetDeclaredProperty(ModelFor.Name);
                foreach (string country in repository.Cities
                        .Select(c => property.GetValue(c)).Distinct()) {
                    if (selected.Equals(country, StringComparison.OrdinalIgnoreCase)) {
                        output.Content.AppendHtml($"<option selected>{country}</option>");
                    } else {
                        output.Content.AppendHtml($"<option>{country}</option>");
                    }
                }
                output.Attributes.SetAttribute("Name", ModelFor.Name);
                output.Attributes.SetAttribute("Id", ModelFor.Name);
            }
        }
    }

(Thanks to Gary Nicholas for reporting this problem)

***
On page **774** the contents of **Listing 24-21** should be:

    @model City
    @addTagHelper Cities.Infrastructure.TagHelpers.SelectOptionTagHelper, Cities
    @{  Layout = "_Layout"; }
    <form method="post" asp-controller="Home" asp-action="Create"
        asp-antiforgery="true">
        <div class="form-group">
            <label asp-for="Name"></label>
            <input class="form-control" asp-for="Name" />
        </div>
        <div class="form-group">
            <label asp-for="Country"></label>
            <select class="form-control" model-for="Country">
                <option disabled selected value="">Select a Country</option>
            </select>
        </div> 
        <div class="form-group"> 
            <label asp-for="Population"></label> 
            <input class="form-control" asp-for="Population" /> 
        </div> 
        <button type="submit" class="btn btn-primary">Add</button> 
        <a class="btn btn-primary" href="/Home/Index">Cancel</a> 
    </form> 

(Thanks to Gary Nicholas for reporting this problem)