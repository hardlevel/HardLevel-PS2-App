namespace HardLevel_PS2_App.modues.osdmenu
{
    public static class CnfParser
    {
        public static List<string> ReadRawLines(string path)
        {
            return File.Exists(path) ? new List<string>(File.ReadAllLines(path)) : new List<string>();
        }

        public static Dictionary<string, string> Parse(string path)
        {
            var lines = ReadRawLines(path);
            var dict = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                if (line.StartsWith("#") || string.IsNullOrWhiteSpace(line))
                    continue;

                var split = line.Split('=', 2);
                if (split.Length == 2)
                    dict[split[0].Trim()] = split[1].Trim();
            }

            return dict;
        }

        public static void Save(Dictionary<string, string> data, string path)
        {
            using (var sw = new StreamWriter(path))
            {
                foreach (var pair in data)
                {
                    sw.WriteLine($"{pair.Key} = {pair.Value}");
                }
            }
        }
    }
}
