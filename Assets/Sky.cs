﻿using UnityEngine;
using dpp;
using System.Collections;

public class Sky : MonoBehaviour {
    private Data[] data;
    private GameObject[] s;

	// Use this for initialization
	void Start () {
        
        s = new GameObject[571];
        data = new Data[571];
        data[0] = new Data(13209, 42.496, 27.2605, 3.612);
        data[1] = new Data(9884, 31.7933, 23.4624, 2.007);
        data[2] = new Data(8903, 28.66, 20.808, 2.645);
        data[3] = new Data(8832, 28.3826, 19.2948, 3.88);
        data[4] = new Data(71865, 220.49, -37.7935, 3.997);
        data[5] = new Data(72010, 220.914, -35.1737, 4.045);
        data[6] = new Data(65936, 202.761, -39.4074, 3.887);
        data[7] = new Data(71683, 219.899, -60.8354, -0.01);
        data[8] = new Data(71681, 219.899, -60.8354, 1.35);
        data[9] = new Data(68702, 210.956, -60.373, 0.61);
        data[10] = new Data(61932, 190.379, -48.9597, 2.2);
        data[11] = new Data(59196, 182.09, -50.7224, 2.575);
        data[12] = new Data(66657, 204.972, -53.4664, 2.303);
        data[13] = new Data(68002, 208.885, -47.2884, 2.545);
        data[14] = new Data(71352, 218.877, -42.1579, 2.356);
        data[15] = new Data(68933, 211.671, -36.37, 2.055);
        data[16] = new Data(65109, 200.149, -36.7123, 2.75);
        data[17] = new Data(73334, 224.79, -42.1043, 3.133);
        data[18] = new Data(56561, 173.945, -63.0198, 3.11);
        data[19] = new Data(67472, 207.404, -42.4738, 3.19);
        data[20] = new Data(67464, 207.376, -41.6877, 3.406);
        data[21] = new Data(55425, 170.252, -54.4911, 3.9);
        data[22] = new Data(59449, 182.913, -52.3684, 3.96);
        data[23] = new Data(60823, 187.01, -50.2307, 3.909);
        data[24] = new Data(61622, 189.426, -48.5413, 3.874);
        data[25] = new Data(68282, 209.67, -44.8036, 3.865);
        data[26] = new Data(68245, 209.568, -42.1007, 3.819);
        data[27] = new Data(70090, 215.139, -37.8853, 4.046);
        data[28] = new Data(115438, 350.743, -20.1006, 3.957);
        data[29] = new Data(114341, 347.362, -21.1724, 3.671);
        data[30] = new Data(109074, 331.446, 0.319853, 2.944);
        data[31] = new Data(106278, 322.89, -5.57118, 2.899);
        data[32] = new Data(110395, 335.414, -1.38734, 3.847);
        data[33] = new Data(113136, 343.663, -15.8208, 3.275);
        data[34] = new Data(102618, 311.919, -9.49576, 3.772);
        data[35] = new Data(110960, 337.209, 0.0200806, 3.648);
        data[36] = new Data(111497, 338.839, 0.1175, 4.024);
        data[37] = new Data(112961, 343.154, -7.57961, 3.741);
        data[38] = new Data(112716, 342.398, -13.5926, 4.015);
        data[39] = new Data(76267, 233.672, 26.7147, 2.221);
        data[40] = new Data(75695, 231.957, 29.1057, 3.678);
        data[41] = new Data(76952, 235.686, 26.2953, 3.83);
        data[42] = new Data(21594, 69.545, -14.3039, 3.863);
        data[43] = new Data(7588, 24.4285, -57.2367, 0.453);
        data[44] = new Data(23875, 76.9624, -5.08645, 2.784);
        data[45] = new Data(18543, 59.5073, -13.5085, 2.95);
        data[46] = new Data(17378, 55.8121, -9.7634, 3.528);
        data[47] = new Data(16537, 53.2327, -9.45826, 3.726);
        data[48] = new Data(13701, 44.1069, -8.89817, 3.894);
        data[49] = new Data(13847, 44.5668, -40.3047, 2.906);
        data[50] = new Data(22109, 71.3756, -3.25465, 4.012);
        data[51] = new Data(21444, 69.0797, -3.35247, 3.93);
        data[52] = new Data(19587, 62.9664, -6.83758, 4.044);
        data[53] = new Data(14146, 45.5979, -23.6244, 4.08);
        data[54] = new Data(15474, 49.8792, -21.7579, 3.652);
        data[55] = new Data(21393, 68.8877, -30.5623, 3.812);
        data[56] = new Data(20535, 66.0092, -34.0169, 3.96);
        data[57] = new Data(20042, 64.4736, -33.7983, 3.548);
        data[58] = new Data(10602, 34.1275, -51.5122, 3.549);
        data[59] = new Data(9007, 28.9895, -51.6089, 3.695);
        data[60] = new Data(61585, 189.296, -69.1355, 2.688);
        data[61] = new Data(62322, 191.57, -68.1081, 3.043);
        data[62] = new Data(61199, 188.117, -72.133, 3.858);
        data[63] = new Data(63613, 195.568, -71.5489, 3.612);
        data[64] = new Data(59929, 184.392, -67.9607, 4.059);
        data[65] = new Data(57363, 176.402, -66.7287, 3.631);
        data[66] = new Data(71860, 220.482, -47.3882, 2.304);
        data[67] = new Data(73273, 224.633, -43.134, 2.677);
        data[68] = new Data(76297, 233.785, -41.1668, 2.8);
        data[69] = new Data(75141, 230.343, -40.6476, 3.216);
        data[70] = new Data(75264, 230.67, -44.6896, 3.373);
        data[71] = new Data(74395, 228.071, -52.0993, 3.405);
        data[72] = new Data(78384, 240.031, -38.3968, 3.42);
        data[73] = new Data(69996, 214.851, -46.0581, 3.553);
        data[74] = new Data(74376, 227.984, -48.7379, 3.88);
        data[75] = new Data(74117, 227.211, -45.2798, 4.055);
        data[76] = new Data(73807, 226.28, -47.0511, 3.891);
        data[77] = new Data(71536, 219.472, -49.4259, 4.036);
        data[78] = new Data(75177, 230.452, -36.2614, 3.558);
        data[79] = new Data(77634, 237.74, -33.6272, 3.956);
        data[80] = new Data(41307, 126.415, -3.90643, 3.898);
        data[81] = new Data(46390, 141.897, -8.65865, 1.977);
        data[82] = new Data(64962, 199.73, -23.1716, 2.991);
        data[83] = new Data(43109, 131.694, 6.41878, 3.38);
        data[84] = new Data(43813, 133.848, 5.94552, 3.109);
        data[85] = new Data(45336, 138.591, 2.31423, 3.885);
        data[86] = new Data(47431, 144.964, -1.14288, 3.903);
        data[87] = new Data(49841, 152.647, -12.3541, 3.612);
        data[88] = new Data(51069, 156.523, -16.8363, 3.818);
        data[89] = new Data(52943, 162.406, -16.1937, 3.114);
        data[90] = new Data(56343, 173.251, -31.8576, 3.541);
        data[91] = new Data(68895, 211.593, -26.6824, 3.265);
        data[92] = new Data(45080, 137.742, -58.967, 3.432);
        data[93] = new Data(43783, 133.762, -60.6446, 3.835);
        data[94] = new Data(46974, 143.611, -59.2296, 4.086);
        data[95] = new Data(45101, 137.82, -62.317, 3.963);
        data[96] = new Data(51576, 158.006, -61.6854, 3.3);
        data[97] = new Data(50371, 154.271, -61.3323, 3.357);
        data[98] = new Data(51232, 156.97, -58.7395, 3.818);
        data[99] = new Data(53253, 163.373, -58.8532, 3.775);
        data[100] = new Data(54463, 167.147, -58.9751, 4.02);
        data[101] = new Data(30438, 95.988, -52.6957, -0.736);
        data[102] = new Data(45238, 138.3, -69.7172, 1.672);
        data[103] = new Data(41037, 125.628, -59.5096, 1.86);
        data[104] = new Data(52419, 160.739, -64.3945, 2.764);
        data[105] = new Data(45556, 139.273, -59.2753, 2.246);
        data[106] = new Data(48002, 146.775, -65.0719, 2.92);
        data[107] = new Data(38827, 119.195, -52.9823, 3.457);
        data[108] = new Data(50099, 153.434, -70.0379, 3.309);
        data[109] = new Data(43023, 131.507, -46.0416, 3.902);
        data[110] = new Data(42570, 130.157, -46.6488, 3.8);
        data[111] = new Data(44511, 136.039, -47.0978, 3.749);
        data[112] = new Data(42884, 131.1, -42.6492, 4.02);
        data[113] = new Data(46701, 142.806, -57.0344, 3.144);
        data[114] = new Data(51986, 159.326, -48.2256, 3.84);
        data[115] = new Data(50191, 153.684, -42.122, 3.842);
        data[116] = new Data(39953, 122.383, -47.3366, 1.793);
        data[117] = new Data(42913, 131.176, -54.7084, 1.954);
        data[118] = new Data(45941, 140.528, -55.0107, 2.49);
        data[119] = new Data(44816, 136.999, -43.4326, 2.204);
        data[120] = new Data(52727, 161.693, -49.4201, 2.692);
        data[121] = new Data(42536, 130.073, -52.922, 3.596);
        data[122] = new Data(48774, 149.216, -54.5678, 3.48);
        data[123] = new Data(46651, 142.675, -40.4667, 3.6);
        data[124] = new Data(38414, 118.054, -40.5759, 3.714);
        data[125] = new Data(37819, 116.314, -37.9687, 3.601);
        data[126] = new Data(37677, 115.952, -28.9548, 3.964);
        data[127] = new Data(38164, 117.31, -46.3732, 4.1);
        data[128] = new Data(39429, 120.896, -40.0032, 2.246);
        data[129] = new Data(31685, 99.4403, -43.196, 3.173);
        data[130] = new Data(38170, 117.324, -24.8598, 3.343);
        data[131] = new Data(35264, 109.286, -37.0975, 2.706);
        data[132] = new Data(39757, 121.886, -24.3043, 2.803);
        data[133] = new Data(36377, 112.308, -43.3015, 3.21);
        data[134] = new Data(32768, 102.484, -50.6146, 2.931);
        data[135] = new Data(32349, 101.287, -16.7161, -1.44);
        data[136] = new Data(30324, 95.6749, -17.9559, 1.976);
        data[137] = new Data(34444, 107.098, -26.3932, 1.83);
        data[138] = new Data(33579, 104.656, -28.9721, 1.502);
        data[139] = new Data(30122, 95.0783, -30.0634, 3.022);
        data[140] = new Data(35904, 111.024, -29.3031, 2.448);
        data[141] = new Data(33160, 103.547, -12.0386, 4.07);
        data[142] = new Data(32759, 102.46, -32.5085, 3.9);
        data[143] = new Data(31592, 99.1709, -19.2558, 3.952);
        data[144] = new Data(33152, 103.533, -24.184, 3.88);
        data[145] = new Data(33977, 105.756, -23.8333, 3.032);
        data[146] = new Data(33856, 105.43, -27.9348, 3.464);
        data[147] = new Data(35037, 108.703, -26.7727, 3.89);
        data[148] = new Data(44248, 135.16, 41.7828, 4.1);
        data[149] = new Data(65477, 201.307, 54.9881, 4.009);
        data[150] = new Data(46733, 142.882, 63.0619, 3.7);
        data[151] = new Data(54061, 165.932, 61.7509, 1.8);
        data[152] = new Data(53910, 165.46, 56.3824, 2.365);
        data[153] = new Data(58001, 178.458, 53.6948, 2.433);
        data[154] = new Data(59774, 183.857, 57.0326, 3.313);
        data[155] = new Data(62956, 193.507, 55.9599, 1.763);
        data[156] = new Data(65378, 200.981, 54.9254, 2.06);
        data[157] = new Data(67301, 206.885, 49.3133, 1.854);
        data[158] = new Data(46853, 143.214, 51.6773, 3.185);
        data[159] = new Data(44127, 134.802, 48.0417, 3.14);
        data[160] = new Data(44471, 135.906, 47.1565, 3.58);
        data[161] = new Data(50372, 154.274, 42.9144, 3.45);
        data[162] = new Data(50801, 155.582, 41.4995, 3.16);
        data[163] = new Data(55219, 169.62, 33.0943, 3.507);
        data[164] = new Data(55203, 169.546, 31.5294, 3.786);
        data[165] = new Data(41704, 127.566, 60.7182, 3.37);
        data[166] = new Data(48319, 147.747, 59.0387, 3.8);
        data[167] = new Data(57399, 176.513, 47.7794, 3.712);
        data[168] = new Data(54539, 167.416, 44.4985, 3.004);
        data[169] = new Data(110130, 334.625, -60.2596, 2.878);
        data[170] = new Data(114996, 349.357, -58.2357, 3.992);
        data[171] = new Data(91117, 278.802, -8.24406, 3.849);
        data[172] = new Data(105502, 320.522, 19.8045, 4.07);
        data[173] = new Data(113963, 346.19, 15.2052, 2.487);
        data[174] = new Data(113881, 345.944, 28.0828, 2.52);
        data[175] = new Data(1067, 3.30898, 15.1836, 2.834);
        data[176] = new Data(107315, 326.047, 9.87498, 2.1);
        data[177] = new Data(112029, 340.366, 10.8313, 3.406);
        data[178] = new Data(112158, 340.751, 30.2213, 2.948);
        data[179] = new Data(109427, 332.55, 6.19785, 3.519);
        data[180] = new Data(109176, 331.753, 25.3451, 3.767);
        data[181] = new Data(112440, 341.633, 23.5657, 3.945);
        data[182] = new Data(112748, 342.501, 24.6016, 3.493);
        data[183] = new Data(44382, 135.612, -66.3961, 3.999);
        data[184] = new Data(41312, 126.434, -66.1369, 3.765);
        data[185] = new Data(34481, 107.187, -70.499, 3.776);
        data[186] = new Data(35228, 109.208, -67.9572, 3.972);
        data[187] = new Data(37504, 115.455, -72.6061, 3.933);
        data[188] = new Data(2081, 6.57096, -42.3061, 2.397);
        data[189] = new Data(5165, 16.5214, -46.7184, 3.317);
        data[190] = new Data(6867, 22.0914, -43.3182, 3.414);
        data[191] = new Data(7083, 22.813, -49.0727, 3.942);
        data[192] = new Data(765, 2.35275, -45.7474, 3.876);
        data[193] = new Data(5348, 17.096, -55.2458, 3.99);
        data[194] = new Data(2072, 6.55076, -43.6798, 3.933);
        data[195] = new Data(101958, 309.91, 15.912, 3.771);
        data[196] = new Data(101769, 309.387, 14.5952, 3.64);
        data[197] = new Data(101421, 308.303, 11.3033, 4.032);
        data[198] = new Data(32607, 102.048, -61.9414, 3.266);
        data[199] = new Data(27321, 86.8212, -51.0665, 3.85);
        data[200] = new Data(21281, 68.4991, -55.0451, 3.3);
        data[201] = new Data(26069, 83.4063, -62.4899, 3.88);
        data[202] = new Data(17499, 56.2189, 24.1133, 3.704);
        data[203] = new Data(17573, 56.4565, 24.3676, 3.875);
        data[204] = new Data(17847, 57.2906, 24.0534, 3.62);
        data[205] = new Data(21421, 68.9802, 16.5093, 0.867);
        data[206] = new Data(25428, 81.573, 28.6074, 1.65);
        data[207] = new Data(20205, 64.9483, 15.6276, 3.636);
        data[208] = new Data(20455, 65.7337, 17.5425, 3.757);
        data[209] = new Data(20889, 67.1542, 19.1804, 3.535);
        data[210] = new Data(26451, 84.4112, 21.1425, 3.02);
        data[211] = new Data(17702, 56.8711, 24.1051, 2.873);
        data[212] = new Data(20885, 67.1438, 15.9622, 3.84);
        data[213] = new Data(20894, 67.1657, 15.8709, 3.4);
        data[214] = new Data(18724, 60.1701, 12.4903, 3.45);
        data[215] = new Data(18907, 60.7891, 5.9893, 3.904);
        data[216] = new Data(16083, 51.7923, 9.7327, 3.733);
        data[217] = new Data(15900, 51.2033, 9.02885, 3.602);
        data[218] = new Data(14135, 45.5699, 4.0897, 2.526);
        data[219] = new Data(3419, 10.8974, -17.9866, 2.037);
        data[220] = new Data(12706, 40.8252, 3.23572, 3.468);
        data[221] = new Data(12387, 39.8706, 0.328494, 4.079);
        data[222] = new Data(8645, 27.8652, -10.3351, 3.725);
        data[223] = new Data(5364, 17.1475, -10.1823, 3.441);
        data[224] = new Data(6537, 21.0059, -8.18341, 3.603);
        data[225] = new Data(1562, 4.85698, -8.82393, 3.559);
        data[226] = new Data(8102, 26.017, -15.9375, 3.495);
        data[227] = new Data(9347, 30.0013, -21.0778, 3.992);
        data[228] = new Data(80000, 244.96, -50.1555, 4.017);
        data[229] = new Data(53740, 164.944, -18.2988, 4.08);
        data[230] = new Data(55705, 171.221, -17.684, 4.08);
        data[231] = new Data(55282, 169.835, -14.7786, 3.559);
        data[232] = new Data(77070, 236.067, 6.42564, 2.6);
        data[233] = new Data(77233, 236.547, 15.4218, 3.662);
        data[234] = new Data(78072, 239.113, 15.6616, 3.845);
        data[235] = new Data(76276, 233.7, 10.5383, 3.8);
        data[236] = new Data(77622, 237.704, 4.47773, 3.708);
        data[237] = new Data(89962, 275.328, -2.89882, 3.255);
        data[238] = new Data(77450, 237.185, 18.1416, 4.093);
        data[239] = new Data(77516, 237.405, -3.43023, 3.542);
        data[240] = new Data(86263, 264.397, -15.3986, 3.538);
        data[241] = new Data(40526, 124.129, 9.18553, 3.528);
        data[242] = new Data(42911, 131.171, 18.1543, 3.936);
        data[243] = new Data(43103, 131.674, 28.7599, 4.029);
        data[244] = new Data(100751, 306.412, -56.7351, 1.94);
        data[245] = new Data(102395, 311.239, -66.2032, 3.421);
        data[246] = new Data(99240, 302.182, -66.1821, 3.554);
        data[247] = new Data(98495, 300.148, -72.9105, 3.955);
        data[248] = new Data(91792, 280.759, -71.4281, 4.005);
        data[249] = new Data(86929, 266.433, -64.7238, 3.608);
        data[250] = new Data(27989, 88.7929, 7.40704, 0.87);
        data[251] = new Data(24436, 78.6344, -8.20166, 0.1);
        data[252] = new Data(25336, 81.2827, 6.34965, 1.636);
        data[253] = new Data(25930, 83.0017, 0.299133, 2.25);
        data[254] = new Data(26311, 84.0534, -1.20195, 1.694);
        data[255] = new Data(26727, 85.1897, -1.94264, 1.766);
        data[256] = new Data(25281, 81.1193, -2.39707, 3.35);
        data[257] = new Data(26241, 83.8582, -5.90989, 2.77);
        data[258] = new Data(27366, 86.9391, -9.66965, 2.065);
        data[259] = new Data(26207, 83.7844, 9.93406, 3.39);
        data[260] = new Data(22957, 74.0928, 13.5144, 4.063);
        data[261] = new Data(22449, 72.4601, 6.96126, 3.187);
        data[262] = new Data(22549, 72.8015, 5.60509, 3.681);
        data[263] = new Data(22797, 73.5629, 2.44065, 3.708);
        data[264] = new Data(26549, 84.6865, -2.60002, 3.85);
        data[265] = new Data(24674, 79.4016, -6.84441, 3.59);
        data[266] = new Data(26366, 84.2267, 9.29056, 4.085);
        data[267] = new Data(63125, 194.007, 38.3184, 2.89);
        data[268] = new Data(23522, 75.8545, 60.4422, 4.031);
        data[269] = new Data(42828, 130.898, -33.1864, 3.679);
        data[270] = new Data(42515, 130.026, -35.3084, 3.961);
        data[271] = new Data(43409, 132.633, -27.7099, 4.011);
        data[272] = new Data(100064, 304.514, -12.5448, 3.57);
        data[273] = new Data(100345, 305.253, -14.7814, 3.08);
        data[274] = new Data(106985, 325.023, -16.6623, 3.673);
        data[275] = new Data(107556, 326.76, -16.1273, 2.85);
        data[276] = new Data(105881, 321.667, -22.4113, 3.744);
        data[277] = new Data(104139, 316.487, -17.2328, 4.068);
        data[278] = new Data(69673, 213.915, 19.1824, -0.05);
        data[279] = new Data(73555, 225.486, 40.3906, 3.512);
        data[280] = new Data(71075, 218.019, 38.3083, 3.04);
        data[281] = new Data(74666, 228.876, 33.3148, 3.487);
        data[282] = new Data(72105, 221.247, 27.0742, 2.378);
        data[283] = new Data(71795, 220.287, 13.7283, 3.782);
        data[284] = new Data(67927, 208.671, 18.3977, 2.68);
        data[285] = new Data(70497, 216.299, 51.8508, 4.052);
        data[286] = new Data(71053, 217.957, 30.3714, 3.581);
        data[287] = new Data(67459, 207.369, 15.7979, 4.046);
        data[288] = new Data(107089, 325.369, -77.3901, 3.749);
        data[289] = new Data(82273, 252.166, -69.0277, 1.91);
        data[290] = new Data(77952, 238.786, -63.4307, 2.81);
        data[291] = new Data(74946, 229.727, -68.6796, 2.872);
        data[292] = new Data(79664, 243.859, -63.6856, 3.845);
        data[293] = new Data(76440, 234.18, -66.3171, 4.094);
        data[294] = new Data(60718, 186.651, -63.0992, 0.775);
        data[295] = new Data(62434, 191.93, -59.6887, 1.253);
        data[296] = new Data(61084, 187.791, -57.1132, 1.624);
        data[297] = new Data(59747, 183.786, -58.7489, 2.793);
        data[298] = new Data(60260, 185.34, -60.4012, 3.589);
        data[299] = new Data(60009, 184.609, -64.0032, 4.053);
        data[300] = new Data(63003, 193.649, -57.1777, 4.032);
        data[301] = new Data(113368, 344.413, -29.6223, 1.166);
        data[302] = new Data(37447, 115.312, -9.55116, 3.938);
        data[303] = new Data(30867, 97.205, -7.03353, 3.76);
        data[304] = new Data(29651, 93.7138, -6.27476, 3.971);
        data[305] = new Data(95347, 290.972, -40.616, 3.964);
        data[306] = new Data(95241, 290.66, -44.459, 3.917);
        data[307] = new Data(88635, 271.452, -30.4241, 2.984);
        data[308] = new Data(89931, 275.249, -29.8281, 2.7);
        data[309] = new Data(90185, 276.043, -34.3846, 1.836);
        data[310] = new Data(93506, 285.653, -29.8802, 2.6);
        data[311] = new Data(89642, 274.407, -36.7617, 3.079);
        data[312] = new Data(90496, 276.993, -25.4217, 2.824);
        data[313] = new Data(89341, 273.441, -21.0588, 3.82);
        data[314] = new Data(93085, 284.432, -21.1067, 3.514);
        data[315] = new Data(93683, 286.171, -21.7416, 3.763);
        data[316] = new Data(94141, 287.441, -21.0236, 2.9);
        data[317] = new Data(95168, 290.418, -17.8472, 3.921);
        data[318] = new Data(92855, 283.816, -26.2967, 2.066);
        data[319] = new Data(93864, 286.735, -27.6704, 3.318);
        data[320] = new Data(92041, 281.414, -26.9908, 3.172);
        data[321] = new Data(8796, 28.2704, 29.5788, 3.416);
        data[322] = new Data(10064, 32.3859, 34.9873, 3.004);
        data[323] = new Data(10670, 34.3286, 33.8472, 4.006);
        data[324] = new Data(88192, 270.161, 2.93156, 3.96);
        data[325] = new Data(88601, 271.364, 2.49951, 4.026);
        data[326] = new Data(88771, 271.837, 9.56385, 3.73);
        data[327] = new Data(86032, 263.734, 12.56, 2.08);
        data[328] = new Data(86742, 265.868, 4.56729, 2.77);
        data[329] = new Data(87108, 266.973, 2.70728, 3.747);
        data[330] = new Data(79593, 243.586, -3.69432, 2.734);
        data[331] = new Data(79882, 244.58, -4.6925, 3.234);
        data[332] = new Data(81377, 249.29, -10.5671, 2.571);
        data[333] = new Data(84012, 257.595, -15.7249, 2.43);
        data[334] = new Data(84970, 260.502, -24.9995, 3.269);
        data[335] = new Data(83000, 254.417, 9.37503, 3.39);
        data[336] = new Data(80883, 247.728, 1.98392, 3.816);
        data[337] = new Data(88048, 269.757, -9.77364, 3.333);
        data[338] = new Data(49669, 152.093, 11.9672, 1.36);
        data[339] = new Data(57632, 177.265, 14.572, 2.136);
        data[340] = new Data(50583, 154.993, 19.8414, 2.01);
        data[341] = new Data(54872, 168.527, 20.5237, 2.56);
        data[342] = new Data(47908, 146.463, 23.7742, 2.98);
        data[343] = new Data(50335, 154.173, 23.4173, 3.435);
        data[344] = new Data(49583, 151.833, 16.7627, 3.518);
        data[345] = new Data(54879, 168.56, 15.4295, 3.333);
        data[346] = new Data(55642, 170.981, 10.5292, 4);
        data[347] = new Data(48455, 148.191, 26.0069, 3.883);
        data[348] = new Data(47508, 145.288, 9.8923, 3.52);
        data[349] = new Data(51624, 158.203, 9.30657, 3.874);
        data[350] = new Data(55434, 170.284, 6.02932, 4.043);
        data[351] = new Data(19747, 63.5005, -42.2944, 3.854);
        data[352] = new Data(72220, 221.562, 1.89282, 3.732);
        data[353] = new Data(65474, 201.298, -11.1613, 0.976);
        data[354] = new Data(57757, 177.674, 1.76468, 3.59);
        data[355] = new Data(61941, 190.415, -1.44941, 2.74);
        data[356] = new Data(63090, 193.901, 3.39743, 3.383);
        data[357] = new Data(63608, 195.544, 10.9591, 2.828);
        data[358] = new Data(66249, 203.673, 0.595942, 3.377);
        data[359] = new Data(60129, 184.976, 0.666808, 3.887);
        data[360] = new Data(69701, 214.004, -6.00057, 4.079);
        data[361] = new Data(71957, 220.765, -5.65821, 3.873);
        data[362] = new Data(57380, 176.465, 6.52932, 4.034);
        data[363] = new Data(9487, 30.5119, 2.7637, 3.818);
        data[364] = new Data(114971, 349.291, 3.28227, 3.698);
        data[365] = new Data(7097, 22.8709, 15.3458, 3.618);
        data[366] = new Data(118268, 359.828, 6.86328, 4.008);
        data[367] = new Data(36850, 113.65, 31.8885, 1.58);
        data[368] = new Data(37826, 116.329, 28.0262, 1.161);
        data[369] = new Data(31681, 99.428, 16.3993, 1.928);
        data[370] = new Data(35550, 110.031, 21.9823, 3.5);
        data[371] = new Data(32246, 100.983, 25.1311, 3);
        data[372] = new Data(29655, 93.7196, 22.5067, 3.65);
        data[373] = new Data(33018, 103.197, 33.9612, 3.599);
        data[374] = new Data(36046, 111.432, 27.798, 3.791);
        data[375] = new Data(37740, 116.112, 24.398, 3.576);
        data[376] = new Data(35350, 109.523, 16.5404, 3.582);
        data[377] = new Data(30343, 95.7401, 22.5136, 2.89);
        data[378] = new Data(32362, 101.322, 12.8956, 3.359);
        data[379] = new Data(36962, 113.981, 26.8957, 4.058);
        data[380] = new Data(9236, 29.6925, -61.5698, 2.857);
        data[381] = new Data(2021, 6.43773, -77.2543, 2.82);
        data[382] = new Data(17678, 56.8097, -74.239, 3.237);
        data[383] = new Data(11001, 35.4373, -68.6594, 4.081);
        data[384] = new Data(72622, 222.72, -16.0418, 2.747);
        data[385] = new Data(74785, 229.252, -9.38293, 2.614);
        data[386] = new Data(76333, 233.882, -14.7896, 3.91);
        data[387] = new Data(73714, 226.018, -25.282, 3.293);
        data[388] = new Data(76600, 234.664, -29.7778, 3.651);
        data[389] = new Data(76470, 234.256, -28.135, 3.596);
        data[390] = new Data(101076, 307.349, 30.3686, 4.015);
        data[391] = new Data(102098, 310.358, 45.2804, 1.246);
        data[392] = new Data(95947, 292.68, 27.9597, 3.08);
        data[393] = new Data(100453, 305.557, 40.2567, 2.208);
        data[394] = new Data(97165, 296.244, 45.1307, 2.86);
        data[395] = new Data(102488, 311.553, 33.9703, 2.5);
        data[396] = new Data(104732, 318.234, 30.227, 3.206);
        data[397] = new Data(98110, 299.077, 35.0834, 3.892);
        data[398] = new Data(95853, 292.426, 51.7298, 3.787);
        data[399] = new Data(94779, 289.276, 53.3685, 3.796);
        data[400] = new Data(103413, 314.293, 41.1672, 3.939);
        data[401] = new Data(104060, 316.233, 43.9279, 3.7);
        data[402] = new Data(99675, 303.408, 46.7414, 3.8);
        data[403] = new Data(99848, 303.868, 47.7144, 3.94);
        data[404] = new Data(106481, 323.495, 45.5918, 4.005);
        data[405] = new Data(104887, 318.698, 38.0456, 3.745);
        data[406] = new Data(26634, 84.9123, -34.0742, 2.652);
        data[407] = new Data(27628, 87.74, -35.7684, 3.116);
        data[408] = new Data(30277, 95.5286, -33.4364, 3.846);
        data[409] = new Data(25859, 82.8031, -35.4706, 3.861);
        data[410] = new Data(28328, 89.7867, -42.8152, 3.956);
        data[411] = new Data(109268, 332.058, -46.961, 1.734);
        data[412] = new Data(112122, 340.667, -46.8846, 2.15);
        data[413] = new Data(108085, 328.482, -37.3649, 3.003);
        data[414] = new Data(110997, 337.317, -43.4956, 3.967);
        data[415] = new Data(111043, 337.44, -43.7492, 4.09);
        data[416] = new Data(112623, 342.139, -51.3169, 3.488);
        data[417] = new Data(114421, 347.59, -45.2467, 3.894);
        data[418] = new Data(98337, 299.689, 19.4922, 3.483);
        data[419] = new Data(97365, 296.847, 18.5343, 3.78);
        data[420] = new Data(68756, 211.097, 64.3758, 3.657);
        data[421] = new Data(85670, 262.608, 52.3014, 2.799);
        data[422] = new Data(87833, 269.152, 51.4889, 2.231);
        data[423] = new Data(94376, 288.139, 67.6615, 3.071);
        data[424] = new Data(97433, 297.043, 70.2682, 3.841);
        data[425] = new Data(83895, 257.197, 65.7147, 3.171);
        data[426] = new Data(80331, 245.998, 61.5144, 2.727);
        data[427] = new Data(78527, 240.472, 58.5653, 4.005);
        data[428] = new Data(75458, 231.232, 58.9661, 3.291);
        data[429] = new Data(61281, 188.371, 69.7882, 3.862);
        data[430] = new Data(56211, 172.851, 69.3311, 3.846);
        data[431] = new Data(87585, 268.382, 56.8727, 3.747);
        data[432] = new Data(89937, 275.264, 72.7329, 3.571);
        data[433] = new Data(14879, 48.0179, -28.987, 3.8);
        data[434] = new Data(45688, 139.711, 36.8027, 3.82);
        data[435] = new Data(45860, 140.264, 34.3926, 3.142);
        data[436] = new Data(91262, 279.235, 38.7837, 0.033);
        data[437] = new Data(92420, 282.52, 33.3627, 3.8);
        data[438] = new Data(93194, 284.736, 32.6896, 3.247);
        data[439] = new Data(85792, 262.96, -49.8762, 2.877);
        data[440] = new Data(85258, 261.325, -55.5299, 2.84);
        data[441] = new Data(85267, 261.348, -56.3776, 3.323);
        data[442] = new Data(85727, 262.775, -60.6838, 3.611);
        data[443] = new Data(83153, 254.896, -53.1605, 4.055);
        data[444] = new Data(83081, 254.655, -55.9901, 3.121);
        data[445] = new Data(82363, 252.446, -59.0414, 3.752);
        data[446] = new Data(88714, 271.658, -50.0915, 3.679);
        data[447] = new Data(25985, 83.1825, -17.8223, 2.582);
        data[448] = new Data(25606, 82.0613, -20.7595, 2.833);
        data[449] = new Data(27072, 86.1158, -22.4484, 3.59);
        data[450] = new Data(27654, 87.8304, -20.8791, 3.779);
        data[451] = new Data(23685, 76.3653, -22.3711, 3.177);
        data[452] = new Data(27288, 86.7389, -14.822, 3.546);
        data[453] = new Data(28103, 89.1012, -14.1677, 3.713);
        data[454] = new Data(24305, 78.2329, -16.2055, 3.19);
        data[455] = new Data(87261, 267.465, -37.0433, 3.202);
        data[456] = new Data(80763, 247.352, -26.432, 1.02);
        data[457] = new Data(78820, 241.359, -19.8054, 2.561);
        data[458] = new Data(78401, 240.083, -22.6217, 2.316);
        data[459] = new Data(82396, 252.541, -34.2933, 2.291);
        data[460] = new Data(82729, 253.646, -42.3613, 3.618);
        data[461] = new Data(84143, 258.038, -43.2392, 3.322);
        data[462] = new Data(86228, 264.33, -42.9978, 1.859);
        data[463] = new Data(87073, 266.896, -40.127, 3.022);
        data[464] = new Data(86670, 265.622, -39.03, 2.407);
        data[465] = new Data(85927, 263.402, -37.1038, 1.62);
        data[466] = new Data(82514, 252.968, -38.0474, 3.08);
        data[467] = new Data(82545, 253.084, -38.0174, 3.56);
        data[468] = new Data(79374, 242.999, -19.4606, 4.002);
        data[469] = new Data(78265, 239.713, -26.1141, 2.906);
        data[470] = new Data(78104, 239.221, -29.2141, 3.879);
        data[471] = new Data(80112, 245.297, -25.5928, 2.903);
        data[472] = new Data(81266, 248.971, -28.216, 2.822);
        data[473] = new Data(85696, 262.691, -37.2958, 2.696);
        data[474] = new Data(78933, 241.702, -20.6691, 3.957);
        data[475] = new Data(72370, 221.965, -79.0448, 3.826);
        data[476] = new Data(81065, 248.363, -78.8971, 3.881);
        data[477] = new Data(93429, 285.42, -5.739, 4.019);
        data[478] = new Data(97649, 297.696, 8.86834, 0.765);
        data[479] = new Data(98036, 298.828, 6.40675, 3.719);
        data[480] = new Data(97278, 296.565, 10.6133, 2.718);
        data[481] = new Data(95501, 291.375, 3.11477, 3.36);
        data[482] = new Data(93244, 284.906, 15.0683, 4.022);
        data[483] = new Data(93747, 286.353, 13.8635, 2.986);
        data[484] = new Data(99473, 302.826, 0.821472, 3.238);
        data[485] = new Data(93805, 286.562, -4.88254, 3.43);
        data[486] = new Data(19780, 63.6062, -62.4738, 3.334);
        data[487] = new Data(17440, 56.0499, -64.807, 3.837);
        data[488] = new Data(90422, 276.743, -45.9684, 3.495);
        data[489] = new Data(59199, 182.103, -24.7289, 4.021);
        data[490] = new Data(61359, 188.597, -23.3968, 2.648);
        data[491] = new Data(59803, 183.952, -17.5419, 2.58);
        data[492] = new Data(60965, 187.466, -16.5154, 2.945);
        data[493] = new Data(59316, 182.531, -22.6198, 3.001);
        data[494] = new Data(90139, 275.925, 21.7697, 3.848);
        data[495] = new Data(84345, 258.663, 14.39, 3.58);
        data[496] = new Data(80816, 247.555, 21.4896, 2.781);
        data[497] = new Data(80170, 245.48, 19.1531, 3.8);
        data[498] = new Data(84379, 258.758, 24.8392, 3.123);
        data[499] = new Data(83207, 255.072, 30.9264, 3.915);
        data[500] = new Data(81693, 250.322, 31.603, 2.807);
        data[501] = new Data(81833, 250.724, 38.9223, 3.495);
        data[502] = new Data(87808, 269.063, 37.2505, 3.86);
        data[503] = new Data(86414, 264.866, 46.0064, 3.8);
        data[504] = new Data(86974, 266.615, 27.7207, 3.41);
        data[505] = new Data(87933, 269.441, 29.2479, 3.699);
        data[506] = new Data(88794, 271.886, 28.7625, 3.832);
        data[507] = new Data(84380, 258.762, 36.8092, 3.163);
        data[508] = new Data(79992, 244.935, 46.3134, 3.896);
        data[509] = new Data(9598, 30.8587, 72.4213, 3.964);
        data[510] = new Data(3179, 10.1269, 56.5374, 2.225);
        data[511] = new Data(746, 2.29456, 59.1498, 2.268);
        data[512] = new Data(4427, 14.1772, 60.7167, 2.3);
        data[513] = new Data(6686, 21.454, 60.2353, 2.678);
        data[514] = new Data(8886, 28.5988, 63.6701, 3.368);
        data[515] = new Data(2920, 9.24288, 53.8969, 3.67);
        data[516] = new Data(3821, 12.2742, 57.8162, 3.45);
        data[517] = new Data(7607, 24.4982, 48.6282, 3.573);
        data[518] = new Data(677, 2.09694, 29.0904, 2.073);
        data[519] = new Data(5447, 17.433, 35.6205, 2.048);
        data[520] = new Data(9640, 30.9748, 42.3297, 2.26);
        data[521] = new Data(3092, 9.83207, 30.861, 3.27);
        data[522] = new Data(3693, 11.8347, 24.2672, 4.03);
        data[523] = new Data(116584, 354.391, 46.4582, 3.83);
        data[524] = new Data(4436, 14.1884, 38.4993, 3.862);
        data[525] = new Data(113726, 345.48, 42.326, 3.62);
        data[526] = new Data(7513, 24.1993, 41.4055, 4.091);
        data[527] = new Data(105199, 319.645, 62.5856, 2.451);
        data[528] = new Data(106032, 322.165, 70.5607, 3.19);
        data[529] = new Data(116727, 354.837, 77.6324, 3.208);
        data[530] = new Data(109492, 332.714, 58.2012, 3.4);
        data[531] = new Data(102422, 311.322, 61.8388, 3.428);
        data[532] = new Data(112724, 342.42, 66.2004, 3.519);
        data[533] = new Data(104987, 318.956, 5.24785, 3.92);
        data[534] = new Data(37279, 114.825, 5.22502, 0.4);
        data[535] = new Data(36188, 111.788, 8.28931, 2.894);
        data[536] = new Data(53229, 163.328, 34.2149, 3.816);
        data[537] = new Data(11767, 37.9529, 89.2641, 1.99);
        data[538] = new Data(72607, 222.676, 74.1555, 2.081);
        data[539] = new Data(75097, 230.182, 71.834, 3.047);
        data[540] = new Data(111169, 337.823, 50.2825, 3.758);
        data[541] = new Data(40702, 124.631, -76.9196, 4.063);
        data[542] = new Data(101772, 309.392, -47.2915, 3.108);
        data[543] = new Data(103227, 313.702, -58.4542, 3.643);
        data[544] = new Data(19343, 62.1654, 47.7125, 4.034);
        data[545] = new Data(15863, 51.0807, 49.8612, 1.795);
        data[546] = new Data(14576, 47.0422, 40.9557, 2.31);
        data[547] = new Data(14328, 46.1991, 53.5065, 2.93);
        data[548] = new Data(17358, 55.7312, 47.7876, 3.01);
        data[549] = new Data(18532, 59.4634, 40.0102, 2.888);
        data[550] = new Data(18246, 58.533, 31.8836, 2.89);
        data[551] = new Data(13268, 42.6742, 55.8955, 3.767);
        data[552] = new Data(14632, 47.2667, 49.6133, 4.049);
        data[553] = new Data(14668, 47.374, 44.8573, 3.803);
        data[554] = new Data(17529, 56.2985, 42.5785, 3.777);
        data[555] = new Data(18614, 59.7413, 35.791, 4.04);
        data[556] = new Data(17448, 56.0794, 32.2879, 3.838);
        data[557] = new Data(14354, 46.2941, 38.8403, 3.77);
        data[558] = new Data(13531, 43.5644, 52.7625, 3.93);
        data[559] = new Data(8068, 25.9152, 50.6887, 4.062);
        data[560] = new Data(24608, 79.1723, 45.998, 0.08);
        data[561] = new Data(28360, 89.8822, 44.9474, 1.9);
        data[562] = new Data(28358, 89.8818, 54.2847, 3.721);
        data[563] = new Data(23416, 75.4922, 43.8233, 3.06);
        data[564] = new Data(23453, 75.6195, 41.0758, 3.74);
        data[565] = new Data(23767, 76.6287, 41.2345, 3.17);
        data[566] = new Data(28380, 89.9302, 37.2127, 2.649);
        data[567] = new Data(23015, 74.2484, 33.1661, 2.693);
        data[568] = new Data(27673, 87.8725, 39.1485, 3.982);
        data[569] = new Data(71908, 220.627, -64.9751, 3.194);
        data[570] = new Data(74824, 229.378, -58.8012, 4.063);

        for (int i = 0; i < 571; i++)
        {
            //if (data[i].deg <= 3.5)
            {
                s[i] = Instantiate(GameObject.Find("Star"));
                //s[i].transform.rotation = Quaternion.Euler(new Vector3(0, (float)data[i].cj, (float)data[i].cw));
                s[i].transform.Rotate(0, -(float)data[i].cj, 0);
                s[i].transform.Rotate(0, 0, (float)data[i].cw);
                float radius = ((float)-data[i].deg + 3) / 4.0f + 0.6f;
                s[i].transform.GetChild(1).transform.localScale = new Vector3(radius, radius, radius);
            } 
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
