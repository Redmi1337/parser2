namespace Classes
{
    public static class Classes
    {
        static public List<int> ReadNumbers(string example)
        {
            List<int> result = new List<int> { };
            string temp = "";
            foreach (char x in example)
            {
                if (int.TryParse(Convert.ToString(x), out _))
                {
                    temp += x;
                }
                else
                {
                    if (temp != "")
                    {
                        result.Add(Convert.ToInt32(temp));
                    }
                    temp = "";
                }
            }
            if (temp != "")
            {
                result.Add(Convert.ToInt32(temp));
            }
            return result;
        }
        static public List<char> ReadSigns(string example)
        {
            List<char> signs = new List<char> { };
            foreach (char x in example)
            {
                if (x == '+' || x == '-' || x == '*' || x == '/')
                {
                    signs.Add(x);
                }
            }
            return signs;
        }
    }
}