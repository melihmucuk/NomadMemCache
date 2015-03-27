# NomadMemCache
In-memory cache helper class for .NET. NomadMemCache uses 

### Adding Object

* Create object.

`var list = new List<int>{0, 1, 2, 3};`

* Add object to memory cache with key and expiration time.

`var cacher = Cacher.Instance.Add("sampleKey", list, DateTimeOffset.Now.AddMinutes(5));`

### Getting Object

Get object with specified key and type

`var listFromCache = Cacher.Instance.GetValue<List<int>>("sampleKey");`

### Deleting Object 

Delete object with key

`Cacher.Instance.Delete("sampleKey");`
