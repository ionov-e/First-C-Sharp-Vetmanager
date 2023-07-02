using static FirstCSharp.VetmanagerApiGateway.ApiGateway;

namespace FirstCSharp.VetmanagerApiGateway
{
    public class PathUri
    {
        private const string s_prefix = "/rest/api/";
        private readonly Model model;
        private readonly int? id;
        private readonly Filter[] filters;

        public PathUri(Model model)
        {
            this.model = model;
            filters = Array.Empty<Filter>();
        }

        public PathUri(Model model, int id)
        {
            this.model = model;
            this.id = id;
            filters = Array.Empty<Filter>();
        }

        public PathUri(Model model, Filter[] filters)
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

        public class Filter
        {
            private readonly string _property;
            private readonly string _value;
            private readonly string? _operator;

            public Filter(string property, string value)
            {
                _property = property;
                _value = value;
            }

            public Filter(string property, string value, string @operator)
            {
                _property = property;
                _value = value;
                _operator = @operator;
            }

            public override string ToString()
            {
                return "{'property':'" + _property + "', 'value':'" + _value + "'" + GetOperatorAsString() + "}";
            }

            private string GetOperatorAsString()
            {
                return _operator == null
                    ? ""
                    : ", 'operator':'" + _operator + "'";
            }
        }

    }
}
