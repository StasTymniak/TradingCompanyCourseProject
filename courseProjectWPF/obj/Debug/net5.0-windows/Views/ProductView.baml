   M S B A M L   `   `   `  ����K  GcourseProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:courseProjectWPF.ViewscourseProjectWPF.Views  5      I)clr-namespace:courseProjectWPF.ViewModelscourseProjectWPF.ViewModels  6A   (    "courseProjectWPF.Views.ProductView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:courseProjectWPF.Views     5      @
viewmodels)clr-namespace:courseProjectWPF.ViewModels     6A     � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $m gC:\Users\tymniak\source\repos\TradingCompanyCourseProject\courseProjectWPF\Styles\ButtonDictionary.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��50 �6#   60   �� 5      6%   .+�5      �� $��0��6   $��20��6L   ���#545d6a��6&   �� *SelectedCategoryName+5   -   �� 5      $
��Left=�6   $��1��60   $
��Find��6@   $��50��6O   $��20��6Z      RoundedButton#��[  6�   ��6f   �� *FindProductsCommand+��6�   �� *SelectedCategoryName+6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Imported��5       $��1��6   $	��Top=�5!         AutoGenerateColumns$ False��5$         CanUserResizeColumns$
 True��5%      $��10(�5&      ���#1b3a4b   RowBackground �#065a60	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 5)      
   HorizontalGridLinesBrush

 �   �   VerticalGridLinesBrush
 �   �$   HorizontalScrollBarVisibility$ Hidden=�5,      "   VerticalScrollBarVisibility$ Hidden=�5-         RowHeaderWidth$ 0Q�5.         
IsReadOnly$
 True��5/      ��5"      �� *Products_Category+ �� SelectedItem 5#      �� *SelectedItem+  51       �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value��%;  '��       '  L     �� 53      " ��6   .�54      ��  � y�$ Hidden=�63   55      �� 57      "  6    58      P� 59       �@ 
IsSelected$
 True��6E   . �5:      ��  � ��
 �����6;   �� 5;       � ��
 �   �6;   �� 5<       � ��$ 15(�69   5=      5?      5@         ColumnHeaderStyle 5B      �� 5C      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5D      ��  � ��
 �����63   �� 5E       � ��
 �   �63   �� 5F       � ��
 �����64   �� 5G       � ��$ 1 1 1 1q�68   �� 5H       � ��$ 	-1,-1,0,0q�6/   �� 5I       � ��$ 28��6/   �� 5J       � ��$
 auto��6.   �� 5K       � ��$ Center=�6C   5L         Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ Item1.ProductId�  5Q      $
 Name��6%    63   �� $ Item1.ProductName�  5R      $ Category��6%    67   �� $ Item2�  5S      $ 
InsertTime��6%    69   �� $ Item1.RowInsertTime�  5T      $ 
UpdateTime��6%    69   �� $ Item1.RowUpdateTime�5V      � 5W   
   $��2��6    5X      �� 5Y      $
��Auto �6    60   �� 5Z      6"   .+�5\      � $��0��6    5]      �� 5^      6&   �� 5_      6&   .+�5a      �� $��0��6    � DataContext 6*   �� *SelectedItem+.+�5b      ��  �� Orientation$ 
Horizontal=�6!   .+�5c      �� 
�������$��25(�6>   $
��ID: ��6L   �� 5d      
�������$��25(�6>   ��6L   �� $ Item1.ProductId� �� Mode$ TwoWay=�5e      �� 5f      $ 
Horizontal=�6!   .+�5g      �� 
�������$��25(�6>   $��Product name: ��6L   �� 5h      $��WrapWithOverflow=�6$   
�������$��25(�6_   ��6m   �� $ Item1.ProductName�$ TwoWay=�5i      �� 5j      $ 
Horizontal=�6!   .+�5k      �� 
�������$��25(�6>   $��
Category: ��6L   �� 5l      
�������$��25(�6>   ��6L   �� $ Item2�5m      5n      � 5o      $��1��6    5p      �� 5q      6-   �� 5r      6-   .+�5t      �� $��0��6!   .+�5u      �� $ 
Horizontal=�6%   .+�5v      �� 
�������$��25(�6B   $��Startup Price: ��6P   �� 5w      $	��155��6&   ���#545d6a
�������$��25(�6`   $��31��5z   [   ��5w   n   �� *AuctionStartupPrice+ �� ValidatesOnDataErrors$
 True��  �� UpdateSourceTrigger$  PropertyChanged=�! � ToolTip! 5z   "   �� *&$ErrorCollection[AuctionStartupPrice]+6[   5{      �� 5|      $ 
Horizontal=�6%   .+�5}      �� 
�������$��25(�6B   $��Redemption Price: ��6P   �� 5~      $	��100��6&   ���#545d6a
�������$��25(�6a   $��30��5�   ^   ��5~   o   �� *AuctionRedemptionPrice+$
 True��$  PropertyChanged=�! 5�   "   �� *)'ErrorCollection[AuctionRedemptionPrice]+6^   5�      �� 5�      $ 
Horizontal=�6%   .+�5�      �� 
�������$��25(�6B   $��	EndTime: ��6P   �� 5�      $	��199��6&   ���#545d6a
�������$��25(�6a   $��32��5�   V   ��5�   o   �� *AuctionEndTime+$
 True��$  PropertyChanged=�! 5�   "   �� *!ErrorCollection[AuctionEndTime]+6V   5�      5�      �� 5�      $��1��6   $��50��5�      $��Create auction��5�      $��0,50,0,0q�5�        DefaultButtonDesign#��[ 5�      
���   ���5�      �� *CreateNewAuctionCommand+{�5�      �� *ButtonCreateIsEnable+5�      5�      5�      5�      5�      