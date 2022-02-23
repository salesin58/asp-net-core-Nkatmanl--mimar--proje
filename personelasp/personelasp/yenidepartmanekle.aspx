<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="yenidepartmanekle.aspx.cs" Inherits="personelasp.yenidepartmanekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <form runat="server" class="form-group">
       <div>
           <asp:Label ID="Label1" runat="server" Text="Departman Adı" Font-Bold="true"></asp:Label>
           <br />   
           <br />
           <asp:TextBox  ID="TextBox1" runat="server"  CssClass="form-control"></asp:TextBox>
       </div>
       <div>
           <asp:Button ID="Button1" runat="server" Text="departmanı kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />
       </div>
   </form>
</asp:Content>
