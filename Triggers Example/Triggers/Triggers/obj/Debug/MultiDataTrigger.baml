   M S B A M L   `   `   `  ����C  ?Triggers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TriggersTriggers  5   	       Triggers.MultiDataTrigger   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Triggers     5   	   -   5          �Name$  window1��5   #   $	��450��6
   $	��800��6    � 	Resources 5
      ��%    5      ��5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property � �� �� Value
 � ���6+   �� 5       �@�Title$ Welcome��6&    �� Triggers 5      ^� 5       ^� 
Conditions 5      �� 5       �� Binding 6$   ��  �� ElementName$	 RT1��	 �� Path$
	 Text�
 �� Value	
 Hello6S   �� 5       6$   �� $	 RT2��$
	 Text�
 WPF6S   0�5      �� 5       � ��
 �  ��67   �� 5       �@�Title$$ MultiDataTrigger was Activated��62   5      5      .��5"      � .+�5#   
   ��  �� Orientation$ 
Horizontal=�6   .+�5'      �� -   5         ��Name$	 RT1��5'      $��10q�6#   $	��300��6/   $��50��6;   $��Center=�6G   $��Center=�6b   �� 5+      -   5        $	 RT2��5+      $��10q�6#   $	��300��6/   $��50��6;   $��Center=�6G   $��Center=�6b   5B      5D      5G      