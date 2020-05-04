namespace GangOfFour.TemplateMethod
{
	/// <summary>
	/// Template
	/// </summary>
	public abstract class TaskTemplate
	{
		private AuditService auditService;

		public TaskTemplate()
		{
			this.auditService = new AuditService();
		}

		public TaskTemplate(AuditService auditService)
		{
			this.auditService = auditService;
		}

		public void Execute()
		{
			auditService.Audit();

			DoExecute();
		}

		protected abstract void DoExecute();
	}
}
