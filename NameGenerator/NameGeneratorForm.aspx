<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NameGeneratorForm.aspx.cs" Inherits="NameGenerator.NameGeneratorForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="vertical-align: 85%; text-align: center; position: relative; line-height: normal; font-size: x-large;">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Resources/1408449211_pen-name.gif" />
    
        Добро пожаловать на сайт, который позволит вам сгенерить китайское имя.<asp:Image ID="Image2" runat="server" ImageUrl="~/Resources/1408449211_pen-name.gif" />
        <br />
        <hr />
        Происхождение&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Слогов в фамилии&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Слогов в имени<br />
        <br />
        <asp:ListBox ID="lstType" runat="server" Rows="3">
            <asp:ListItem Value="chi">Китайское</asp:ListItem>
            <asp:ListItem Value="can">Кантонское</asp:ListItem>
            <asp:ListItem Selected="True">random</asp:ListItem>
        </asp:ListBox>
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
        <asp:ListBox ID="lstFam" runat="server" Rows="3">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem Selected="True" Value="0">random</asp:ListItem>
        </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstName" runat="server" Rows="3">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem Selected="True" Value="0">random</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:TextBox ID="txtEng" runat="server" Width="154px"></asp:TextBox>
        &nbsp;
        <asp:TextBox ID="txtRus" runat="server" Width="154px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Сгенерить имя" BorderColor="#669999" BorderStyle="Solid" />
    
    </div>
        <br /><div style="vertical-align: 85%; text-align: center; position: relative; line-height: normal; font-size: x-large;">
        Комментарий:<br />
        
        <asp:TextBox ID="txtComment" runat="server" Height="91px" Rows="5" TextMode="MultiLine" Width="505px"></asp:TextBox><br />
<asp:Button ID="Button2" runat="server" BorderColor="#669999" BorderStyle="Solid" OnClick="Button2_Click" Text="Сохранить имя" Width="147px" />
            <br /><br /><asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Показать сохранённые имена" />
</div>
    </form>
</body>
</html>
