   M S B A M L   `   `   `  ����J  FLibrary Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_ManagerLibrary_Manager  5      #    Library_Manager.EmployeePanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Library_Manager     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�6,   $	��600��5      $
��1200��6    � 
ResizeMode$ NoResize=�6!    � Title$ EmployeePanel��5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��0.08* �6    �� 5       � ColumnDefinitions 5      �� 5      $
��153* �6#   �� 5      $
��647* �6#   .+�5      � -   5        $��0��5      ���#673ab7$��2��65    5      �� 5       $
��736* �6'   �� 5!      $	��33* �6'   �� 5"      $	��33* �6'   .+�5$      � $��2��6   .+�5%      �� -   5         ��Name$ 	close_btn��5%        MaterialDesignIconButton#��[ 60   	 � ToolTip$	 MaterialDesignIconButton��6b   
�������$��Center=�6�   $��Center=�6�   .��5&      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Power=�62   5'      5(      '  !MaterialDesignThemes.Wpf.PopupBox  5)      $��1��6*   
�������   PlacementMode$ BottomAndAlignRightEdges=�6M      PopupContent. 5*      �� $	��200��6!   .+�5+      �� -   5          MaterialDesignFlatButton#��[ 5+   !   $��Log Out��6h   5,      5-      5.      � 5/      $��1��6   ���#eceff1 50      �� 51      $	��90* �6$   �� 52      $	��30* �6$   �� 53      $	��30* �6$   �� 54      $	��30* �6$   �� 55      $	��30* �6$   �� 56      $	��30* �6$   �� 57      $
��188* �6$   �� 58      $	��19* �6$   .+�5:      � ���#ffffff 5;      �� 5<      $	��76* �6(   �� 5=      $	��25* �6(   .+�5?      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6/   $��Stretch=�6C   .��5@        $
 Library=�62   ���#1c313a$��Center=�6V   $��Center=�6q   $��45��6�   $��45��6�   5A      �� 5B      $��1��6    $��Rayo Libray��6-   $��Center=�6@   $��Center=�6]   5C      �� 5D      $��1��6   $��Center=�6*    �� Orientation$ 
Horizontal=�6E   .+�5E      �� -   5        #��[ 5E      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   .��5F      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5G        $

 Home=�66   $
��10 0q�6B   $
��Left=�6P   $��Center=�6k   ���#1c313a6�   �� 5H       " MaterialDesignCaptionTextBlock#��[ 6(   $
��Home��6`   $��Center=�6l   $
��Left=�6�   5I      5J      5K      �� 5L      $��2��6   $��Center=�6*   $ 
Horizontal=�6E   .+�5M      �� -   5        #��[ 5M      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   $
��Left=�6�   .��5N      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5O        $

 Edit=�66   $
��10 0q�6B   $��Right=�6P   $��Center=�6l   ���#1c313a6�   �� 5P      #��[ 6(   $��Edit profile��6`   $��Center=�6t   5Q      5R      5S      �� 5T      $��3��6   $��Center=�6*   $ 
Horizontal=�6E   .+�5U      �� -   5        #��[ 5U      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   $
��Left=�6�   .��5V      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5W        $

 Book=�66   $
��10 0q�6B   $��Right=�6P   $��Center=�6l   ���#1c313a6�   �� 5X      #��[ 6(   $��Books��6`   $��Center=�6m   5Y      5Z      5[      �� 5\      $��4��6   $��Center=�6*   $ 
Horizontal=�6E   .+�5]      �� -   5        #��[ 5]      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   $
��Left=�6�   .��5^      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5_        $

 User=�66   $
��10 0q�6B   $��Right=�6P   $��Center=�6l   ���#1c313a6�   �� 5`      #��[ 6(   $��Members��6`   $��Center=�6o   5a      5b      5c      �� 5d      $��5��6   $��Center=�6*   $ 
Horizontal=�6E   .+�5e      �� -   5        #��[ 5e      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   $
��Left=�6�   .��5f      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5g        $
 Money100=�66   $
��10 0q�6F   $��Right=�6T   $��Center=�6p   ���#1c313a6�   �� 5h      #��[ 6(   $��Budget��6`   $��Center=�6n   5i      5j      5k      �� 5l      $��7��6   $��Version 1.0.0��6)   $��9(�6>   $��Center=�6K   5m      � 5n      $��1��6   $��1��6    .+�5o      #  MaterialDesignThemes.Wpf.Card  $��15 15q�6&   .��5p       � -	   5          �Name$ employeeFrame��5p        � NavigationUIVisibility$ Hidden=�63   5q      5r      5s      5t      5u      