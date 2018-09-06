<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="teste.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- Anotações: todo controle que eu precise tratar no .cs, ele precisa ter um ID e o atributo RUNAT=Server --%>
          <asp:Label runat="server" ID="lblFiltro" Text ="Filtar por Filial: "> </asp:Label> <asp:DropDownList runat="server" ID="ddlFiltro" AutoPostBack="true" OnSelectedIndexChanged="ddlFiltro_SelectedIndexChanged1">
               
           </asp:DropDownList>
            <hr />
            <asp:GridView runat="server" ID="gvDados" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Nome" DataField="vc_func_nome" />
                    <asp:BoundField HeaderText="Funcional" DataField="vc_func_funcional" />
                    <asp:BoundField HeaderText="Filial" DataField="vc_func_filial" />

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
