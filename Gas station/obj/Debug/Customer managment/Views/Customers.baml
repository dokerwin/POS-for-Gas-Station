   M S B A M L   `   `   `  ����F  BGas station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Gas_station.Customer_managment.Views$Gas_station.Customer_managment.Views  5      4    .Gas_station.Customer_managment.Views.Customers   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:Gas_station.Customer_managment.Views     5        N� Title$  	Customers��5	       � DataContext 6   ��  �� RelativeSource �� *Self+.��5      (� $��Stretch=�6   $��Stretch=�6,   .��5   
   � $	��474��6   $	��835��6   .+�5      �� -   5         ��Name$ customersList��5      $��419,48,22,6q�6Q   ���	#4DFFFFFF��6/   �� *	customers+ �� View 5      �� 5      .P�5      �� $��ID Customer��6)    �� Width$
 auto��6>    �� DisplayMemberBinding 6K   �� *
CustomerID+�� 5      $��Card ID��6)   $
 auto��6:    6G   �� *ID_LoyaltyCard+�� 5      $
��Name��6)   $
 auto��67    6D   �� *Person.Name+�� 5      $��Surname��6)   $
 auto��6:    6G   �� *Person.Surname+�� 5      $��Phone��6)   $
 auto��68    6E   �� *Person.Phone1+�� 5      $��Country��6)   $
 auto��6:    6G   �� *Person.Adres_country+5      5      �� 5      $��Cutomers��6   $
��Left=�6'   $��335,-10,0,0q�6B   $	��Top=�6W   $��36(�6o   
�������6}   �� 5      -   5         ��Name$ Id_receipt_txt��5   >   $
��Left=�6V   $��26��6q   $��
270,48,0,0q�6}    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��133��6�   ��6   �� *	_customer+	 �� Mode$	 TwoWay=�6�   �� 5      $��Id customer��6   $
��Left=�6*   $��
190,48,0,0q�6E   $	��Top=�6Y   ���	#FF1E8AC2���	#FFF0ECEC
 J� RenderTransformOrigin$
 2.525,0.551&�6�   $��80��6�   �� 5      -   5         ��Name$ FindCustomer_Copy��5      $��Find customer��62   $
��Left=�6J   $	��Top=�6e   $	��213��6}      btnBlue#��[  6�   $��
190,96,0,0q�6�   $��34��6�   �� 5      -   5         ��Name$ customer_info_lbl��5      $�� ��6/   $��10,159,432,32q�6:   
�������$��20(�6d   5!      5"      5$      