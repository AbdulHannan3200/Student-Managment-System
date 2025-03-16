namespace StudentManagmentSystem.Middlware
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class RoutePrefixAttribute(string prefix) : RouteAttribute(prefix)
    {
    }

}
