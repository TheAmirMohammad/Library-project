   M S B A M L   `   `   `  ����J  FLibrary Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_ManagerLibrary_Manager  5      2    ,Library_Manager.Pages.Employee.EmployeeBooks   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Library_Manager     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ books��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.9* �6   .+�5   
   �� $��Center=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  $  MaterialDesignHeadline5TextBlock#��[ 6   $��Center=�6V   $��20 10q�6q   $
��Book��6�   5      �� 5      $
��20 0q�6   5      �� 5    
   $ 
Horizontal=�6   $��1��6.   $��Center=�6;   $
��20 0q�6V   .+�5!      �� -   5         ��Name$ FilterChips��5!   V    * &MaterialDesignChoiceChipPrimaryListBox#��[ 6   .@�5"      �� -   5         ��Name$ AllBooks��5"      	 �� 
IsSelected	 . $��	All Books��6B   �� 5#      -   5        $ BorrowedBooks��5#      $��Borrowed Books��65   �� 5$      -   5        $ AvailableBooks��5$      $��Available Books��66   5%      5&      �� 5'   
   $ 
Horizontal=�6   $
��10 0q�5(      $��Bottom=�5)      ���#F4F4F6$��2��5+      .+�5,      �� $��	Book Name��6   $	��120��6)   $��10q�65   $��15(�6A   �� 5-      $��Author��6   $	��120��6&   $��10q�62   $��15(�6>   �� 5.      $��Genre��6   $	��120��6%   $��10q�61   $��15(�6=   �� 5/      $��Print Number��6   $	��150��6,   $��10q�68   $��15(�6D   �� 50      $��Count��6   $	��120��6%   $��10q�61   $��15(�6=   51      �� 52   
   $
��10 0q�6   $��1��6"   $��Bottom=�6/   �� 53   
   $��3��6   .��54      �� ��6   �� *books+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���55      �� 56      .R�57      � $
��20 0q�6    � ColumnDefinitions 58      �� 59   "   $	��140 �63   �� 5:   "   $	��140 �63   �� 5;   "   $	��140 �63   �� 5<   "   $	��170 �63   �� 5=   "   $	��120 �63   .+�5?      �� $��0��6(   $
��0 10q�6N   $��12(�6\   ��68   �� *Name+6\   �� 5@      $��1��6(   $
��0 10q�6P   $��12(�6^   ��68   �� *Author+6^   �� 5A      $��2��6(   $
��0 10q�6O   $��12(�6]   ��68   �� *Genre+6]   �� 5B      $��3��6(   $
��0 10q�6U   $��12(�6c   ��68   �� *PrintNumber+6c   �� 5C      $��4��6(   $
��0 10q�6O   $��12(�6]   ��68   �� *Count+6]   5D      5E      5G      5H      5I      5J      