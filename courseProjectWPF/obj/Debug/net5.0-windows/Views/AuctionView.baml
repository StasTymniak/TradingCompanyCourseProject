   M S B A M L   `   `   `  ����K  GcourseProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:courseProjectWPF.ViewscourseProjectWPF.Views  5      (    "courseProjectWPF.Views.AuctionView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:courseProjectWPF.Views     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $m gC:\Users\tymniak\source\repos\TradingCompanyCourseProject\courseProjectWPF\Styles\ButtonDictionary.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $	��400 �6   6+   �� 5      $��50 �6   6*   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Imported��5      $��0��6   $	��880��5      $	��400��5      $	��Top=�5         AutoGenerateColumns$ False��5         CanUserResizeColumns$
 True��5      $��10(�5      ���#1b3a4b   RowBackground �#065a60   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5!      	   HorizontalGridLinesBrush
	 �   �
   VerticalGridLinesBrush

 �   �$   HorizontalScrollBarVisibility$ Hidden=�5$      "   VerticalScrollBarVisibility$ Hidden=�5%         RowHeaderWidth$ 0Q�5&         
IsReadOnly$
 True��5'      ��5      �� *
Auctions+ �� SelectedItem 5      �� *SelectedAuction+  5)       �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value��%;  '��       '  L     �� 5*      " ��6   .�5+      ��  � y�$ Hidden=�63   5,      �� 5.      "  6    5/      P� 50       �@ 
IsSelected$
 True��6E   . �51      ��  � ��
 �����6;   �� 52       � ��
 �   �6;   �� 53       � ��$ 15(�69   54      56      57         ColumnHeaderStyle 59      �� 5:      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5;      ��  � �� �#00646663   �� 5<       � ��
 �����63   �� 5=       � ��
 �����64   �� 5>       � ��$ 1 1 1 1q�68   �� 5?       � ��$ 	-1,-1,0,0q�6/   �� 5@       � ��$ 30��6/   �� 5A       � ��$
 Auto��6.   �� 5B       � ��$ Center=�6C   �� 5C       � ��$ Center=�6:   5D         Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5H      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ 	AuctionId�  5I      $
 Name��6%    63   �� $ AuctionName�  5J      $ Startup Price��6%    6<   �� $ StrtupPrice�  5K      $ Redemption Price��6%    6?   �� $ RedemptionPrice�  5L      $ 	Is Active��6%    68   �� $ isActive�  5M      $ Activate Time��6%    6<   �� $ ActivateTime�  5N      $ Deactivate Time��6%    6>   �� $ DeactivateTime�  5O      $ End Time��6%    67   �� $ EndTime�  5P      $ 
Product ID��6%    69   �� $ 	ProductId�5R      �� 5S   
   $��1��6      DefaultButtonDesign#��[  5V      ��5T      �� *AuctionButtonContent+��5U      �� *AuctionButtonCommand+5V      5W      5X      