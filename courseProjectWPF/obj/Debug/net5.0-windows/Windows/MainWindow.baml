   M S B A M L   `   `   `  ����K  GcourseProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:courseProjectWPF.WindowscourseProjectWPF.Windows  5   	   )    #courseProjectWPF.Windows.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:courseProjectWPF.Windows     5   	     � Title$  
MainWindow��5   	   $	��640��6   $
��1080��6)    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency$
 True��5   	    J� InputBindings 5      �� 5   
    �� Command$ ApplicationCommands.Close��6   
 �� Key$	 Esc��69    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Close��5      6=   	 � 	Resources	 5      
 �� MergedDictionaries �� Source�� 5   
   
 5      �� 5      $m gC:\Users\tymniak\source\repos\TradingCompanyCourseProject\courseProjectWPF\Styles\ButtonDictionary.xaml?�6%   %    5      .��5      �� ���#272535 �� CornerRadius$ 15��5      ._�5    
   �  � ColumnDefinitions 5!      �� 5"      $	��200 �6#   �� 5#      $	��880 �6#    � RowDefinitions 5%      �� 5&      $��85 �6    �� 5'      .+�5)      �� 
�������$��22(�5+      $��50,0,0,0q�5,      $��Center=�5-      ��5)      �� *
UserRole+5-      �� 5.      $��1��6   .+�5/      	� $��Auctions��6   
�������$��16(�51      $��50��52         MenuButtonTheme#��[  53      $��Auctions��55      ��54      �� *UpdateViewCommand+55      	� 56      $��Products��6   
�������$��16(�58      $��50��59      #��[  5:      $��Products��5<      ��5;      �� *UpdateViewCommand+5<      	� 5=      $��
Categories��6   
�������$��16(�5?      $��50��5@      #��[  5A      $��
Categories��5C      ��5B      �� *UpdateViewCommand+5C      5D      � 5E      $��0��6   $��1��6     5F      �� 5G      $	��600 �6'   65   �� 5H      6)   .+�5J      �� $��1��6!   ��61   �� *SelectedAuthViewModel+5K      �� 5L      $��1��6   $��1��6*   ��6:   �� *SelectedViewModel+5M      5N      5O      