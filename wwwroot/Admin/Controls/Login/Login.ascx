<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Admin.Admin.Controls.Login.Login" %>
  <div class="Login_Div MarginCenter">
        <div class="Login_Header"></div>
            <div class="Login_Body MarginCenter">
                <asp:Login ID="LoginControl" runat="server" BackColor="#f6f6f6" 
                    BorderColor="#c0c0c0" BorderPadding="4"
                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
                    ForeColor="#333333" OnAuthenticate="Login_Authenticate" Width="250">
                    <TitleTextStyle BackColor="#666666" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <LoginButtonStyle BackColor="#f3f3f3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                        Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                </asp:Login>
            </div>
</div>
<div class="Login_Footer MarginCenter">&copy; All Rights Reserved, Kout Food Group</div>