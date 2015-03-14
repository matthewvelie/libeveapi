Note: I've created a new page: DesignDecisions to explain some of the decisions we made when creating the library.

### Network Interface ###
  * Extract an INetwork interface from the existing network code
  * Allow application developer to use their own network implementation
  * Use NMock to turn resource files into api responses instead of using local webserver
  * Provide a default simple network implementation

> This satisfies a few design goals. We can create a simple network implementation that will cover basic needs but every application is going to have different needs. The application developer should have the ability to write their own networking without having to dig into the library. This change would also allow us to make it so the unit tests work out of the box, no local webserver required. (Credit goes to Stinkbomb on the eve-o forums for bringing this up).