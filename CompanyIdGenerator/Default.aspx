<%@Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" CodeFile="Default.aspx.cs" Inherits="CompanyIdGenerator.Default" Language="C#" %>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
                <asp:TextBox ID="codeBox" runat="server" ReadOnly="True" Width="205px"></asp:TextBox>
            <p>
                <asp:RadioButton ID="sweCompany" runat="server" Text="SWE Company" GroupName = "radio" />
            </p>
                <asp:RadioButton ID="sweTax" runat="server" Text="SWE Tax" GroupName = "radio" />
            <p>
                <asp:RadioButton ID="finCompany" runat="server" Text="FIN Company" GroupName = "radio" />
            </p>
                <asp:RadioButton ID="finTax" runat="server" Text="FIN Tax" GroupName = "radio" />
            <p>
                <asp:Button ID="genCode" runat="server" Text="Generate Code" Width="205px" OnClick="btnGenerate_Click"/>
            </p>
        </form>
    </body>
</html>