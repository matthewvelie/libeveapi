### Building the Library ###
The library is being developed in Visual Studio Express and targets the .Net 2.0 framework. You should be able to extract the source, open the libeveapi.sln file and build the library.

### Running the Unit Tests ###
  * The unit tests are written for [NUnit 2.4.6](http://prdownloads.sourceforge.net/nunit/NUnit-2.4.6-net-2.0.msi?download). The NUnit project is located in the UnitTests directory.
  * In the UnitTests project, Add Reference and browse to the bin directory of your nunit install. Add nunit.framework as a reference.
  * The unit tests depend on the XmlResponses folder being published at http://localhost/eveapi
  * Test the published folder by opening the url http://localhost/eveapi/account/Characters.xml in a browser