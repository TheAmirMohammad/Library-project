   M S B A M L   `   `   `  ����J  FLibrary Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_ManagerLibrary_Manager  5      /    )Library_Manager.Pages.Member.MemberWallet   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Library_Manager     5      b ^SharpVectors.Converters.Wpf, Version=1.7.5.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ 	adminBank��5      .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6   .��5      �  � RowDefinitions 5      �� 5      $
��0.4* �6$   �� 5      $
��2.2* �6$   �� 5      $��1* �6$   .+�5      �� $��Center=�6   .+�5      ��  $  MaterialDesignHeadline5TextBlock#��[ 6    $��Center=�6Z   $��	20 5 10 0q�6u   $��Budget��6�   �� 5      $
��20 0q�6    5        5       $��1��6&   $��40 22 40 30q�63   ���#008F95+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6]   $��0q�6�   .��5!      �� .+�5"      �� $	��900��6$   $	��230��60   ��5#      �� 5$   "    �� 
StartPoint$	 0,0&�66    �� EndPoint$	 1,1&�6G   .��5%   &   � 	 � Color$	 #FF0A6c��63   
 � Offset$	
 0.2Q�6C   � 5&   &   $	 #2D27FF��63   $
 1Q�6C   5'   #   5)      �� 5*      $��
0 -225 0 0q�6%   .+�5+      ��    MaterialDesignBody2TextBlock#��[ 6(   $��Center=�6^   $��	10 5 10 0q�6y   $��Jahed Motlagh��6�   
�������6�   �� 5,       " MaterialDesignCaptionTextBlock#��[ 6(   $��Center=�6`   $��	10 0 10 0q�6{   $��
Melat Bank��6�   
�������6�   �� 5-       # MaterialDesignOverlineTextBlock#��[ 6(   $��Center=�6a   $��	10 5 10 0q�6|   $��6037-3374-3338-3971-1497��6�   
�������6�     5.      $	��400��62   $��70��6>   $��145 -100q�6J    J� Opacity$
 0.15Q�6\   .��5/   "   ��  �� Orientation$ 
Horizontal=�6-   $	��400��6F   $	 0.2Q�6R   .+�50   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CurrencyUsd=�6>   $��Center=�6Q   $��5 5 0 5q�6l   $��60��6}   $��60��6�   ���#834fdb6�   �� 51   &   #��[ 60   $��30(�6h   $��Center=�6v   $	��5 0q�6�   $��40.000.000 T��6�   
����� �6�   52   #   53        54      $��Center=�62   $
��10 0q�6O   $��18q�6^   $ 1Q�6j   .��55   "   �� $ 
Horizontal=�6-   $	��400��6F   .+�56   &     $ CurrencyUsd=�6>   $��Center=�6Q   $��5 5 0 5q�6l   $��60��6}   $��60��6�   ���#834fdb6�   �� 57   &   -   5         ��Name$ 	txtBudget��57   0   #��[ 6C   $��30(�6{   $��Center=�6�   $	��5 0q�6�   $��40.000.000 T��6�   
����� �6�   58   #   59      �� 5:      
�������$��
10 10 10 0q�6;   $
 0.75Q�6O   �� 5;      $ 
Horizontal=�6)   .+�5<   "   �� #��[ 6,   $��Center=�6e   $��	10 5 10 0q�6�   $��	1400/2/15��6�   
�������6�   �� 5=   "   #��[ 6,   $��Center=�6e   $��	80 5 10 0q�6�   $��	Visa Card��6�   
�������6�   5>      5?      5@      5A        5B      $��2��6&   $��40 -10 40 10q�63   .��5C      �  5D      �� 5E      $
��0.6* �6,   �� 5F       � ColumnDefinitions 5H      �� 5I      $
��2.3* �6/   �� 5J      .+�5L      �� $��Center=�6%   .+�5M      �� #��[ 6(   $��Center=�6b   $��	20 5 10 0q�6}   $��Deposit��6�   �� 5N      $
��20 0q�6(   5O      �� 5P      $��1��6%   $ 
Horizontal=�62   $��Center=�6K   $
��Left=�6f   $��
16 -15 5 0q�6�   .+�5Q        $ CurrencyUsd=�66   $��Center=�6I   $��0 5 0 5q�6d   $��30��6u   $��30��6�   ���#834fdb6�   �� 5R      -   5         ��Name$ 	txtAmount��5S      $��Center=�5T       % !MaterialDesignFloatingHintTextBox#��[ 5U      $	��200��5V      $��0 -7 0 0q�5W      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .    
PrefixText$ $��5Y         
SuffixText$ T��5Z      .��6K   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5[   "   �� 5\   &   $ 
Horizontal=�5]   %   $��	-2 -2 0 0q�5^   %   .+�5_   *     $��0 -1 0 0q�6B   $ Money=�5`   )   �� 5a   *   $��Money��5b   )   5c   '   .��5d   B   5e      �� 5f      -   5         $  MaterialDesignRaisedAccentButton#��[ 5g   %   $��20��5h   %   $��60��5i   %   $��15 0 0 0q�5j   %    �� 	IsDefault . $��Bottom=�5l   %   ���#834fdb
�������$��Center=�5o   %   $��9(�5p   %   $��0q�5q   %   $	��ADD��5r   %   5s      5t      >� 5u      $��1��6&   $��2��66   .��5v      (  "SharpVectors.Converters.SvgViewbox     Source$ /Assets/wallet.svg?�6.   $��20 20 10 20q�6J   5w      5x      5y      5z      5|      5}      5~      