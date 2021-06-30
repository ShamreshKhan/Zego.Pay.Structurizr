using Structurizr;

namespace Zego.Pay.Structurizr.Actors
{
    public static class Actors
    {
        public static Person Resident;
        public static Person PropertyManager;
        public static Person ZegoAdmin;
        public static Person PmUsingGapi;
        public static Person OnboardingTeam;
        public static Person UtilityOperations;

        public static void Initialize(Model model)
        {
            Resident = model.AddPerson("Resident", "....");
            PropertyManager = model.AddPerson("Property Manager", "....");
            ZegoAdmin = model.AddPerson("Zego admin", "....");
            
            // Pay
            PmUsingGapi = model.AddPerson("Rentmanager (Integration partners)", "Use GAPI to make payments");
            OnboardingTeam = model.AddPerson("Onboarding", ">>");

            // Utilities and Billing
            UtilityOperations = model.AddPerson("Utility Operations", ">>");
        }
    }
}