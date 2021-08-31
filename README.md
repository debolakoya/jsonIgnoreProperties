# jsonIgnoreProperties
A JSON serialization resolver to exclude properties when you don't want to decorate the properties with `[JsonIgnore]`

Usage :  
```csharp
var serializationResolver = new JsonIgnorePropertiesResolver(config.ExcludedFields()); 
or 
var serializationResolver = new JsonIgnorePropertiesResolver(new []{"Property1","Property2"}); 


JsonConvert.SerializeObject(
	YourObject,
	new JsonSerializerSettings() {
		ContractResolver = serializationResolver 
	};
);
```
