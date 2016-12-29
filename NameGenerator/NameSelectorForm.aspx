<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NameSelectorForm.aspx.cs" Inherits="NameGenerator.NameSelectorForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="vertical-align: 85%; text-align: center; position: relative; line-height: normal; font-size: x-large;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Resources/1408449211_pen-name.gif" />
            Добро пожаловать на сайт, который позволит вам сгенерить китайское имя.<asp:Image ID="Image2" runat="server" ImageUrl="~/Resources/1408449211_pen-name.gif" />
            <br />
            <hr />
        </div>
        <div id="SetOptions" runat="server">
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Обновить" />
        </div>
        <div id="DisplayResults" runat="server">
            <asp:GridView ID="grid" runat="server" AutoGenerateColumns="false" HorizontalAlign="Center">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="№" />
                    <asp:BoundField DataField="eng_name" HeaderText="Пиньинь" />
                    <asp:BoundField DataField="rus_name" HeaderText="Кириллица" />
                    <asp:BoundField DataField="date_of_birth" HeaderText="Дата сохранения" />
                    <asp:BoundField DataField="comment" HeaderText="Комментарий" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
