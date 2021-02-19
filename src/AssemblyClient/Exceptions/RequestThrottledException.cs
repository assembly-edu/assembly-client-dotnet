/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.474
 * API Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


using System;

namespace AssemblyClient
{
  public class RequestThrottledException : Exception
  {
    public int Count { get; private set; }

    public int Period { get; private set; }

    public int Limit { get; private set; }

    public RequestThrottledException(string message, int count, int period, int limit)
      : base(message)
    {
      Count = count;
      Period = period;
      Limit = limit;
    }
  }
}
