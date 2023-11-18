using System;

public class Account
{
    public string[] Activities { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return FirstName + " " + LastName; } }
    public string AccountDate { get; set; }
    private float balance = 0;

    public void CheckAccount()
    {
        Console.WriteLine($"Hesap Sahibi: {FullName}");
        Console.WriteLine($"Hesap Açılış Tarihi: {AccountDate}");
        Console.WriteLine($"Bakiye: {balance}");
    }

    public void Deposit(float amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount} TL hesaba yatırıldı. Yeni bakiye: {balance}");
        }
        else
        {
            Console.WriteLine("Yatırılacak para miktarı 0'dan büyük olmalıdır.");
        }
    }

    public void Withdraw(float amount)
    {
        if (amount > 0 && amount <= 10000)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                Console.WriteLine($"{amount} TL çekildi. Yeni bakiye: {balance}");
                Activities = (Activities ?? new string[0])
                    .Concat(new string[] { $"Çekilen miktar: {amount} TL" })
                    .ToArray();
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }
        else
        {
            Console.WriteLine("Çekilecek para miktarı 0'dan büyük ve 10000'den küçük olmalıdır.");
        }
    }

    public void AccountActivities()
    {
        if (Activities != null)
        {
            Console.WriteLine("Hesap Hareketleri:");
            foreach (var activity in Activities)
            {
                Console.WriteLine(activity);
            }
        }
        else
        {
            Console.WriteLine("Hesap hareketi bulunmamaktadır.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Hesap oluştur
        var account = new Account
        {
            FirstName = "John",
            LastName = "Doe",
            AccountDate = "2023-01-15",
        };

        // Bakiye sorgula
        account.CheckAccount();

        // Para yatır
        account.Deposit(5000);

        // Para çek
        account.Withdraw(3000);

        // Hesap hareketlerini görüntüle
        account.AccountActivities();

        Console.ReadLine();
    }
}

