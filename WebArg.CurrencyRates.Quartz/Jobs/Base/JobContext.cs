using Quartz;

namespace WebArg.CurrencyRates.Quartz.Jobs.Base;

/// <summary>
/// Сведения для планировщика
/// </summary>
public static class JobContext
{
    public static ITrigger Trigger => s_trigger.Value;

    private static readonly AsyncLocal<ITrigger> s_trigger;

    static JobContext()
    {
        s_trigger = new AsyncLocal<ITrigger>();
    }

    public static void SetTrigger(ITrigger trigger)
    {
        s_trigger.Value = trigger;
    }
}
