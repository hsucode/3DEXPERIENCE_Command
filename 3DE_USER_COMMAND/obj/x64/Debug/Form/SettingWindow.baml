   M S B A M L   `   `   `  ����K  G3DE_USER_COMMAND, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_3DE_USER_COMMAND.Form_3DE_USER_COMMAND.Form  5   	   *    $_3DE_USER_COMMAND.Form.SettingWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_3DE_USER_COMMAND.Form     5   	     � Title$  SettingWindow��5   	   $	��190��6   $	��400��6,    � WindowStyle$
 None=�68    � AllowsTransparency . 
�������.��5
      � $�� 0q�6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6   .+�5   
   � -   5         �Name$ SettingsWindow��5      $��0��6'   ���	#FF005686.+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $��25 �6'   �� 5      $��* �6'   �� 5      $��26 �6'   �� 5      $��10 �6'   .+�5       � $��1��6   $��Center=�6'   $��Center=�6E   .+�5!      �� 
������ $��Medium"�6:   $��0q�6N   
�������$+��%/3DE_USER_COMMAND;component/Font/#3ds)�6m   	Setting5#      5$      � 5&      $��2��6   .+�5'      �� -   5         ��Name$ CloseSettingWindow��5'      $��3q�69      Button_close#��[  6D   6j   5(      5*      5,      � 5-   
   $��1��6   .+�5.      �� $�� 0q�6   $
��Wrap=�6$   $��Version: v1.2��68   $	��366��6M   5/      50      � 51   
   $��2��6   .+�52      �� $�� 0q�6   $
��Wrap=�6$   $(��"Feedback: terrence.hsu@outlook.com��68   $	��366��6b   53      54      � 55   
   $��3��6   .+�56      �� $�� 0q�6   $
��Wrap=�6$   $	��366��69   hf输入命令，选择命令，按回车或者鼠标右击命令行与菜单栏中间的空白区域。58      5:      � 5;   
   $��4��6   .+�5<      �� $�� 0q�6   $
��Wrap=�6$   $	��366��69   " 输入ds是完整命令列表。5>      5?      � 5@   
   $��5��6   .+�5A      �� $�� 0q�6   $
��Wrap=�6$   $	��366��69   nl在使用过程中需要切换模块，受到许可和模块的限制，有些命令您可能调不出来。5C      5D      5F      5H      