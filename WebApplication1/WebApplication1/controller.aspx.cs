using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class controller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //load model
            try
            {

                if (Request.QueryString.Get("ctrl").Equals("test"))
                {
                    Session.Add("val", "vAL sTRING");
                    Server.TransferRequest("~/View/WebForm1.aspx");
                }
                else if (Request.QueryString.Get("ctrl").Equals("test2"))
                {
                    Server.TransferRequest("~/View/WebForm2.aspx");
                }
            }
            catch (Exception ex)
            {
                Server.TransferRequest("~/error.html");
            }


        }
    }
}