<%@ Page Language="C#" AutoEventWireup="true" Theme="AdminSkin" Inherits="ControlPanel_MediaUpload" Codebehind="MediaUpload.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
.BodyDiv
{
	margin: 0px;
	background:#fff;
}

.FloatLeft
{
    float:left;
}

a
{
	text-decoration:none;
}
    </style>
</head>
<body class="BodyDiv">
    <form id="form1" runat="server">
    <asp:DropDownList ID="FolderDropDownList" runat="server" AutoPostBack="True" 
        onselectedindexchanged="FolderDropDownList_SelectedIndexChanged">
                   </asp:DropDownList>
    <br />
    <br />
    <asp:DropDownList ID="FileDropDownList" runat="server" AutoPostBack="True" 
        onselectedindexchanged="FileDropDownList_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <br />
    <div class = "FloatLeft">
    <asp:TextBox ID="NewFolderTextBox" runat="server" 
        Width="140px"></asp:TextBox>
        </div>
        <div class = "FloatLeft">
    <asp:Button ID="NewFolderButton" runat="server"  
        onclick="NewFolderButton_Click" Text="Create" Width="60px" />
        </div>
    <asp:Label ID="FolderStatusLable" runat="server" Font-Size="7pt" 
        Visible="False"></asp:Label>
    <br />
    <div>
     <asp:Panel ID="OriginalPanel" runat="server">
                   <div class="FloatLeft"> <asp:Label ID="MediaLabel" runat="server"></asp:Label></div>
                   
                 <br class="ClearBoth" />
                    <asp:LinkButton ID="NewLinkButton" runat="server" 
                        onclick="UploadNewLinkButton_Click">New Media</asp:LinkButton>
                </asp:Panel>
                <asp:Panel ID="NewPanel" runat="server" Visible="False" >
                    <input ID="FileImage" runat="server" style="width: 450px" type="file" 
                        /><table cellpadding="0" cellspacing="0" style="width: 100px">
                        <tr>
                            <td>
                                <asp:LinkButton ID="UploadLinkButton" runat="server" 
                                    onclick="UploadLinkButton_Click">Upload</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="CencelLinkButton" runat="server" 
                                    onclick="CencelLinkButton_Click">Cancel</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                
    </div>
   
    </form>
</body>
</html>
