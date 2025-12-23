<%@ Page Language="C#" CodeBehind="Default.aspx.cs" Inherits="_Default" %>

<html>
<head>
    <title>Vessel List</title>
</head>
<body>
    <h1>Vessel List</h1>
    <form id="form1" runat="server">
        <asp:GridView ID="gvVessels" runat="server" AutoGenerateColumns="true" />
    </form>
    <script type="text/javascript">
        console.log('Hello, World!');
    </script>
</body>
</html>
