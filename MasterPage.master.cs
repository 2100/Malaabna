using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            refreshdata();
        }
    }


    public void refreshdata()
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;" +
                                          "Database=mal3ebna;" +
                                          "Uid=root;" +
                                          "Pwd=;");

        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("mal3b.xml"));
        if (ds != null && ds.HasChanges())
        {
            GridView2.DataSource = ds;
            GridView2.DataBind();

        }
        else
        {

            GridView2.DataBind();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(constr);

        try
        {
            conn.Open();

            String description = "mal3ab helw gedan, mawgod f sheraton";
            String id = "1";
            String location = "sheraton";
            String name = "markaz shabab sheraton";
            String price = "30 for 1 hour";


            String my_querry = "INSERT INTO mal3ab(description,id,location,name,price)VALUES('" + description + "','" + id + "','" + location +
                "','" + name + "','" + price + "')";

            MySqlCommand cmd = new MySqlCommand(my_querry, conn);

            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('data saved succseffuly...!!!!');</script>");
        }



        catch (Exception ex)
        {
            // MessageBox.Show("Failed due to" + ex.Message);
        }
        finally
        {
            conn.Close();

        }
    }


    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}