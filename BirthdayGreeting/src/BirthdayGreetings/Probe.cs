
namespace BirthdayGreetings
{
  public class Probe
  {
    private static readonly List<string> logged = new();

    public static void AssertLogged(string what)
    {
      if (!logged.Contains(what))
        throw new Exception("Assertion failed");
    }

    public static void AssertNotLogged(string what)
    {
      if (logged.Contains(what))
        throw new Exception("Assertion failed");
    }

    public static void Log(params string[] messages)
    {
      logged.AddRange(messages);
    }

    public static void NothingWasLogged()
    {
      if (logged.Count > 0)
        throw new Exception("Assertion failed");
    }

    public static void Reset()
    {
      logged.Clear();
    }
  }
}
