   M S B A M L   `   `   `  ����L  HTemplates Example, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Templates_ExampleTemplates_Example  5   	   "    Templates_Example.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Templates_Example     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
         btntemplate �� 
TargetType A�Name �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName	 �� Property
 �� Value��%�  &	        �� 5   
   " ��6.   .R�5      � .+�5      A� $ ellip��6   #��z��6)   #��z��6M   5      �� 5      $��Center=�6#   $��Center=�6@   5      5       5      ]� 5       5      �� 5       �@J�IsMouseOver . 6;   /�5#      �� 5$      $ ellip��6!   	 � ��

 � ���6D   �� 5%      $ ellip��6!   	 � ��

 � ���6F   5(      5*      5-      .��50      �� .+�51   
   �� -   5         ��Name$
 btn1��51      $
��Home��6   $	��100��6.   $��10q�6�   #��[  6�   
����ح�
����  �$��18(�6�   $
��Bold"�6�   ��6:   ��  �� RelativeSource ��  �� Mode$
 Self=� �� Path$ Width�53      �� 55   
   -   5        $
 btn2��55      $��About��6   $	��100��6/   $��10q�6�   #��[  56      
������
��� d �$��18(�6i   $
��Bold"�6w   ��55   ;   ��  �� $
 Self=�$ Width�58      59      5J      