   M S B A M L   `   `   `  ����@  <CS_GO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CS_GOCS_GO  5   	       CS_GO.DevWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:CS_GO     5   	     � Title$1  +Соотношение В/П раундов��5   	   $	��450��6)   $	��800��66    � 	Resources 5	         listMenu��%�   &	        �� 5
   
   .@�5      m� -   5        $��Добавить��5      6)   m� 5      -   5        $��Удалить��5      6(   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   ��  �� DisplayMemberPath$ LastName��5       � ContextMenu# [  5      ��5      �� *Devs+ �� SelectedItem 5      �� *SelectedDev+��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   � 5      $ Black��6#   	 � Offset$	 1Q�61   � 5      $ 	#FFFF2500��6#   $	 0.285Q�65   � 5      $ 	#FFC8D014��6#   $	 0.703Q�65   5      5       �� 5!   
   $��1��6   
 � DataContext
 6%   �� *SelectedDev+��5"      �� 5#      $ 0.5,1&�6&   $ 0.5,0&�67   .��5$      � $ Black��6#   � 5%      $ Black��6#   $	 1Q�61   � 5&      $ 	#FFFFF700��6#   $	 0.277Q�65   � 5'      $ 	#FFC8490C��6#   $	 0.703Q�65   5(      .+�5*      �� $'��!Выигранные раунды��6   
����� �$��Comic Sans MS)�6B   $��15(�6]   �� 5+      
���������6   �� *	FirstName+61   �� 5,      $)��#Проигранные раунды��6   
����� �$��Comic Sans MS)�6C   $��15(�6^   �� 5-      
���������6   �� *
Patronymic+62   �� 5.      $��Всего раундов��6   
����� �$��Comic Sans MS)�6>   $��15(�6Y   �� 5/      
���������6   �� *
LastName+60   50      51      52      