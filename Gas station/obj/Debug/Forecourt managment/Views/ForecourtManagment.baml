   M S B A M L   `   `   `  ����F  BGas station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Gas_station.Forecourt_managment.Views%Gas_station.Forecourt_managment.Views  5      >    8Gas_station.Forecourt_managment.Views.ForecourtManagment   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:Gas_station.Forecourt_managment.Views     5        N� Title$  ForecourtManagment��5	       � DataContext 6"   ��  �� RelativeSource �� *Self+.��5
      (� .��5   
   � $	��764��6   .+�5      �� $��Start ��6   $
��Left=�6&   $��	13,23,0,0q�6A   $	��Top=�6T   $��66��6l   $��59��6w      btnBlue#��[  6�   ���	#FF0BE73D6�   �� 5      $
��Stop��6   $
��Left=�6$   $��	91,23,0,0q�6?   $	��Top=�6R   $��66��6j   $��59��6u   #��[  6�   ���	#FFF932116�   �� 5      $
��Lock��6   $
��Left=�6$   $��
170,23,0,0q�6?   $	��Top=�6S   $��62��6k   $��59��6v   #��[  6�   ���	#FFDBFF0F6�   �� 5      $
��Left=�6   $��
328,23,0,0q�62   $	��Top=�6F   $��74��6^   $��24��6i   $��20(�6u   ��5      �� 5       �� EndPoint$	 0,1&�6*    �� 
StartPoint$	 0,0&�69   .��5      �  � Color$ 	#FFF0F0F0��6'    � Offset$ 0Q�69   � 5      $ 	#FFF3F3F3��6'   $ 1Q�69   5      5      �� 5      $��Oder fuel 
delivery��6   $
��Left=�6<   $��348,186,0,0q�6W   $	��Top=�6l   $��97��6�   #��[  6�   �� 5      $��Prepay��6   $
��Left=�6&   $��
244,23,0,0q�6A   $	��Top=�6U   $��61��6m   $��59��6x   #��[  6�   �� 5      $��Declare
 cisterns ��6   $
��Left=�6;   $��348,107,0,0q�6V   $	��Top=�6k   $��97��6�   $��55��6�   #��[  6�   �� 5      -   5        $��CisternList��5      $
��Left=�6*   $	��202��6E   $��
13,107,0,0q�6R   $	��Top=�6f   $	��322��6~    J� RenderTransformOrigin$ -0.328,-0.116&�6�    �� View 5      �� 5      .P�5      �� $��ID��6)   	 �� Width$	 40��65   
 �� DisplayMemberBinding
 6@   �� *
ID_Cistern+�� 5      $
��Fuel��6)   $	 80��67   
 6B   �� *Product.Pro_Name+�� 5      $��Actual level��6)   $		 100��6?   
 6K   �� *ActualVolume+�� 5       $��Min Lt��6)   $	 50��69   
 6D   �� *	MinVolume+�� 5!      $��Max Lt��6)   $	 50��69   
 6D   �� *	MaxVolume+5"      5$      �� 5%      $.��(Please, declare cisterns before filling!��6   $
��Left=�6G   $��202,329,0,-0.2q�6b   $	��Top=�6z   $��22(�6�   $	��386��6�   ���	#FFF37A006�   �� 5&      -   5         ��Name$ FuelDeliveryList��5&      $
��Left=�61   $	��202��6L   $��462,107,0,0q�6Y   $	��Top=�6n   $	��292��6�   $ -0.328,-0.116&�6�    5'      �� 5(      .P�5)      �� $��Cistern��6)   $		 100��6:   
 6F   �� *
ID_Cistern+�� 5*      $��Data next delivery��6)   $		 200��6E   
 6Q   �� *DataDelivery+5-      5/      50      51      52      