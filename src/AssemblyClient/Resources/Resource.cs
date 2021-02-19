/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.472
 * API Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


namespace AssemblyClient
{
  public class Resource
  {
    protected ApiClient Client { get; private set; }

    internal static string DateFormat => "yyyy-MM-dd";

    public Resource(ApiClient client)
    {
      Client = client;
    }
  }
}
