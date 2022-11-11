namespace DesignPatterns.MoshExs.Behavioral.TemplateMethod
{
    public abstract class BankTask
    {
        private readonly AuditTrail _AuditTrail;

        public BankTask(AuditTrail auditTrail)
        {
            _AuditTrail = auditTrail;
        }
        public void Execute()
        {
            _AuditTrail.Recored();
            DoExecute();
        }
        protected abstract void DoExecute();
    }
}
