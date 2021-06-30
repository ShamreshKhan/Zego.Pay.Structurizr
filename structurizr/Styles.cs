using System.ComponentModel;
using Structurizr;

namespace structurizr
{
    public static class ZegoStyles
    {
        public static string IntroBox = "IntroBox";
        public static string DatabaseTag = "Database";
        public static string NonZegoSystem = "NonZegoSystem";
        public static string Folder = "Folder";
        public static string MessageBus = "MessageBus";
        
        public static void ConfigureStyles(Styles styles)
        {
            
            styles.Add(new ElementStyle(Tags.Element) {Color = "#ffffff"});
            styles.Add(new ElementStyle(Tags.SoftwareSystem) {Background = "#1168bd"});
            styles.Add(new ElementStyle(IntroBox) {Background = "#1168bd", Height = 900, Width = 1000, FontSize = 50});
            styles.Add(new ElementStyle(Tags.Container) {Background = "#438dd5"});
            styles.Add(new ElementStyle(Tags.Component) {Background = "#85bbf0", Color = "#000000"});
            styles.Add(new ElementStyle(Tags.Person) {Background = "#08427b", Shape = Shape.Person, FontSize = 22});
            styles.Add(new ElementStyle(NonZegoSystem) {Background = "#999999"});
            //
            styles.Add(new ElementStyle(MessageBus) {Width = 900, Height= 150, Shape = Shape.Pipe});
            // styles.Add(new ElementStyle(MicroserviceTag) { Shape = Shape.Hexagon});
            styles.Add(new ElementStyle(DatabaseTag) {Background = "#f5da81", Shape = Shape.Cylinder});
            styles.Add(new ElementStyle(Folder) {Background = "#1168bd", Shape = Shape.Folder});

            // styles.Add(new ElementStyle(FoldersTag) { Background = "#f5da81", Shape = Shape.Folder });
            // styles.Add(new ElementStyle(WebBrowserTag) { Shape = Shape.WebBrowser });
            // styles.Add(new ElementStyle(TopicExchange) { Shape = Shape.Circle });
            // //styles.Add(new RelationshipStyle(Tags.Relationship) { Routing = Routing.Orthogonal });
            // styles.Add(new ElementStyle(MobileAppTag) { Shape = Shape.MobileDeviceLandscape });

            styles.Add(new RelationshipStyle(Tags.Asynchronous) {Dashed = true});
            styles.Add(new RelationshipStyle(Tags.Synchronous) {Dashed = false});
            
        }
    }
}