using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;

namespace CoreFormatterAutofac.Formatters
{
    public class SampleFormatter : OutputFormatter
    {
        private readonly IAmADepedency _depedency;

        public SampleFormatter(IAmADepedency depedency)
        {
            SupportedMediaTypes.Clear();
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/vnd.sample+json"));
            _depedency = depedency;
        }

        public override Task WriteResponseBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}