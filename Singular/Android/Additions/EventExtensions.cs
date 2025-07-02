using System;

namespace Com.Singular.Sdk
{
    public partial class Singular
    {
        public static void Event(
            Events name)
        {
            Singular.Event(name.Name());
        }

        public static void Event(
            Events name,
            string extra)
        {
            Singular.Event(name.Name(), extra);
        }

        public static void EventJSON(
            Events name,
            global::Org.Json.JSONObject json)
        {
            Singular.EventJSON(name.Name(), json);
        }
    }
}
