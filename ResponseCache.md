## Description ##
A class for caching responses from the eve api.

## Thread Safety ##
All ResponseCache methods are thread safe.

## Methods ##
| **Name** | **Description** |
|:---------|:----------------|
| void Save(string filePath) | Save the response cache to this filename |
| void Save(Stream s) | Save the response cache using an external stream |
| void Load(string filePath) | Load the response cache from this filename |
| void Load(Stream s) | Load the response cache from an external stream |
| void Clear() | Clear the response cache |