using Structurizr;
using Zego.Pay.Structurizr.Actors;
using Zego.Pay.Structurizr.Systems;

namespace structurizr.Views.Systems
{
    public static class PaySystemContextView
    {
        public static void Initialize(ViewSet views)
        {
            var paySystemContextView = views.CreateSystemContextView(ZegoSystems.Pay, "Zego Pay", "StateFarm with RMS NA");
            paySystemContextView.Remove(ZegoSystems.Pay);
            paySystemContextView.Add(ZegoActors.PropertyManager);
            paySystemContextView.Add(ZegoActors.Resident);
            paySystemContextView.Add(ZegoActors.ZegoAdmin);
            paySystemContextView.Add(NonZegoSystems.PmIntegrationSoftwareSystem);
            paySystemContextView.Add(ZegoSystems.PayleaseSystem);
            paySystemContextView.Add(NonZegoSystems.PmWebPortal);
            paySystemContextView.Add(ZegoActors.PmUsingGapi);
            paySystemContextView.Add(ZegoSystems.UtilitiesSystem);
            paySystemContextView.Add(NonZegoSystems.CleverTapSystem);
            paySystemContextView.Add(ZegoSystems.EngageSystem);
            paySystemContextView.PaperSize = PaperSize.A3_Landscape;
        }
    }
}