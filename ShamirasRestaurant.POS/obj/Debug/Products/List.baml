   M S B A M L   `   `   `  ����Q  MShamirasRestaurant.POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ShamirasRestaurant.POS.ProductsShamirasRestaurant.POS.Products  5   	   *    $ShamirasRestaurant.POS.Products.List   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ShamirasRestaurant.POS.Products     5   	     � Title$
  List��5   	   $��413.8��6   $��786.4��6%   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grList��5
      $
��Left=�6#   $	��242��6>   $��	23,74,0,0q�6K   $	��Top=�6^   $	��743��6v      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   .   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *Name+6.     5      $ Price��6%   $ * 5   /    6   �� *Price+6/   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      5      5      5      �� 5   
   -   5        	 ��Name$	 btnLast��5      $��>|��6"   $
��Left=�62   $��731,323,0,0q�6M   $	��Top=�6b   $��34��6z   $��54��6�   $��22(�6�   6�   �� 5   
   -   5        $	 btnNext��5      $��>��6"   $
��Left=�61   $��691,323,0,0q�6L   $	��Top=�6a   $��34��6y   $��54��6�   $��22(�6�   6�   �� 5   
   -   5        $	 btnPrev��5      $��<��6"   $
��Left=�61   $��537,323,0,0q�6L   $	��Top=�6a   $��36��6y   $��54��6�   $��22(�6�   6�   �� 5   
   -   5        $	 btnFirst��5      $��|<��6#   $
��Left=�63   $��497,323,0,0q�6N   $	��Top=�6c   $��36��6{   $��54��6�   $��22(�6�   6�   �� 5   
   -   5        
 ��Name$
 lblPages��5      $��page X of Y��6"   $
��Left=�68   $��577,337,0,0q�6S   $	��Top=�6h    J� RenderTransformOrigin$ -2.079,-0.173&�6�   $	��108��6�   $��Center=�6�   $��Italic$�6�   �� 5   
   -   5         ��Name$ cboSortOrder��5      $
��Left=�6)   $��
100,47,0,0q�6D   $	��Top=�6X   $	��120��6p   6|   �� 5   
   -   5        $
 
lblResults��5      $"��Search Result : Z Categories��6$   $
��Left=�6K   $��
23,321,0,0q�6f   $	��Top=�6z   $ -2.079,-0.173&�6�   $	��183��6�   �� 5    
   -	   5        $
 lblPageSize��5       $��	Page size��6%   $
��Left=�69   $��
23,352,0,0q�6T   $	��Top=�6h   $ -2.079,-0.173&�6�   $��60��6�   �� 5!   
   -
   5         ��Name$ txtPageSize��5!      $
��Left=�6'   $��23��6B   $��131,354,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $��3��6w   $	��Top=�6�   $��20��6�   $ 14.2,-7.043&�6�   6�   �� 5"   
   -   5        $
 lblSort��5"      $��
Sort Order��6!   $
��Left=�66   $��	23,43,0,0q�6Q   $	��Top=�6d   $��72��6|   �� 5#   
   -   5        $ 	txtSearch��5#      $
��Left=�6%   $��23��6@   $��
565,11,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5$   
   -   5        $	 	btnSearch��5$      $��Search��6$   $
��Left=�65   $��
691,13,0,0q�6P   $	��Top=�6d   $��75��6|   $ 0.169,0.183&�6�   6�   �� 5%   
   -   5        $
 lblTitle��5%      $��Products��6"   $
��Left=�65   $��	23,10,0,0q�6P   $	��Top=�6c   $	��510��6{   $
��Bold"�6�   $��18(�6�   5'      5(      