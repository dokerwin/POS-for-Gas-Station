   M S B A M L   `   `   `  ����F  BGas station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Gas_station.Forecourt_managment.Views%Gas_station.Forecourt_managment.Views  5      6    0Gas_station.Forecourt_managment.Views.PrepayPomp   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:Gas_station.Forecourt_managment.Views     5        � DataContext  5	      ��  �� RelativeSource �� *Self+.��5
      (� .��5   
   � $��250,150q�6   $	��392��6    $	��207��6,   ��5      �� 5       �� ImageSource$ messagebox.jpg��6   .+�5      �� -   5         ��Name$ 
Prepay_btn��5      $��Prepay��6*   $
��Left=�6;   $��261,44,0,133q�6V   $	��109��6l   $
��Bold"�6x    J� RenderTransformOrigin$ 1.503,0.487&�6�      btnGreen#��[  6�   6�   �� 5      -   5        $ 	Close_btn��5      $
��Back��6)   $
��Left=�68   $��261,165,0,10q�6S   $	��109��6i   $
��Bold"�6u   $ 1.503,0.487&�6�   #��[  6�   6�   �� 5      $
��Left=�6B   $��30��6]   $��	93,44,0,0q�6i    �� TextWrapping$
 Wrap=�6|   $	��Top=�6�   $	��163��6�   
���������6   �� *fuel.quantity+ �� Mode$ TwoWay=�6�   �� 5      $��Amount��6   $
��Left=�6%   $��	29,44,0,0q�6@   $	��Top=�6S   $��30��6k   $��64��6w   ���	#FFC7FDC8$��14(�6�   �� 5      -   5         ��Name$ forecourt_txt��5      $
��Left=�6+   $��	140,0,0,0q�6F   $	��Top=�6Y   $��34��6q   $	��116��6}   $��18(�6�   ��6�   Z� 6�   �� 5      $��Amount��6   $
��Left=�6%   $��	29,44,0,0q�6@   $	��Top=�6S   $��30��6k   $��64��6w   ���	#FFC7FDC8$��14(�6�   �� 5      -   5        $��category_box��5       �� DisplayMemberPath$
 Name��5      $
��Left=�5      $��
93,105,0,0q�6'   $	��Top=�6;   $	��163��6S   $��30��6_   $ -0.476,0.464&�6k   ��5   +   �� 	 �� Path$	 fuelList�
 �� SelectedItem
 5      �� *fuel.product+$ TwoWay=�5   k   �� 5      $��Amount��6   $
��Left=�6%   $��
29,105,0,0q�6@   $	��Top=�6T   $��30��6l   $��64��6x   ���	#FFC7FDC8$��14(�6�   5      5      5      