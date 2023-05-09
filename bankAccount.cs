public class bankAccount {

    private double balance = 0;

    //constructor
    public bankAccount(double newBalance) {
         if (newBalance < 0) {
            throw new Exception("No negative Values");
         }
         balance = newBalance;
    }

    public double withdraw(double amount) {
        balance = balance - amount;
     // balance -= amount;
     return balance;
    }

    public double deposit(double amount) {
        balance = balance + amount;
        // balance -+ amount;
        return balance;
    }

    // method to get the balance
    public double getBalance() {
        return balance;
    }
     
     // created a new checkingAccount that onherits from the bankAccount "parent class"
    public class checkingAccount : bankAccount {
      
      public checkingAccount(double initialBalance): base(initialBalance) {

      }
      }

    }
