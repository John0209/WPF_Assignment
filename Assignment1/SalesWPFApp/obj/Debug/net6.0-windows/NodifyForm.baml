   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.NodifyForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   'localclr-namespace:SalesWPFApp   5   	   X	 TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp 	 61     � Title$  
NodifyForm��5	   
   $	��210��6   $	��450��6*    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�5
   	   
������  � AllowsTransparency$
 True��65   .��5      ��  �� CornerRadius$ 10��6   $��1q�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #462AD8��6    � Offset$ 0Q�6/   � 5      $ #DA34AE��6   $
 0.75Q�6/   � 5      $ #8A16C1��6   $ 1Q�6/   5      ._�5   
   � 	 � RowDefinitions	 5      �� 5      $��20 �6    �� 5      $	��100 �6    �� 5      $��* �6    .+�5      �� $ 	10,10,0,0��6   $��0��6.   ��5      �� 5      $	 0,0&�6*   $ 1,0.7&�6;   .��5       � $ #281663��6'   $ 0Q�67   � 5!      $ #231457��6'   $ 1Q�67   5"      5$      �� 5'      $ 0,0,0,0��6   $��1��6,   ��5(      �� 5)      $	 0,0&�6*   $ 1,0.7&�6;   .��5*      � $ #281663��6'   $ 0Q�67   � 5+      $ #231457��6'   $ 1Q�67   5,      ._�5.      �� -   5        
 ��Name$
 	txtNodify��5/   h   $��Add Successfully!��5.      
��� ���$��18(�6M   $��Medium"�6[   $��
Montserrat)�5/       $��	0,35,0,10q�68   $��Center=�6K   6h   50      �� 52      $ 	0,0,10,10��6   $��2��6.   ��53      �� 54      $	 1,1&�6*   $	 0,0&�6;   .��55      � $ #0a0441��6'   $ 0Q�67   � 56      $ #1d114e��6'   $ 1Q�67   57      ._�5:      �� -   5         ��Name$ btnShut��5:      $��0q�6+   $��CLOSE��6?   
�������$��13(�5;   0   $��
Montserrat)�6>    � Cursor$
 Hand��6V   $��2��5<      $��0,0,0,0q�6-   ��5=      �� 5>       �� 
TargetType" ��6    .�5?      ��  �� Property � �� �� Value
 ��p��6;    �� Triggers 5@      P� 5A   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5B   &   ��  � �� �#C62DAE6C   5C   #   5E      ��5G      �� 5H       �� 
TargetType" ��6*   .R�5I      �� $��90��6%   $��27��60   $ 20��6<   #��z��6N   ._�5J   "   �� $��Center=�63   $��Center=�6N   5K      5L      5N      5O      5R      5S      5T      