   M S B A M L   `   `   `  ����J  FLibrary Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_ManagerLibrary_Manager  5      ,    &Library_Manager.Pages.Admin.AdminBooks   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Library_Manager     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ 
Adminbooks��5      .��5      �  � RowDefinitions 5   
   �� 5      $��0.20* �6   �� 5      $��0.10* �6   �� 5      .+�5   
   �� $��Center=�6   .+�5      �� .+�5      ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Center=�6V   $��20 10q�6q   $��Books��6�   �� 5      -   5          MaterialDesignIconButton#��[ 5   %   $��40��5   %   $��40��5   %   $��
2 -50 10 0q�5    %   $��Right=�5!   %   ���#834fdb$��Center=�5#   %   .��5$      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	PlusThick=�5%   !   5&      5'      �� 5(      $
��20 0q�6   �� 5)      $��1��6   5*      �� 5+   
    �� Orientation$ 
Horizontal=�6   $
��10 0q�5,      $��Bottom=�5-      ���#F4F4F6$��1��5/      .+�50      �� $��	Book Name��6   $	��120��6)   $��10q�65   $��15(�6A   �� 51      $��Author��6   $	��120��6&   $��10q�62   $��15(�6>   �� 52      $��Genre��6   $	��120��6%   $��10q�61   $��15(�6=   �� 53      $��Print Number��6   $	��150��6,   $��10q�68   $��15(�6D   �� 54      $��Count��6   $	��120��6%   $��10q�61   $��15(�6=   55      �� 56   
   $
��10 0q�6   $��1��6"   $��Bottom=�6/   �� 57   
   $��2��6   .��58      �� ��6   �� *books+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=���59      �� 5:      .R�5;      � $
��20 0q�6   
 � ColumnDefinitions
 5<      �� 5=   "   $	��140 �63   �� 5>   "   $	��140 �63   �� 5?   "   $	��140 �63   �� 5@   "   $	��170 �63   �� 5A   "   $	��120 �63   .+�5C      �� $��0��6(   $
��0 10q�6N   $��12(�6\   ��68   �� *Name+6\   �� 5D      $��1��6(   $
��0 10q�6P   $��12(�6^   ��68   �� *Author+6^   �� 5E      $��2��6(   $
��0 10q�6O   $��12(�6]   ��68   �� *Genre+6]   �� 5F      $��3��6(   $
��0 10q�6U   $��12(�6c   ��68   �� *PrintNumber+6c   �� 5G      $��4��6(   $
��0 10q�6O   $��12(�6]   ��68   �� *Count+6]   5H      5I      5K      5L      5M      5N      