using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.CSharpFeatures.AsyncApp
{
    public class SiteChecker
    {
        public int GetStatusCode(string siteurl)
        {
            var client = new HttpClient();
            var httpResponse = client.GetAsync(siteurl).Result;
            return (int)httpResponse.StatusCode;
        }
        public double AverageRating(IEnumerable<int> ratings)
        {
            return ratings.Average();
        }
    }
}
