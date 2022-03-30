using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Image = System.Web.UI.WebControls.Image;

namespace interfejspro
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private DropDownList wybrany;
        private Button klik;
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            
        String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
             SqlConnection conn = new SqlConnection(strConn);
             conn.Open();

             SqlCommand cmd = new SqlCommand("Select [Nazwa], [Cena], [Zdjęcie] From Sprzet Where Nazwa = @Button1", conn);

            try
              {

               SqlParameter search = new SqlParameter();
               search.ParameterName = "@Button1";
               search.Value = TextBox1.Text.Trim();

                cmd.Parameters.Add(search);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                GridView1.DataSource = dt;
                GridView1.DataBind();


             }
             catch (Exception ex)
              {
                 Response.Write(ex.Message);
             }
              finally
             {
           //Connection Object Closed
              conn.Close();


            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (DropDownList1.SelectedIndex == 0)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                Image1.Visible = true;
                Image1.Visible = true;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = true;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                Image1.Visible = true;
                Image2.Visible = true;
                Image3.Visible = false;
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;
                Label11.Visible = true;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = true;
                Label16.Visible = true;
                Label17.Visible = false;

            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                Image1.Visible = true;
                Image2.Visible = true;
                Image3.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;
                Label11.Visible = true;
                Label12.Visible = true;
                Label13.Visible = true;
                Label14.Visible = true;
                Label15.Visible = true;
                Label16.Visible = true;
                Label17.Visible = true;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedIndex == 0)
            {
                Image1.Visible = true;
                Image2.Visible = true;
                Image3.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;
                Label11.Visible = true;
                Label12.Visible = true;
                Label13.Visible = true;
                Label14.Visible = true;
                Label15.Visible = true;
                Label16.Visible = true;
                Label17.Visible = true;
            }
            else if (DropDownList2.SelectedIndex == 1)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList2.SelectedIndex == 2)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;

            }
            else if (DropDownList2.SelectedIndex == 3)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList2.SelectedIndex == 4)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }

            if (DropDownList2.SelectedIndex == 1)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT  [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM Sprzet ORDER BY [Cena];", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList2";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList2.SelectedIndex == 2)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT  [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM Sprzet ORDER BY [Cena] DESC;", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList2";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList2.SelectedIndex == 0)
            {
                GridView1.Visible = false;
            }
            else if (DropDownList2.SelectedIndex == 3)
            {

                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM Sprzet ORDER BY [Nazwa]", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList2";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();

                }
            }
            else if (DropDownList2.SelectedIndex == 4)
            {

                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM Sprzet ORDER BY [Nazwa] DESC", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList2";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();

                }
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedIndex == 0)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList3.SelectedIndex == 1)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList3.SelectedIndex == 2)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;

            }
            else if (DropDownList3.SelectedIndex == 3)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList3.SelectedIndex == 4)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            if (DropDownList3.SelectedIndex == 0)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%telewizor%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList3";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList3.SelectedIndex == 1)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%odtwarzacz%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList3";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList3.SelectedIndex == 2)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%projektor%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList3";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList3.SelectedIndex == 3)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%drobnysprzęt%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList3";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList4.SelectedIndex == 0)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList4.SelectedIndex == 1)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList4.SelectedIndex == 2)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;

            }
            else if (DropDownList4.SelectedIndex == 3)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList4.SelectedIndex == 4)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            if (DropDownList4.SelectedIndex == 0)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%komputer%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList4";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList4.SelectedIndex == 1)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintariu;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%laptop%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList4";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList4.SelectedIndex == 2)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%tablet%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList4";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList4.SelectedIndex == 3)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%serwer%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList4";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList5.SelectedIndex == 0)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList5.SelectedIndex == 1)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList5.SelectedIndex == 2)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;

            }
            else if (DropDownList5.SelectedIndex == 3)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList5.SelectedIndex == 4)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            if (DropDownList5.SelectedIndex == 0)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%podzespoły%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList5";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList5.SelectedIndex == 1)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%płyta główna%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList5";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList5.SelectedIndex == 2)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%Karta Graficzna%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList5";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList5.SelectedIndex == 3)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%procesor%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList5";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList6.SelectedIndex == 0)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList6.SelectedIndex == 1)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList6.SelectedIndex == 2)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;

            }
            else if (DropDownList6.SelectedIndex == 3)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            else if (DropDownList6.SelectedIndex == 4)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
            }
            if (DropDownList6.SelectedIndex == 0)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%AGD%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList6";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList6.SelectedIndex == 1)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%lodówka%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList6";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList6.SelectedIndex == 2)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%pralka%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList6";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
            else if (DropDownList6.SelectedIndex == 3)
            {


                String strConn = "Data Source=DESKTOP-27MOBFG\\xintarius;Initial Catalog=interfejs1;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Nazwa] AS Nazwa, [Cena], [Zdjęcie] FROM [Sprzet] WHERE [Nazwa] LIKE '%zmywarka%';", conn);

                try
                {

                    SqlParameter search = new SqlParameter();
                    search.ParameterName = "@DropDownList6";
                    search.Value = TextBox1.Text.Trim();

                    cmd.Parameters.Add(search);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Connection Object Closed
                    conn.Close();


                }
            }
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            try
            {
             
            }
            catch
            {

            }
            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DetailsView1_PageIndexChanging1(object sender, DetailsViewPageEventArgs e)
        {

        }
    }
}