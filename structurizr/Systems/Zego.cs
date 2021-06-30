using System.ComponentModel;
using Structurizr;

namespace structurizr.Systems
{
    public static class ZegoSystems
    {
        public static SoftwareSystem Pay;
        public static SoftwareSystem ResX;
        public static SoftwareSystem UemAndBilling;
        public static SoftwareSystem MobileDoorman;
        public static SoftwareSystem PayleaseSystem;
        public static SoftwareSystem EngageSystem;
        public static SoftwareSystem UtilitiesSystem;
        public static SoftwareSystem BillingSystem;
        public static SoftwareSystem CoreEntity;
        public static SoftwareSystem ZegoCore;

        public static void Initialize(Model model)
        {
            Pay = model.AddSoftwareSystem("Pay",
                "Zego™ Pay minimizes the volume of paper payments that come through your door by offering residents convenient and flexible alternatives. Residents can pay rent online, with a sleek rent payment mobile app, or in-person at a participating retail location.");
            Pay.AddTags(ZegoStyles.IntroBox);
            ResX = model.AddSoftwareSystem("Resx",
                "Equip your communities with a modern edge over the competition. Zego Smart™ connects residents with their home and empowers community managers with a unified resident experience management platform that gives them better control over property operations.");
            ResX.AddTags(ZegoStyles.IntroBox);
            UemAndBilling = model.AddSoftwareSystem("UEM and Billing",
                "Maximize expense recovery and give your associates the freedom to do more with their day. From invoice auditing, to accounts payable, and expense recovery, our end-to-end utility management software gives you better control over expenses and boosts operational productivity.");
            UemAndBilling.AddTags(ZegoStyles.IntroBox);
            MobileDoorman = model.AddSoftwareSystem("Mobile Doorman",
                "Zego™ Mobile Doorman helps multifamily communities create branded mobile apps for residents. Our fully customizable, user-friendly tool elevates the resident experience by empowering residents to manage all their apartment needs right from their mobile phones.");
            MobileDoorman.AddTags(ZegoStyles.IntroBox);

            PayleaseSystem = model.AddSoftwareSystem("Paylease", "My software system.");
            EngageSystem = model.AddSoftwareSystem("Resx/Engage", "My software system.");
            UtilitiesSystem = model.AddSoftwareSystem("Utilities", "My software system.");
            BillingSystem = model.AddSoftwareSystem("Billing", "My software system.");
            CoreEntity = model.AddSoftwareSystem("CORE Entity", "My software system.");
            ZegoCore = model.AddSoftwareSystem("Zego Core", "My software system.");
        }
    }
}