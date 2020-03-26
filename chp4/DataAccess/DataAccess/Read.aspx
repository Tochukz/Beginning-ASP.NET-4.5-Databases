<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="DataAccess.Read" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Read Operation</title>
      <style type="text/css">
        .error {
            color: red;
        }
        .border {
            border: solid silver 1px;
        }
        .table {
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employees</h2>
            <table id="employeeTable" runat="server" border="1" class="table">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Gender</th>
                        <th>City</th>
                        <th>Salary</th>
                    </tr>
                </thead>
            </table>
        </div>
        <div id="errorDiv" runat="server" class="error"></div>
    </form>
</body>
</html>
