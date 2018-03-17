using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Entity;

namespace WebApp_sem6_pr1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (DbContext dbContext = new DbContext("ConnectionString"))
            {
                if(CheckBox1.Checked == true && CheckBox2.Checked == false)
                dbContext.Database.ExecuteSqlCommand("INSERT INTO Student VALUES ('" + TextBox1.Text + "', '" + TextBox3.Text + "', " + TextBox2.Text + ");" +
                    " INSERT INTO Phones VALUES('" + TextBox4.Text + "', SCOPE_IDENTITY())");
                else if(CheckBox1.Checked == true && CheckBox2.Checked == true)
                    dbContext.Database.ExecuteSqlCommand("INSERT INTO Student VALUES ('" + TextBox1.Text + "', '" + TextBox3.Text + "', " + TextBox2.Text + ");" +
                    " INSERT INTO Phones VALUES('" + TextBox4.Text + "', SCOPE_IDENTITY()), ('" + TextBox5.Text + "', SCOPE_IDENTITY())" );
                else if (CheckBox1.Checked == false && CheckBox2.Checked == true)
                    dbContext.Database.ExecuteSqlCommand("INSERT INTO Student VALUES ('" + TextBox1.Text + "', '" + TextBox3.Text + "', " + TextBox2.Text + ");" +
                    " INSERT INTO Phones VALUES('" + TextBox5.Text + "', SCOPE_IDENTITY())");
                else
                    dbContext.Database.ExecuteSqlCommand("INSERT INTO Student VALUES ('" + TextBox1.Text + "', '" + TextBox3.Text + "', " + TextBox2.Text + ");");
                dbContext.SaveChanges();
            }
            GridView1.DataBind();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
               TextBox4.Enabled = true;
            else
               TextBox4.Enabled = false;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
                TextBox5.Enabled = true;
            else
                TextBox5.Enabled = false;
        }
    }
}