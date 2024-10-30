using NUnit.Framework;

namespace BirthdayGreetings.Tests
{
  public class BirthdayGreetings
  {
    [Test]
    public void DoesNotThrowsOnInit()
    {
      BirthdayService.SendGreetings(
        fileName: "employee_data.txt",
        date: new XDate(1, 1),
        smtpHost: "localhost",
        smtpPort: 1);
    }

    [Test]
    public void ShouldStart()
    {
      BirthdayService.SendGreetings(
        fileName: "employee_data.txt",
        date: new XDate(1, 1),
        smtpHost: "localhost",
        smtpPort: 1);

      Probe.AssertLogged("Starting");
    }
  }
}
