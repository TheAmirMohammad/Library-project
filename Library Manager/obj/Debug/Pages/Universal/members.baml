   M S B A M L   `   `   `  ����J  FLibrary Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_ManagerLibrary_Manager  5      -    'Library_Manager.Pages.Universal.members   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Library_Manager     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ Members��5      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.9* �6   .+�5   
   �� $��Center=�6   $��2��60   $	��0,5q�6D   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5       ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Center=�6V   $��20 10q�6q   $��Members��6�   5!      �� 5"      $
��20 0q�6   5#      �� 5$   
   $ 
Horizontal=�6   $��1��6.   $��Center=�6;   $��20,10q�6V   $��2��6e   .+�5%      �� -   5         ��Name$ FilterChips��5%       * &MaterialDesignChoiceChipPrimaryListBox#��[ 6+   .@�5&      �� -   5        	 ��Name$	 
allMembers��5&   0   
 �� 
IsSelected
 . $��All Members��6D   �� 5'      -   5        $	 
lateReturn��5'   <   $��Late Return Members��6   6<   �� 5(      -   5        $	 lateAccount��5(   =   $��Late Account Members��6   6=   5)      5*      �� 5+   
   $ 
Horizontal=�6   $
��10 0q�5,      $��Bottom=�5-      ���#F4F4F6$��2��5/      .+�50      �� $
��Name��6   $	��200��6$   $��10q�60   $��15(�6<   �� 51      $��Email��6   $	��200��6%   $��10q�61   $��15(�6=   �� 52      $��Phone Number��6   $	��120��6,   $��10q�68   $��15(�6D   53      �� 54   
   $
��10 0q�6   $��2��6"   $��Bottom=�6/   �� 55   
   $��3��6   $��0 0 10 0q�6$   .��56      �� ��6   �� *users+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���57      �� 58      .R�59      �  5:      �� 5;   "   $	��220 �63   �� 5<   "   $	��220 �63   �� 5=   "   $	��200 �63   �� 5>   "   .+�5@      �� $��0��6(   $��20 10q�6N   $��12(�6]   ��68   �� *Name+6]   �� 5A      $��1��6(   $��20 10q�6O   $��12(�6^   ��68   �� *Email+6^   �� 5B      $��2��6(   $��20 10q�6U   $��12(�6d   ��68   �� *PhoneNumber+6d   �� 5C      -   5        $	��100��5C   %   $��0 0 10 0q�61   $��Right=�6C   $��3��6_   $
��Info��6o   6~   5D      5E      5G      5H      5I      5J      