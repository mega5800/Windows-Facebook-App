using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Ex02.FacebookAppUI.Classes
{
    public sealed class AppSettings
    {
        // ATTRIBUTES
        private const string k_XmlFilePath = @"C:\Users\mega5\Desktop\Projects\A21 Ex02 Sharon 323600296 Tomer 205972946\appSettings.xml";
        private static readonly object sr_LockContext = new object();
        private static AppSettings s_Instance = null;

        // PROPERTIES
        public static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockContext)
                    {
                        if (s_Instance == null)
                        {
                            loadFromFile();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public Point LastWindowLocation { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        // CTOR
        private AppSettings()
        {
            this.LastWindowLocation = new Point(100, 100);
            this.RememberUser = false;
            this.LastAccessToken = null;
        }

        // PUBLIC METHODS
        public void SaveToFile()
        {
            using (Stream stream = new FileStream(k_XmlFilePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        // PRIVATE METHODS
        private static void loadFromFile()
        {
            s_Instance = new AppSettings();

            if (File.Exists(k_XmlFilePath))
            {
                using (Stream stream = new FileStream(k_XmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    s_Instance = serializer.Deserialize(stream) as AppSettings;
                }
            }
        }
    }
}