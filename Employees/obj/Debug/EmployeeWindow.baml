   M S B A M L   `   `   `  ����D  @Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Employees	Employees  5   	       Employees.EmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Employees     5   	     � Title$  EmployeeWindow��5   	   $	��200��6    $	��300��6-    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5
   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��
First Name��6   �� 5   
   $��	Last Name��6   $��1��6%   �� 5   
   $��
Department��6   $��2��6&   �� 5    
   $��1��6-   ��6   �� *	FirstName+6-   �� 5!   
   $��1��6,   $��1��6<   ��6   �� *
LastName+6<   �� 5"   
   $��1��62   $��2��6B   ��6   �� *DepartmentName+6B   �� 5$   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��3��6K   $��1��6X   .+�5%      �� -   5         �� 	IsDefault . $��60��5%   ;   $��5q�6I   .��6T   OK6X   �� 5&      	 �� IsCancel	 . $��60��6%   $��5q�63   .��6>   Отмена6F   5'      5)      5*      