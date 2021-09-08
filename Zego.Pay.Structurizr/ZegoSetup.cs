using Structurizr;

namespace Zego.Pay.Structurizr
{ 
    public static class ZegoSetup
    {
        public static Workspace Workspace;
        public static Model Model;
        public static ViewSet Views;
        public static Styles Styles;
        public static void Initialize()
        {
            Workspace = new Workspace("Zego Pay", "Systems/Services/External integrations used in Zego Pay");
            Model = Workspace.Model;
            Model.Enterprise = new Enterprise("Zego");
            Views = Workspace.Views;
            Styles = Views.Configuration.Styles;
        }
    }
}