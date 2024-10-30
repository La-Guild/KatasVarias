using netDumbster.smtp;
using NUnit.Framework;

namespace BirthdayGreetings.Tests
{
  public class BirthdayGreetings
  {

    private SimpleSmtpServer? smtpServer;

    [SetUp]
    public void Setup()
    {
      smtpServer = SimpleSmtpServer.Start();
      Probe.Reset();
    }

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

    [Test]
    public void GreetsBirthday()
    {
      BirthdayService.SendGreetings(
        fileName: "employee_data.txt",
        date: new XDate(Day: 11, Month: 3),
        smtpHost: "localhost",
        smtpPort: smtpServer.Configuration.Port);

      Probe.AssertLogged("Birthday greeted: mary.ann@foobar.com");
    }

    [Test]
    public void DoesNotGreetsBirthday_ToWhomsBirthdayIsNotToday()
    {
      BirthdayService.SendGreetings(
        fileName: "employee_data.txt",
        date: new XDate(Day: 11, Month: 3),
        smtpHost: "localhost",
        smtpPort: smtpServer.Configuration.Port);

      Probe.AssertNotLogged("Birthday greeted: john.doe@foobar.com");
    }

    [Test]
    [Ignore("dsf")]
    public void ShouldBeGreenWhenRefactorIsOver()
    {
      BirthdayService.SendGreetings(
        fileName: "employee_data.txt",
        date: new XDate(Day: 11, Month: 3),
        smtpHost: "localhost",
        smtpPort: smtpServer.Configuration.Port);

      Probe.NothingWasLogged();
    }
  }
}
