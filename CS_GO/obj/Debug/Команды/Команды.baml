   M S B A M L   `   `   `  ����@  <CS_GO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CS_GOCS_GO  5   	       CS_GO.CommandWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:CS_GO     5   	     � Title$  Команды��5   	   $	��450��6   $	��800��6&    � 	Resources 5	         listMenu��%�   &	        �� 5
   
   .@�5      m� -   5        $��Добавить��5      6)   m� 5      -   5        $��Удалить��5      6(   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   ��  �� DisplayMemberPath$ Title��5       � ContextMenu# [  5      ��5      �� *
Commands+ �� SelectedItem 5      �� *SelectedCommand+��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   � 5      $ Black��6#   	 � Offset$	 1Q�61   � 5      $ 	#FFC31414��6#   $	 0.703Q�65   � 5      $ 	#FFFF9C00��6#   $	 0.276Q�65   5      5       �� 5!   
   $��1��6   ��5"      �� 5#      $ 0.5,1&�6&   $ 0.5,0&�67   .��5$      � $ Black��6#   � 5%      $ Black��6#   $	 1Q�61   � 5&      $ 	#FFFFB700��6#   $	 0.703Q�65   � 5'      $ 	#FFE71B1B��6#   $	 0.276Q�65   5(      .+�5*      �� 
 � DataContext
 6   �� *SelectedCommand+.+�5+      �� $��Название��6   
�������$��Comic Sans MS)�6>   $��15(�6Y   �� 5,      
���������6   �� *Title+61   5-      �� 5.      $ ��Кол-во человек��6   
�������$��15(�6@   $��Comic Sans MS)�6N   �� 5/      $ Title��51      
���������5/      �� *Org+ 50      �� *SelectedCommand.Org+51   1   �� 52      $��Основатели��6   
�������$��Comic Sans MS)�6<   $��15(�6W   �� 53      $ LastName��55      
���������53      �� *Dev+ 54      �� *SelectedCommand.Dev+55   4   56      57      58      