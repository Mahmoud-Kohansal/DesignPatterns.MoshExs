
namespace DesignPatterns.MoshExs.Behavioral.TemplateMethod
{
    public class TransferMoneyTask : BankTask
    {
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }
        protected override void DoExecute()
        {
            Console.WriteLine("Transfering money...");
        }
    }
}
