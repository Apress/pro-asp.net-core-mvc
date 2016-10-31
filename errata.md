#Errata for *Pro ASP.NET Core MVC*

On **page 40** `IsValue` should be `IsValid` (2 times):

The Controller base class provides a property called ModelState that provides information about the
conversion of HTTP request data into C# objects. If the ModelState.**IsValue** property returns true , then I know that MVC has been able to satisfy the validation constraints I specified through the attributes on the GuestResponse class. When this happens, I render the Thanks view, just as I did previously.

If the ModelState.**IsValue** property returns false , then I know that there are validation errors. Theobject returned by the ModelState property provides details of each problem that has been encountered, but I don’t need to get into that level of detail, because I can rely on a useful feature that automates the process of asking the user to address any problems by calling the View method without any parameters.

***

**Table 5-2**. Chapter Summary:

In the first row of the table in the "Solution" column, the text reads, "Use an @Model expression to define the model type and @model expressions to access the model object". This should read "Use an **@model** expression to define the model type and **@Model** expressions to access the model object".

***
