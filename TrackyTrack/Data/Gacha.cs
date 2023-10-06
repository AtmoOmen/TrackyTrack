﻿using Newtonsoft.Json;

namespace TrackyTrack.Data;

// Content from: https://github.com/Caraxi/SimpleTweaksPlugin/blob/7c46ac283353126e0c1619843824e30669a65775/Tweaks/Tooltips/TrackGachaItems.cs#L26C5-L26C5
public class GachaThreeZero
{
    public int Opened = 0;
    public Dictionary<uint, uint> Obtained = new();

    [JsonIgnore]
    public static readonly List<uint> Content = new()
    {
        9350, 12051, 6187, 15441, 6175, 7564, 6186, 6203, 6177, 17525, 15440, 14098, 6003, 12055, 6199, 6205,
        16570, 16568, 6189, 15447, 8193, 9347, 14103, 12054, 8194, 12061, 6191, 12069, 13279, 6179, 12058, 13283,
        12056, 9348, 7568, 6004, 8196, 8201, 7566, 10071, 6204, 6173, 14100, 9349, 8200, 8205, 16564, 8202, 12052,
        12057, 13275, 7559, 6192, 16572, 6208, 6195, 12062, 7567, 6188, 6174, 8199, 6185, 8195, 12053, 12049, 6005,
        6213, 6200, 6190, 16573, 17527, 14093, 13284, 13276, 14095, 6214, 15436, 15437, 14094, 6184, 14083, 6183,
        6198, 8192, 6209, 6178
    };
}

public class GachaFourZero
{
    public int Opened = 0;
    public Dictionary<uint, uint> Obtained = new();

    [JsonIgnore]
    public static readonly List<uint> Content = new()
    {
        24902, 21921, 21063, 20529, 20530, 21920, 24002, 20524, 24635, 23027, 24001, 23023, 20533, 24219, 24630, 21052,
        20542, 24903, 20538, 21064, 20541, 21058, 20536, 23032, 23998, 20525, 21916, 20531, 21193, 23989, 24634, 21059,
        21922, 21919, 20528, 21911, 20547, 20539, 24000, 21918, 21055, 20544, 20546, 21915, 21060, 21917, 20537, 21057,
        23030, 21065, 20545, 23028, 24639, 23036, 24640
    };
}

public class Sanctuary
{
    public int Opened = 0;
    public Dictionary<uint, uint> Obtained = new();

    [JsonIgnore]
    public static readonly List<uint> Content = new()
    {
        27976, 24804, 33937, 40627, 40393, 13115, 39350, 41138, 41585, 33939, 33922, 20529, 41104, 33926, 41142, 33935,
        20528, 41586, 39502, 33940, 33927, 38610, 31091, 20524, 20542, 38540, 41649, 20531
    };
}
