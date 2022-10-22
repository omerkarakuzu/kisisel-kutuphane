<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Kutuphane.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Create a new book</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <div class="form-horizontal">
         <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Name" CssClass="col-md-2 control-label">Kitap İsmi</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Name" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Name"
                    CssClass="text-danger" ErrorMessage="Name is Required." />
            </div>
        </div>
                        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Author" CssClass="col-md-2 control-label">Yazarı</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Author" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Author"
                    CssClass="text-danger" ErrorMessage="Author is Required." />
            </div>
        </div>
                                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Link" CssClass="col-md-2 control-label">Kitap Linki</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Link" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Link"
                    CssClass="text-danger" ErrorMessage="Link is Required." />
            </div>
        </div>
                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Category" CssClass="col-md-2 control-label">Kategori</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList runat="server" ID="Category" CssClass="form-control" AppendDataBoundItems="true" >
                    <asp:ListItem Selected="True" Value="0">Seçiniz</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Category" InitialValue="0"
                    CssClass="text-danger" ErrorMessage="Category Date is Required" />
            </div>
        </div>
                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Read" CssClass="col-md-2 control-label">Okundu Bilgisi</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList runat="server" ID="Read" CssClass="form-control" AppendDataBoundItems="true" >
                    <asp:ListItem Selected="True" Value="0">Seçiniz</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Read" InitialValue="0"
                    CssClass="text-danger" ErrorMessage="Read Date is Required" />
            </div>
        </div>
                <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateBook_Click" Text="Create Book" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
