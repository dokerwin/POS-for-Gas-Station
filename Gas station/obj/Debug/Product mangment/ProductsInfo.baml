   M S B A M L   `   `   `  ����F  BGas station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Gas_station.Product_mangmentGas_station.Product_mangment  5      /    )Gas_station.Product_mangment.ProductsInfo   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Gas_station.Product_mangment     5        N� Title$  	Customers��5	       � DataContext 6   ��  �� RelativeSource �� *Self+.��5      (� $��Stretch=�6   $��Stretch=�6,   .��5   
   � $	��474��6   $	��835��6   .+�5      �� -   5         ��Name$ customersList��5      $��228,48,10,10q�6T   ���	#4DFFFFFF��6/   �� *ProductsList+ �� SelectedItem 6�   �� *SelectedProduct+ �� View 5      �� 5      .P�5      �� $��Product ID ��6)    �� Width$
 auto��6>    �� DisplayMemberBinding 6K   �� *	ProductID+�� 5      $��Product name��6)   $
 auto��6?    6L   �� *Name+�� 5      $��Category��6)   $
 auto��6;    6H   �� *Category.Name+�� 5      $��Product price��6)   $
 auto��6@    6M   �� *
List_Price+�� 5      $��Supplier��6)   $
 auto��6;    6H   �� *Distributor.Name+�� 5      $��	Developer��6)   $
 auto��6<    6I   �� *Developer.Name+�� 5      $��Stock Qt��6)   $
 auto��6;    6H   �� *
Quantity+�� 5      $��Restriction��6)   $
 auto��6>    6K   �� *Restriction_age+�� 5      $��Last update��6)   $
 auto��6>    6K   �� *
LastUpdate+�� 5      $
��Edit��6)   $	 200��67    �� CellTemplate 5      �� 5   "   .R�5   &   �� $
��Edit��6-   ��6=   �� 5   #   5      �� 5       $��Delete��6)   $	 200��69    5!      �� 5"   "   .R�5#   &   �� $��Delete��6-   ��6?   �� 5$   #   5&      5'      5)      �� 5+      $��All products��6   $
��Left=�6+   $��335,-10,0,0q�6F   $	��Top=�6[   $��36(�6s   
�������6�   �� 5,      -   5        	 ��Name$	 Id_receipt_txt��5,   >   $
��Left=�6V   $��24��6q   $��	10,72,0,0q�6}   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��213��6�   ��6   �� *	productID+ �� Mode$ TwoWay=�6�   �� 5-      $%��                Product barcode��6   $
��Left=�6>   $��	10,48,0,0q�6Y   $	��Top=�6l   ���	#FF1E8AC2���	#FFF0ECEC J� RenderTransformOrigin$ 2.525,0.551&�6�   $	��213��6�   $��24��6�   �� 5.         btnBlue#��[  6   $��ParameterValue��5/      $��Find product��68   $��10,106,612,335q�6O   ��5.   8   �� *	MyCommand+5/   O   �� 50      #��[  6   $��ParameterValue��51      $��Add new product��64   $��10,153,612,290q�6N   ��50   8   �� *AddProductBtn+51   N   53      54      56      