﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="personelasp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>DEPARTMAN ID</th>
            <th>DEPARTMAN ADI</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                       <td> <%# Eval("DEPARTMANID") %></td>
                         <td> <%# Eval("DEPARTMANAD") %></td>
                        

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="yenidepartmanekle.aspx" class="btn btn-info" >yeni departman ekle</a>
</asp:Content>
