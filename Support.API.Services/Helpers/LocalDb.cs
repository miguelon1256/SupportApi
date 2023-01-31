using System.Collections.Generic;

public static class LocalDb
{
    public static Dictionary<string, string> Values = new Dictionary<string, string>()
    {
        { "SUPPORT_DB_SERVER", "localhost" },
        { "SUPPORT_DB_INTERNAL_SERVER", "localhost" },
        { "SUPPORT_DB_PORT", "5440" },
        { "SUPPORT_DB_INTERNAL_PORT", "5440" },
        { "SUPPORT_DB_NAME", "support" },
        { "SUPPORT_DB_USER", "user" },
        { "SUPPORT_DB_PASSWORD", "password" },

        { "KOBO_DB_SERVER", "192.168.59.129" },
        { "KOBO_DB_PORT", "5435"},
        { "KOBO_DB_NAME", "koboform"},
        { "KOBO_CAT_DB_NAME", "kobocat"},
        { "KOBO_DB_USER", "kobo"},
        { "KOBO_DB_PASSWORD", "password"},

        { "KOBO_API_SERVER", "http://kf.mmaya.gob.bo" }
    };
}