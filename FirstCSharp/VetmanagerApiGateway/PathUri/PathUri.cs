namespace FirstCSharp.VetmanagerApiGateway.PathUri
{
    public class PathUri
    {
        private const string s_prefix = "/rest/api/";
        private readonly AccessibleModelPathUri model;
        private readonly int? id;
        private readonly Filter[] filters;

        public PathUri(AccessibleModelPathUri model)
        {
            this.model = model;
            filters = Array.Empty<Filter>();
        }

        public PathUri(AccessibleModelPathUri model, int id)
        {
            this.model = model;
            this.id = id;
            filters = Array.Empty<Filter>();
        }

        public PathUri(AccessibleModelPathUri model, Filter[] filters)
        {
            this.model = model;
            this.filters = filters;
        }

        public override string ToString() { return s_prefix + model.ToString() + GetIdIfPresent() + GetFiltersIfPresent(); }

        private string GetIdIfPresent() { return id == null ? "" : $"/{id}"; }

        private string GetFiltersIfPresent()
        {

            if (!filters.Any())
            {
                return "";
            }

            string filtersAsString = string.Empty;

            foreach (var filter in filters)
            {
                filtersAsString += filter.ToString();

                if (!filter.Equals(filters.Last()))
                {
                    filtersAsString += ',';
                }
            }

            return $"?filter=[{filtersAsString}]";
        }
    }
}
