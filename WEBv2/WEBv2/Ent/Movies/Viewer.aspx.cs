using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBv2.App_Code;

namespace WEBv2.Ent.Movies
{
    public partial class Viewer : System.Web.UI.Page
    {
        public string test;
        protected void Page_Load(object sender, EventArgs e)
        {
            var a = "";
            Algorithms algorithms = new Algorithms();
            algorithms.(out a, "Education");
            test = a;
        }
    }
}