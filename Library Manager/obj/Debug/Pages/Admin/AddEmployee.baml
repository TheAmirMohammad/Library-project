   M S B A M L   `   `   `  ����  Library Manager!    Library_Manager.AddEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5	      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ AddEmployee��5      .��5      � 
�������.+�5   
   � $��20 ,0q�6    � RowDefinitions 5      �� 5      $��0.75* �6    �� 5      $
��1.6* �6    �� 5      $
��0.7* �6    �� 5      $
��0.7* �6    �� 5      $
��0.7* �6    �� 5      $
��0.7* �6    �� 5      $
��0.7* �6    �� 5      $
��0.7* �6    .+�5      �� $��Hello, There !��6   $��Center=�5       $��Center=�5!       $  MaterialDesignHeadline4TextBlock#��[ 5"      �� 5%      $��1��6   $	��110��6&   $��5q�62   .+�5&      � ���#eceff1$��80��6-    5'      �� 5(      $��2* �6(   �� 5)      $��1* �6(   .+�5+      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6/   $��Stretch=�6C   .��5,      �� -   5         ��Name$ ProfileImage��5,       $!��/Assets/Profile Default.png��66   $��Stretch=�6[   $��Stretch=�6w   5-      �� 5.      -   5        $��1��5.        MaterialDesignFlatButton#��[ 6*    � ToolTip$ MaterialDesignFlatButton��6\   $��Choose File��6   $��30��6�   6�   5/      50      �� 52      	 �� Orientation$	 Vertical=�6   $	��Top=�53      $��2��54      .+�56      �� -   5        
 ��Name$
 txtName��56      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name��6+    % !MaterialDesignFloatingHintTextBox#��[ 6Q   57      �� 59      $	 Vertical=�6   $	��Top=�5:      $��3��5;      .+�5=      �� -   5        $
 txtEmail��5=      $ Email��6,   #��[ 6S   5>      �� 5@      $	��Top=�6   $��4��61   .+�5A      �  � ColumnDefinitions 5B      �� 5C      $
��auto �6+   �� 5D      .+�5F      �� -   5        $
 txtPreNumber��5F   (   $��98��6   $��Center=�6>   .  (MaterialDesignThemes.Wpf.TextFieldAssist   
PrefixText$ +��6Y   $��0 11.25 0 0q�6�   �� 5G      -   5        $
 txtPhoneNumber��5G   .   $��1��6   $ Phone Number��6F   #��[ 6t   $��10 0 0 0q�6�   5H      5J      �� 5L      $	 Vertical=�6   $	��Top=�5M      $��5��5N      .+�5P      G� -   5         G�Name$ txtPassword��5Q      $ Password��5R         HasClearButton .    
HelperText$ At least 8 characters��5T       ) %MaterialDesignFloatingHintPasswordBox#��[ 5U      5V      �� 5X      $	 Vertical=�6   $	��Top=�5Y      $��6��5Z      .+�5\      �� -   5        $
 	txtSalary��5\      $ Salary��6-   #��[ 6U   5]      �� 5_      -	   5         ��Name$ 	AddButton��5_      $	��Add��6(   $��7��66   $��Center=�6C   $	��100��6`   6l   5a      5b      5c      