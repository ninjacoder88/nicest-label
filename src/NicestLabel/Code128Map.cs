namespace NicestLabel
{
    internal static class Code128Map
    {
        static Code128Map()
        {
            var list = new List<Code128CharcterValue>();
            list.Add(new Code128CharcterValue(32, 0, "11011001100"));
            list.Add(new Code128CharcterValue(33, 1, "11001101100"));
            list.Add(new Code128CharcterValue(34, 2, "11001100110"));
            list.Add(new Code128CharcterValue(35, 3, "10010011000"));
            list.Add(new Code128CharcterValue(36, 4, "10010001100"));
            list.Add(new Code128CharcterValue(37, 5, "10001001100"));
            list.Add(new Code128CharcterValue(38, 6, "10011001000"));
            list.Add(new Code128CharcterValue(39, 7, "10011000100"));
            list.Add(new Code128CharcterValue(40, 8, "10001100100"));
            list.Add(new Code128CharcterValue(41, 9, "11001001000"));
            list.Add(new Code128CharcterValue(42, 10, "11001000100"));
            list.Add(new Code128CharcterValue(43, 11, "11000100100"));
            list.Add(new Code128CharcterValue(44, 12, "10110011100"));
            list.Add(new Code128CharcterValue(45, 13, "10011011100"));
            list.Add(new Code128CharcterValue(46, 14, "10011001110"));
            list.Add(new Code128CharcterValue(47, 15, "10111001100"));
            list.Add(new Code128CharcterValue(48, 16, "10011101100"));
            list.Add(new Code128CharcterValue(49, 17, "10011100110"));
            list.Add(new Code128CharcterValue(50, 18, "11001110010"));
            list.Add(new Code128CharcterValue(51, 19, "11001011100"));
            list.Add(new Code128CharcterValue(52, 20, "11001001110"));
            list.Add(new Code128CharcterValue(53, 21, "11011100100"));
            list.Add(new Code128CharcterValue(54, 22, "11001110100"));
            list.Add(new Code128CharcterValue(55, 23, "11101101110"));
            list.Add(new Code128CharcterValue(56, 24, "11101001100"));
            list.Add(new Code128CharcterValue(57, 25, "11100101100"));
            list.Add(new Code128CharcterValue(58, 26, "11100100110"));
            list.Add(new Code128CharcterValue(59, 27, "11101100100"));
            list.Add(new Code128CharcterValue(60, 28, "11100110100"));
            list.Add(new Code128CharcterValue(61, 29, "11100110010"));
            list.Add(new Code128CharcterValue(62, 30, "11011011000"));
            list.Add(new Code128CharcterValue(63, 31, "11011000110"));
            list.Add(new Code128CharcterValue(64, 32, "11000110110"));
            list.Add(new Code128CharcterValue(65, 33, "10100011000"));
            list.Add(new Code128CharcterValue(66, 34, "10001011000"));
            list.Add(new Code128CharcterValue(67, 35, "10001000110"));
            list.Add(new Code128CharcterValue(68, 36, "10110001000"));
            list.Add(new Code128CharcterValue(69, 37, "10001101000"));
            list.Add(new Code128CharcterValue(70, 38, "10001100010"));
            list.Add(new Code128CharcterValue(71, 39, "11010001000"));
            list.Add(new Code128CharcterValue(72, 40, "11000101000"));
            list.Add(new Code128CharcterValue(73, 41, "11000100010"));
            list.Add(new Code128CharcterValue(74, 42, "10110111000"));
            list.Add(new Code128CharcterValue(75, 43, "10110001110"));
            list.Add(new Code128CharcterValue(76, 44, "10001101110"));
            list.Add(new Code128CharcterValue(77, 45, "10111011000"));
            list.Add(new Code128CharcterValue(78, 46, "10111000110"));
            list.Add(new Code128CharcterValue(79, 47, "10001110110"));
            list.Add(new Code128CharcterValue(80, 48, "11101110110"));
            list.Add(new Code128CharcterValue(81, 49, "11010001110"));
            list.Add(new Code128CharcterValue(82, 50, "11000101110"));
            list.Add(new Code128CharcterValue(83, 51, "11011101000"));
            list.Add(new Code128CharcterValue(84, 52, "11011100010"));
            list.Add(new Code128CharcterValue(85, 53, "11011101110"));
            list.Add(new Code128CharcterValue(86, 54, "11101011000"));
            list.Add(new Code128CharcterValue(87, 55, "11101000110"));
            list.Add(new Code128CharcterValue(88, 56, "11100010110"));
            list.Add(new Code128CharcterValue(89, 57, "11101101000"));
            list.Add(new Code128CharcterValue(90, 58, "11101100010"));
            list.Add(new Code128CharcterValue(91, 59, "11100011010"));
            list.Add(new Code128CharcterValue(92, 60, "11101111010"));
            list.Add(new Code128CharcterValue(93, 61, "11001000010"));
            list.Add(new Code128CharcterValue(94, 62, "11110001010"));
            list.Add(new Code128CharcterValue(95, 63, "10100110000"));
            list.Add(new Code128CharcterValue(96, 64, "10100001100"));
            list.Add(new Code128CharcterValue(97, 65, "10010110000"));
            list.Add(new Code128CharcterValue(98, 66, "10010000110"));
            list.Add(new Code128CharcterValue(99, 67, "10000101100"));
            list.Add(new Code128CharcterValue(100, 68, "10000100110"));
            list.Add(new Code128CharcterValue(101, 69, "10110010000"));
            list.Add(new Code128CharcterValue(102, 70, "10110000100"));
            list.Add(new Code128CharcterValue(103, 71, "10011010000"));
            list.Add(new Code128CharcterValue(104, 72, "10011000010"));
            list.Add(new Code128CharcterValue(105, 73, "10000110100"));
            list.Add(new Code128CharcterValue(106, 74, "10000110010"));
            list.Add(new Code128CharcterValue(107, 75, "11000010010"));
            list.Add(new Code128CharcterValue(108, 76, "11001010000"));
            list.Add(new Code128CharcterValue(109, 77, "11110111010"));
            list.Add(new Code128CharcterValue(110, 78, "11000010100"));
            list.Add(new Code128CharcterValue(111, 79, "10001111010"));
            list.Add(new Code128CharcterValue(112, 80, "10100111100"));
            list.Add(new Code128CharcterValue(113, 81, "10010111100"));
            list.Add(new Code128CharcterValue(114, 82, "10010011110"));
            list.Add(new Code128CharcterValue(115, 83, "10111100100"));
            list.Add(new Code128CharcterValue(116, 84, "10011110100"));
            list.Add(new Code128CharcterValue(117, 85, "10011110010"));
            list.Add(new Code128CharcterValue(118, 86, "11110100100"));
            list.Add(new Code128CharcterValue(119, 87, "11110010100"));
            list.Add(new Code128CharcterValue(120, 88, "11110010010"));
            list.Add(new Code128CharcterValue(121, 89, "11011011110"));
            list.Add(new Code128CharcterValue(122, 90, "11011110110"));
            list.Add(new Code128CharcterValue(123, 91, "11110110110"));
            list.Add(new Code128CharcterValue(124, 92, "10101111000"));
            list.Add(new Code128CharcterValue(125, 93, "10100011110"));
            list.Add(new Code128CharcterValue(126, 94, "10001011110"));

            list.Add(new Code128CharcterValue(195, 95, "10111101000"));
            list.Add(new Code128CharcterValue(196, 96, "10111100010"));
            list.Add(new Code128CharcterValue(197, 97, "11110101000"));
            list.Add(new Code128CharcterValue(198, 98, "11110100010"));
            list.Add(new Code128CharcterValue(199, 99, "10111011110"));
            list.Add(new Code128CharcterValue(200, 100, "10111101110"));
            list.Add(new Code128CharcterValue(201, 101, "11101011110"));
            list.Add(new Code128CharcterValue(202, 102, "11110101110"));
            list.Add(new Code128CharcterValue(203, 103, "11010000100"));
            list.Add(new Code128CharcterValue(204, 104, "11010010000"));
            list.Add(new Code128CharcterValue(205, 105, "11010011100"));
            list.Add(new Code128CharcterValue(206, 106, "11000111010"));
            CharacterMap = list.ToDictionary(k => k.Code, v => v);
            ValueMap = list.ToDictionary(k => k.Value, v => v);
        }

        public static Dictionary<int, Code128CharcterValue> CharacterMap { get; private set; }

        public static Dictionary<int, Code128CharcterValue> ValueMap { get; private set; }
    }

    internal class Code128CharcterValue
    {
        public Code128CharcterValue(int code, int value, string pattern)
        {
            Code = code;
            Value = value;
            Pattern = pattern;
        }

        public int Code { get; }

        public int Value { get; }

        public string Pattern { get; }
    }
}
