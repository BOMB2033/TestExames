   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5          WpfApp2.SalesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp2     5      -   5          N� Title$  	SalesPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataGrid1��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5      $ Наименование��6%    6;   �� *Name+  5      $ Цена��6%    63   �� *Cast+  5      $ Колличество��6%    6:   �� *Count+  5      $ Поставщик��6%    68   �� *Postav+5      �� 5   
   	 �� Orientation$	 
Horizontal=�6   $��Center=�6.   $��Center=�6K   $��1��6f   .+�5      �� -   5        
 ��Name$
 btnAdd��5      $��Добавить��6%   $��5q�6M   $	��150��6X   $��30��6d   �� 5      -   5        $
 btnEdit��5      $ ��Редактировать��6&   $��5q�6T   $	��150��6_   $��30��6k   �� 5       -   5        $
 btnDelet��5       $��Удалить��6'   $��5q�6P   $	��150��6[   $��30��6g   �� 5!      -   5        $
 btnExit��5!      $��
Назад��6&   $��5q�6L   $	��150��6W   $��30��6c   5"      �� 5$   
   $	 Vertical=�6   $��Center=�6,   $��Center=�6I   $��0��6d   $��1��6q   .+�5%      �� -   5         ��Name$ textBoxSearch��5%      $��5q�6-   $��30��68   $	��150��6D   �� 5&      -   5        $
 	btnSearch��5&      $��
Посик��6(   $��5q�6P   $	��150��6[   $��30��6g   �� 5'      -	   5         ��Name$ ComboBoxSort��5'      $��5q�6^   $	��150��6i   $��30��6u   5(      5*      5+      