  public class JsonIgnorePropertiesResolver : DefaultContractResolver
    {
        private readonly HashSet<string>  propsToIgnore;

        public JsonIgnorePropertiesResolver(IEnumerable<string> propNamesToIgnore)
        { 
            propsToIgnore = new HashSet<string>(propNamesToIgnore, StringComparer.OrdinalIgnoreCase);
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            if (propsToIgnore.Contains(property.PropertyName))
            {
                property.ShouldSerialize = (x) => false;
            }

            return property;
        }
    }
