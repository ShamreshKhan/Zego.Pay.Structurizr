using Structurizr;
using structurizr.Systems;

namespace structurizr.Views.Systems
{
    public static class PaySystemContextView
    {
        public static void Initialize(ViewSet views)
        {
            var paySystemContextView = views.CreateSystemContextView(ZegoSystems.Pay, "Zego Pay", "StateFarm with RMS NA");
            paySystemContextView.Remove(ZegoSystems.Pay);
            paySystemContextView.Add(Actors.PropertyManager);
            paySystemContextView.Add(Actors.Resident);
            paySystemContextView.Add(Actors.ZegoAdmin);
            paySystemContextView.Add(NonZegoSystems.PmIntegrationSoftwareSystem);
            paySystemContextView.Add(ZegoSystems.PayleaseSystem);
            paySystemContextView.Add(NonZegoSystems.PmWebPortal);
            paySystemContextView.Add(Actors.PmUsingGapi);
            paySystemContextView.Add(ZegoSystems.UtilitiesSystem);
            paySystemContextView.Add(NonZegoSystems.CleverTapSystem);
            paySystemContextView.Add(ZegoSystems.EngageSystem);
            paySystemContextView.PaperSize = PaperSize.A3_Landscape;
        }
    }
}