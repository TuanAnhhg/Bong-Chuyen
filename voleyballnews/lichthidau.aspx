<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="lichthidau.aspx.cs" Inherits="voleyballnews.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Lịch Thi đấu bóng chuyền nam</h2>
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/image/fd4977172cb1caef93a013112019104719.jpg" />
    </p>
    <h3>Lịch Thi đấu bóng chuyền nữ </h3>
    <p>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/image/lich-thi-dau-sea-games-30-hom-nay-8-12.jpg" />
    </p>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
