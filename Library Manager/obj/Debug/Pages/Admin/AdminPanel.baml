   M S B A M L   `   `   `  ����J  FLibrary Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_ManagerLibrary_Manager  5           Library_Manager.AdminPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Library_Manager     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�6,   $	��600��5      $
��1200��6    � 
ResizeMode$ NoResize=�6!    � Title$ 
AdminPanel��5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��0.08* �6    �� 5       � ColumnDefinitions 5      �� 5      $
��153* �6#   �� 5      $
��647* �6#   .+�5      � -   5        $��0��5      ���#673ab7$��2��65    5      �� 5       $
��736* �6'   �� 5!      $	��33* �6'   �� 5"      $	��33* �6'   .+�5$      � $��2��6   .+�5%      �� -   5         ��Name$ 	close_btn��5%        MaterialDesignIconButton#��[ 60   	 � ToolTip$	 MaterialDesignIconButton��6b   
�������$��Center=�6�   $��Center=�6�   .��5&      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Power=�62   5'      5(      '  !MaterialDesignThemes.Wpf.PopupBox  5)      $��1��6*   
�������   PlacementMode$ BottomAndAlignRightEdges=�6M      PopupContent. 5*      �� $	��200��6!   .+�5+      �� -   5        $ logout��5+   S     MaterialDesignFlatButton#��[ 6!   $��Log Out��6w   5,      5-      5.      � 5/      $��1��6   ���#eceff1 50      �� 51      $	��90* �6$   �� 52      $	��30* �6$   �� 53      $	��30* �6$   �� 54      $	��30* �6$   �� 55      $	��30* �6$   �� 56      $
��188* �6$   �� 57      $	��19* �6$   .+�59      � ���#ffffff 5:      �� 5;      $	��76* �6(   �� 5<      $	��25* �6(   .+�5>      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6/   $��Stretch=�6C   .��5?        $
 Library=�62   ���#1c313a$��Center=�6V   $��Center=�6q   $��45��6�   $��45��6�   5@      �� 5A      $��1��6    $��Rayo Libray��6-   $��Center=�6@   $��Center=�6]   5B      �� 5C      $��1��6   $��Center=�6*    �� Orientation$ 
Horizontal=�6E   .+�5D      �� -   5        #��[ 5D      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   .��5E      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5F        $

 Home=�66   $
��10 0q�6B   $
��Left=�6P   $��Center=�6k   ���#1c313a6�   �� 5G       " MaterialDesignCaptionTextBlock#��[ 6(   $
��Home��6`   $��Center=�6l   $
��Left=�6�   5H      5I      5J      �� 5K      $��2��6   $��Center=�6*   $ 
Horizontal=�6E   .+�5L      �� -   5        #��[ 5L      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   $
��Left=�6�   .��5M      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5N        $

 User=�66   $
��10 0q�6B   $��Right=�6P   $��Center=�6l   ���#1c313a6�   �� 5O      #��[ 6(   $��	Employees��6`   $��Center=�6q   5P      5Q      5R      �� 5S      $��3��6   $��Center=�6*   $ 
Horizontal=�6E   .+�5T      �� -   5        #��[ 5T      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   $
��Left=�6�   .��5U      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5V        $

 Book=�66   $
��10 0q�6B   $��Right=�6P   $��Center=�6l   ���#1c313a6�   �� 5W      #��[ 6(   $��Books��6`   $��Center=�6m   5X      5Y      5Z      �� 5[      $��4��6   $��Center=�6*   $ 
Horizontal=�6E   .+�5\      �� -   5        #��[ 5\      $	��-10q�6O   $��Center=�6]   ���#1c313a$	��230��6�   $
��Left=�6�   .��5]      �� $ 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $	��215��6t   .+�5^        $
 Money100=�66   $
��10 0q�6F   $��Right=�6T   $��Center=�6p   ���#1c313a6�   �� 5_      #��[ 6(   $��Budget��6`   $��Center=�6n   5`      5a      5b      �� 5c      $��6��6   $��Version 1.0.0��6)   $��9(�6>   $��Center=�6K   5d      � 5e      $��1��6   $��1��6    .+�5f      #  MaterialDesignThemes.Wpf.Card  $��15 15q�6&   .��5g       � -   5          �Name$ 
adminFrame��5g        � NavigationUIVisibility$ Hidden=�60   5h      5i      5j      5k      5l      