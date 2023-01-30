<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rank.aspx.cs" Inherits="rank" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
<title>REVENGE SERVER</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">

<style type="text/css">
.auto-style1 {
	text-align: center;
	font-size: 30pt;
	font-weight: bold;
	color: #FFFFFF;
}

.large-2 {
  margin-left: 0px;
  float: left;
  
  overflow-y: scroll;
  margin-bottom: 0px;
  
  
}

.force-overflow {
  min-height: 450px;
}

.large-2::-webkit-scrollbar-track {
  border: 1px solid #000;
  padding: 2px 0;
  background-color: #737272;
}

.large-2::-webkit-scrollbar {
  width: 12px;
}

.large-2::-webkit-scrollbar-thumb {
  border-radius: 10px;
  box-shadow: inset 0 0 6px rgba(0,0,0,.3);
  background-color: #404040;
  border: 1px solid #000;
}
.centered {
  position: absolute;
  top: 520px;
  left: 215px;
  transform: translate(-50%, -50%);
  text-align: center;
	font-size: 30pt;
	font-weight: bold;
	color: #FFFFFF;
}

</style>
</head>
<body bgcolor="#4e4e4d" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<!-- Save for Web Slices (1.psd) -->
<table id="Table_01" width="611" height="225" border="0" cellpadding="0" cellspacing="0">
	<tr>
		<td colspan="7">
			<img src="images/1_01.jpg" width="611" height="81" alt=""></td>
	</tr>
	<tr>
	<form id="form1" runat="server" >
		<td colspan="5">
			<img src="images/1_02.jpg" width="424" height="44" alt=""></td>
		<td rowspan="4">
<div  class="large-2" style="height:495px; width:149px; overflow-y:scroll;overflow-x: hidden">
		<table id="Table_01" border="0" cellpadding="0" cellspacing="0" height="0" width="154">
		
		

				
				<asp:ImageButton ID="allButton" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_03.jpg" OnClick="allButton_Click" />
			</tr>
			<tr>
				 <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_04.jpg" OnClick="ImageButton1_Click" />
			</tr>
			<tr>
				 <asp:ImageButton ID="ImageButton2" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_05.jpg" OnClick="ImageButton2_Click" />
				</td>
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton3" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_06.jpg" OnClick="ImageButton3_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton4" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_07.jpg" OnClick="ImageButton4_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton5" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_08.jpg" OnClick="ImageButton5_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton6" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_09.jpg" OnClick="ImageButton6_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton7" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_10.jpg" OnClick="ImageButton7_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton8" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_11.jpg" OnClick="ImageButton8_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton9" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_12.jpg" OnClick="ImageButton9_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton10" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_13.jpg" OnClick="ImageButton10_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton11" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_14.jpg" OnClick="ImageButton11_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton12" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_15.jpg" OnClick="ImageButton12_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton13" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_16.jpg" OnClick="ImageButton13_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton14" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_17.jpg" OnClick="ImageButton14_Click" />
			</tr>
		    <tr>
				 <asp:ImageButton ID="ImageButton15" runat="server" Height="40px" width="140" ImageAlign="Left" src="images/3_18.jpg" OnClick="ImageButton15_Click" />
			</tr>
		
		
			
		
		</table>
<!-- End Save for Web Slices -->
</div>
		<td rowspan="5">
			<img src="images/1_04.jpg" width="38" height="544" alt=""></td>
	</tr>
	<tr>
		<td rowspan="4">
			<img src="images/1_05.jpg" width="41" height="500" alt=""></td>
		<td colspan="3">
	
			<div  style="position:absolute; width:329px; height:352px; z-index:2; left:51px; top:125px; color:#ffeb3f">
				
 <div class="large-2" style="height:355px; width:370px; overflow-x: hidden ">
				
      <div class="style1" style="width: 250px; height: 188px">  
	  
		 <asp:GridView GridLines="None" ID="GridView1" runat="server" CellPadding="6" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" Width="400px" Height="46px">
            <Columns>  
        <asp:BoundField ItemStyle-Width="150px" DataField="JobName" HeaderText="" />
  		<asp:BoundField ItemStyle-Width="150px" DataField="CRPoints" HeaderText="" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="" />		
            </Columns>  
        </asp:GridView>

		
		
    	  <br />
		  <br />
		  </div>  
	  
	   </div> 

	   
	   
	
			</div>
			<img alt="" height="362" src="images/1_06.jpg" width="365">
			</div>
			</td>
			
		
		<td rowspan="4">
			<img src="images/1_07.jpg" width="18" height="500" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="images/1_08.jpg" width="365" height="17" alt=""></td>
	</tr>
	<tr>
		<td rowspan="2">
			<img src="images/1_09.jpg" width="21" height="116" alt=""></td>
		<td>
    
   
    <img src="<%=path%>" width="89" height="67" />
			
		<td>
<div class="container">
  <img src="images/1_11.jpg" alt="" height="67" width="255">
  
  <asp:Label ID="Label1" runat="server" Text=" " class="centered" ></asp:Label>
  
</div>
			
	</tr>
	<tr>
		<td colspan="2">
			<img src="images/1_12.jpg" width="344" height="45" alt=""></td>
		<td>
			<img src="images/1_13.jpg" width="149" height="45" alt=""></td>
	</tr>
 	   <div id="layer2" class="auto-style1" style="position: absolute; width: 100px; height: 42px; z-index: 2; left: 205px; top: 525px; right: 30px;">
<label id="Label1" ></label>
	
	</form>


</div>	
</table>

<br/>
</body>
</html>

