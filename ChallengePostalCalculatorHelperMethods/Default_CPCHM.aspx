<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_CPCHM.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default_CPCHM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:&nbsp;&nbsp;
            <asp:TextBox ID="inputWidthBox" runat="server" AutoPostBack="True" OnTextChanged="InputWidthBox_TextChanged"></asp:TextBox>
            <br />
            Height:&nbsp;
            <asp:TextBox ID="inputHeightBox" runat="server" AutoPostBack="True" OnTextChanged="InputHeightBox_TextChanged"></asp:TextBox>
            <br />
            Length:&nbsp;
            <asp:TextBox ID="inputLengthBox" runat="server" AutoPostBack="True" OnTextChanged="InputLengthBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="radioBtnGround" runat="server" AutoPostBack="True" GroupName="shipMethod" OnCheckedChanged="RadioBtnGround_CheckedChanged" Text="Ground Shipping" />
            <br />
            <asp:RadioButton ID="radioBtnAir" runat="server" AutoPostBack="True" GroupName="shipMethod" OnCheckedChanged="RadioBtnAir_CheckedChanged" Text="Air Shipping" />
            <br />
            <asp:RadioButton ID="radioBtnOvernight" runat="server" AutoPostBack="True" GroupName="shipMethod" OnCheckedChanged="RadioBtnOvernight_CheckedChanged" Text="Next Day Shipping" />
            <br />
            <br />
            <br />
            <asp:Label ID="shipmentTotalOutput" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
