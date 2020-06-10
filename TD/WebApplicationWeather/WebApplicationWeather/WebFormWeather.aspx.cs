using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWeather
{
    public partial class WebFormWeather : System.Web.UI.Page
    {
        private weatherWS.GlobalWeather weatherWSreference;
        protected void Page_Load(object sender, EventArgs e)
        {
            weatherWSreference = new weatherWS.GlobalWeather();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = weatherWSreference.GetWeather(this.Text1.Text, this.Text2.Text);
        }
    }
}