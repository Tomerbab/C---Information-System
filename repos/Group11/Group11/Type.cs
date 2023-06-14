using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;



namespace Group11
{
    public enum Type
    {
        [Description("manager")] manager,
        [Description("sewing manager")]sewingmanager,
        [Description("installer")] installer,
        [Description("tailor")] tailor,
        [Description("accountant")] accountant,
    }


}
