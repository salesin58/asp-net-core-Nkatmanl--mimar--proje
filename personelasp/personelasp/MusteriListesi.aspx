<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="MusteriListesi.aspx.cs" Inherits="personelasp.MusteriListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>MÜŞTERİ İD </th>
            <th>MÜŞTERİ AD </th>
            <th>MÜŞTERİ SOYAD </th>
            <th>SİL </th>
            <th>GÜNCELLE </th>


        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("MUSTERIID") %></td>
                        <td><%# Eval("MUSTERIAD") %></td>
                        <td><%# Eval("MUSTERISOYAD") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "~/musterisil.aspx?MUSTERIID=" + Eval("MUSTERIID")%>'>Sil</asp:HyperLink></td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "~/musteriguncelle.aspx?MUSTERIID=" + Eval("MUSTERIID")%>'>Güncelle</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>

            </asp:Repeater>

        </tbody>
    </table>
    <a href="musteriekle.aspx" class="btn btn-info">musteri ekle</a>
</asp:Content>
