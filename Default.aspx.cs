using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var vessels = new List<Vessel>
            {
                new Vessel { Name = "Titanic", Type = "Passenger Ship", Capacity = 2435 },
                new Vessel { Name = "USS Enterprise", Type = "Aircraft Carrier", Capacity = 5000 },
                new Vessel { Name = "Santa Maria", Type = "Caravel", Capacity = 40 }
            };
            gvVessels.DataSource = vessels;
            gvVessels.DataBind();
        }
    }
}

public class Vessel
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Capacity { get; set; }
}