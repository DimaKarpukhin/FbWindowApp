namespace AppLogic
{
    using System.Drawing;
    using System.IO;
    using System.Xml.Serialization;

    public class AppSettings
    { 
        private const string k_FileName = "\\appSettings.xml";
        private static readonly string sr_FilePath;
        private static AppSettings s_This;

        public static AppSettings Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = AppSettings.LoadFromFile();
                }

                return s_This;
            }
        }

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        static AppSettings()
        {
            // This is the first operation executed while using this class for the first time
            sr_FilePath = Directory.GetCurrentDirectory() + k_FileName;
        }

        private AppSettings()
        {
            // Sets default settings
            LastWindowLocation = new Point(50, 50);
            LastWindowSize = new Size(1000, 300);
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings loadedSettings;

            if (s_This == null)
            {
                using (Stream stream = new FileStream(sr_FilePath, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));    // if the file exists
                    try
                    {
                        loadedSettings = serializer.Deserialize(stream) as AppSettings;
                    }
                    catch
                    {
                        loadedSettings = new AppSettings();
                    }
                }
            }
            else
            {
                loadedSettings = s_This;
            }
            
            return loadedSettings;
        }

        public void SaveToFile()
        {

            // programming-pattern that preforms try-finally-dispose
            using (Stream stream = new FileStream(sr_FilePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType()); // prepares the serializer for serialize method
                serializer.Serialize(stream, this);                           // takes the metadata and preforms reflection
            }
        }
    }
}
