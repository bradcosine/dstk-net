dstk-net
========

A c# wrapper for Data Science Toolkit APIs. Only street2coordinates has been implemented thus far so there is much more work to do.

Uses the [fastest JSON serializer for .NET](http://www.servicestack.net/mythz_blog/?p=344) which is the ServiceStack JsonSerializer in the [ServiceStack.Text](https://github.com/ServiceStack/ServiceStack.Text) project.

Example usage:
```c#
DSTK dstk = new DSTK();
dstk.DSTK_API_BASE = @"http://your.dstk.instance/";
var results = dstk.street2coordinates("8852 W. Sunset Blvd, Los Angeles, CA 90069");
Console.WriteLine("latitude: " +results.location.First().latitude);
Console.WriteLine("longitude: " +results.location.First().longitude);

```
