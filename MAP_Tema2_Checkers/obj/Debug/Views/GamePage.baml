   M S B A M L   `   `   `  ����M  IMVP_Tema2_Checkers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MAP_Tema2_Checkers.ViewsMAP_Tema2_Checkers.Views  5      M+clr-namespace:MAP_Tema2_Checkers.ViewModelsMAP_Tema2_Checkers.ViewModels  5      '    !MAP_Tema2_Checkers.Views.GamePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:MAP_Tema2_Checkers.Views     5      :vm+clr-namespace:MAP_Tema2_Checkers.ViewModels     5        N� Title$  GamePage��5
       N� 
Background �#2c3e50 � DataContext 5      .  (MAP_Tema2_Checkers.ViewModels.GamePageVM  5   
    � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   $��Center=�6%   .+�5      �� $��65��6E   $��65��6P   $��Uniform=�6\   ��6   �� *GameVM.Game.Player.PieceImage+6\   �� 5      $��About��6     
MenuButton#���  6%   ��6J   �� *AboutPageCommand+�� 5      $��New Game��6   #���  6(   ��6M   �� *NewGameCommand+��6p   �� *GameVM.Game+�� 5      $
��Save��6   #���  6$   ��6I   �� *SaveCommand+��6i   �� *GameVM.Game+�� 5      $
��Load��6   #���  6$   ��6I   �� *LoadCommand+��6i   �� *GameVM.Game+�� 5      $
��Exit��6   #���  6$   ��6I   �� *CloseWindowCommand+�� 5       $��Center=�6    �� Orientation$ 
Horizontal=�66   $��10q�6O   .+�5!      �� $��0,5,10,5q�6    d� 	IsChecked 6-   �� *GameVM.Game.MultipleJump+��6\   �� *MultipleJumpCommand+ � LayoutTransform 5"      �� 5#       �� ScaleX$ 2Q�6)   	 �� ScaleY$	 2Q�64   5%      �� 5&      $��Multiple jump��6   $��28(�61   
�������6?   5'      �� 5(      $��Center=�6   $��28(�6z   
���������65   �� *GameVM.Game.RedPieces+
 �� StringFormat$
 Red pieces: {0}��6�   �� 5)      $��Center=�6   $��28(�6~   
���������65   �� *GameVM.Game.BlackPieces+$
 Black pieces: {0}��6�   5*      � 5+   
   $��1��6   $��20q�6   ���#2c4e3a.+�5,      �� $��10q�6   ���#333333$��Center=�6@   $��Center=�6[   ._�5-      �� -   5         ��Name$ BoardControl��5-      ��65   �� *GameVM.GameBoard+��5.      �� 5/      .R�50      �� ��6+   �� ��51   "   �� 52   &   .R�53   *   �  � Orientation$ 
Horizontal=�64   54   '   ��56   "   �� 57   &   .R�58   *   �� $��80��6�   $��80��6�   ��61   �� *CellObj.TileColor+��6Z   �� *MoveCommand+��6z   �� *	CellObj+.��59   .   � .+�5:   2   �� $��3q�6g   ��68   �� *CellObj.PieceSet.PieceImage+6g   �� 5;   2   $��2q�69   ���#77ff00y�6c   �� *CellObj.Selected+ �� 	Converter# [  5<   /   5=   +   5>   '   5@      5A      5C      5D      5E      5F      5G      