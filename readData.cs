using System.Net;
using System.Data;
using Newtonsoft.Json;

protected void Page_Load(object sender, EventArgs e)
{
    if (!this.IsPostBack)
    {
        string json = (new WebClient()).DownloadString("https://api.doladujkarnet.pl:8443/BxNetRest/rest/people/license/amount.json");
        gridview1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
        object p = gridview1.DataBind();
    }
}