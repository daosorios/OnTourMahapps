   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5	   	   I EProyectoBeLife, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProyectoBeLifeProyectoBeLife 5
   	   !   ProyectoBeLife.AutoRegistro   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   Emah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	   	   (localclr-namespace:ProyectoBeLife  5
   	     N� 
Background
  ����� N� Title$ Acceso��5   	   $	��800��6   $
��1000��6%   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��3* �6    �� 5      $��3* �6    �� 5      $��3* �6    �� 5      $��3* �6    �� 5      $��3* �6    �� 5      $��3* �6    �� 5      $��3* �6    �� 5      $��3* �6    �� 5      $��3* �6    �� 5      $��2* �6    .+�5      � $��0��6   
��� ���$��Stretch=�64    � ColumnDefinitions 5      �� 5       $��1* �6'   �� 5!      $��1* �6'   �� 5"      $��1* �6'   .+�5%      � $��1��6   .+�5&      �� $��Imagen/Logo.png��6   5'      5(      � 5+      $��1��6   $��Stretch=�6!    5,      �� 5-      $��1* �6'   �� 5.      $��1* �6'   �� 5/      $��1* �6'   .+�52      � $��0��6   .+�53      �� $+��%Registrate con tu correo electrónico��6   $��Center=�54      $��Center=�69   $��Normal$�55      
���   �$��16(�6B   56      57      � 59      $��2��6   $��Stretch=�6!    5:      �� 5;      $��1* �6'   �� 5<      $��1* �6'   �� 5=      $��1* �6'   .+�5@      � $��1��6   .+�5A      �� $��Correo electrónico��6   $
��Left=�5B      $	��Top=�67   $��Normal$�5C      
���   �$��14(�6B   �� 5E      -   5         ��Name$ TxbCorreoRegistro��5E      $	��300��69   $��30��6E   $
��Left=�5F      $��Center=�69   
�������6T   5I      5J      � 5L      $��3��6   $��Stretch=�6!    5M      �� 5N      $��1* �6'   �� 5O      $��1* �6'   �� 5P      $��1* �6'   .+�5S      � $��1��6   .+�5T      �� $��Ingresa tu Nombre��6   $
��Left=�5U      $	��Top=�67   $��Normal$�5V      
���   �$��14(�6B   �� 5Y      -   5        $ TxbNombreRegistro��5Y      $	��300��69   $��30��6E   $
��Left=�5Z      $��Center=�69   
�������6T   5\      5]      � 5`      $��4��6   $��Stretch=�6!    5a      �� 5b      $��1* �6'   �� 5c      $��1* �6'   �� 5d      $��1* �6'   .+�5g      � $��1��6   .+�5h      �� $��Ingresa tu Rut��6   $
��Left=�5i      $	��Top=�67   $��Normal$�5j      
���   �$��14(�6B   �� 5m      -   5        $ TxbRutRegistro��5m      $	��300��66   $��30��6B   $
��Left=�5n      $��Center=�69   
�������6T   5p      5q      � 5s      $��5��6   $��Stretch=�6!    5t      �� 5u      $��1* �6'   �� 5v      $��1* �6'   �� 5w      $��1* �6'   .+�5z      � $��1��6   .+�5{      �� $��Ingresa Curso de Alumno��6   $
��Left=�5|      $	��Top=�67   $��Normal$�5}      
���   �$��14(�6B   �� 5�      -   5        $ TxbCursoRegistro��5�      $	��300��68   $��30��6D   $
��Left=�5�      $��Center=�69   
�������6T   5�      5�      � 5�      $��6��6   $��Stretch=�6!    5�      �� 5�      $��1* �6'   �� 5�      $��1* �6'   �� 5�      $��1* �6'   .+�5�      � $��1��6   .+�5�      �� $$��Ingresa Institución de Alumno��6   $
��Left=�5�      $	��Top=�67   $��Normal$�5�      
���   �$��14(�6B   �� 5�      -   5        $ TxbInstituRegistro��5�      $	��300��6:   $��30��6F   $
��Left=�5�      $��Center=�69   
�������6T   5�      5�      � 5�      $��7��6   $��Stretch=�6!    5�      �� 5�      $��1* �6'   �� 5�      $��1* �6'   �� 5�      $��1* �6'   .+�5�      � $��1��6   .+�5�      �� $��Crea una contraseña��6   $
��Left=�5�      $	��Top=�67   $��Normal$�5�      
���   �$��14(�6B   G� 5�      -   5         G�Name$ TxbContraseñaRegistro��5�   "   $	��300��6A   $��30��6M   $
��Left=�6Y   $��Center=�6t   
�������6�   5�      5�      � 5�      $��8��6    5�      �� 5�      $��1* �6'   �� 5�      $��1* �6'   �� 5�      $��1* �6'   .+�5�      � $��1��6   .+�5�      �� -   5         ��Name$ BtAutoRegistrar��5�      
��� ���$	��100��5�      $��30��6)   $��	Registrar��65   $	��Top=�6I   
�������$��14(�5�   0   $��Regular"�6>   6S   5�      5�      5�      5�      5�      