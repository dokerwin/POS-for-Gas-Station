   M S B A M L   `   `   `  ����F  BGas station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Gas_station.LoyaltyCard_mamagment.Views'Gas_station.LoyaltyCard_mamagment.Views  5      ;    5Gas_station.LoyaltyCard_mamagment.Views.CardManagment   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:Gas_station.LoyaltyCard_mamagment.Views     5        N� Title$  CardManagment��5	       � DataContext 5
      ��  �� RelativeSource �� *Self+.��5      (�  (� Stretch$ Uniform=�6   $��Stretch=�6    $��Stretch=�6>   .��5   
   � $��50q�6   $	��357��6   $	��704��6(    � ColumnDefinitions 5      �� 5      $
��100* �6#   �� 5      $
��191* �6#   �� 5      $	��90* �6#   �� 5      $
��Auto �6#   $	��320��60    � RowDefinitions 5      �� 5      $	��64* �6    �� 5      $	��36* �6    �� 5      $	��22* �6    �� 5      $	��35* �6    �� 5      $
��168* �6    5      �� 5      $	��31* �6    .+�5      �� -   5        $��checkBalance_btn��5         btnBlue#��[  6.   $��Check balance��6O   $��102.159,0.6,35.441,0.6q�6g   $��3��6�   $��3��6�   6�   �� 5       $��Top up card��6   $��24(�6+   $��
98,0,1.4,3q�69   $��2��6M   �� 5!      $��
Card nuber��6   $
��Left=�6)   $��1��6D   $	��Top=�6Q   $��35��6i   $	��100��6u   $��2��6�   �� 5"      $��Amount��6   $
��Left=�6%   $��
-5,1.6,0,0q�6@   $��3��6T   $	��Top=�6a   $��38��6y   $	��100��6�   $��2��6�   �� 5#      $
��Left=�6@   $��36��6[    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��191��6�   $��1��6�   $��3��6�   $��98,0,0,0q�6�   ��6   �� *_cardNumber+ �� Mode$ TwoWay=�6�   �� 5$      $��98,1.6,1.4,0.6q�6=   $��3��6U   $��2��6b   ��6   �� *	_amount+$ TwoWay=�6b   �� 5%      -   5        $��	topUp_btn��5%      #��[  6'   $��Top up��6H   $��98,24.4,1.4,110.6q�6Y   $��4��6t   $��2��6�   6�   �� 5&      $��3��6A   $
��Left=�6Q   $��36��6l   $
 Wrap=�6x   $	��Top=�6�   $	��191��6�   $��102.159,63,0,0q�6�   $��2��6�   ��6   �� *_cardNumber+$ TwoWay=�6�   �� 5'      $��
Card nuber��6   $
��Left=�6)   $	��Top=�6D   $��35��6\   $	��100��6h   $��3��6t   $��2.159,63,0,0q�6�   $��2��6�   �� 5(      $��Check balance��6   $��24(�6-   $��102.159,3,65.441,0q�6;   $��3��6W    J� RenderTransformOrigin$ 0.164,0.384&�6g   �� 5)      -   5        $��balance_lbl��5)      $��24(�6(   $��142.6,100.4,197.441,30.8q�66   $ 0.164,0.384&�6X   $��4��6|   $��3��6�   $��2��6�   $��1��6�   
�������6�   5,      5-      5.      