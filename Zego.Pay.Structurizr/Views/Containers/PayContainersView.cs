﻿using Structurizr;
using Zego.Pay.Structurizr;
using Zego.Pay.Structurizr.Actors;
using Zego.Pay.Structurizr.Systems;

namespace structurizr.Views.Containers
{
    public static class PayContainersView
    {
        public static void Initialize(ViewSet views)
        {
            var payContainerView = views.CreateContainerView(ZegoSystems.PayleaseSystem, "Zego pay", ">>>");
            payContainerView.Add(ZegoActors.PropertyManager);
            payContainerView.Add(ZegoActors.Resident);
            payContainerView.Add(ZegoActors.ZegoAdmin);
            payContainerView.Add(NonZegoSystems.PmIntegrationSoftwareSystem);
            payContainerView.Add(PayContainers.ResidentUiWeb1PayLease);
            payContainerView.Add(PayContainers.PayleaseDatabase);
            payContainerView.Add(PayContainers.PayleaseWeb);
            payContainerView.Add(NonZegoSystems.PmWebPortal);
            payContainerView.PaperSize = PaperSize.A3_Landscape;
        }
    }
}