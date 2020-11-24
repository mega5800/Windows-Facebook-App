using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Ex01.FacebookAppUI.Classes
{
    public sealed class AppSettings
    {
        // ATTRIBUTES
        private static readonly object sr_LockContext = new object();
        private static AppSettings s_Instance = null;
        public Point LastWindowLocation { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        private const string k_XmlFilePath = @"C:\Users\mega5\Desktop\Projects\A21 Ex01 Sharon 323600296 Tomer 205972946\appSettings.xml";

        // CTOR
        private AppSettings()
        {
            this.LastWindowLocation = new Point(100,100);
            this.RememberUser = false;
            this.LastAccessToken = null;
        }

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
                            LoadFromFile();
                        }
                    }
                }

                return s_Instance;
            }
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
        private static void LoadFromFile()
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