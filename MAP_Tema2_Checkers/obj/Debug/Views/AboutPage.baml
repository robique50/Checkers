   M S B A M L   `   `   `  ����M  IMVP_Tema2_Checkers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:MAP_Tema2_Checkers.ViewModelsMAP_Tema2_Checkers.ViewModels  5      (    "MAP_Tema2_Checkers.Views.AboutPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :vm+clr-namespace:MAP_Tema2_Checkers.ViewModels     5        N� Title$  	AboutPage��5	       N� 
Background �#2c3e50 � 	Resources 5      3  -System.Windows.Media.Effects.DropShadowEffect   ShadowEffect   
BlurRadius   ShadowDepth   	Direction   Opacity��%Q   &	          5   
   $ 10Q�60   $ 3Q�6@   $	 320Q�6P   $	 0.5Q�6`   5       � DataContext 5      /  )MAP_Tema2_Checkers.ViewModels.AboutPageVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   $��Center=�6%   .+�5      �� $��
About Page��6   	 �� Padding$	 	0,30,0,20q�6*   $��Center=�6>   $��50(�6[   $
��Bold"�6i   
�������6{   �� 5      $
��Game��6     
MenuButton#���  6$   ��6I   �� *GamePageCommand+�� 5      $
��Exit��6   #���  6$   ��6I   �� *CloseWindowCommand+�� 5      $��Center=�6   $��32(�6s   ��65   �� *GameWins.RedWins+
 �� StringFormat$
 Red wins: {0}����6�   �� *
Foreground+�� 5      $��Center=�6   $��32(�6w   ��65   �� *GameWins.BlackWins+$
 Black wins: {0}����6�   �� *
Foreground+5      � 5   
   $��1��6   $��15q�6   ���#2c4e3a J� Effect# �   6@   .+�5       �� $��30q�6   .+�5!      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�66   .+�5"      �� $��Programmer: ��6    ��64   �� *
FontSize+��6R   �� *
Foreground+�� 5#      ��6    �� *
Programmer+��6<   �� *
FontSize+��6Z   �� *
Foreground+5$      �� 5%      $ 
Horizontal=�6   $
��0,10q�66   .+�5&      �� $��Email: ��6    $	��103��6o   ��6/   �� *
FontSize+��6M   �� *
Foreground+6o   �� 5'      $	��721��6w   ��6    �� *Email+��67   �� *
FontSize+��6U   �� *
Foreground+6w   5(      �� 5)      $ 
Horizontal=�6   $
��0,10q�66   .+�5*      �� $��Group: ��6    ��6/   �� *
FontSize+��6M   �� *
Foreground+�� 5+      ��6    �� *Group+��67   �� *
FontSize+��6U   �� *
Foreground+5,      �� 5-      $��Stretch=�6   $
��0,20q�6;   .+�5.      �� $��Description��6    $��Center=�63   ��6P   �� *
FontSize+��6n   �� *
Foreground+�� 5/      $��2q�6   $��5q�6T   # �   6_   ��61   �� *
Foreground+6_   �� 50      $��25(�6=   $
��Wrap=�6K   # �   6�   ��6    �� *Description+��6_   �� *
Foreground+6�   51      52      53      54      55      