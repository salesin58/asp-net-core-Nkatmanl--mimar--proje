<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="personel.aspx.cs" Inherits="personelasp.personel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>PERSONEL İD </th>
            <th>PERSONEL AD </th>
            <th>PERSONEL SOYAD </th>
            <th>PERSONEL DEPARTMAN </th>
            <th>PERSONEL MAAŞ </th>
            <th>PERSONEL FOTOGRAF </th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("PERSONELID") %></td>
                        <td><%# Eval("PERSONELAD") %></td>
                        <td><%# Eval("PERSONELSOYAD") %></td>
                        <td><%# Eval("PERSONELDEPARTMAN") %></td>
                        <td><%# Eval("PERSONELMAAS") %></td>
                        <td><%# Eval("PERSONELFOTOGRAF") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>
</asp:Content>
