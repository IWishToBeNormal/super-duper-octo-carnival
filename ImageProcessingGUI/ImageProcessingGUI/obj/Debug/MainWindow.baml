   M S B A M L   `   `   `  ����M  IImageProcessingGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ImageProcessingGUIImageProcessingGUI  5   	   #    ImageProcessingGUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ImageProcessingGUI     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��4* �6   6*   �� 5      $��70 �6   6*    � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� $��0��6   $��0��6%   .+�5      �� -   5        $��Bilde��5      6#   5      �� 5   
   $��1��6   $��0��6%   $��10q�62   .+�5      �� 
�������$��2q�6(   ._�5      �� -   5        $��Image_results_txt��5      $��Center=�61   $	��150��6N   $	��200��6Z   6i   5      5      �� 5   
   $��1��6   $��1��6%   .+�5      �� -   5        $��	CheckFail��5      $	��100��6&   $��20q�62   $��Check��6>   $��30��6N   
�������6�   5       �� 5"   
   $��0��6   $��1��6%    �� Orientation$ 
Horizontal=�62   .+�5#      �� -   5        $��	file_Path��5#   '   
�������$��Image��68   $��70��6H   $��30��6S   $��Right=�6_   $��20q�6{   6�   �� 5$      -   5        $��File_path_txt��5$      
�������$	��200��6B   $��30��6N   6\   5%      5)      5*      