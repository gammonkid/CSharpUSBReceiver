   M S B A M L   `   `   `  ����I  ESensitivityApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SensitivityAppSensitivityApp  5   	       SensitivityApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SensitivityApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� 
���   �$��1q�6%   $
��Left=�69   $	��163��6T   $��
189,46,0,0q�6a   $	��Top=�6u   $	��406��6�   ._�5      ��  �� TextAlignment$ Right=�6f   $��172,61,182,67q�6|   ��6   �� *Value+ �� ElementName$ Slider�� �� UpdateSourceTrigger$ PropertyChanged=�6|   5      �� 5   
   -   5         ��Name$ AdjustSense��5      $
��Left=�6)   $��
287,83,0,0q�6D   $
��Wrap=�6X   $,��&Adjust the sensitivity of this device.��6l   $	��Top=�6�   �� 5   
   $��CheckBox��6   $
��Left=�6&   $��-103,-38,0,0q�6A   $	��Top=�6W   �� 5   
   -   5         ��Name$ Slider��5      $
��Left=�6!   $��259,138,0,0q�6<   $	��Top=�6Q   $��71��6i   $	��240��6u    � Maximum$	 100Q�6�    �� TickPlacement$ BottomRight=�6�    �� TickFrequency$ 10Q�6�   	 �� IsSnapToTickEnabled	 . 6�   5      5      