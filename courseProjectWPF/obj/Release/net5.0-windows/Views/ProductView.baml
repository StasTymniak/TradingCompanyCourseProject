   M S B A M L   `   `   `  ���� K  GcourseProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:courseProjectWPF.ViewscourseProjectWPF.Views  I)clr-namespace:courseProjectWPF.ViewModelscourseProjectWPF.ViewModels  (    "courseProjectWPF.Views.ProductView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:courseProjectWPF.Views     @
viewmodels)clr-namespace:courseProjectWPF.ViewModels       � 	Resources   �� MergedDictionaries �� Source��  �� $m gC:\Users\tymniak\source\repos\TradingCompanyCourseProject\courseProjectWPF\Styles\ButtonDictionary.xaml?�%    .���  � RowDefinitions �� $
��Auto ��� $��* ��� $��* �.+�� $��0�� � ColumnDefinitions �� $��50 ��� .+��� $��0��$��20�����#545d6a���� *SelectedCategoryName+�� $
��Left=�$��1��$
��Find��$��50��$��20��   RoundedButton#��[  ���� *FindProductsCommand+���� *SelectedCategoryName+&   System.Windows.Controls.DataGrid  -     Name$ Imported��$��1��$	��Top=�   AutoGenerateColumns$ False��   CanUserResizeColumns$
 True��$��10(����#1b3a4b   RowBackground �#065a60	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 
   HorizontalGridLinesBrush

 �   �   VerticalGridLinesBrush
 �   �$   HorizontalScrollBarVisibility$ Hidden=�"   VerticalScrollBarVisibility$ Hidden=�   RowHeaderWidth$ 0Q����� *Products_Category+ �� SelectedItem �� *SelectedItem+   �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value��%�   '��       '  '     �� " ��.���  � y�$ Hidden=��� "   P�  �@ 
IsSelected$
 True��. ���  � ��
 �������  � ��
 �   ���  � ��$ 15(�   ColumnHeaderStyle �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � ��
 �������  � ��
 �   ���  � ��
 �������  � ��$ 1 1 1 1q���  � ��$ 	-1,-1,0,0q���  � ��$ 28����  � ��$
 auto����  � ��$ Center=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ Item1.ProductId�  $
 Name�� �� $ Item1.ProductName�  $ Category�� �� $ Item2�  $ 
InsertTime�� �� $ Item1.RowInsertTime�  $ 
UpdateTime�� �� $ Item1.RowUpdateTime�� $��2�� �� $
��Auto ��� .+�� $��0�� �� �� .+��� $��0�� � DataContext �� *SelectedItem+.+���  �� Orientation$ 
Horizontal=�.+��� 
�������$��25(�$
��ID: ���� 
�������$��25(����� $ Item1.ProductId� �� Mode$ TwoWay=��� $ 
Horizontal=�.+��� 
�������$��25(�$��Product name: ���� $��WrapWithOverflow=�
�������$��25(����� $ Item1.ProductName�$ TwoWay=��� $ 
Horizontal=�.+��� 
�������$��25(�$��
Category: ���� 
�������$��25(����� $ Item2�� $��1�� �� �� .+��� $��0��.+��� $ 
Horizontal=�.+��� 
�������$��25(�$��Startup Price: ���� $	��155�����#545d6a
�������$��25(�$��31������ *AuctionStartupPrice+ �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�  � ToolTip  �� *&$ErrorCollection[AuctionStartupPrice]+�� $ 
Horizontal=�.+��� 
�������$��25(�$��Redemption Price: ���� $	��100�����#545d6a
�������$��25(�$��30������ *AuctionRedemptionPrice+$
 True��$ PropertyChanged=�  �� *)'ErrorCollection[AuctionRedemptionPrice]+�� $ 
Horizontal=�.+��� 
�������$��25(�$��	EndTime: ���� $	��199�����#545d6a
�������$��25(�$��32������ *AuctionEndTime+$
 True��$ PropertyChanged=�  �� *!ErrorCollection[AuctionEndTime]+�� $��1��$��50��$��Create auction��$��0,50,0,0q�  DefaultButtonDesign#��[ 
���   ����� *CreateNewAuctionCommand+{��� *ButtonCreateIsEnable+