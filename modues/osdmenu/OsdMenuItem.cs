namespace HardLevel_PS2_App.modues.osdmenu
{
    public class OsdMenuItem
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public List<string> Paths { get; set; } = new();
        public List<string> Args { get; set; } = new();
    }
}
