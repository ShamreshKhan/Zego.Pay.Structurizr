using Structurizr;
using Zego.Pay.Structurizr;
using Zego.Pay.Structurizr.Actors;
using Zego.Pay.Structurizr.Systems;

namespace structurizr.Views.Dynamic
{
    public static class ResidentPortalLoginDynamicView
    {
        public static void Initialize(ViewSet views)
        {
            var residentPMPortalLoginProcessDynamicView = views.CreateDynamicView(ZegoSystems.PayleaseSystem, "Pay - Resident using PM portal login process", "Resident using PM portal login process");
            residentPMPortalLoginProcessDynamicView.Add(ZegoActors.Resident, "Resident logs in", NonZegoSystems.PmWebPortal);
            residentPMPortalLoginProcessDynamicView.Add(NonZegoSystems.PmWebPortal, "SSO redirect or iframe to payments", PayContainers.ResidentUiWeb1PayLease);
            residentPMPortalLoginProcessDynamicView.Add(PayContainers.ResidentUiWeb1PayLease, "Deconstruct SSO string and matches residents", PayContainers.PayleaseWeb);
            residentPMPortalLoginProcessDynamicView.Add(PayContainers.PayleaseWeb, "Create resident if not matched", PayContainers.PayleaseDatabase);
            residentPMPortalLoginProcessDynamicView.Add(PayContainers.ResidentUiWeb1PayLease, "Redirect host payment (if in URL)", NonZegoSystems.PmWebPortal);
            residentPMPortalLoginProcessDynamicView.PaperSize = PaperSize.A3_Landscape;
        }
    }
}