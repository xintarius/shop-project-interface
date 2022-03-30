<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="interfejspro.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 110px;
        }
        .auto-style2 {
            width: 74%;
            height: 600px;
            left: 376px;
            top: 158px;
            float: left;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style ="background-color:dimgrey;">
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" style="float:right;" AutoGenerateRows="False" DataKeyNames="sprzet_ID" DataSourceID="SqlDataSource2" DefaultMode="Insert" OnPageIndexChanging="DetailsView1_PageIndexChanging1">
            <Fields>
                <asp:BoundField DataField="Nazwa" HeaderText="Nazwa" SortExpression="Nazwa" />
                <asp:BoundField DataField="Cena" HeaderText="Cena" SortExpression="Cena" />
                <asp:TemplateField HeaderText="Zdjęcie">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Zdjęcie") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:FileUpload ID="FileUpload1" filebytes='<%# Bind("Zdjęcie") %>' runat="server" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Zdjęcie") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField CancelText="" InsertText="Dodaj Produkt" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
            
            
            
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left:1000px;margin-top:75px;height:25px;"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Szukaj" />
            <asp:DropDownList ID="DropDownList1" runat="server" style ="margin-top:-30px;height:30px;" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="0">Wyświetlane po</asp:ListItem>
                <asp:ListItem Value="1">1 Element</asp:ListItem>
                <asp:ListItem Value="2">2 Elementy</asp:ListItem>
                <asp:ListItem Value="3">3 Elementy</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" style ="height:30px;" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="0">Filtr</asp:ListItem>
                <asp:ListItem Value="1">Cena-rosnąco</asp:ListItem>
                <asp:ListItem Value="2">Cena-malejąco</asp:ListItem>
                <asp:ListItem Value="3">Od A do Z</asp:ListItem>
                <asp:ListItem Value="4">Od Z do A</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:interfejs1ConnectionString %>" DeleteCommand="DELETE FROM [Sprzet] WHERE [sprzet_ID] = @original_sprzet_ID AND [Nazwa] = @original_Nazwa AND (([Cena] = @original_Cena) OR ([Cena] IS NULL AND @original_Cena IS NULL)) AND (([Zdjęcie] = @original_Zdjęcie) OR ([Zdjęcie] IS NULL AND @original_Zdjęcie IS NULL))" InsertCommand="INSERT INTO [Sprzet] ([Nazwa], [Cena], [Zdjęcie]) VALUES (@Nazwa, @Cena, @Zdjęcie)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Sprzet]" UpdateCommand="UPDATE [Sprzet] SET [Nazwa] = @Nazwa, [Cena] = @Cena, [Zdjęcie] = @Zdjęcie WHERE [sprzet_ID] = @original_sprzet_ID AND [Nazwa] = @original_Nazwa AND (([Cena] = @original_Cena) OR ([Cena] IS NULL AND @original_Cena IS NULL)) AND (([Zdjęcie] = @original_Zdjęcie) OR ([Zdjęcie] IS NULL AND @original_Zdjęcie IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_sprzet_ID" Type="Int32" />
                    <asp:Parameter Name="original_Nazwa" Type="String" />
                    <asp:Parameter Name="original_Cena" Type="Decimal" />
                    <asp:Parameter Name="original_Zdjęcie" Type="Object" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Nazwa" Type="String" />
                    <asp:Parameter Name="Cena" Type="Decimal" />
                    <asp:Parameter Name="Zdjęcie" Type="Object" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Nazwa" Type="String" />
                    <asp:Parameter Name="Cena" Type="Decimal" />
                    <asp:Parameter Name="Zdjęcie" Type="Object" />
                    <asp:Parameter Name="original_sprzet_ID" Type="Int32" />
                    <asp:Parameter Name="original_Nazwa" Type="String" />
                    <asp:Parameter Name="original_Cena" Type="Decimal" />
                    <asp:Parameter Name="original_Zdjęcie" Type="Object" />
                </UpdateParameters>
            </asp:SqlDataSource>
            
            
            
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:interfejs1ConnectionString2 %>" DeleteCommand="DELETE FROM [Sprzet] WHERE [sprzet_ID] = @original_sprzet_ID AND [Nazwa] = @original_Nazwa AND (([Cena] = @original_Cena) OR ([Cena] IS NULL AND @original_Cena IS NULL)) AND (([Zdjęcie] = @original_Zdjęcie) OR ([Zdjęcie] IS NULL AND @original_Zdjęcie IS NULL))" InsertCommand="INSERT INTO [Sprzet] ([Nazwa], [Cena], [Zdjęcie]) VALUES (@Nazwa, @Cena, @Zdjęcie)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Sprzet]" UpdateCommand="UPDATE [Sprzet] SET [Nazwa] = @Nazwa, [Cena] = @Cena, [Zdjęcie] = @Zdjęcie WHERE [sprzet_ID] = @original_sprzet_ID AND [Nazwa] = @original_Nazwa AND (([Cena] = @original_Cena) OR ([Cena] IS NULL AND @original_Cena IS NULL)) AND (([Zdjęcie] = @original_Zdjęcie) OR ([Zdjęcie] IS NULL AND @original_Zdjęcie IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_sprzet_ID" Type="Int32" />
                <asp:Parameter Name="original_Nazwa" Type="String" />
                <asp:Parameter Name="original_Cena" Type="Decimal" />
                <asp:Parameter Name="original_Zdjęcie" Type="Object" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nazwa" Type="String" />
                <asp:Parameter Name="Cena" Type="Decimal" />
                <asp:Parameter Name="Zdjęcie" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nazwa" Type="String" />
                <asp:Parameter Name="Cena" Type="Decimal" />
                <asp:Parameter Name="Zdjęcie" />
                <asp:Parameter Name="original_sprzet_ID" Type="Int32" />
                <asp:Parameter Name="original_Nazwa" Type="String" />
                <asp:Parameter Name="original_Cena" Type="Decimal" />
                <asp:Parameter Name="original_Zdjęcie" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <div id ="lewybok" style ="background-color:#B8741A;width:25%;height:700px;float:left;">

            <asp:DropDownList ID="DropDownList3" runat="server" style ="float:left;margin-top:100px;margin-left:60px;width:250px;height:30px;" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                <asp:ListItem Value="0">Telewizory</asp:ListItem>
                <asp:ListItem Value="1">Odtwarzacze</asp:ListItem>
                <asp:ListItem Value="2">Projektory</asp:ListItem>
                <asp:ListItem Value="3">Drobny sprzęt RTV</asp:ListItem>
            </asp:DropDownList>

            <asp:DropDownList ID="DropDownList4" runat="server" style="margin-top:50px;float:left;margin-left:-250px;width:250px;height:30px;" AutoPostBack="True" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                <asp:ListItem Value="0">Komputery</asp:ListItem>
                <asp:ListItem Value="1">Laptopy</asp:ListItem>
                <asp:ListItem Value="2">Tablety</asp:ListItem>
                <asp:ListItem Value="3">Serwery</asp:ListItem>
            </asp:DropDownList>

            
            <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" style="height: 30px;float:left;margin-top:25px;margin-left:60px;width:250px;">
                <asp:ListItem Value="0">Podzespoły Komputerowe</asp:ListItem>
                <asp:ListItem Value="1">Płyty główne</asp:ListItem>
                <asp:ListItem Value="2">Karty Graficzne</asp:ListItem>
                <asp:ListItem Value="4">Procesory</asp:ListItem>
            </asp:DropDownList>

            <asp:DropDownList ID="DropDownList6" runat="server" style ="width:250px;margin-left:60px;height:30px;margin-top:25px;" AutoPostBack="True" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged">
                <asp:ListItem Value="0">AGD</asp:ListItem>
                <asp:ListItem Value="1">Lodówki</asp:ListItem>
                <asp:ListItem Value="2">Pralki</asp:ListItem>
                <asp:ListItem Value="3">Zmywarki</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div id ="prawybok" style ="width:75%;margin-left:25%;height:700px;">
             <asp:Label ID="Label4" runat="server" CssClass="auto-style19" Text="Polecane produkty" style ="float:left;"></asp:Label>
            
              <asp:Image ID="Image1" runat="server" Height="107px" ImageUrl="~/Images/Telewizor2.jpg" Width="153px" style ="position:absolute;float:left;margin-top:50px;" />
           <asp:Label ID="Label6" runat="server" CssClass="auto-style25" Font-Size="15px" Text="Opis Produktu:" style ="float:right;margin-top:30px;margin-right:695px;"></asp:Label>
            <asp:Label ID="Label5" runat="server" CssClass="auto-style24" Font-Size="15px" Text="       Telewizor SONY LED KD-55XH9096BAEP             " style ="margin-top:50px;float:right;"></asp:Label>
            <asp:Label ID="Label7" runat="server" style ="margin-right:700px;float:right;" CssClass="auto-style26" Font-Size="12px" Text="Ekran 65&quot;, UHD/4K, 3840 x 2160px &lt;br&gt; Smart TV : Tak &lt;br&gt; Android TV Nie &lt;br&gt; Dla graczy: Tak &lt;br&gt; Częstotliwość odświeżania ekranu 120 Hz &lt;br&gt; Technologia HDR(High Dynamic Range): Tak &lt;br&gt; Złącza HDMI x4, USB x3 Funkcje Wi-Fi, Bluetooth, Nagrywanie na USB &lt;br&gt; Kolor obudowy: Czarny"></asp:Label>
            <asp:Label ID="Label15" runat="server" CssClass="auto-style43" Font-Size="20px" Text="3000zł" style="margin-left:1100px;margin-top:-100px;float:left;"></asp:Label>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Laptop1.jpg" Width="133px" style ="margin-top:80px;height:100px;float:left;margin-left:150px;" />
            <asp:Label ID="Label10" runat="server" CssClass="auto-style38" Font-Size="15px" Text="Opis produktu:" style ="float:right;margin-top:50px;margin-right:690px;"></asp:Label>
             <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:interfejs1ConnectionString7 %>" SelectCommand="SELECT * FROM [Sprzet]"></asp:SqlDataSource>
            <asp:Label ID="Label9" runat="server" CssClass="auto-style37" Font-Size="15px" Text="Laptop Lenovo IdeaPad Gaming 3 Ryzen 5 4600H" style="float:left;margin-left:75px;"></asp:Label>
               <asp:Label ID="Label11" runat="server" CssClass="auto-style39" Font-Size="12px" style="float:left;margin-top:20px;margin-left:-305px;" Text="Ekran 15,6&quot;m 1920 x 1080px 60Hz &lt;br&gt;Procesor AMD Ryzen 5 4600H &lt;br&gt;Wielkość pamięci RAM [GB] 8 &lt;br&gt;Dysk 512GB SSD &lt;br&gt;Karta graficzna NVIDIA GeForce GTX 1650 Ti &lt;br&gt;System operacyjny Brak"></asp:Label>
                <asp:Label ID="Label16" runat="server" CssClass="auto-style44" Font-Size="20px" Text="4500zł" style="float:right;margin-right:270px;margin-top:25px;"></asp:Label> 
            
            <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Zmywarka1.jpg" Width="137px" style ="margin-top:450px;height:100px;position:absolute;float:left;"/>
            <asp:Label ID="Label13" runat="server" CssClass="auto-style41" Font-Size="15px" style ="float:left;margin-top:150px;margin-left:-35px;" Text="Opis produktu:"></asp:Label>
            <asp:Label ID="Label12" runat="server" CssClass="auto-style40" Font-Size="15px" style="float:left;margin-top:180px;margin-left:-360px;" Text="Zmywarka BOSH SMS4HDI52E"></asp:Label>
            <asp:Label ID="Label14" runat="server" CssClass="auto-style42" Font-Size="12px" style="float:left;margin-top:200px;margin-left:-360px;" Text="Wymiary (SxWxG) [cm] 60 x 84.5 x 60 &lt;br&gt;Pojemność [kgl.] 9.5 &lt;br&gt;Zużycie wody [l/cykl] 9.5 &lt;br&gt;Poziom hałasu [dB] 44 &lt;br&gt;Sterowanie smartfonem Tak"></asp:Label>
            <asp:Label ID="Label17" runat="server" CssClass="auto-style45" Font-Size="20px" Text="2200zł" style="float:right;margin-top:200px;margin-right:-55px;"></asp:Label>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style2"  style="width:100%;height:700px;" AllowCustomPaging="True" AllowPaging="True" PageIndex="4">
            <Columns>
                <asp:TemplateField HeaderText ="Zdjęcie">
                    <ItemTemplate>
                        <asp:Image ID="Image4" runat="server" Width="300px" Height ="300px" ImageUrl='<%#"data:Image/jpg;base64,"+Convert.ToBase64String((byte [])Eval("Zdjęcie"))  %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText ="Nazwa">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Nazwa") %>'></asp:Label>

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText ="Cena">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Cena") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>
            </Columns>
            
            </asp:GridView>
           
                

           
        </div>
        
        
     
        
      
        
       
        
        
        
        
        
        
        
        <div id ="footer" style = "background-color:#5E9CB0;width:100%;height:100px;"></div>
    </form>
</body>
</html>
