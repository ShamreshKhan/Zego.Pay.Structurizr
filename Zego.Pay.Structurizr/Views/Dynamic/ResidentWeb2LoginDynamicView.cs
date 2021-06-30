using Structurizr;
using Zego.Pay.Structurizr;
using Zego.Pay.Structurizr.Actors;
using Zego.Pay.Structurizr.Systems;

namespace structurizr.Views.Dynamic
{
    public static class ResidentWeb2LoginDynamicView
    {
        public static void Initialize(ViewSet views)
        {
            var residentLoginProcessDynamicView = views.CreateDynamicView(ZegoSystems.PayleaseSystem, "Pay - Resident is login into Paylease process", "Resident is login into Paylease process");
            residentLoginProcessDynamicView.Add(ZegoActors.Resident, "Resident logs in", PayContainers.ResidentUiWeb1PayLease);
            residentLoginProcessDynamicView.Add(PayContainers.ResidentUiWeb1PayLease, "starts log in", PayContainers.PayleaseWeb);
            residentLoginProcessDynamicView.Add(PayContainers.PayleaseWeb, "creates resident", PayContainers.PayleaseDatabase);
            residentLoginProcessDynamicView.Add(PayContainers.PayleaseDatabase, "send resident data changes (createResidentAccount)",  PayContainers.DeltaEngine);
            residentLoginProcessDynamicView.Add(PayContainers.DeltaEngine, "send resident changes", NonZegoSystems.KafkaSassSolution);
            residentLoginProcessDynamicView.Add(NonZegoSystems.KafkaSassSolution, "send changes", ZegoSystems.ZegoCore);
            residentLoginProcessDynamicView.Add(ZegoSystems.ZegoCore, "notify to send email", NonZegoSystems.CleverTapSystem);
            residentLoginProcessDynamicView.Add(NonZegoSystems.CleverTapSystem, "sends activation email", ZegoActors.Resident);
            residentLoginProcessDynamicView.PaperSize = PaperSize.A3_Landscape;
        }
    }
}