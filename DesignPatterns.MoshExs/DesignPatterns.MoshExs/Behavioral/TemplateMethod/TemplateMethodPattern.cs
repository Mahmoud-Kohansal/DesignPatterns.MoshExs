
namespace DesignPatterns.MoshExs.Behavioral.TemplateMethod
{
    public static class TemplateMethodPattern
    {
        public static void Run()
        {
            BankTask transferMoneyTask = new TransferMoneyTask(new AuditTrail());
            transferMoneyTask.Execute();
            Console.WriteLine("-----------Template method for Window----------");
            var window = new DialogWindow();
            window.Close();

           
        }
    }
}
