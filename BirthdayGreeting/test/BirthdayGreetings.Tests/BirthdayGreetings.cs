using netDumbster.smtp;
using NUnit.Framework;
using System.Net.Mail;

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
      GreetOn(day: 1, month: 1);
    }

    [Test]
    public void ShouldStart()
    {
      GreetOn(day: 1, month: 1);

      Probe.AssertLogged("Starting");
    }

    [Test]
    public void GreetsBirthday()
    {
      GreetOn(day: 11, month: 3);

      Probe.AssertLogged("Birthday greeted: mary.ann@foobar.com");
    }

    [Test]
    public void DoesNotGreetsBirthday_ToWhomsBirthdayIsNotToday()
    {
      GreetOn(day: 11, month: 3);

      Probe.AssertNotLogged("Birthday greeted: john.doe@foobar.com");
    }

    [Test]
    public void FailsToSendToServer()
    {
      smtpServer.Stop();

      Assert.Throws<SmtpException>(() => GreetOn(day: 11, month: 3));
    }

    [Test]
    [Ignore("dsf")]
    public void ShouldBeGreenWhenRefactorIsOver()
    {
      GreetOn(day: 11, month: 3);

      Probe.NothingWasLogged();
    }

    private void GreetOn(int day, int month)
    {
      BirthdayService.SendGreetings(
          fileName: "employee_data.txt",
          date: new XDate(Day: day, Month: month),
          smtpHost: "localhost",
          smtpPort: smtpServer.Configuration.Port);
    }
  }
}
