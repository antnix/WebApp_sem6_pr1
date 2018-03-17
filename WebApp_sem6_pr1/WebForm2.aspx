<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApp_sem6_pr1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-right: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<p>
    <asp:GridView ID="gwMainTable" runat="server" Width="457px" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2" AllowPaging="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
            <asp:BoundField DataField="Nr_albomu" HeaderText="Nr_albomu" SortExpression="Nr_albomu" />
            <asp:BoundField DataField="Number" HeaderText="Number" SortExpression="Number" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Student.Id, Student.Name, Student.Surname, Student.Nr_albomu, Phones.Number FROM Phones RIGHT OUTER JOIN Student ON Phones.Id_person = Student.Id"></asp:SqlDataSource>
    <table class="auto-style1">
        <tr>
            <td> <h3>Add new data:</h3></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
             <asp:TextBox ID="tbName1" runat="server" placeholder="Imie"></asp:TextBox>
            </td>
            <td>
            <asp:TextBox ID="tbName2" runat="server" placeholder="Nazwisko" CssClass="auto-style2"></asp:TextBox>
            </td>
            <td>
            <asp:TextBox ID="tbId" runat="server" placeholder="Nr indeksu"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="tbPhoneNumber1" runat="server" placeholder="Telefon" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:CheckBox ID="cbPhoneNumber1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Telefon 1" />
            </td>
            <td>
                <asp:TextBox ID="tbPhoneNumber2" runat="server" placeholder="Telefon" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:CheckBox ID="cbPhoneNumber2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Telefon 2" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="160px" />
            </td>
        </tr>
    </table>
</p>
</asp:Content>
