   M S B A M L   `   `   `  ���� K  GcourseProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:courseProjectWPF.WindowscourseProjectWPF.Windows  )    #courseProjectWPF.Windows.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:courseProjectWPF.Windows       � Title$  
MainWindow��$	��640��$
��1080�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency$
 True�� J� InputBindings ��  �� Command$ ApplicationCommands.Close��
 �� Key$	 Esc�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$ ApplicationCommands.Close��	 � 	Resources	 
 �� MergedDictionaries �� Source�� 
 �� $m gC:\Users\tymniak\source\repos\TradingCompanyCourseProject\courseProjectWPF\Styles\ButtonDictionary.xaml?�%    .���� ���#272535 �� CornerRadius$ 15��._��  � ColumnDefinitions �� $	��200 ��� $	��880 � � RowDefinitions �� $��85 ��� .+��� 
�������$��22(�$��50,0,0,0q�$��Center=����� *
UserRole+�� $��1��.+�	� $��Auctions��
�������$��16(�$��50��   MenuButtonTheme#��[  $��Auctions������ *UpdateViewCommand+	� $��Products��
�������$��16(�$��50��#��[  $��Products������ *UpdateViewCommand+	� $��
Categories��
�������$��16(�$��50��#��[  $��
Categories������ *UpdateViewCommand+� $��0��$��1�� �� $	��600 ��� .+��� $��1������ *SelectedAuthViewModel+�� $��1��$��1������ *SelectedViewModel+