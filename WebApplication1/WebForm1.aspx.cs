using Hello.World.QiyaChiChi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloWorld hello = new HelloWorld();
            Hello.World.QiyaChiChi.HelloWorld helloWorld = new Hello.World.QiyaChiChi.HelloWorld();
        }
    }
}

namespace Hello.World.QiyaChiChi
{
    public class HelloWorld
    {
        public string HelloWorldPerportyA { set; get; }

        public void HelloWorldFunctionA()
        {

        }
    }
}