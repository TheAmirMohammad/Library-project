   M S B A M L   `   `   `  ����J  FLibrary Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_ManagerLibrary_Manager  5      +    %Library_Manager.Pages.Admin.adminBank   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Library_Manager     5      b ^SharpVectors.Converters.Wpf, Version=1.7.5.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ 	adminBank��5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��0.4* �6    �� 5      $
��2.2* �6    �� 5      $��1* �6    .+�5      �� $��Center=�6   .+�5      ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Center=�6V   $��	20 5 10 0q�6q   $��Budget��6�   �� 5      $
��20 0q�6   5      #  MaterialDesignThemes.Wpf.Card  5      $��1��6"   $��40 22 40 30q�6/   ���#008F95+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6Y   $��0q�6�   .��5       �� .+�5!      �� $
��auto��6    $	��270��6-   ��5"      �� 5#       �� 
StartPoint$	 0,0&�62    �� EndPoint$	 1,1&�6C   .��5$   "   � 	 � Color$	 #FF0A6c��6/   
 � Offset$	
 0.2Q�6?   � 5%   "   $	 #2D27FF��6/   $
 1Q�6?   5&      5(      �� 5)      $��
0 -240 0 0q�6!   .+�5*      ��    MaterialDesignBody2TextBlock#��[ 6$   $��Center=�6Z   $��	10 5 10 0q�6u   $��Jahed Motlagh��6�   
�������6�   �� 5+       " MaterialDesignCaptionTextBlock#��[ 6$   $��Center=�6\   $��	10 0 10 0q�6w   $��
Melat Bank��6�   
�������6�   �� 5,       # MaterialDesignOverlineTextBlock#��[ 6$   $��Center=�6]   $��	10 5 10 0q�6x   $��6037-3374-3338-3971-1497��6�   
�������6�     5-      $	��400��6.   $��70��6:   $��145 -100q�6F    J� Opacity$
 0.15Q�6X   .��5.      ��  �� Orientation$ 
Horizontal=�6)   $	��400��6B   $	 0.2Q�6N   .+�5/   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CurrencyUsd=�6:   $��Center=�6M   $��5 5 0 5q�6h   $��60��6y   $��60��6�   ���#834fdb6�   �� 50   "   #��[ 6,   $��30(�6d   $��Center=�6r   $	��5 0q�6�   $��40.000.000 T��6�   
����� �6�   51      52        53      $��Center=�6.   $
��10 0q�6K   $��18q�6Z   $ 1Q�6f   .��54      �� $ 
Horizontal=�6)   $	��400��6B   .+�55   "     $ CurrencyUsd=�6:   $��Center=�6M   $��5 5 0 5q�6h   $��60��6y   $��60��6�   ���#834fdb6�   �� 56   "   -   5         ��Name$ 	txtBudget��56   ,   #��[ 6?   $��30(�6w   $��Center=�6�   $	��5 0q�6�   $��40.000.000 T��6�   
����� �6�   57      58      �� 59      
�������$��
10 10 10 0q�67   $
 0.75Q�6K   �� 5:      $ 
Horizontal=�6%   .+�5;      �� #��[ 6(   $��Center=�6a   $��	10 5 10 0q�6|   $��	1400/2/15��6�   
�������6�   �� 5<      #��[ 6(   $��Center=�6a   $��	80 5 10 0q�6|   $��	Visa Card��6�   
�������6�   5=      5>      5?      5@        5A      $��2��6"   $��40 -10 40 10q�6/   .��5B      �  5C      �� 5D      $
��0.6* �6(   �� 5E       � ColumnDefinitions 5G      �� 5H      $
��2.3* �6+   �� 5I      .+�5K      �� $��Center=�6!   .+�5L      �� #��[ 6$   $��Center=�6^   $��	20 5 10 0q�6y   $��Deposit��6�   �� 5M      $
��20 0q�6$   5N      �� 5O      $��1��6!   $ 
Horizontal=�6.   $��Center=�6G   $
��Left=�6b   $��
16 -15 5 0q�6}   .+�5P        $ CurrencyUsd=�62   $��Center=�6E   $��0 5 0 5q�6`   $��30��6q   $��30��6|   ���#834fdb6�   �� 5Q      -   5         ��Name$ 	txtAmount��5R      $��Center=�5S       % !MaterialDesignFloatingHintTextBox#��[ 5T      $	��200��5U      $��0 -7 0 0q�5V      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .    
PrefixText$ $��5X         
SuffixText$ T��5Y      .��6K   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5Z      �� 5[   "   $ 
Horizontal=�5\   %   $��	-2 -2 0 0q�5]   %   .+�5^   &     $��0 -1 0 0q�6>   $ Money=�5_   )   �� 5`   &   $��Money��5a   )   5b   #   .��5c   >   5d      �� 5e      -   5         $  MaterialDesignRaisedAccentButton#��[ 5f   %   $��20��5g   %   $��60��5h   %   $��15 0 0 0q�5i   %    � ToolTip$5 /Resource name: MaterialDesignRaisedAccentButton��5j   %   $��Bottom=�5k   %   ���#834fdb
�������$��Center=�5n   %   $��9(�5o   %   $��0q�5p   %   $	��ADD��5q   %   5r      5s      >� 5t      $��1��6"   $��2��62   .��5u      (  "SharpVectors.Converters.SvgViewbox     Source$ /Assets/wallet.svg?�6*   $��20 20 10 20q�6F   5v      5w      5x      5y      5z      5{      