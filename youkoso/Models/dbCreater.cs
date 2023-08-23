using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace youkoso;

        public class Japanese
        {
            public Japanese() { }
            public Japanese(string h1, string k1, string h2, string k2, string h3, string k3, string s1, string n1, string t1, string g1, string n2, string f1, string b1)
            {
                this.h1 = h1;
                this.h2 = h2;
                this.h3 = h3;
                this.k1 = k1;
                this.k2 = k2;
                this.k3 = k3;
                this.s1 = s1;
                this.n1 = n1;
                this.t1 = t1;
                this.g1 = g1;
                this.n2 = n2;
                this.f1 = f1;
                this.b1 = b1;
}
//            [AutoIncrement, PrimaryKey]
            public int Id { get; set; } // 主キー

            public string h1 { get; set; }
            public string h2 { get; set; }
            public string h3 { get; set; }
            public string k1 { get; set; }
            public string k2 { get; set; }
            public string k3 { get; set; }
            public string s1 { get; set; }
            public string n1 { get; set; }
            public string t1 { get; set; }
            public string g1 { get; set; }
            public string n2 { get; set; }
            public string f1 { get; set; }
            public string b1 { get; set; }
}

