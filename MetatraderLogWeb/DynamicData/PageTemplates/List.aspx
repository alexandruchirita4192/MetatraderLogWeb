<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeFile="List.aspx.cs" Inherits="List" %>

<%@ Register src="~/DynamicData/Content/GridViewPager.ascx" tagname="GridViewPager" tagprefix="asp" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true">
        <DataControls>
            <asp:DataControlReference ControlID="GridView1" />
        </DataControls>
    </asp:DynamicDataManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="DD">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
                    HeaderText="List of validation errors" CssClass="DDValidator" />
                <asp:DynamicValidator runat="server" ID="GridViewValidator" ControlToValidate="GridView1" Display="None" CssClass="DDValidator" />

                <asp:QueryableFilterRepeater runat="server" ID="FilterRepeater">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%# Eval("DisplayName") %>' OnPreRender="Label_PreRender" />
                        <asp:DynamicFilter runat="server" ID="DynamicFilter" OnFilterChanged="DynamicFilter_FilterChanged" /><br />
                    </ItemTemplate>
                </asp:QueryableFilterRepeater>
                <br />
            </div>

            <asp:GridView ID="GridView1" runat="server" DataSourceID="GridDataSource" EnablePersistedSelection="True"
                AllowPaging="True" AllowSorting="True" CssClass="DDGridView" 
                RowStyle-CssClass="td" HeaderStyle-CssClass="th" CellPadding="3" PageSize="40" SortedDescendingHeaderStyle-Wrap="True" SortedAscendingHeaderStyle-VerticalAlign="NotSet" RowStyle-Wrap="False" SelectedRowStyle-Wrap="False" PagerStyle-Wrap="False" HeaderStyle-Wrap="False" GridLines="Vertical" Width="100%" Height="100%" ViewStateMode="Enabled" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" CssClass="none" Font-Bold="True" ForeColor="White" Wrap="False" HorizontalAlign="Left" />

                <PagerStyle CssClass="DDFooter" Width="100%" BackColor="#999999" ForeColor="Black" HorizontalAlign="Center"/>        
                <PagerTemplate>
                    <asp:GridViewPager runat="server" />
                </PagerTemplate>
                <EmptyDataTemplate>
                    There are currently no items in this table.
                </EmptyDataTemplate>
                <RowStyle CssClass="td" Wrap="False" />
                <SelectedRowStyle Wrap="False" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" Wrap="True" />
            </asp:GridView>

            <asp:EntityDataSource ID="GridDataSource" runat="server" EnableDelete="true" />
            
            <asp:QueryExtender TargetControlID="GridDataSource" ID="GridQueryExtender" runat="server">
                <asp:DynamicFilterExpression ControlID="FilterRepeater" />
            </asp:QueryExtender>

            <div class="DDBottomHyperLink">
                <asp:DynamicHyperLink ID="InsertHyperLink" runat="server" Action="Insert"><img runat="server" src="~/DynamicData/Content/Images/plus.gif" alt="Insert new item" />Insert new item</asp:DynamicHyperLink>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

