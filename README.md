<!--
*** Thanks for checking out the README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "feature".
*** Thanks again! Now go create something AMAZING! :D
-->

# MediaTypesLite

Lite library containing definition of Media Types

<!-- ABOUT THE PROJECT -->
## About The Project

Since in `System.Net.Mime.MediaTypeNames` not all Media Types all defined
<br />
and it would be nice to have const for example `MediaTypeNames.Image.Png`
<br />
So I decided to parse documentation of Media Types to create const strings for all types.
<br />


<!-- MEDIA TYPES -->
## Media Types

<a href="https://www.iana.org/assignments/media-types/media-types.xhtml">Media Types</a> are defined by <a href="https://www.iana.org">Internet Assigned Numbers Authority</a>
<br />
It is two-part identifier for file formats and format contents transmitted <a href="https://en.wikipedia.org/wiki/Media_type">more info</a>

### Definded Media Types in project
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Application.cs"><strong>Application »</strong></a>
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Audio.cs"><strong>Audio »</strong></a>
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Font.cs"><strong>Font »</strong></a>
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Image.cs"><strong>Image »</strong></a>
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Message.cs"><strong>Message »</strong></a>
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Model.cs"><strong>Model »</strong></a>
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Multipart.cs"><strong>Multipart »</strong></a>
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Text.cs"><strong>Text »</strong></a>
* <a href="https://github.com/SideswipeN7/MediaTypesLite/blob/main/source/MediaTypesLite/MediaType/Video.cs"><strong>Video »</strong></a>

<!-- GETTING STARTED -->
## Getting Started

<a href="https://www.nuget.org/packages/WhyNot.MediaTypesLite"><strong>NuGet package</strong></a>
This is how to use this library
```cs
var imgPng = MediaTypesLite.MediaType.Image.Png; // image/png
var appWord = MediaTypesLite.MediaType.Application.Msword; // application/msword
```
