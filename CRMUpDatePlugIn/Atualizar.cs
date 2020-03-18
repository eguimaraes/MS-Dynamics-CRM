using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Workflow;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;

namespace CRMUpDatePlugIn
{
public class Atualizar : CodeActivity
    {
        [Output("PrimaryEntityID")]
        [ArgumentDescription("Primary Entity ID.")]
        public OutArgument<string> PrimaryEntityId { get; set; }

        [Output("PrimaryEntityName")]
        [ArgumentDescription("Primary Entity Name.")]
        public OutArgument<string> PrimaryEntityName { get; set; }

        [Output("SecondaryEntityName")]
        [ArgumentDescription("Secondary Entity Name.")]
        public OutArgument<string> SecondaryEntityName { get; set; }

        [Output("Request Id")]
        [ArgumentDescription("Request ID.")]
        public OutArgument<string> RequestId { get; set; }

        [Output("Correlation Id")]
        [ArgumentDescription("Correlation ID.")]
        public OutArgument<string> CorrelationId { get; set; }

        [Output("InitiatingUser Id")]
        [ArgumentDescription("InitiatingUser ID.")]
        public OutArgument<string> InitiatingUserId { get; set; }

        [Output("Operation Id")]
        [ArgumentDescription("Operation ID.")]
        public OutArgument<string> OperationId { get; set; }

        protected override void Execute(CodeActivityContext executionContext)
        {

            //Create the tracing service
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();

            //Create the context
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

            tracingService.Trace("Iniciando workflow");

                        
            if (context == null)
                throw new InvalidPluginExecutionException("Failed to retrieve workflow context.");

            //Save off the values
            PrimaryEntityId.Set(executionContext, context.PrimaryEntityId.ToString());

            if (context.RequestId.HasValue)
                RequestId.Set(executionContext, context.RequestId.Value.ToString());

            PrimaryEntityName.Set(executionContext, context.PrimaryEntityName);
            SecondaryEntityName.Set(executionContext, context.SecondaryEntityName);
            CorrelationId.Set(executionContext, context.CorrelationId.ToString());
            InitiatingUserId.Set(executionContext, context.InitiatingUserId.ToString());
            OperationId.Set(executionContext, context.OperationId.ToString());

            Guid guid=new Guid(PrimaryEntityId.Get<string>(executionContext));

            Entity entitlement = service.Retrieve("entitlement", new Guid(PrimaryEntityId.Get<string>(executionContext)), new ColumnSet(new String[] { "name", "statecode", "statuscode", "startdate" }));
            entitlement["statecode"] = new OptionSetValue(1);
            entitlement["statuscode"] = new OptionSetValue(1);

            service.Update(entitlement);






        }
    }


}

