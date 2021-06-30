using Zego.Pay.Structurizr.Systems;

namespace Zego.Pay.Structurizr
{
    public static class PayContainersRelationships
    {
        public static void Initialize()
        {
            Actors.ZegoActors.Resident.Uses(PayContainers.ResidentUiWeb1PayLease, "uses");
            PayContainers.ResidentUiWeb1PayLease.Uses(PayContainers.PayleaseWeb, "uses");
            PayContainers.PayleaseWeb.Uses(PayContainers.PayleaseDatabase, "uses");
            NonZegoSystems.PmWebPortal.Uses(PayContainers.ResidentUiWeb1PayLease, "uses");
            PayContainers.ResidentUiWeb1PayLease.Uses(PayContainers.PayleaseWeb, "uses");
            PayContainers.ResidentUiWeb1PayLease.Uses(NonZegoSystems.PmWebPortal, "uses");
            NonZegoSystems.PmWebPortal.Uses(ZegoSystems.PayleaseSystem, "");
            PayContainers.PayleaseDatabase.Uses(PayContainers.DeltaEngine, "uses");
            PayContainers.DeltaEngine.Uses(NonZegoSystems.KafkaSassSolution, "uses");
            NonZegoSystems.KafkaSassSolution.Uses(ZegoSystems.ZegoCore, "uses");
            ZegoSystems.ZegoCore.Uses(NonZegoSystems.CleverTapSystem, "uses");
            NonZegoSystems.CleverTapSystem.Delivers(Actors.ZegoActors.Resident, "Sends");
        }
    }
}