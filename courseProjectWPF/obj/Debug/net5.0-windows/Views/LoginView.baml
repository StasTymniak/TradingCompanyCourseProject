   M S B A M L   `   `   `  ����K  GcourseProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:courseProjectWPF.ViewscourseProjectWPF.Views  5      &     courseProjectWPF.Views.LoginView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:courseProjectWPF.Views     5      $	��280��5   "     � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $m gC:\Users\tymniak\source\repos\TradingCompanyCourseProject\courseProjectWPF\Styles\ButtonDictionary.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   6*   �� 5      $��25 �6   6*   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��Login��6   
�������$��60��67   �� 5      ���#545d6a
�������$��15(�5      $��70��5      $��20��5      ��5      �� *
UserName+ �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=� � ToolTip 5      �� *ErrorCollection[UserName]+{�5       �� *
IsLoggedIn+�� 5!      $��Password��6   
�������$��60��6:   �� 5"      ���#545d6a
�������$��70��5(      $��20��5)      $��15(�5*      ��5"      �� *UserPassword+$
 True��$ PropertyChanged=� 5%      �� *ErrorCollection[UserPassword]+{�5+      �� *
IsLoggedIn+5,      �� 5-   
   $��1��6   $��60��6   $��
179,0,41,0q�6)      RoundedButton#��[  50      ��5-   =   �� *LoginViewButtonContent+��5.      �� *LoginButtonCommand+{�5/      �� *ButtonLogInIsEnable+51      52      53      