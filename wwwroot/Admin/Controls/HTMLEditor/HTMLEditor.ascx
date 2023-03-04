<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HTMLEditor.ascx.cs" Inherits="Admin.Admin.Controls.Editor.HTMLEditor" %>
<%@ Register TagPrefix="editor" Assembly="WYSIWYGEditor" namespace="InnovaStudio" %>
    <editor:WYSIWYGEditor ID="BodyEditor" runat="server" 
        btnHTMLFullSource="True" btnLTR="True" btnRTL="True" UseTab="False" 
        btnClearAll="True">
    </editor:WYSIWYGEditor>