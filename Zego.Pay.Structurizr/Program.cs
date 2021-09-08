using structurizr;
using Structurizr;
using Structurizr.Api;
using structurizr.Views.Containers;
using structurizr.Views.Dynamic;
using structurizr.Views.Systems;
using Zego.Pay.Structurizr.Actors;
using Zego.Pay.Structurizr.Systems;

namespace Zego.Pay.Structurizr
{
    class Program
    {
        #region Workspace keys
        private const long WorkspaceId = 000000;
        private const string ApiKey = "[API Key]";
        private const string ApiSecret = "[API Secret]";
        #endregion

        static void Main(string[] args)
        {
            ZegoSetup.Initialize();

            ZegoStyles.ConfigureStyles(ZegoSetup.Styles);
            ZegoActors.Initialize(ZegoSetup.Model);
            ZegoSystems.Initialize(ZegoSetup.Model);
            NonZegoSystems.Intitialize(ZegoSetup.Model);
            SystemRelationships.Intitialize();
            ZegoLandscapeView.Initialize(ZegoSetup.Views);
            
            PayContainers.Initialize();
            PayContainersRelationships.Initialize();
            
            PaySystemContextView.Initialize(ZegoSetup.Views);
            PayContainersView.Initialize(ZegoSetup.Views);

            ResidentWeb2LoginDynamicView.Initialize(ZegoSetup.Views);
            ResidentPortalLoginDynamicView.Initialize(ZegoSetup.Views);
            
            AddDocumentation(ZegoSetup.Workspace);
            UploadWorkspaceToStructurizr(ZegoSetup.Workspace);
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