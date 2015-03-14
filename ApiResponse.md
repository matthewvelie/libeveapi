### Description ###
A base class that is used for all responses from the Eve Api.

| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| HashedUrl | string | SHA1 hash of the url used to make the request |
| CurrentTime | DateTime | The currentTime timestamp from the XML Response in CCP time |
| CachedUntil | DateTime | The cachedUntil timestamp from the XML Response in CCP time |
| CachedUntilLocal | DateTime | The cachedUntil timestamp in local time |
| CurrentTimeLocal | DateTime | The currentTime timestamp in local time |
| ResponseXml | XmlDocument | The XML response from CCP |
| FromCache | bool | True if this object came from the cache. False if it came directly from the eve api|