   M S B A M L   `   `   `  ����  SalesWPFApp    SalesWPFApp.App   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        �� 	Resources  5       �� MergedDictionaries �� Source �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType	 ��Name
 J� SnapsToDevicePixels �Name J� Opacity � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName �� Padding ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column  ��Name! �� CanContentScroll" ��Name# �� ScrollableHeight$ � Maximum% �� Orientation& �� ViewportHeight' �� ViewportSize*( �� #ComputedVerticalScrollBarVisibility) � Value* �� Mode+ �� Mode, �� ScrollableWidth- �� ViewportWidth,. �� %ComputedHorizontalScrollBarVisibility/ �� Triggers0 ]� 
Conditions1 �� Property2 �� Value�� 5   
    5	      �� 5
      $ /Styles/ButtonStyles.xaml?�6%   �� 5      $ /Styles/Color.xaml?�6%   %�  (��       5      $" DataGridSelectAllButtonStyle��"  )'  �    �� 6   " ��6�   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      � .+�5   "   �� $	 Border��6,   #��� ��6<   $

 True��6}   � 5   "   $ Arrow��6*   
���   �$��Right=�6F   $��8,8,3,3q�6b   $
 0.15Q�6s    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5       5      P� 5   "    �@J�IsMouseOver$
 True��6A   . �5   &   �� $ Border��6?   # � ��6S    � ��5   #   P� 5   "    � ��$
 True��6?   . �5   &   �� $ Border��6=   # � ��6Q    � ��5   #   P� 5   "    � {�$ False��6?   . �5   &   �� $ Arrow��6C    � y�$ 	Collapsed=�6V   5   #   5       5"      5#      �� 5$      "  6   .�5%      ��  � ��# � ��6/   �� 5&       � ��# � ��6/   �� 5'       � �� �	#FF688CAF60   �� 5(       � ��$ 1q�64   �� 5)        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�6=   �� 5*       � ��$
 true��6B   �� 5+       �@��PanningMode$
 Both=�6=   �� 5,       �@��IsFlicksEnabled$ False��6;   �� 5-       � �� 5.      �� 5/      "  6*   .R�50      �� #��z��6%   #��z��6O   #��z��6{   # z��6�   $

 True��6�   ._�51   "   �� $ DG_ScrollViewer��6/   $|�false��6H   ��52   &   �� 53   *   " ��6:   .R�54   .   �  55   2   �� 56   6   $
��Auto �6G   �� 57   6   $��* �6G   �� 58   6   $
��Auto �6G    5:   2   �� 5;   6   $
��Auto �6D   �� 5<   6   $��* �6D   �� 5=   6   $
��Auto �6D   .+�5?   2   �� #��Z 69   $|�false��6h   ��6z   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5@   2   $! PART_ColumnHeadersPresenter��6Q   $��1��6v   y�6�   �� *HeadersVisibility+# Z # Z  �� "  �� 5A   2   $!  PART_ScrollContentPresenter��6I   #! z��6n   $��2��6�   $��1��6�   �� 5B   2   $" PART_VerticalScrollBar��6<   $��2��6\   #$ z# 6l   $% Vertical=�6�   $��1��6�   #' z& 6!  #y�z( 6Q  ) 6�   �� *VerticalOffset+$* OneWay=� �� $+ TemplatedParent=�6Q  � 5C   2   $��1��67   $��2��6G    5D   6   �� 5E   :   ��6K   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5F   :   $��* �6K   .+�5H   6   �� $" PART_HorizontalScrollBar��6@   $��1��6b   #$ z, 6r   $% 
Horizontal=�6�   #' z- 6  #y�z. 6L  ) 6�   �� *HorizontalOffset+$* OneWay=� �� $+ TemplatedParent=�6L  5I   3   5J   /   5K   +   .��5M   &   �� #
 z
 65   5N   #   5O      5P      5R      / 5S      ]� 5T      0 5U      �� 5V      1 �@��
IsGrouping$
2 true��6>   �� 5W      "1 �@%�IsVirtualizingWhenGrouping$2 false��6`   ./�5Y      ��  � ��$ false��6J   5Z      5\      5]      5`      