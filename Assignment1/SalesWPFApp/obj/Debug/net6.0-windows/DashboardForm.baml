   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.DashboardForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  ProductForm��5	   	   $	��700��6   $
��1300��6*    � WindowStartupLocation$ CenterScreen=�67    � WindowStyle$
 None=�5
   	   
������  � AllowsTransparency$
 True��65   .��5      ��  �� CornerRadius$ 10��6   $��1q�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #462AD8��6    � Offset$ 0Q�6/   � 5      $ #DA34AE��6   $
 0.75Q�6/   � 5      $ #8A16C1��6   $ 1Q�6/   5      ._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $	��250 �6#   �� 5      $��* �6#   .+�5      �� $ 	10,0,0,10��6   $��0��6.   ��5      �� 5       $	 0,0&�6*   $ 1,0.7&�6;   .��5!      � $ #281663��6'   $ 0Q�67   � 5"      $ #231457��6'   $ 1Q�67   5#      ._�5%      �� .+�5'      �� 
 �� Orientation$
 
Horizontal=�6!   $��35��6:   $��
15,25,0,40q�6F   .+�5(      �� $��/Images/logo.png��6    $��30��6:   �� 5)      $��JUICE��6$   
�������$��20(�6I   $��
Montserrat)�6W   $��Medium"�5*   $   $��Center=�68   $��10,0,0,0q�6S   5+      	� 5-      -   5         	�Name$ btnDashboard��5-   U      
menuButton#��[  6"   
 � Tag$ #8287ff��6F   .��5.      �� $
 
Horizontal=�6%   .+�5/      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     menuButtonIcon#��[ 67   �� 50      $��	Dashboard��6(     menuButtonText#��[ 69   51      52      	� 54      -   5        $ 
btnProduct��54   T   #��[  6"   $ #40cef1��6F   .��55      �� $
 
Horizontal=�6%   .+�56        $ ProductHunt=�6+   #��[ 6>   �� 57      $��Product��6(   #��[ 67   58      59      	� 5;      -   5        $ btnOrder��5;   T   #��[  6"   $ #E285DE��6F   .��5<      �� $
 
Horizontal=�6%   .+�5=        $ MoneyBill1Wave=�6+   #��[ 6A   �� 5>      $��Order��6(   #��[ 65   5?      5@      	� 5B      -   5        $ 	btnMember��5B   T   #��[  6"   $ #ffbd43��6F   .��5C      �� $
 
Horizontal=�6%   .+�5D        $ PeopleGroup=�6+   #��[ 6>   �� 5E      $��Member��6(   #��[ 66   5F      5G      5I      5J      �� 5L      $ 	0,10,10,0��6   $��1��6.   ��5M      �� 5N      $	 1,1&�6*   $	 0,0&�6;   .��5O      � $ #0a0441��6'   $ 0Q�67   � 5P      $ #1d114e��6'   $ 1Q�67   5Q      ._�5T      �  � RowDefinitions 5U      �� 5V      $��25 �6(   �� 5W      $��35 �6(   �� 5X      $��* �6(   .+�5[      �� -   5         ��Name$ pnlControlBar��5[   !   $��0��68   $
 
Horizontal=�6E   $��RightToLeft=�6^   
������ $��0,0,5,0q�5\   :   .+�5^      �� -   5         ��Name$ btnClose��5^   !     controlButton#��[ 63   $��0,0,15,0q�6[   $ PaleVioletRed��5_   !   .��5`        $ Xmark=�6+     controlButtonIcon#��[ 68   5a      �� 5c      -   5        $ btnMaximize��5c   !   #��[ 66   $��0,0,15,0q�6^   $ #ffbd43��5d   !   .��5e        $ Square=�6+   #��[ 69   5f      �� 5h      -   5        $ btnMinimize��5h   !   #��[ 66   $ #28AEED��5i   !   .��5j        $ WindowMinimize=�6+   #��[ 6A   $��12��6l   5k      5l      �� 5n      $
 
Horizontal=�6!   $��2��6;   .+�5o      �� $��/Images/violet.jpg��6    $	��636��6<   $
��1048��6I   5p      5r      5t      5v      5w      5y      