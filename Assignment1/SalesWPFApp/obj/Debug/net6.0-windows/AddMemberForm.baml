   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.AddMemberForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   'localclr-namespace:SalesWPFApp   5   	   X	 TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp 	 61     � Title$  AddForm��5	   	   $	��650��6   $	��500��6&    � WindowStartupLocation$ CenterScreen=�62    � WindowStyle$
 None=�5
   	   
������  � AllowsTransparency$
 True��65   .��5      ��  �� CornerRadius$ 10��6   $��1q�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #462AD8��6    � Offset$ 0Q�6/   � 5      $ #DA34AE��6   $
 0.75Q�6/   � 5      $ #8A16C1��6   $ 1Q�6/   5      ._�5   
   � 	 � RowDefinitions	 5      �� 5      $��20 �6    �� 5      $	��100 �6    �� 5      $��* �6    .+�5      �� $ 	10,10,0,0��6   $��0��6.   ��5      �� 5       $	 0,0&�6*   $ 1,0.7&�6;   .��5!      � $ #281663��6'   $ 0Q�67   � 5"      $ #231457��6'   $ 1Q�67   5#      ._�5%      �� -   5        
 ��Name$
 btnClose��5%      $��Right=�6,   $��0,0,4,0q�6H   
 � Tag$ PaleVioletRed��5&   !   
������ 
��� ���.��5'      ! 	 FontAwesome.Sharp.IconImage  � 	 �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6#    
  closeX#��[  60   5(      5)      �� 5,      $ 0,0,0,0��6   $��1��6,   ��5-      �� 5.      $	 0,0&�6*   $ 1,0.7&�6;   .��5/      � $ #281663��6'   $ 0Q�67   � 50      $ #231457��6'   $ 1Q�67   51      ._�53      �� $��
ADD MEMBER��6   
��� ���$��50(�6F   $��Medium"�6T   $��
Montserrat)�54       $��	0,35,0,10q�68   $��Center=�6K   55      �� 57      $ 	0,0,10,10��6   $��2��6.   ��58      �� 59      $	 1,1&�6*   $	 0,0&�6;   .��5:      � $ #0a0441��6'   $ 0Q�67   � 5;      $ #1d114e��6'   $ 1Q�67   5<      ._�5>      �� $	��300��6    �� Orientation$ Vertical=�6)   $��0,50,0,0q�6@   $��2��6R   .+�5@      �� $��Email��6    
�������$��15(�6C   $��Medium"�6Q   $��
Montserrat)�5A       $��	37,10,0,0q�68   �� 5B      $��	0,0,270,0q�6     colorButton#��[ 6/   .��5C      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ EmailBox=�60   $��20��6@   $��20��6K   5D      �� 5E      -   5         ��Name$ txtEmail��5E      
�������$��25(�6C   $��Medium"�6Q   $��
Montserrat)�5F       $��	0,-30,0,0q�68   $��35,0,0,0q�6K    �� 
CaretBrush
 �����
�������$��0,0,0,1q�5G   L   $��30��5H      $��Center=�6*   
������ .��5I      5J      �� 5L      $��Company Name��6    
�������$��15(�6J   $��Medium"�6X   $��
Montserrat)�5M       $��	37,10,0,0q�68   �� 5N      $��	0,0,270,0q�6   #��[ 6/   .��5O        $
 Home=�60   $��20��6=   $��20��6H   5P      �� 5Q      -   5        $ 
txtCompany��5Q      
�������$��25(�6E   $��Medium"�6S   $��
Montserrat)�5R       $��	0,-30,0,0q�68   $��35,0,0,0q�6K   
 �����
�������$��0,0,0,1q�5S   L   $��30��5T      $��Center=�6*   
������ .��6_   5U      �� 5W      $
��City��6    
�������$��15(�6B   $��Medium"�6P   $��
Montserrat)�5X       $��	37,10,0,0q�68   �� 5Y      $��	0,0,270,0q�6   #��[ 6/   .��5Z        $
 City=�60   $��20��6<   $��20��6G   5[      �� 5\      -   5        $ txtCity��5\      
�������$��25(�6B   $��Medium"�6P   $��
Montserrat)�5]       $��	0,-30,0,0q�68   $��35,0,0,0q�6K   
 �����
�������$��0,0,0,1q�5^   L   $��30��5_      $��Center=�6*   
������ .��6_   5`      �� 5b      $��Country��6    
�������$��15(�6E   $��Medium"�6S   $��
Montserrat)�5c       $��	37,10,0,0q�68   �� 5d      $��	0,0,270,0q�6   #��[ 6/   .��5e        $ Mapbox=�60   $��20��6?   $��20��6J   5f      �� 5g      -   5        $ 
txtCountry��5g      
�������$��25(�6E   $��Medium"�6S   $��
Montserrat)�5h       $��	0,-30,0,0q�68   $��35,0,0,0q�6K   
 �����
�������$��0,0,0,1q�5i   L   $��30��5j      $��Center=�6*   
������ .��6^   5k      �� 5m      $��Password��6    
�������$��15(�6F   $��Medium"�6T   $��
Montserrat)�5n       $��	37,10,0,0q�68   �� 5o      $��	0,0,270,0q�6   #��[ 6/   .��5p        $ Onepassword=�60   $��20��6D   $��20��6O   5q      �� 5r      -   5        $ txtPassword��5r      
�������$��25(�6F   $��Medium"�6T   $��
Montserrat)�5s       $��	0,-30,0,0q�68   $��35,0,0,0q�6K   
 �����
�������$��0,0,0,1q�5t   L   $��30��5u      $��Center=�6*   
������ .��6_   5v      �� 5x      -   5        $
 btnAdd��5x      $��0q�6.   $	��ADD��6B   
�������$��20(�5y   0   $��
Montserrat)�6>    � Cursor$
 Hand��6V   $��2��5z      $��0,60,0,0q�6-   ��5{      �� 5|       �� 
TargetType" ��6$   .�5}   "   ��  �� Property � �� �� Value �#C62DAE6?    �� Triggers 5~   "   P� 5   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5�   *   ��  � ��
 ��p��6G   5�   '   5�      ��5�      �� 5�       �� 
TargetType" ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��6A   #��z��6S   ._�5�   &   �� $��Center=�67   $��Center=�6R   5�   #   5�      5�      5�      5�      5�      5�      5�      