   M S B A M L   `   `   `  ����J  FLibrary Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_ManagerLibrary_Manager  5      /    )Library_Manager.Pages.Member.MemberMyBook   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Library_Manager     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ Memberbooks��5      .��5      �  � RowDefinitions 5   
   �� 5      $��0.20* �6   �� 5      .+�5   
   �� $��Center=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Center=�6V   $��20 10q�6q   $��My Books��6�   5      �� 5      $
��20 0q�6   5      #  MaterialDesignThemes.Wpf.Card  5   
   $��1��6   $��10q�6+   .��5      �  5       �� 5!      $��0.15* �6$   �� 5"      .+�5$      �� $ 
Horizontal=�6   $
��10 0q�5%      $��Bottom=�5&      ���#F4F4F6$��0��5(      .+�5)      �� $��	Book Name��6    $	��120��61   $��10q�6=   $��15(�6I   �� 5*      $��Author��6    $	��120��6.   $��10q�6:   $��15(�6F   �� 5+      $��Genre��6    $	��120��6-   $��10q�69   $��15(�6E   �� 5,      $��Print Number��6    $	��150��64   $��10q�6@   $��15(�6L   �� 5-      $��Count��6    $��60��6-   $��10q�68   $��15(�6D   5.      �� 50      $
��10 0q�6   $��1��6*   $��Bottom=�67   �� 51      $��1��6   .��52      �� ��6#   �� *books+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���53      �� 54      .R�55   "   � $
��20 0q�6'   	 � ColumnDefinitions	 56   &   �� 57   *   $	��140 �6;   �� 58   *   $	��140 �6;   �� 59   *   $	��140 �6;   �� 5:   *   $	��170 �6;   �� 5;   *   $	��120 �6;   �� 5<   *   .+�5>   &   �� $��0��60   $
��0 10q�6V   $��12(�6d   ��6@   �� *Name+6d   �� 5?   &   $��1��60   $
��0 10q�6X   $��12(�6f   ��6@   �� *Author+6f   �� 5@   &   $��2��60   $
��0 10q�6W   $��12(�6e   ��6@   �� *Genre+6e   �� 5A   &   $��3��60   $
��0 10q�6]   $��12(�6k   ��6@   �� *PrintNumber+6k   �� 5B   &   $��4��60   $
��0 10q�6W   $��12(�6e   ��6@   �� *Count+6e   �� 5C   &   -   5        $��5��5C   -   $��Return��6=   $	��150��5D   -   $��Right=�69   6U   5F   #   5G      5I      5J      5K      5L      5M      5N      