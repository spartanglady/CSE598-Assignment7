<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt._Default" %>
     
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Assignment 7 TryIt Site</h1>
    <div class="jumbotron">
        <h2>XML Validation Using XSD Schema</h2>
        <p>A Service That Validates the Xml Against an XML Schema</p>
        <p>Input: XSD and XML Url String | Output: String</p>
        <p>Sample XML Files can be Found in the service (svc) Project Under XML Folder. When the webservice is running you can get the localhost url. Example: http://localhost:58524/Xml/Computers.xml </p>
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="true" Font-Size="Medium">Enter XML URL: -></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />


        
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="true" Font-Size="Medium">Enter XSD URL: -></asp:Label>

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>


        
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"  />



        
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="281px" Width="555px"></asp:ListBox>



        
    </div>

    <div class="jumbotron">
                <h2>XML Search Using TagName</h2>
        <p>A Service That returns the node Value or the InnerText of a given TagName</p>
        <p>Input: XML Url and Tag Name | Output: List of String</p>
        <asp:Label ID="Label3" runat="server" Text="Label" Font-Bold="true" Font-Size="Medium">Enter XML URL: -></asp:Label>

                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>


        <br />





                <br />
                <asp:Label ID="Label4" runat="server" Text="Label" Font-Bold="true" Font-Size="Medium">Enter Tag Name: -></asp:Label>





                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />





                <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />





                <br />
                <br />
                <asp:ListBox ID="ListBox2" runat="server" Height="240px" Width="1647px"></asp:ListBox>





        </div>

    

</asp:Content>
