using Structurizr;
using structurizr.Systems;

namespace structurizr.Views.Containers
{
    public static class PayContainersView
    {
        public static void Initialize(ViewSet views)
        {
            var payContainerView = views.CreateContainerView(ZegoSystems.PayleaseSystem, "Zego pay", ">>>");
            payContainerView.Add(Actors.PropertyManager);
            payContainerView.Add(Actors.Resident);
            payContainerView.Add(Actors.ZegoAdmin);
            payContainerView.Add(NonZegoSystems.PmIntegrationSoftwareSystem);
            payContainerView.Add(PayContainers.ResidentUiWeb1PayLease);
            payContainerView.Add(PayContainers.PayleaseDatabase);
            payContainerView.Add(PayContainers.PayleaseWeb);
            payContainerView.Add(NonZegoSystems.PmWebPortal);
            payContainerView.PaperSize = PaperSize.A3_Landscape;
        }
    }
}