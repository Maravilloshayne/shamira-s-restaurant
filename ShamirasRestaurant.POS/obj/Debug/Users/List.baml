   M S B A M L   `   `   `  ����Q  MShamirasRestaurant.POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ShamirasRestaurant.POS.UsersShamirasRestaurant.POS.Users  5   	   '    !ShamirasRestaurant.POS.Users.List   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ShamirasRestaurant.POS.Users     5   	     � Title$
  List��5   	   $��469.76��6   $��782.4��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgList��5
      $
��Left=�6#   $	��199��6>   $��	49,96,0,0q�6K   $	��Top=�6^   $	��679��6v      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Username��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   4   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *
UserName+64     5      $ 	Firstname��6%   $ * 5   5    6   �� *	FirstName+65     5      $ Lastname��6%   $ * 5   4    6   �� *
LastName+64     5      $
 Role��6%   $ * 5   0    6   �� *Role+60   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� 	 ��Name$	 	btnUpdate��6%   -   5        .��5   P   Update6X   5      5        5       5      �� 5      .R�5      �� $	 btnConfirmDelete��6%   -   5        .��5   ^   Delete6f   5      5!      5#      �� 5$   
   -   5        $	 btnFirst��5$      $��|<��6#   $
��Left=�63   $��224,380,0,0q�6N   $	��Top=�6c   $��43��6{   $��52��6�   6�   �� 5%   
   -   5        $	 btnLast��5%      $��>|��6"   $
��Left=�62   $��522,380,0,0q�6M   $	��Top=�6b   $��43��6z   $��52��6�   6�   �� 5&   
   -   5        $	 btnNext��5&      $��>��6"   $
��Left=�61   $��474,380,0,0q�6L   $	��Top=�6a   $��43��6y   $��52��6�   6�   �� 5'   
   -   5        $	 btnPrev��5'      $��<��6"   $
��Left=�61   $��272,380,0,0q�6L   $	��Top=�6a   $��43��6y   $��52��6�   6�   �� 5(   
   -   5        
 ��Name$
 lblPages��5(      $��Page X of Y��6"   $
��Left=�68   $��320,380,0,0q�6S   $	��Top=�6h   $��52��6�   $	��149��6�   $��Italic$�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   �� 5)   
   -	   5        $
 	lblResult��5)      $��Search Result: Z Users��6#   $
��Left=�6D   $��
49,300,0,0q�6_   $	��Top=�6s   $��39��6�   $��73��6�   �� 5*   
   -
   5        $
 lblPageSize��5*      $��	Page Size��6%   $
��Left=�69   $��
49,345,0,0q�6T   $	��Top=�6h   $��34��6�   $��73��6�   $��14(�6�   �� 5+   
   -   5        $
 lblSort��5+      $��Sort by��6!   $
��Left=�63   $��	49,59,0,0q�6N   $	��Top=�6a   $��32��6y   $��73��6�   �� 5,   
   -   5         ��Name$ txtPageSize��5,      $
��Left=�6'   $��34��6B   $��127,345,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $��29��6�   6�   �� 5-   
   -   5         ��Name$ 	cboSortBy��5-      $
��Left=�6&   $��
127,59,0,0q�6A   $	��Top=�6U   $	��125��6m   $��32��6y   6�   �� 5.   
   -   5        $ cboSortOrder��5.      $
��Left=�6)   $��
257,59,0,0q�6D   $	��Top=�6X   $	��134��6p   $��37��6|   6�   �� 5/   
   -   5        $	 	btnSearch��5/      $��Search��6$   $
��Left=�65   $��
694,10,0,0q�6P   $	��Top=�6d   $��73��6|   $��33��6�   6�   �� 50   
   -   5        $ txtboxSearch��50      $
��Left=�6(   $��33��6C   $��
600,10,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $��94��6�   �� 51   
   -   5        $ cboRole��51      $
��Left=�6$   $��
498,10,0,0q�6?   $	��Top=�6S   $��74��6k   $��33��6v   6�   �� 52   
   -   5        $
 	lblFilter��52      $��Filter��6#   $
��Left=�64   $��
436,10,0,0q�6O   $	��Top=�6c   $��57��6{   $��33��6�   �� 53   
   -   5        $	��Add��53      $
��Left=�6   $��
694,57,0,0q�6:   $	��Top=�6N   $��72��6f    J� RenderTransformOrigin$ 0.553,-0.319&�6q   $��32��6�   6�   54      55      