# Introduction #

At current time the library supports sending requests through a proxy server if needed.  By default the library uses a "user-agent" string of "libEveApi/X" where X is the version number when downloading api data.


# Details #
Details below describe how to change the advanced network options.

## Proxy Server ##
To use a proxy server use the code below before calling any network connections.
```
//Set proxy server to localhost:8080
EveApi.SetProxy("localhost", 8080);
//or with username/password
EveApi.SetProxy("localhost", 8080, "username", "password");
```
This will set the library to use "localhost" as the server and 8080 as the port for the proxy server.  All internet traffic will be forwarded through this proxy server.  At current time only proxy's which do not require usernames and passwords are supported.

If a proxy has been set and needs to be removed then use
```
//Unset the proxy server
EveApi.UnsetProxy();
```
After running the code the proxy server settings are disregarded and will no longer be used for internet requests.

## User Agent ##
In order to better track how the library is used and to more easily identify potential bugs in the library, any requests that are made, use the user-agent string of "libEveApi/X" where X is the version number of the API being used.  No user data is transmitted with this.  If there is a large bug in the api, the remote server can refuse requests based on the version provided in the user-agent string.

Developers may want to add their application to the user-agent string in order to track use or other options.  The library provides an easy way to add this information.
```
//Add to the user-agent string
EveApi.SetUserAgent("API Program 1");
```
This additional text will be added to the user-agent string of every request.  Please make sure to do it before any web requests are made.  The new format of the user-agent string will be: "libEveApi/1 (XXXX)" where XXXX is the developer defined user agent string.