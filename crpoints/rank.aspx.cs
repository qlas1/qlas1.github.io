using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;  
using System.Data.SqlClient;

public partial class rank : System.Web.UI.Page  
{  
    
	//qlas
	
		
	
	protected string FormatUrl(int FriendsAccountID)
{
   return "rank.aspx?id=" + FriendsAccountID;
	
}

public string path; 
public string text; 

 	
    //Connection String from Web.config file  
    //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;  
    protected void Page_Load(object sender, EventArgs e)  
    { 
	
	int editScore =0;
	string s = Request.QueryString["id"];
	
	
	 SqlConnection con = new SqlConnection();
            con.ConnectionString =  
"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";		
		
	
       using (SqlDataAdapter sda = new SqlDataAdapter("select CRPoints from Revenge_CR_View where CharacterSid = 3420", con)) 
        {
			 using (DataTable dt = new DataTable())
                {
		con.Open();  
        sda.Fill(dt);
        con.Close();  
		GridView1.DataSource = dt;  

            if (dt.Rows.Count > 0)
            {
               text = dt.Rows[0]["CRPoints"].ToString().Trim();
               
            }	
				}
		Label1.Text = text;		
		}
		
		
    editScore = Int32.Parse(text) / 500;
     if (editScore == 0 || editScore <= 1000){path = "images/1.jpg"; }
	if (editScore >= 1001 || editScore >= 2000){path = "images/2.jpg";}
	if (editScore >= 2001 || editScore >= 3000) {path = "images/3.jpg";}
	if (editScore >= 3001 || editScore >= 4000) {path = "images/4.jpg";}
	if (editScore >= 4001 || editScore >= 5000) {path = "images/5.jpg";}
	if (editScore >= 5001 || editScore >= 6000) {path = "images/6.jpg";}
	
        if(!IsPostBack)  
        {  
            ShowData();  
		
        }  
	
      
	
	}
	//--------------
	
      
	//----------------
	
    //method for Displaying Data in Gridview  
    protected void ShowData()  
    {  

        SqlConnection con = new SqlConnection();
            con.ConnectionString =  
"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";		
		
		
        using (SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 20 name,  JobName, CRPoints FROM Revenge_CR_View WHERE name NOT LIKE '%@%'", con)) 
        {
			 using (DataTable dt = new DataTable())
                {
		con.Open();  
        sda.Fill(dt);
        con.Close();  
		GridView1.DataSource = dt;  
        GridView1.DataBind(); 
		
				}		
		}
    }  
	
	protected void allButton_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 20 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE name NOT LIKE '%@%'", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
		
				}		
		}
		  
		}

	
	    protected void ImageButton1_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '320' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
	
		protected void ImageButton2_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '322' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
	
		protected void ImageButton3_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '321' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		protected void ImageButton4_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '123' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}

		protected void ImageButton5_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '122' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}

		protected void ImageButton6_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '121' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		protected void ImageButton7_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '120' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		protected void ImageButton8_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '220' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		protected void ImageButton9_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '221' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		protected void ImageButton10_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '323' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		protected void ImageButton11_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '222' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}

		protected void ImageButton12_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '223' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		protected void ImageButton13_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '224' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		protected void ImageButton14_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '324' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		protected void ImageButton15_Click(object sender, EventArgs e)
        {
			SqlConnection con1 = new SqlConnection();
            con1.ConnectionString =  
			"Data Source=54.37.93.173;" +
"Initial Catalog=Telecaster;" +
"User id=r3v1web;" +
"Password=R3V_G@S369ser36veRR9;";	
			using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP 10 name,  JobName, CRPoints  FROM Revenge_CR_View WHERE jobid  LIKE '124' ", con1)) 
        {
			 using (DataTable dt1 = new DataTable())
                {
		con1.Open();  
        sda1.Fill(dt1);
        con1.Close();  
		
		string[] columnNames = (from dc in dt1.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();
		
        GridView1.DataSource = dt1;  
        GridView1.DataBind(); 
				}		
		}
		  
		}
		
		
    //RowDataBound Event  
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)  
    {  
        //Checking the RowType of the Row  
        if(e.Row.RowType==DataControlRowType.DataRow)  
        {  
            //If Salary is less than 10000 than set the row Background Color to Cyan 
            
            if(e.Row.Cells[2].Text.Contains("#1e00fe"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#1e00fe", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#1e00fe");			
			}
			if(e.Row.Cells[2].Text.Contains("#00a2ff"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#00a2ff", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#00a2ff");			
			}
            if(e.Row.Cells[2].Text.Contains("#7e01ff"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#7e01ff", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#7e01ff");			
			}			
			if(e.Row.Cells[2].Text.Contains("#dd00fe"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#dd00fe", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#dd00fe");			
			} 
			if(e.Row.Cells[2].Text.Contains("#ff00c0"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#ff00c0", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#ff00c0");			
			}
			if(e.Row.Cells[2].Text.Contains("#0077d3"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#0077d3", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#0077d3");			
			}
			if(e.Row.Cells[2].Text.Contains("#00ffa3"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#00ffa3", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#00ffa3");			
			}
			if(e.Row.Cells[2].Text.Contains("#7dff00"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#7dff00", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#7dff00");			
			}
			if(e.Row.Cells[2].Text.Contains("#00fcff"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#00fcff", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#00fcff");			
			}
			if(e.Row.Cells[2].Text.Contains("#af0237"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#af0237", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#af0237");			
			}
			if(e.Row.Cells[2].Text.Contains("#ff0060"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#ff0060", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#ff0060");			
			}
			if(e.Row.Cells[2].Text.Contains("#ffc000"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#ffc000", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#ffc000");			
			}
			if(e.Row.Cells[2].Text.Contains("#dffe02"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#dffe02", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#dffe02");			
			}
			if(e.Row.Cells[2].Text.Contains("#ff6100"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#ff6100", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#ff6100");			
			}
			if(e.Row.Cells[2].Text.Contains("#fe0000"))
			{
	  	    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Replace("#fe0000", "");
		    e.Row.Cells[2].Text = e.Row.Cells[2].Text.Substring(4);
            e.Row.Cells[2].ForeColor = Color.FromName("#fe0000");			
			}
			//=================== 
          
			
        }

		Label1.Text = text;
		
		
		
    }  

 
}  





