using Banking;
using Taxation;
using Notification;


Account acc = new Account();
acc.Balance = 60000;
// acc.OverBalance+=TaxationServ.PayIncomeTac;
acc.underBalance+=NotificationServ.SendMail;
acc.Withdraw(59200);
float CurrentB = acc.Balance;
Console.WriteLine("Your Account Current Balance is " + CurrentB);

NotificationOps revadi=new NotificationOps(NotificationServ.SendMail);
revadi("Manish", "jasghdjasgh");


NotificationServ.SendMail("yeren","Your salary is deposited");
NotificationOps proxy = new NotificationOps(NotificationServ.SendSMS);
proxy.Invoke("Err","yesiy");

NotificationOps pro1 = new NotificationOps(NotificationServ.SendSMS);
NotificationOps pro = new NotificationOps(NotificationServ.SendMail);



