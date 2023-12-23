namespace Banking;
using Taxation;
using Notification;

public class Account {

    public event TaxOperation OverBalance;
    public event NotificationOps underBalance;

    public float Balance{get;set;}
    public void Deposit(float amount){
        this.Balance = this.Balance +amount;
        if(this.Balance>=500000){
            OverBalance((this.Balance*10)/100);
        }
    }

    public void Withdraw(float amount){
        this.Balance = this.Balance-amount;
        Console.WriteLine(this.Balance);
        if(this.Balance<=10000){
            underBalance("Eren" , "Your Account is Frozen as Balance is below the limit and furture operation is terminated till Base Limit amount is deposited");
        }
    }
}