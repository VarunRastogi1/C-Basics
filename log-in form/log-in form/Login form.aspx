<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login form.aspx.cs" Inherits="log_in_form.Login_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            USER NAME&nbsp;
            <asp:TextBox ID="UserTextBox" runat="server" Height="31px" Width="402px"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserTextBox" Display="Dynamic" ErrorMessage="Please Enter Username" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;
        </div>
        PASSWORD&nbsp;&nbsp;
        <asp:TextBox ID="PassTextBox2" runat="server" Height="31px" Width="402px"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PassTextBox2" Display="Dynamic" ErrorMessage="Please Enter Password" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="LogInButton" runat="server" OnClick="Button1_Click" Text="LOG IN" Width="208px" />
        </p>
    </form>
</body>
</html>
