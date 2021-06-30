using structurizr;
using Structurizr;

namespace Zego.Pay.Structurizr.Systems
{
    public static class NonZegoSystems
    {
        public static SoftwareSystem CleverTapSystem;
        public static SoftwareSystem PmIntegrationSoftwareSystem;
        public static SoftwareSystem PmWebPortal;
        public static SoftwareSystem MandrillSystem;
        public static SoftwareSystem EngieSystem;
        public static SoftwareSystem CassSystem;
        public static SoftwareSystem OsgSystem;
        public static SoftwareSystem KafkaSassSolution;
        public static SoftwareSystem SmartDevicesSystem;
        public static SoftwareSystem SendBirdSystem;
        public static SoftwareSystem TwillioSystem;
        public static SoftwareSystem SendGridSystem;

        public static void Intitialize(Model model)
        {
            CleverTapSystem = model.AddSoftwareSystem(Location.External, "CleverTap", "My software system.");
            CleverTapSystem.AddTags(ZegoStyles.NonZegoSystem);
            PmIntegrationSoftwareSystem = model.AddSoftwareSystem(Location.External, "PM Integration Software", "My software system.");
            PmIntegrationSoftwareSystem.AddTags(ZegoStyles.NonZegoSystem);
            PmWebPortal = model.AddSoftwareSystem(Location.External, "PM web portal", "Hosted by PM");
            PmWebPortal.AddTags(ZegoStyles.NonZegoSystem);
            MandrillSystem = model.AddSoftwareSystem(Location.External, "Mandrill", "My software system.");
            MandrillSystem.AddTags(ZegoStyles.NonZegoSystem);
            EngieSystem = model.AddSoftwareSystem(Location.External, "ENGIE", "My software system.");
            EngieSystem.AddTags(ZegoStyles.NonZegoSystem);
            CassSystem = model.AddSoftwareSystem(Location.External, "CASS", "My software system.");
            CassSystem.AddTags(ZegoStyles.NonZegoSystem);
            OsgSystem = model.AddSoftwareSystem(Location.External, "OSG", "My software system.");
            OsgSystem.AddTags(ZegoStyles.NonZegoSystem);
            
            KafkaSassSolution = model.AddSoftwareSystem(Location.External, "Kafka", "Aiven");
            KafkaSassSolution.AddTags(ZegoStyles.MessageBus);

            SmartDevicesSystem = model.AddSoftwareSystem(Location.External, "Smart Devices", "My software system.");
            SendBirdSystem = model.AddSoftwareSystem(Location.External, "SendBird", "My software system.");
            TwillioSystem = model.AddSoftwareSystem(Location.External, "Twillio", "My software system.");
            SendGridSystem = model.AddSoftwareSystem(Location.External, "SendGrid", "My software system.");
        }
    }
}