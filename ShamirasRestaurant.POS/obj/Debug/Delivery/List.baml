   M S B A M L   `   `   `  ����Q  MShamirasRestaurant.POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ShamirasRestaurant.POS.DeliveryShamirasRestaurant.POS.Delivery  5   	   *    $ShamirasRestaurant.POS.Delivery.List   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ShamirasRestaurant.POS.Delivery     5   	     � Title$
  List��5   	   $��453.095��6   $��792.619��6'   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grList��5
      $
��Left=�6#   $	��242��6>   $��	24,73,0,0q�6K   $	��Top=�6^   $	��743��6v      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Delivery Date��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *	Timestamp+ �� StringFormat$ {0:ddd dd MMMM yyyy}��6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$
 	btnUpdate��6%   .��68   Update6@   5      5        5      	 5      �� 5      .R�5      �� $
 btnConfirmDelete��6%   .��6?   Delete6G   5      5      5      �� 5   
   -   5         ��Name$ lblPages��5      $��page X of Y��6"   $
��Left=�68   $��578,336,0,0q�6S   $	��Top=�6h    J� RenderTransformOrigin$ -2.079,-0.173&�6�   $	��108��6�   $��Center=�6�   $��Italic$�6�   �� 5    
   -   5        $ lblSort��5       $��Sort By��6!   $
��Left=�63   $��	24,42,0,0q�6N   $	��Top=�6a   $��50��6y   �� 5!   
   -   5         ��Name$ cboSortOrder��5!      $
��Left=�6)   $��
209,46,0,0q�6D   $	��Top=�6X   $	��120��6p   6|   �� 5"   
   -   5        $ 
lblResults��5"      $��Search Result : Z Users��6$   $
��Left=�6F   $��
24,320,0,0q�6a   $	��Top=�6u   $ -2.079,-0.173&�6�   $	��183��6�   �� 5#   
   -   5        $ lblPageSize��5#      $��	Page size��6%   $
��Left=�69   $��
24,351,0,0q�6T   $	��Top=�6h   $ -2.079,-0.173&�6�   $��60��6�   �� 5$   
   -   5         ��Name$ txtPageSize��5$      $
��Left=�6'   $��23��6B   $��132,353,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $��3��6w   $	��Top=�6�   $��20��6�   $ 14.2,-7.043&�6�   6�   �� 5%   
   -   5        $
 btnAdd��5%      $��Add Delivery��6!   $
��Left=�68   $��
692,42,0,0q�6S   $	��Top=�6g   $��75��6   $ 0.169,0.183&�6�   6�   5&      5'      