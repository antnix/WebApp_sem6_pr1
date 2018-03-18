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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (DbContext dbContext = new DbContext("ConnectionString"))
            {
                var name = tbName1.Text;
                var lastName = tbName2.Text;
                var phoneNumber1 = tbPhoneNumber1.Text;
                var phoneNumber2 = tbPhoneNumber2.Text;
                int.TryParse(tbId.Text, out int id);

                dbContext.Database.ExecuteSqlCommand($"INSERT INTO Student VALUES ('{name}', '{lastName}', {id});");

                if (cbPhoneNumber1.Checked == true && cbPhoneNumber2.Checked == false)
                dbContext.Database.ExecuteSqlCommand("INSERT INTO Student VALUES ('" + tbName1.Text + "', '" + tbName2.Text + "', " + tbId.Text + ");" +
                    " INSERT INTO Phones VALUES('" + tbPhoneNumber1.Text + "', SCOPE_IDENTITY())");
                else if(cbPhoneNumber1.Checked == true && cbPhoneNumber2.Checked == true)
                    dbContext.Database.ExecuteSqlCommand("INSERT INTO Student VALUES ('" + tbName1.Text + "', '" + tbName2.Text + "', " + tbId.Text + ");" +
                    " INSERT INTO Phones VALUES('" + tbPhoneNumber1.Text + "', SCOPE_IDENTITY()), ('" + tbPhoneNumber2.Text + "', SCOPE_IDENTITY())" );
                else if (cbPhoneNumber1.Checked == false && cbPhoneNumber2.Checked == true)
                    dbContext.Database.ExecuteSqlCommand("INSERT INTO Student VALUES ('" + tbName1.Text + "', '" + tbName2.Text + "', " + tbId.Text + ");" +
                    " INSERT INTO Phones VALUES('" + tbPhoneNumber2.Text + "', SCOPE_IDENTITY())");
                else
                    dbContext.Database.ExecuteSqlCommand("INSERT INTO Student VALUES ('" + tbName1.Text + "', '" + tbName2.Text + "', " + tbId.Text + ");");
                dbContext.SaveChanges();
            }
            gwMainTable.DataBind();
        }
        
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhoneNumber1.Checked)
               tbPhoneNumber1.Enabled = true;
            else
               tbPhoneNumber1.Enabled = false;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhoneNumber2.Checked)
                tbPhoneNumber2.Enabled = true;
            else
                tbPhoneNumber2.Enabled = false;
        }
    }
}