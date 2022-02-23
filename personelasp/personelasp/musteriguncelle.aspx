<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="musteriguncelle.aspx.cs" Inherits="personelasp.musteriguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <form runat="server" class="form-group">
           <div>
           <asp:Label ID="Label3" runat="server" Text="musteri ıd" Font-Bold="true"></asp:Label>
          
               <asp:TextBox placeholder="musteri ıd" ID="TextBox3" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
       </div>
       <div>
           <asp:Label ID="Label1" runat="server" Text="musteri Adı" Font-Bold="true"></asp:Label>
          
           <asp:TextBox placeholder="musteri adı" ID="TextBox1" runat="server"  CssClass="form-control"></asp:TextBox>
       </div>
         <br />
         <div>
             <asp:Label ID="Label2" runat="server" Text="musteri soyad" Font-Bold="true"></asp:Label>
               <asp:TextBox placeholder="musteri soyad" ID="TextBox2" runat="server"  CssClass="form-control"></asp:TextBox>
         </div>
         <br />
       <div>
           <asp:Button ID="Button1" runat="server" Text="Müşteri guncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
       </div>
   </form>
</asp:Content>
