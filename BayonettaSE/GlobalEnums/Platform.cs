namespace BayonettaSE.GlobalEnums
{
    public enum Platform
    {
        Unknown = -1,
        PC, // Windows
        WiiU,
        PS3,
        PS3OrWiiU, // Temporary: Apparently, the save file format is the same for both PS3 and WiiU, so this is used to represent either of those platforms. Need to remove to be more explicit in the future.
        PS4,
        X360,
        XOne,
        Switch
    }
}