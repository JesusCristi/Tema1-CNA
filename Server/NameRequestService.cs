using Grpc.Core;
using Generated;
using System.Threading.Tasks;

namespace Server
{
    internal class NameRequestService : Generated.NameRequestService.NameRequestServiceBase
    {
        public override Task<EmptyMessage> OutputName(Name request, ServerCallContext context)
        {
            System.Console.WriteLine("Hello {0}", request.Name_ + "!");
            return Task.FromResult(new EmptyMessage() { });
        }
    }
}
