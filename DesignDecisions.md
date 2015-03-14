### Objects returned from the library should be immutable (aka public member variables are bad) ###
Here are a few of the problems with doing this:
  * Fields with readonly modifier can only be set in the declaration or constructor of their class. XmlSerializer always calls the class's empty constructor making it impossible to set the readonly fields.
  * Collections (including Array) are still mutable when wrapped in a get-only property. They can be made immutable with a ReadOnlyCollection

&lt;T&gt;

 wrapper. Using an immutable collection with XmlSerializer might be possible with a public property that wraps the array in the getter. Then the ReadXml() function (from IXmlSerializable) could operate on a mutable private collection. In this case the underlying collection is still mutable and public immutability can only be enforced at runtime.

We could overcome most of the issues by only caching the xml response from the eve-api and re-parsing it every time it comes out of the cache. One of the goals of the project is to make using the cache is inexpensive as possible so I don't really see that as a possibility. Especially now that the cache can act as a data store.

Implementing the IXmlSerializable interface would allow us to set private fields that could be wrapped in get-only public properties. Along with the quasi-readonly collections outline above this might be an ok solution. From the public interface I think the objects would be effectively immutable. Implementing IXmlSerializable for all the response object classes would be a fair amount of work.

**Pros**
  * Would discourage improper usage of the response objects and cache. An example would be using the library as a mutable data store.

**Cons**
  * Not enough immutability to be inherently thread safe.
  * IReadOnlyCollection enforces immutability at runtime not compile time.
  * Quite a bit of work implementing the ReadXml and WriteXml methods for every class (including nested classes)
  * There is the possibility of performance issues  Automatic links to other wiki pages

### Why do response objects use Array for collections instead of List

&lt;T&gt;

 ###
ApiResponse objects are not meant to be modified. While we don't have a way to effectively enforce immutability, I would definitely discourage adding, removing or modifying objects from a response. I think using Array for response collections discourages modification more than a List

&lt;T&gt;

 would.