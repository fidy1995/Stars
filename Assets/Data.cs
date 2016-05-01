using UnityEngine;
using System.Collections;

namespace dpp
{
    public class Data : MonoBehaviour
    {
        public int no { get; set; }
        public double cj { get; set; }
        public double cw { get; set; }
        public double deg { get; set; }

        public Data(int n, double j, double w, double d)
        {
            no = n;
            cj = j;
            cw = w;
            deg = d;
        }
    }
}
