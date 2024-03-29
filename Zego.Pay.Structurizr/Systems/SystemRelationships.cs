﻿namespace Zego.Pay.Structurizr.Systems
{
    public static class SystemRelationships
    {
        public static void Intitialize()
        {
            Actors.ZegoActors.PropertyManager.Uses(ZegoSystems.PayleaseSystem, "Views payments/reports/VCR/bills");
            Actors.ZegoActors.PropertyManager.Uses(ZegoSystems.EngageSystem, "Send work orders");
            Actors.ZegoActors.Resident.Uses(ZegoSystems.PayleaseSystem, "Logs in using Web 1.0");
            Actors.ZegoActors.Resident.Uses(ZegoSystems.EngageSystem, "Logs in using Web 2.0");
            
            Actors.ZegoActors.Resident.Uses(ZegoSystems.PayleaseSystem, "Views bills and makes payments");
            Actors.ZegoActors.Resident.Uses(ZegoSystems.PayleaseSystem, "Activates/Registers account");

            Actors.ZegoActors.ZegoAdmin.Uses(ZegoSystems.PayleaseSystem, "Onboards PM");
            Actors.ZegoActors.ZegoAdmin.Uses(ZegoSystems.PayleaseSystem, "Reviews and validates VCR/Utility Bills and validates charges");

            Actors.ZegoActors.Resident.Uses(NonZegoSystems.PmWebPortal, "makes a payment via SSO redirect/iframe");
            Actors.ZegoActors.ZegoAdmin.Uses(ZegoSystems.PayleaseSystem, "Uses");

            Actors.ZegoActors.PmUsingGapi.Uses(ZegoSystems.PayleaseSystem, "Make gapi payments");

            ZegoSystems.PayleaseSystem.Uses(NonZegoSystems.PmIntegrationSoftwareSystem, "Import resident data");
            ZegoSystems.PayleaseSystem.Uses(NonZegoSystems.PmIntegrationSoftwareSystem, "Update accounting ledgers");
            ZegoSystems.PayleaseSystem.Uses(NonZegoSystems.PmIntegrationSoftwareSystem, "Make payments");

            ZegoSystems.PayleaseSystem.Uses(ZegoSystems.UtilitiesSystem, "Approve VCR and Utility Bills");
            ZegoSystems.UtilitiesSystem.Uses(ZegoSystems.PayleaseSystem, "Get resident data");
            ZegoSystems.PayleaseSystem.Uses(ZegoSystems.UtilitiesSystem, "Get bills");

            ZegoSystems.PayleaseSystem.Uses(NonZegoSystems.CleverTapSystem, "Send resident activation emails");
            ZegoSystems.PayleaseSystem.Uses(NonZegoSystems.CleverTapSystem, "Send reports");

            ZegoSystems.EngageSystem.Uses(ZegoSystems.PayleaseSystem, "Send work order");
            ZegoSystems.EngageSystem.Uses(ZegoSystems.PayleaseSystem, "Get pay access token");
            
            var pmReviewandApprovePreBillRelationship = Actors.ZegoActors.PropertyManager.Uses(ZegoSystems.PayleaseSystem, "Review and approve pre-bill");
            var pmReviewVCRandUtitlityBillsRelationship = Actors.ZegoActors.PropertyManager.Uses(ZegoSystems.PayleaseSystem, "Review VCR and utility bills");
            var pmReviewBillingStatementsRelationship = Actors.ZegoActors.Resident.Uses(ZegoSystems.BillingSystem, "Review billing systems");

            ZegoSystems.EngageSystem.Uses(ZegoSystems.BillingSystem, "Get statement info");
            ZegoSystems.BillingSystem.Uses(NonZegoSystems.OsgSystem, "Send billing statements to print");
            ZegoSystems.BillingSystem.Uses(NonZegoSystems.MandrillSystem, "Send emails");

            NonZegoSystems.CassSystem.Uses(ZegoSystems.UtilitiesSystem, "Utility data imported");
            NonZegoSystems.EngieSystem.Uses(ZegoSystems.UtilitiesSystem, "Utility data imported");

            ZegoSystems.UtilitiesSystem.Uses(NonZegoSystems.PmIntegrationSoftwareSystem, "Pushing payables and break down");
            ZegoSystems.BillingSystem.Uses(NonZegoSystems.PmIntegrationSoftwareSystem, "Resident charge push");

        }
    }
}