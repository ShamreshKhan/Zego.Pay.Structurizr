using Structurizr;
using Structurizr.Api;
using Structurizr.Documentation;
using structurizr.Systems;
using structurizr.Views.Containers;
using structurizr.Views.Dynamic;
using structurizr.Views.Systems;

namespace structurizr
{
    
    /// <summary>
    /// This is a simple example of how to get started with Structurizr for .NET.
    /// </summary>
    class Program
    {

        #region Private variables
        private const long WorkspaceId = 68009;
        private const string ApiKey = "cada854f-6143-47ee-b7a5-9020213be652";
        private const string ApiSecret = "fa59853c-36ca-432c-bb8d-85498a088d8d";
        
 
        #endregion

        static void Main(string[] args)
        {
            #region Set up Structurizr
            // a Structurizr workspace is the wrapper for a software architecture model, views and documentation
            Workspace workspace = new Workspace("Zego", "Systems/Services/External integrations used in Zego");
            Model model = workspace.Model;
            model.Enterprise = new Enterprise("Zego");
            ViewSet views = workspace.Views;
            Styles styles = views.Configuration.Styles;
            #endregion

            ZegoStyles.ConfigureStyles(styles);
            
            #region Actors/Persons
            Actors.Initialize(model);
            #endregion

            #region Zego Systems
            ZegoSystems.Initialize(model);
            #endregion
            
            #region Non Zego Systems
            NonZegoSystems.Intitialize(model);
            #endregion

            #region How all systems are connected
            SystemRelationships.Intitialize();
            #endregion
            
            #region VIEW: Zego LANDSCAPE Context
            ZegoLandscapeView.Initialize(views);
            #endregion
            
            // ***************** Zego systems ***********************************************************//
          
            #region Pay (System, Containers, Associations, Views)

                #region Pay Containers
                PayContainers.Initialize();
                #endregion

                #region Pay containers associations
                PayContainersRelationships.Initialize();
                #endregion
            
                #region VIEW: Pay views
                    PaySystemContextView.Initialize(views);
                    PayContainersView.Initialize(views);

                    #region VIEW: Pay DYNAMIC views (workflows)

                      ResidentWeb2LoginDynamicView.Initialize(views);
                      ResidentPortalLoginDynamicView.Initialize(views);
            
                    #endregion
                #endregion
            #endregion

            // #region Utilities and Billing (System, Containers, Associations, Views)
            //
            //     #region Utilities containers
            //     var occiusMainDatabase = ZegoSystems.UtilitiesSystem.AddContainer("Occius Main Database", "??", "SQL Server/RDS/EC2");
            //     occiusMainDatabase.AddTags(ZegoStyles.DatabaseTag);
            //     var residentDataImport = ZegoSystems.UtilitiesSystem.AddContainer("Resident Data Import", "Loads files uploaded from Casa by the utility operations", ".net4.7/Cron/IIS/EC2");
            //     var casaUI = ZegoSystems.UtilitiesSystem.AddContainer("Casa UI", "??", ".net/IIS/EC2");
            //     var pcd = ZegoSystems.UtilitiesSystem.AddContainer("PCD", "??", "PHP/Apache/EC2");
            //     var plapi = ZegoSystems.UtilitiesSystem.AddContainer("Plapi", "??", "PHP/Apache/EC2");
            //     var residentFlatFileShare = ZegoSystems.UtilitiesSystem.AddContainer("File Share", "??", "PHP/Apache/EC2");
            //     residentFlatFileShare.AddTags(ZegoStyles.Folder);
            //
            //     #endregion
            //
            //     #region Utilitiy container associations
            //     Actors.UtilityOperations.Uses(casaUI, "uses");
            //     casaUI.Uses(residentFlatFileShare, "uses");
            //     residentDataImport.Uses(residentFlatFileShare, "uses");
            //     residentDataImport.Uses(occiusMainDatabase, "Use");
            //     pcd.Uses(occiusMainDatabase, "import residents");
            //     ZegoSystems.PayleaseSystem.Uses(plapi, "uses");
            //     plapi.Uses(occiusMainDatabase, "import residents");
            //     pcd.Uses(NonZegoSystems.PmIntegrationSoftwareSystem, "custom resident data import via API (Yardi etc.)");
            //     pcd.Uses(ZegoSystems.PayleaseSystem, "uses");
            //    
            //     #endregion
            //     
            //     #region VIEW: Utility views
            //
            //         #region VIEW: Utility System CONTEXT view
            //         var utilitySystemContextView = views.CreateSystemContextView(ZegoSystems.UemAndBilling, "Utility Pay", "StateFarm with RMS NA");
            //         //pmReviewandApprovePreBillRelationship
            //         utilitySystemContextView.Remove(ZegoSystems.UemAndBilling);
            //         utilitySystemContextView.Add(Actors.UtilityOperations);
            //         utilitySystemContextView.Add(Actors.Resident);
            //         utilitySystemContextView.Add(Actors.PropertyManager);
            //         utilitySystemContextView.Add(NonZegoSystems.CassSystem);
            //         utilitySystemContextView.Add(NonZegoSystems.EngieSystem);
            //         utilitySystemContextView.Add(ZegoSystems.BillingSystem);
            //         utilitySystemContextView.Add(ZegoSystems.UtilitiesSystem);
            //         utilitySystemContextView.Add(NonZegoSystems.PmIntegrationSoftwareSystem);
            //         utilitySystemContextView.Add(NonZegoSystems.MandrillSystem);
            //         utilitySystemContextView.Add(ZegoSystems.EngageSystem);
            //         utilitySystemContextView.Add(NonZegoSystems.OsgSystem);
            //
            //         utilitySystemContextView.PaperSize = PaperSize.A3_Landscape;
            //
            //         #endregion
            //     
            //         #region VIEW: Utility DYNAMIC views (workflows)
            //
            //             #region VIEW: Utility - Monthly resident data import
            //             var residentMonthlyDataImportProcessDynamicView = views.CreateDynamicView(ZegoSystems.UtilitiesSystem, "Utility - Monthly resident data import", "Monthly Resident data import container view (incl. occupancy, sq ft, rent, fees, charges,  etc)");
            //             residentMonthlyDataImportProcessDynamicView.Add(Actors.UtilityOperations, "Upload Resident flat file", casaUI);
            //             residentMonthlyDataImportProcessDynamicView.Add(casaUI, "Drops files to fileshare", residentFlatFileShare);
            //             residentMonthlyDataImportProcessDynamicView.Add(residentDataImport, "Load and process file", residentFlatFileShare);
            //             residentMonthlyDataImportProcessDynamicView.Add(residentDataImport, "Import residents", occiusMainDatabase);
            //             residentMonthlyDataImportProcessDynamicView.Add(pcd, "Start resident pull via API (Rent Manager, MRI, (etc async))", ZegoSystems.PayleaseSystem);
            //             residentMonthlyDataImportProcessDynamicView.Add(ZegoSystems.PayleaseSystem, "Get residents and store billing data", NonZegoSystems.PmIntegrationSoftwareSystem);
            //             residentMonthlyDataImportProcessDynamicView.Add(ZegoSystems.PayleaseSystem, "Pushes resident data", plapi);
            //             residentMonthlyDataImportProcessDynamicView.Add(plapi, "Import resident data", occiusMainDatabase);
            //             residentMonthlyDataImportProcessDynamicView.PaperSize = PaperSize.A3_Landscape;
            //
            //             #endregion
            //         #endregion
            //
            //     #endregion
            // #endregion
            //
            // #region Resx (System, Containers, Associations, Views)
            //
            //
            // #endregion
            //
            // #region MobileDoorman (System, Containers, Associations, Views)
            // #endregion

            AddDocumentation(workspace);
            UploadWorkspaceToStructurizr(workspace);
        }
        
        private static void UploadWorkspaceToStructurizr(Workspace workspace) {
            StructurizrClient structurizrClient = new StructurizrClient(ApiKey, ApiSecret);
            structurizrClient.PutWorkspace(WorkspaceId, workspace);
        }

        private static void AddDocumentation(Workspace workspace)
        {
            // // add some documentation
            // StructurizrDocumentationTemplate template = new StructurizrDocumentationTemplate(workspace);
            // template.AddContextSection(softwareSystem, Format.Markdown,
            //     "Here is some context about the software system...\n" +
            //     "\n" +
            //     "![](embed:SystemContext)");
        }
    }
}