   M S B A M L   `   `   `  ����H  DInventory App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RibbonWin	RibbonWin  5   	       RibbonWin.Window2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:RibbonWin     5   	     � Title$  Add partner��5   	   $��215.696��6   $��434.156��6.   .��5	      � $��15q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��ptrname��5      $��1��6   $��	0,1,624,0q�6/   $��2��6B   .��6S   Enter the Partner Name :6m   �� 5   
   -   5        $��
ptrnametxt��5      $��1��6$   $��0��64   $��
204,10,0,0q�6A   $
��Left=�6U   $	��176��6p   $��2��6|   �� 5   
   -   5        $��	ptrnumber��5      $��1��6!   $��	0,5,576,4q�61   $��2��6D   .��6Q   " Enter the Partner Phone Number :6s   �� 5   
   -   5        $��prtnumbertxt��5      $��1��6&   $��0��66   $��
204,10,0,7q�6C   $��2��6W   $
��Left=�6d   $	��176��6   �� 5   
   -   5        $��	ptremailr��5      $��1��6!   $��0,36,616,-27q�61   $��2��6G   .��6T   Enter the Partner Email :6o   �� 5   
   -   5        $��ptremailrtxt��5      $��1��6&   $��0��66   $��204,36,0,-19q�6C   $��2��6Y   $
��Left=�6f   $	��176��6�   �� 5   
   -   5         �� IsCancel . $��60��5   !   $��1��6D   $��135,87,0,-78q�6T   $��2��6j   $
��Left=�6w   $	��102��6�   .��6�   	_Cancel6�   �� 5   
   -   5         ��Name$ btnDialogOk��5   "    �� 	IsDefault . $��60��6Q   $��35,87,0,-78q�6_   $	��_Ok��6t   $��1��6�   $��2��6�   $
��Left=�6�   $��77��6�   5!      5"      