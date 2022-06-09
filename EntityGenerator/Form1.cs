using System;

using System.Data;

using System.Windows.Forms;

using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;

namespace WindowsApplication1
{

    public partial class Form1 : Form

    {
        public Form1()

        {

            InitializeComponent();

            dataGridView1.ColumnCount = 1;

            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
           
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

            cmb.HeaderText = "Select Type";

            cmb.Name = "cmb";

            cmb.MaxDropDownItems = 4;

            cmb.Items.Add("int");

            cmb.Items.Add("decimal");

            cmb.Items.Add("bool");

            cmb.Items.Add("string");

            cmb.Items.Add("datetime");

            cmb.Items.Add("object");

            dataGridView1.Columns.Add(cmb);

            string[] row = new string[] { "Id" };

            dataGridView1.Rows.Add("Id", "int");

        }

        private void btnGenerateEntities_Click(object sender, EventArgs e)
        {
            textArea.Clear();
            textArea2.Clear();
            textArea3.Clear();

            #region Entity

            var entityHeader =
                @"using Sda.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sda.Arms.Entities
{
     public class " + className.Text + "\n" + "    {" + "\n" + "        public " + className.Text + "()" + "\n" + "        {" + "\n\n" + "        }" + "\n";

            var entityContent = "";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                entityContent = entityContent + "        public " + dataGridView1.Rows[i].Cells[1].Value + " " + dataGridView1.Rows[i].Cells[0].Value + " { get; set; }" + "\n";
            }
            entityContent = entityContent + "    }";
            entityContent = entityContent + "\n" + "}\n";

            entityContent = entityContent.Replace("datetime", "DateTime");

            textArea.AppendText(entityHeader + entityContent);


            #endregion

            #region NHibernate

            var nhibernateHeader = @"<?xml version=""1.0"" encoding=""utf - 8"" ?>
  < hibernate - mapping xmlns = ""urn:nhibernate-mapping-2.2"" schema = ""dbo""
                   assembly = ""Sda.Arms.Data""
                   namespace=""Sda.Arms.Entities"" default-lazy=""false"" default-cascade=""none"">
  <class name=""Sda.Arms.Entities." + className.Text + @", Sda.Arms"" table=""" + className.Text + @""">
       <id name = ""Id"" column=""id"" type=""int"" ></id>
";

            var nhibernateContent = "";
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() != "Id")
                {
                nhibernateContent = nhibernateContent + "  <property name=" + "\"" + dataGridView1.Rows[i].Cells[0].Value + "\"" + " type=" + "\"" + dataGridView1.Rows[i].Cells[1].Value + "\"" + "/>" + "\n";
                }
            }

            var nhibernateFooter = @"  </class>
  
</hibernate-mapping>";

            nhibernateContent = nhibernateContent.Replace("string", "AnsiString");
            nhibernateContent = nhibernateContent.Replace("datetime", "DateTime");

            var nhibernateString = nhibernateHeader + nhibernateContent + nhibernateFooter;

            textArea2.AppendText(nhibernateString);


            #endregion

            #region Model

            var modelHeader =
                @"using Sda.Arms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Sda.Arms.Api.Models
{
      [DataContract]
      public class " + className.Text + "Model" + "\n" +"      {" + "\n" + "           public " + className.Text + "Model" + "()" + "\n" + "           {" + "\n\n" + "           }\n\n";

            var modelContent = "";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string variable = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (variable != string.Empty && char.IsUpper(variable[0]))
                {
                    variable = char.ToLower(variable[0]) + variable.Substring(1);
                }
                modelContent = modelContent + @"            [DataMember(Name = """ + variable + @""")]" + "\n" + "            public " + dataGridView1.Rows[i].Cells[1].Value + " " + dataGridView1.Rows[i].Cells[0].Value + " { get; set; }" + "\n";
            }

            modelContent = modelContent + "\n            public void ImportData(" + className.Text + " entity)\n            {\n                  if (entity == null) { return; }\n";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                modelContent = modelContent + @"                  this." + dataGridView1.Rows[i].Cells[0].Value + " = entity." + dataGridView1.Rows[i].Cells[0].Value + ";\n";
            }
            modelContent = modelContent + "            }\n";

            modelContent = modelContent + "\n            public void ExportData(" + className.Text + " entity)\n            {\n                  if (entity == null) { return; }\n";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                modelContent = modelContent + @"                  entity." + dataGridView1.Rows[i].Cells[0].Value + " = this." + dataGridView1.Rows[i].Cells[0].Value + ";\n";
            }
            modelContent = modelContent + "            }\n";

            modelContent = modelContent + "\n            public " + className.Text + " GetEntity()\n            {\n                  var entity = new " + className.Text + "();\n                  this.ExportData(entity);\n                  return entity;\n            }\n";

            modelContent = modelContent + "\n      }" + "\n" + "}\n";
            textArea3.AppendText(modelHeader + modelContent);

            #endregion

        }
        
        private void dgridv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                if (item.Index != dataGridView1.RowCount - 1)
                {
                dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            switch (Tabs.SelectedIndex)
            {
                case 0:
                    StringBuilder sb1 = new StringBuilder();

                    foreach (string line in textArea.Lines)
                        sb1.AppendLine(line);

                    Clipboard.SetText(sb1.ToString());
                    break;
                case 1:
                    StringBuilder sb2 = new StringBuilder();

                    foreach (string line in textArea2.Lines)
                        sb2.AppendLine(line);

                    Clipboard.SetText(sb2.ToString());
                    break;
                case 2:
                    StringBuilder sb3 = new StringBuilder();

                    foreach (string line in textArea3.Lines)
                        sb3.AppendLine(line);

                    Clipboard.SetText(sb3.ToString());
                    break;
                default:
                    break;
            }

        }
    }

}
