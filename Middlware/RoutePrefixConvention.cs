namespace StudentManagmentSystem.Middlware
{
    using Microsoft.AspNetCore.Mvc.ApplicationModels;

    public class RoutePrefixConvention(string routePrefix) : IApplicationModelConvention
    {
        private readonly string _routePrefix = routePrefix;

        public void Apply(ApplicationModel application)
        {
            foreach (var controller in application.Controllers)
            {
                var  matchedSelectors  = controller.Selectors.FirstOrDefault(x => x.AttributeRouteModel != null);

                if (matchedSelectors != null)
                {
                    matchedSelectors.AttributeRouteModel = new AttributeRouteModel()
                    {
                        Template = $"{_routePrefix}/{matchedSelectors.AttributeRouteModel.Template}"
                    };
                }
                else
                {
                    controller.Selectors.Add(new SelectorModel
                    {
                        AttributeRouteModel = new AttributeRouteModel
                        {
                            Template = $"{_routePrefix}/{controller.ControllerName}"
                        }
                    });
                }
            }
        }
    }

}
