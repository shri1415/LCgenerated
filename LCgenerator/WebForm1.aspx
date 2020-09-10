<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LCgenerator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" />
    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/jquery-3.3.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="Content/dataTables.bootstrap4.min.css" rel="stylesheet" />
    <script src="scripts/dataTables.bootstrap4.min.js"></script>
    <script src="scripts/jquery.dataTables.min.js"></script>

    <style>
        #out {
            border: 1px solid black;
            outline: #808080 solid 10px;
            margin: auto;
            padding: 2px;
            text-align: center;
        }

        .btnMargin {
            margin-bottom: 5px !important;
        }

        #blank {
            width: 70px;
            /*background-color:blue;*/
        }

        td {
            padding-right: 10px;
            padding-bottom: 5px;
            /*background-color:red;*/
        }

        #txtSearch {
            /*width: 100%;
            box-sizing: border-box;
            border: 2px solid #ccc;
            border-radius: 4px;
            font-size: 14px;
            background-color: white;
            padding: 5px 3px 3px 5px;*/
            border: 2px solid #ccc;
            color: black;
            padding: 10px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            margin: 2px 2px;
            cursor: pointer;
        }

        .button {
            background-color: #007bff;
            border: none;
            color: white;
            padding: 12px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            margin: 2px 2px;
            cursor: pointer;
            transition-duration: 0.4s;
        }

            .button:hover {
                background-color: #ccc;
                color: blue;
            }
    </style>
</head>
<body>
    <form id="form1" class="form-inline" runat="server">
        <%--<div id="out">--%>
        <div class="container">
            <div class="jumbotron">
                <h1 style="text-align: center; text-transform: uppercase; color: #9b0c0c;">Student Information</h1>
                <br />
                <%--<div style="margin-left:610px;">--%>
                <div>
                    <b style="margin-left: 590px; margin-right: 40px;">Search : </b>
                    <asp:TextBox ID="txtSearch" runat="server" placeholder="Search...."></asp:TextBox>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="button" />
                </div>


                <div></div>

                <table>
                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lAdmissionNo" runat="server" Text="Admission Number" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox class="form-control" ID="txtAdissionNo" runat="server" Width="350px" /></td>
                        &nbsp;
                        <td>
                            <asp:Label ID="lStudentName" runat="server" Text="Student Name" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox class="form-control" ID="txtStudentName" runat="server" Width="350px" /></td>
                    </tr>

                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lblNationality" runat="server" Text="Nationality" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox class="form-control" ID="txtNationalaity" runat="server" Width="350px" /></td>
                        <td>
                            <asp:Label ID="lblMotherTong" runat="server" Text="Mother Tongue" Width="150px"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="drpLanguage" CssClass="form-control" runat="server">
                                <asp:ListItem Text="Marathi" Value="1"></asp:ListItem>
                                <asp:ListItem Text="English" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Hindhi" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Bengali" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Urdu" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Marwari" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Pnjabi" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Telgu" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Kannada" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Other" Value="4"></asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>



                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lblRelegion" runat="server" Text="Religion" Width="150px"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="drpRelegion" CssClass="form-control" runat="server">
                                <asp:ListItem Text="Hindu" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Islam" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Buddhism" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Jain" Value="4"></asp:ListItem>
                                <asp:ListItem Text="Spiritual" Value="5"></asp:ListItem>
                                <asp:ListItem Text="Jewish" Value="6"></asp:ListItem>
                                <asp:ListItem Text="Muslim" Value="7"></asp:ListItem>
                                <asp:ListItem Text="Christain" Value="8"></asp:ListItem>
                                <asp:ListItem Text="Sikh" Value="9"></asp:ListItem>
                                <asp:ListItem Text="Other" Value="10"></asp:ListItem>
                            </asp:DropDownList></td>
                        <td></td>
                        <td>
                            <asp:Label ID="lblCast" runat="server" Text="Cast" Width=""></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="drpCast" CssClass="form-control" runat="server">
                                <asp:ListItem>Maratha</asp:ListItem>
                                <asp:ListItem>OBC</asp:ListItem>
                                <asp:ListItem>Other</asp:ListItem>
                            </asp:DropDownList></td>
                        <td id="blank"></td>
                        <td>
                            <asp:Label ID="lblSubCast" runat="server" Text="Sub Cast" Width="140px"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="drpSubCast" CssClass="form-control" runat="server">
                                <asp:ListItem Text="Maratha" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Kunbi" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Other" Value="3"></asp:ListItem>
                            </asp:DropDownList></td>

                        <td>
                            <asp:Label ID="lblBirthPlace" runat="server" Text="Birth Place" Width="80px"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="drpBirthPlace" CssClass="form-control" runat="server">
                                <asp:ListItem Text="Pune" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Mumbai" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Kerala" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Jammu" Value="4"></asp:ListItem>
                                <asp:ListItem Text="Punjab" Value="5"></asp:ListItem>
                                <asp:ListItem Text="Up" Value="6"></asp:ListItem>
                                <asp:ListItem Text="Mp" Value="7"></asp:ListItem>
                                <asp:ListItem Text="Thane" Value="8"></asp:ListItem>
                                <asp:ListItem Text="Sangli" Value="9"></asp:ListItem>
                                <asp:ListItem Text="Other" Value="10"></asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>


                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lbldob" runat="server" Text="Birth Date" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox TextMode="Date" ID="txtDOB" runat="server" Width="350px"></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblDobINword" runat="server" Text="Birth Date in Word" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtDOBW" runat="server" Width="350px"></asp:TextBox></td>
                    </tr>

                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lblPrevSchool" runat="server" Text="Previous School" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtPrevSchool" runat="server" Width="350px"></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblAdmitClass" runat="server" Text="Admit For class" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtAdmitClass" runat="server" Width="350px"></asp:TextBox></td>
                        <%-- <asp:DropDownList ID="drpAdmit Class" CssClass="form-control" runat="server">
                        <asp:ListItem Text="Fisrt" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Second" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Third" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Fourth" Value="4"></asp:ListItem>
                        <asp:ListItem Text="Fifth" Value="5"></asp:ListItem>
                        <asp:ListItem Text="Sixth" Value="6"></asp:ListItem>
                        <asp:ListItem Text="Seventh" Value="7"></asp:ListItem>
                        <asp:ListItem Text="Eight" Value="8"></asp:ListItem>
                        <asp:ListItem Text="Ninth" Value="9"></asp:ListItem>
                        <asp:ListItem Text="Tenth" Value="10"></asp:ListItem>
                    </asp:DropDownList>--%>
                    </tr>

                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lblAdmissionDate" runat="server" Text="Admission Date" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtAdmissionDate" TextMode="Date" runat="server" Width="350px"></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblProgress" runat="server" Text="Progress" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtProgress" runat="server" Width="350px"></asp:TextBox></td>
                    </tr>

                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lblBehaiour" runat="server" Text="Behaviour" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtBehaviour" runat="server" Width="350px"></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblSchoolLeaveDate" runat="server" Text="Date of School Leave" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtSchoolLeave" TextMode="Date" runat="server" Width="350px"></asp:TextBox></td>
                    </tr>

                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lblClassLeft" runat="server" Text="Class Left" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtClassLeft" runat="server" Width="350px"></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblReason" runat="server" Text="Reason of School Leave" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtReason" runat="server" Width="350px"></asp:TextBox></td>
                    </tr>

                    <tr class="form-group">
                        <td>
                            <asp:Label ID="lblCertificateDate" runat="server" Text="Certificate Date" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtCertDate" TextMode="Date" runat="server" Width="350px"></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblCertificateBy" runat="server" Text="Certificate ReievedBy" Width="150px"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtCertRecBy" runat="server" Width="350px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                </table>
                <div style="padding-top: 10px; align-items: center; margin-left: 300px;">
                    <asp:Button ID="btnAddStudent" Text="Add Student" class="btn btn-primary" runat="server" OnClick="btnAddStudent_Click" />
                    <asp:Button ID="btnClear" Text="Clear" class="btn btn-primary" runat="server" OnClick="btnClear_Click" />
                    <asp:Button ID="btnLeavingCer" Text="Generate Leaving Certificate" class="btn btn-primary" runat="server" OnClick="btnLeavingCer_Click" />
                </div>


            </div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="3px" CellPadding="4" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#e8eaf6" ForeColor="#003399" BorderStyle="Solid" BorderWidth="2px" BorderColor="#CCCCCC" />
                <HeaderStyle BackColor="#e8eaf6" BorderWidth="3px" Font-Bold="True" ForeColor="Black" BorderStyle="Solid" Height="10px" />
                <PagerStyle BackColor="#e8eaf6" ForeColor="#003399" HorizontalAlign="Center" BorderStyle="Solid" BorderWidth="3px" />
                <RowStyle BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
        </div>

        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        <%--</div>--%>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </form>
    <div style="height: 20px; text-align: right;"><h4>@2020</h4></div>
</body>
</html>

