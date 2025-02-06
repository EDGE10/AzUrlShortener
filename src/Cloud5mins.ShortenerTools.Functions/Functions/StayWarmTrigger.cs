using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Cloud5mins.ShortenerTools.Functions;

public static class StayWarmTrigger
{
	[Function("StayWarmTrigger")]
	public static void RunAsync([TimerTrigger("0 */10 * * * *")] TimerInfo myTimer, FunctionContext context)
	{
		var log = context.GetLogger(nameof(StayWarmTrigger));

		log.LogInformation("Executed timer trigger to keep function app warm.");
	}
}