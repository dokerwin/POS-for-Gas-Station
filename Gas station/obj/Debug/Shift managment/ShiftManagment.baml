   M S B A M L   `   `   `  ����F  BGas station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Gas_station.Shift_managmentGas_station.Shift_managment  5      0    *Gas_station.Shift_managment.ShiftManagment   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Gas_station.Shift_managment     5      W SFontAwesome5.Net, Version=2.1.4.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  6?     N� Title$  ShiftManagment��5       � DataContext 6   ��  �� RelativeSource �� *Self+ � 	Resources 5
       �� 
TargetType   AButton �� Property �� Value �� 
TargetType �� CornerRadius	 ��Name��%;  &	        �� 5   
   " ��6   .�5      ��  � ��$	 120��6&   �� 5       � ��$ 50��6'   �� 5       � ��
 � d �6+   �� 5       � ��
 ����6+   �� 5       � ��$ 22(�6)   �� 5       � ��$ Light"�6+   �� 5       �@J�SnapsToDevicePixels . 64   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 15��6!   #��z��63   ._�5      �� $	 MyContentPresenter��6/   #��z��6K   $��Center=�5   !   $��Center=�6>   $��0,0,0,0q�6Y   5      5      5      5      5      .��5       (� $��Stretch=�6   $��Stretch=�6,   .��5!   
   � $	��474��6   $	��667��6   
 � RowDefinitions
 5"      �� 5#      $
��143* �6    �� 5$      $	��15* �6    .+�5&      �� -   5         ��Name$ shiftListView��5&      $��
10,67,0,10q�6P   ���	#4DFFFFFF$��2��6{   ��6.   �� *	shiftList+ �� View 5'      �� 5(      .P�5)      �� $��Shift��6)    �� Width$
 Auto��68    �� DisplayMemberBinding 6E   �� *ShiftNumber+�� 5*      $��Cashier��6)   $
 Auto��6:    6G   �� *	Cashier+�� 5+      $��Station��6)   $
 Auto��6:    6G   �� *	Station+�� 5,      $��Started��6)   $
 Auto��6:    6G   �� *
ShiftStart+�� 5-      $��Ended��6)   $
 Auto��68    6E   �� *
ShiftEnd+5/      53      �� 54      -   5        $��shift_off_btn��54      $��
Shift 
Off��6,   $
��Left=�6E   $	��Top=�6`   $��75��6x     btnBlue#��[ 6�   $��5,5,0,0q�6�   56      �� 57      $��Last shifts��6   $
��Left=�6*   $��	248,5,0,0q�6E   $	��Top=�6X   $��36(�6p   
���   �6~   59      5:      5;      