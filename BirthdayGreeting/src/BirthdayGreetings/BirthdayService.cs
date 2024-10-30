using System.Net.Mail;

namespace BirthdayGreetings;

public class BirthdayService
{
  public static void SendGreetings(
    string fileName,
    XDate date,
    string smtpHost,
    int smtpPort)
  {
    Probe.Log("Starting");

    List<Employee> employees =
      ReadEmployeesFrom(fileName);

    GreetIfIsItsBirthday(date, smtpHost, smtpPort, employees);
  }

  private static List<Employee> ReadEmployeesFrom(
    string fileName)
  {
    StreamReader input = new(fileName);
    var employees = new List<Employee>();

    string? str = input.ReadLine();
    while ((str = input.ReadLine()) != null)
    {
      var employeeData = str.Split(new char[] { ',' }, 1000);
      Employee employee = new(
        employeeData[1].Trim(),
        employeeData[0].Trim(),
        employeeData[2].Trim(),
        employeeData[3].Trim());

      employees.Add(employee);

    }

    return employees;
  }

  private static void GreetIfIsItsBirthday(
    XDate date,
    string smtpHost,
    int smtpPort,
    List<Employee> employees)
  {
    employees.ForEach(employee =>
    {
      if (employee.IsBirthday(date))
      {
        SendMessage(
          smtpHost: smtpHost,
          smtpPort: smtpPort,
          from: "sender@here.com",
          subject: "Happy Birthday!",
          body: $"Happy Birthday, dear {employee.FirstName}",
          recipient: employee.Email);

        Probe.Log($"Birthday greeted: {employee.Email}");
      }
    });
  }

  private static void SendMessage(string smtpHost, int smtpPort, string from, string subject, string body,
    string recipient)
  {
    using var client = new SmtpClient(smtpHost, smtpPort);
    var message = new MailMessage(from, recipient, subject, body);
    client.Send(message);
  }
}