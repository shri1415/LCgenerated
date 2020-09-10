using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using iTextSharp.text.pdf.draw;

namespace LCgenerator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        public void BindGrid()
        {
            string cs = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select AdmissionNo,StudentName,Nationality,MotherTongue,Religion,Caste,SubCast,BirthPlace,DOB_Digit,AdmitInClass,Date_SchoolLeave from StudentDB ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        public DataSet GetData1(int Id)
        {
            string MyConnString = @"Data Source=.;Initial Catalog=SPwork;Integrated Security=True;";
            SqlConnection con = new SqlConnection(MyConnString);
            SqlCommand cmd = new SqlCommand("sp_GetStud", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
            }
            return ds;
        }

        public void userValid()
        {

            var AdmissionNo = txtAdissionNo.Text;
            var StudentName = txtStudentName.Text;
            var Nationality = txtNationalaity.Text;
            var MotherTongue = drpLanguage.Text;
            var Religion = drpRelegion.Text;
            var Caste = drpCast.Text;
            var SubCast = drpSubCast.Text;
            var BirthPlace = drpBirthPlace.Text;
            var DOB_Digit = txtDOB.Text;
            var DOB_Word = txtDOBW.Text;
            var PrevSchoolName = txtPrevSchool.Text;
            var AdmitInClass = txtAdmitClass.Text;
            var Asmission_Date = txtAdmissionDate.Text;
            var Progress = txtProgress.Text;
            var Behaviour = txtBehaviour.Text;
            var Date_SchoolLeave = txtSchoolLeave.Text;
            var Class_Left = txtClassLeft.Text;
            var Reason_SchoolLeave = txtReason.Text;
            var Certificate_Date = txtCertDate.Text;
            var Certificte_RecByName = txtCertRecBy.Text;

            if (AdmissionNo == "" && StudentName == "" && Nationality == "" && MotherTongue == "" && Religion == "" && Caste == "" && SubCast == "" && BirthPlace == "" && DOB_Digit == "" && DOB_Word == ""
                && PrevSchoolName == "" && AdmitInClass == "" && Asmission_Date == "" && Progress == "" && Behaviour == "" && Date_SchoolLeave == ""
                       && Certificate_Date == "" && Certificte_RecByName == "")
            {
                Response.Write("<script>alert('Please Fill All Feilds !!')</script>");
                return;
            }
            if (AdmissionNo == "")
            {
                Response.Write("<script>alert('Please Enter Admission Number')</script>");
                return;
            }
            if (StudentName == "")
            {
                Response.Write("<script>alert('Please Enter Student Name')</script>");
                return;
            }
            if (Nationality == "")
            {
                Response.Write("<script>alert('Please Enter Nationality')</script>");
                return;
            }

            if (MotherTongue == "")
            {
                Response.Write("<script>alert('Please Select Mother Tongue')</script>");
                return;
            }
            if (MotherTongue == "")
            {
                Response.Write("<script>alert('Please Select Mother Tongue')</script>");
                return;
            }
            if (Religion == "")
            {
                Response.Write("<script>alert('Please Select Religion')</script>");
                return;

            }
            if (Caste == "")
            {
                Response.Write("<script>alert('Please Select Cast')</script>");
                return;
            }
            if (SubCast == "")
            {
                Response.Write("<script>alert('Please Select SubCast')</script>");
                return;
            }
            if (BirthPlace == "")
            {
                Response.Write("<script>alert('Please Select Birth Place')</script>");
                return;
            }
            if (DOB_Digit == "")
            {
                Response.Write("<script>alert('Please Select Date Of Birth')</script>");
                return;
            }
            if (DOB_Word == "")
            {
                Response.Write("<script>alert('Please Enter Date Of Birth in Word')</script>");
                return;

            }
            if (PrevSchoolName == "")
            {
                Response.Write("<script>alert('Please Enter Previous School')</script>");
                return;

            }
            if (AdmitInClass == "")
            {
                Response.Write("<script>alert('Please Enter Class which  Admit')</script>");
                return;

            }
            if (Asmission_Date == "")
            {
                Response.Write("<script>alert('Please Select Admission Date')</script>");
                return;

            }

            if (Progress == "")
            {
                Response.Write("<script>alert('Please Enter Progress Details')</script>");
                return;

            }
            if (Behaviour == "")
            {
                Response.Write("<script>alert('Please Enter Behaviour')</script>");
                return;

            }
            if (Date_SchoolLeave == "")
            {
                Response.Write("<script>alert('Please Select School Leave Date')</script>");
                return;

            }
            if (Certificate_Date == "")
            {
                Response.Write("<script>alert('Please Select Certificate Date')</script>");
                return;

            }
            if (Certificte_RecByName == "")
            {
                Response.Write("<script>alert('Please Select Certificate Date')</script>");

                return;

            }

            else
            {
                Response.Write("<script>alert('Record Inserted Successfully!!')</script>");

            }
        }


        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("sp_insetStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AdmissionNo", txtAdissionNo.Text);
            cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
            cmd.Parameters.AddWithValue("@Nationality", txtNationalaity.Text);
            cmd.Parameters.AddWithValue("@MotherTongue", drpLanguage.SelectedValue);
            cmd.Parameters.AddWithValue("@Religion", drpRelegion.SelectedValue);
            cmd.Parameters.AddWithValue("@Caste", drpCast.SelectedValue);
            cmd.Parameters.AddWithValue("@SubCast", drpSubCast.SelectedValue);
            cmd.Parameters.AddWithValue("@BirthPlace", drpBirthPlace.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@DOB_Digit", txtDOB.Text);
            cmd.Parameters.AddWithValue("@DOB_Word", txtDOBW.Text);
            cmd.Parameters.AddWithValue("@PrevSchoolName", txtPrevSchool.Text);
            cmd.Parameters.AddWithValue("@AdmitInClass", txtAdmitClass.Text);
            cmd.Parameters.AddWithValue("@Asmission_Date", txtAdmissionDate.Text);
            cmd.Parameters.AddWithValue("@Progress", txtProgress.Text);
            cmd.Parameters.AddWithValue("@Behaviour", txtBehaviour.Text);
            cmd.Parameters.AddWithValue("@Date_SchoolLeave", txtSchoolLeave.Text);
            cmd.Parameters.AddWithValue("@Class_Left", txtClassLeft.Text);
            cmd.Parameters.AddWithValue("@Reason_SchoolLeave", txtReason.Text);
            cmd.Parameters.AddWithValue("@Certificate_Date", txtCertDate.Text);
            cmd.Parameters.AddWithValue("@Certificte_RecByName", txtCertRecBy.Text);
            userValid();
            con.Open();
            cmd.ExecuteNonQuery();
            BindGrid();
        }


        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtAdissionNo.Text = "";
            txtStudentName.Text = "";
            txtNationalaity.Text = "";
            drpLanguage.Text = "";
            drpRelegion.Text = "";
            drpCast.Text = "";
            drpSubCast.Text = "";
            drpBirthPlace.Text = "";
            txtDOB.Text = "";
            txtDOBW.Text = "";
            txtPrevSchool.Text = "";
            txtAdmitClass.Text = "";
            txtAdmissionDate.Text = "";
            txtProgress.Text = "";
            txtBehaviour.Text = "";
            txtSchoolLeave.Text = "";
            txtBehaviour.Text = "";
            txtClassLeft.Text = "";
            txtReason.Text = "";
            txtCertDate.Text = "";
            txtCertRecBy.Text = "";
            txtSearch.Text = "";
        }

        protected void btnLeavingCer_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            int sid = Convert.ToInt32(txtSearch.Text);
            ds = GetData1(sid);

            if (ds != null)
            {
                Panel pnlPrintControl = new Panel();
                Document doc = new Document(PageSize.A4, 36f, 36f, 36f, 36f);//36f, 36f, 90f, 100f);
                PdfWriter.GetInstance(doc, Response.OutputStream);
                doc.Open();
                #region --Header
                string imagePath = Server.MapPath("Images") + "\\logo.jpg";
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
                image.Alignment = Element.ALIGN_LEFT;

                image.ScaleToFit(80f, 50f);
                doc.Add(image);
                Paragraph title = new Paragraph();

                title.Add(new Chunk("Rajashri Foundation", new Font(Font.FontFamily.COURIER, 10, 1, BaseColor.GREEN)));
                title.Alignment = 1;
                doc.Add(title);

                Paragraph name = new Paragraph();
                name.Add(new Chunk("Dr. Suvarna English Medium School", new Font(Font.FontFamily.TIMES_ROMAN, 17, 1, BaseColor.RED)));
                name.Alignment = 1;
                doc.Add(name);

                Paragraph address = new Paragraph();
                address.Add(new Chunk(@"Tal- Purandhar,Dist - Pune, Pune - 402301.
Ph. No.- 402152", new Font(Font.FontFamily.COURIER, 10, 1, BaseColor.BLUE)));
                address.Alignment = 1;
                doc.Add(address);

                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------------------- " + "\n"));

                Paragraph lc = new Paragraph();
                lc.Add(new Chunk("Leaving Certificate", new Font(Font.FontFamily.COURIER, 16, 1, BaseColor.BLACK)));
                lc.Alignment = 1;
                doc.Add(lc);
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));
                #endregion

                Paragraph p = new Paragraph("\n" + "ID : " + txtSearch.Text + "       " + "       " + "       " + "Admission No : " + txtAdissionNo.Text + "       " + "       " + "       " + "Student Name : " + txtStudentName.Text);
                doc.Add(p);
                doc.Add(new Paragraph("  "));

                Paragraph p1 = new Paragraph("Nationality : " + txtNationalaity.Text + "       " + "       " + "       " + " Mother Tongue : " + drpLanguage.SelectedItem.Text + "       " + "     " + "Religion : " + drpRelegion.SelectedItem.Text);
                doc.Add(p1);
                doc.Add(new Paragraph("  "));

                Paragraph p2 = new Paragraph("Cast : " + drpCast.SelectedItem.Text + "       " + "       " + "       " + "       " + "Sub Cast : " + drpCast.SelectedItem.Text + "       " + "       " + "       " + "       " + "Birth Place : " + drpBirthPlace.SelectedItem.Text);
                doc.Add(p2);
                doc.Add(new Paragraph("  "));

                Paragraph p3 = new Paragraph("Birth Date In Digit : " + txtDOB.Text + "       " + "       " + "       " + "Birth Date In Word : " + txtDOBW.Text);
                doc.Add(p3);
                doc.Add(new Paragraph("  "));

                Paragraph p4 = new Paragraph("Last School Attended  : " + txtPrevSchool.Text + "       " + "Admit In Class : " + txtAdmitClass.Text);
                doc.Add(p4);
                doc.Add(new Paragraph("  "));

                Paragraph p5 = new Paragraph("Admission Date : " + txtAdmissionDate.Text + "       " + "       " + "       " + "       " + "Progress : " + txtProgress.Text + "       " + "       " + "       " + "       " + "Behaviour : " + txtBehaviour.Text);
                doc.Add(p5);
                doc.Add(new Paragraph("  "));

                Paragraph p6 = new Paragraph("Date Of School Leave  : " + txtSchoolLeave.Text + "       " + "           " + "       " + "       " + "Class Which Left  : " + txtClassLeft.Text);
                doc.Add(p6);
                doc.Add(new Paragraph("  "));


                Paragraph p7 = new Paragraph("Reason for Leaving the School : " + txtReason.Text);
                doc.Add(p7);
                doc.Add(new Paragraph("  "));

                Paragraph p8 = new Paragraph("Certificate Date : " + txtCertDate.Text + "        " + "       " + "         " + "       " + "       " + "Certificate Recieved By : " + txtCertRecBy.Text);
                doc.Add(p8);
                doc.Add(new Paragraph("  "));


                Paragraph p9 = new Paragraph(" Date : ________________________ " + "       " + "       " + "       " + "      " + "Place : ___________________________" + "\n");
                doc.Add(p9);
                doc.Add(new Paragraph("  " + "\n"));


                Paragraph p10 = new Paragraph("\n" + "Clerk Sign : ______________________ " + "       " + "       " + "      " + "Principal Sign : ______________________ " + "\n");
                doc.Add(p10);
                doc.Add(new Paragraph("  "));


                doc.Add(new Paragraph("  "));

                //PDF Footer
                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------------------- " + "\n"));
                Paragraph Note = new Paragraph();
                Note.Add(new Chunk("Note : Illegal Changes in the certificate is Offensive by Law ,@2020", new Font(Font.FontFamily.COURIER, 10, 2, BaseColor.BLACK)));
                Note.Alignment = 1;
                doc.Add(Note);
                doc.Close();
                //string path = Server.MapPath("PDF-File");
                // string fileName = path + "/Doc1.pdf";
                string fileName = "Doc" + " " + ".pdf";

                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;" + "filename=" + fileName);
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Write(doc);
                // ShowPdf(fileName);
                Response.Buffer = true;
                Response.Buffer = true;
                Response.End();

            }
            else
            {
                lblMessage.Text = "PDF file not generated.";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from StudentDB where Id like '" + txtSearch.Text + "%'";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr;
            dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                txtAdissionNo.Text = dr["AdmissionNo"].ToString();
                txtStudentName.Text = dr["StudentName"].ToString();
                txtNationalaity.Text = dr["Nationality"].ToString();
                drpLanguage.Text = dr["MotherTongue"].ToString();
                drpRelegion.Text = dr["Religion"].ToString();
                drpCast.Text = dr["Caste"].ToString();
                drpSubCast.Text = dr["SubCast"].ToString();
                drpBirthPlace.Text = dr["BirthPlace"].ToString();
                txtDOB.Text = dr["DOB_Digit"].ToString();
                txtDOBW.Text = dr["DOB_Word"].ToString();
                txtPrevSchool.Text = dr["PrevSchoolName"].ToString();
                txtAdmitClass.Text = dr["AdmitInClass"].ToString();
                txtAdmissionDate.Text = dr["Asmission_Date"].ToString();
                txtProgress.Text = dr["Progress"].ToString();
                txtBehaviour.Text = dr["Behaviour"].ToString();
                txtSchoolLeave.Text = dr["Date_SchoolLeave"].ToString();
                txtBehaviour.Text = dr["Behaviour"].ToString();
                txtClassLeft.Text = dr["Class_Left"].ToString();
                txtReason.Text = dr["Reason_SchoolLeave"].ToString();
                txtCertDate.Text = dr["Certificate_Date"].ToString();
                txtCertRecBy.Text = dr["Certificte_RecByName"].ToString();
            }
            else
            {
                Response.Write("<script>alert('Data Not Found')</script>");
                // Label2.Text = "The search Term " + txtSearch.Text + " Is Not Available in the Records";
            }

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}