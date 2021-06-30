using structurizr;
using Structurizr;
using Zego.Pay.Structurizr.Systems;

namespace Zego.Pay.Structurizr
{
    public static class PayContainers
    {
        public static Container PayleaseDatabase;
        public static Container PayleaseWeb;
        public static Container ResidentUiWeb1PayLease;
        public static Container ResidentUiWeb2PayLease;
        public static Container DeltaEngine;

        public static void Initialize()
        {
            PayleaseDatabase = ZegoSystems.PayleaseSystem.AddContainer("PLA Database", "??", "MySQL/RDS/EC2");
            PayleaseDatabase.AddTags(ZegoStyles.DatabaseTag);
            PayleaseWeb = ZegoSystems.PayleaseSystem.AddContainer("Web", "??", "PHP/Apache/Web/EC2");
            ResidentUiWeb1PayLease = ZegoSystems.PayleaseSystem.AddContainer("Resident UI (Web 1.0)", "??", "PHP/Apache/EC2");
            ResidentUiWeb2PayLease = ZegoSystems.PayleaseSystem.AddContainer("Resident UI (Web 2.0)", "??", "PHP/Apache/EC2");
            DeltaEngine = ZegoSystems.PayleaseSystem.AddContainer("Delta engine", "??", "Nodejs/debezium");
        }
    }
}