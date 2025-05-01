using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace P2ASPNET_22SA11A116
{
	public partial class index : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void btnCreate_Click(object sender,EventArgs e)
		{
			string path = txtpath.Text;
			if (!File.Exists(path))
			{
				string[] buatText =   {
                    "Nama Mahasiswa, Nilai",
                    "Budi, 85",
                    "Siti, 90",
                    "Agus, 78",
                    "Dewi, 88"
                };
                File.WriteAllLines(path, buatText);
			}
			string appendText = "Nilai semua mahasiswa" + Environment.NewLine;
			File.AppendAllText(path, appendText);
            Label1.Text = "File Berhasil Dibuat!";

        }
        protected void btnRead_Click(object sender, EventArgs e)
		{
			if (fileupload1.HasFile)
			{
				using (StreamReader reader = new StreamReader(fileupload1.PostedFile.InputStream))
				{
					textBoxContents.Text = reader.ReadToEnd();
				}
			}
			else
			{
				textBoxContents.Text = "Silahkan pilih/unggah file terlebih dahulu!!";
			}
		}
	}
}