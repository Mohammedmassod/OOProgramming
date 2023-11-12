using System;
using OOProgramming;

class Program
{
    private List<UserAccount>? userAccountList;
    private List<Transaction>? _listOfTransactions;


    static void Main(string[] args)
    {

        // بداية تطبيقك هنا
        // قم بتنفيذ خطوات تسجيل الدخول
        // إذا كانت عملية تسجيل الدخول ناجحة، يمكن للمستخدم رؤية العمليات وتنفيذها

        // تعليمات التطبيق بعد تسجيل الدخول
        if (IsLoggedIn())
        {
            IntroToClasses();
            FirstTests();
            TestLineOfCredit();
        }
        Program program = new Program();
        program.InitializeData();
    }
    public void InitializeData()
    {
        userAccountList = new List<UserAccount>
            {
                new UserAccount{Id=1, FullName = "Mohammed Nasser", AccountNumber=123456,CardNumber =4321, CardPin=1234,AccountBalance=50000.00m,IsLocked=false},
                new UserAccount{Id=2, FullName = "Taha Nasser", AccountNumber=456789,CardNumber =8765, CardPin=5678,AccountBalance=4000.00m,IsLocked=false},
                new UserAccount{Id=3, FullName = "Nasser Mohammed", AccountNumber=123555,CardNumber =0000, CardPin=0000,AccountBalance=2000.00m,IsLocked=true},
            };
        _listOfTransactions = new List<Transaction>();
    }
    static bool IsLoggedIn()
    {
        Console.WriteLine("يرجى إدخال اسم المستخدم:");
        string username = Console.ReadLine();

        Console.WriteLine("يرجى إدخال كلمة المرور:");
        string password = Console.ReadLine();

        // قم بتنفيذ المنطق الخاص بالتحقق من اسم المستخدم وكلمة المرور هنا
        // يمكنك استخدام البيانات المدخلة للتحقق من قاعدة البيانات أو أي طريقة أخرى تناسب احتياجاتك

        if (isValidLogin(username, password))
        {
            return true;
        }
        else
        {
            Console.WriteLine("اسم المستخدم أو كلمة المرور غير صحيحة.");
            return false;
        }
    }

    static bool isValidLogin(string username, string password)
    {
        // قم بتنفيذ المنطق اللازم للتحقق من صحة اسم المستخدم وكلمة المرور هنا
        // يمكنك استخدام قاعدة بيانات أو أي طريقة أخرى تناسب احتياجاتك
        // يجب أن يتطابق اسم المستخدم وكلمة المرور المدخلة مع القيم الموجودة في المصدر المعتمد لديك

        // قم بإرجاع القيمة المناسبة هنا (true إذا كانت الصحيحة ، و false إذا كانت غير صحيحة)
        return true; // قم بتعديل هذا الجزء واستبدله بالمنطق الخاص بك للتحقق من صحة اسم المستخدم وكلمة المرور
    }

   

    static void FirstTests()
    {
        var giftCard = new GiftCardAccount("gift card", 100, 50);
        giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
        giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
        giftCard.PerformMonthEndTransactions();
        // can make additional deposits:
        giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
        Console.WriteLine(giftCard.GetAccountHistory());

        var savings = new InterestEarningAccount("savings account", 10000);
        savings.MakeDeposit(750, DateTime.Now, "save some money");
        savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
        savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
        savings.PerformMonthEndTransactions();
        Console.WriteLine(savings.GetAccountHistory());
    }

    static void TestLineOfCredit()
    {
        var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
        // How much is too much to borrow?
        lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
        lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
        lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
        lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
        lineOfCredit.PerformMonthEndTransactions();
        Console.WriteLine(lineOfCredit.GetAccountHistory());
    }

    static void IntroToClasses()
    {
        var account = new BankAccount("<name>", 1000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        Console.WriteLine(account.Balance);
        account.MakeDeposit(100, DateTime.Now, "friend paid me back");
        Console.WriteLine(account.Balance);

        Console.WriteLine(account.GetAccountHistory());

    }
}

        // Test that the initial balances must be positive: