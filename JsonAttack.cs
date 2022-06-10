using System.IO;

namespace Newtonsoft.Json
{
    public class JsonSerializer
    {
        public void Serialize(JsonTextWriter writer, object o)
        {
            writer.attack();
        }
    }

    public class JsonTextWriter
    {
        public JsonTextWriter(TextWriter writer)
        {
            Writer = writer;
        }

        private TextWriter Writer { get; set; }

        internal void attack()
        {
            Writer.Write("Hello, world.\n");
        }
    }
}
