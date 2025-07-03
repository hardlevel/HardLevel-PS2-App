namespace HardLevel_PS2_App.modues.osdmenu
{
    internal class CnfSettings
    {
    }
    public enum CnfSettingType
    {
        Checkbox,
        Text,
        Select
    }

    public class CnfSetting
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public CnfSettingType Type { get; set; }
        public List<string> Options { get; set; } // só usado se Type == Select
    }
}
