   M S B A M L   `   `   `  ����F  BGas station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Gas_station.Receipt_managment.Views#Gas_station.Receipt_managment.Views  5      :    4Gas_station.Receipt_managment.Views.ReceiptManagment   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:Gas_station.Receipt_managment.Views     5        N� Title$  ReceiptManagment��5	       � DataContext 5
      ��  �� RelativeSource �� *Self+.��5      (� $��Stretch=�6   $��Stretch=�6,   .��5   
   � $	��474��6   $	��835��6   .+�5      �� -   5         ��Name$ receiptListView��5      $��287,47,24,7q�6�   ���	#4DFFFFFF��6`   �� *	_receipts+ �� View 5      �� 5      .P�5      �� $��
Receipt ID��6)    �� Width$	 120��6=    �� DisplayMemberBinding 6I   �� *	ReceiptID+�� 5      $��	Deal time��6)   $	 200��6<    6H   �� *	Deal_time+�� 5      $��Total price��6)   $	 200��6>    6J   �� *	Sel_price+5      5      �� 5      $��Orders ��6   $
��Left=�6&   $��335,-10,0,0q�6A   $	��Top=�6V   $��36(�6n   
�������6|   �� 5      -   5         ��Name$ 	topOrders��5      $��Last 100
orders��6*   $
��Left=�6M   $	��Top=�6h   $	��192��6�      btnBlue#��[  6�   $��
79,114,0,0q�6�   6�   �� 5      -   5         ��Name$ Id_receipt_txt��5   ?   $
��Left=�6W   $��26��6r   $��
138,47,0,0q�6~   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $	��133��6�   ��6   �� *
_receiptId+
 �� Mode$
 TwoWay=�6�   �� 5      $��
Id receipt��6   $
��Left=�6)   $��	79,47,0,0q�6D   $	��Top=�6W   ���	#FF1E8AC2���	#FFF0ECEC J� RenderTransformOrigin$ 2.525,0.551&�6�   5!      5"      5#      