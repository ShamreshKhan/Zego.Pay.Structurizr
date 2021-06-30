using Structurizr;
using structurizr.Systems;

namespace structurizr.Views.Systems
{
    public static class ZegoLandscapeView
    {

        public static void Initialize(ViewSet views)
        {
            var zegoBusinessLandscapeView = views.CreateSystemLandscapeView("Zego landscape view", "4 areas");
            zegoBusinessLandscapeView.Add(ZegoSystems.Pay);
            zegoBusinessLandscapeView.Add(ZegoSystems.ResX);
            zegoBusinessLandscapeView.Add(ZegoSystems.UemAndBilling);
            zegoBusinessLandscapeView.Add(ZegoSystems.MobileDoorman);
            zegoBusinessLandscapeView.PaperSize = PaperSize.A3_Landscape;
        }
    }
}