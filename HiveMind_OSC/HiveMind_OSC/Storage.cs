using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveMind_OSC
{
    internal class Storage
    {
        public static bool ShouldTerminateDisplayMessageThread { get; set; } = false;

        public static int SlidingMessageSelection { get; set; } = 0;
        public static List<List<string>> SlidingMessages { get; set; } = new List<List<string>>() { new List<string> { 
                             "- HiveMind -",
                             " - HiveMind ",
                             "d - HiveMind",
                             "d - HiveMind",
                             "nd - HiveMin",
                             "ind - HiveMi",
                             "Mind - HiveM",
                             "eMind - Hive",
                             "veMind - Hiv",
                             "iveMind - Hi",
                             "HiveMind - H",
                             " HiveMind - ",
                             "- HiveMind -",
            },  new List<string> {
                             "- Owned by xenosia <3 -",
                             " - Owned by xenosia <3 ",
                             "3 - Owned by xenosia <3",
                             "<3 - Owned by xenosia <",
                             " <3 - Owned by xenosia ",
                             "a <3 - Owned by xenosia",
                             "ia <3 - Owned by xenosi",
                             "sia <3 - Owned by xenos",
                             "osia <3 - Owned by xeno",
                             "nosia <3 - Owned by xen",
                             "enosia <3 - Owned by xe",
                             "xenosia <3 - Owned by x",
                             " xenosia <3 - Owned by ",
                             "y xenosia <3 - Owned by",
                             "by xenosia <3 - Owned b",
                             " by xenosia <3 - Owned ",
                             "d by xenosia <3 - Owned",
                             "ed by xenosia <3 - Owne",
                             "ned by xenosia <3 - Own",
                             "wned by xenosia <3 - Ow",
                             "Owned by xenosia <3 - O",
                             " Owned by xenosia <3 - ",
                             "- Owned by xenosia <3 -",

            }};
    }
}
