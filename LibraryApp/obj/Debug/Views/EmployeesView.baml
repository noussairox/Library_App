   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LibraryApp.ViewsLibraryApp.Views  5      $    LibraryApp.Views.EmployeesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:LibraryApp.Views     5        N� Title$  EmployeesView��5	      .��5      � ���#FFFF$��10,0,0,0q�6   .+�5   
   �� $��Center=�6   $��81��62   $	��Top=�6>   $	��990��6V   ���	#FF5F86706b   �� 5   
   $��Center=�6   $��0,17,0,0q�61   $
��Wrap=�6C   $0��*Application de gestion d'une bibliothèque��6W   $	��Top=�6�   $��Pristina)�6�   $��36(�6�   
�������6�   �� 5   
   $��Center=�6   $��	0,100,0,0q�61   $
��Wrap=�6D   $	��Top=�6X   $��	Agency FB)�6p   $��20(�6�   ���	#FF5F8670�� 6�   $�gestion des ��6�   �� 6�    � Language$ fr-fr�6�   $�
employées��6�   �� 6�   �� 6�   $ fr-fr�6�   6  �� 5   
   -   5         ��Name$ 
NomTextBox��5      $
��Left=�6&   $��114,164,0,0q�6A    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��151��6�   $��20��6�   $��2,2,2,2q�6�   �� 5   
   $
��Left=�6   $��116,136,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��	Agency FB)�6p   $��16(�6�   ���	#FF5F8670$��26��6�   $	��115��6�   �� 6�   $ fr-fr�6�   $	�Nom��6�   6�   �� 5   
   -   5        $ PrenomTextBox��5      $
��Left=�6)   $��329,162,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��151��6�   $��22��6�   $��2,2,2,2q�6�   �� 5   
   $
��Left=�6   $��331,134,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��	Agency FB)�6p   $��16(�6�   ���	#FF5F8670$��26��6�   $	��115��6�   �� 6�   $ fr-fr�6�   $�Prenom��6�   6�   �� 5   
   -   5        $ EmailTextBox��5      $
��Left=�6(   $��545,164,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��151��6�   $��20��6�   $��2,2,2,2q�6�   �� 5   
   $
��Left=�6   $��547,136,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��	Agency FB)�6p   $��16(�6�   ���	#FF5F8670$��26��6�   $	��115��6�   �� 6�   $ fr-fr�6�   $�Email��6�   6�   �� 5   
   -   5        $ RoleTextBox��5      $
��Left=�6'   $��743,164,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��151��6�   $��20��6�   $��2,2,2,2q�6�   �� 5   
   $
��Left=�6   $��745,136,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��	Agency FB)�6p   $��16(�6�   ���	#FF5F8670$��26��6�   $	��115��6�   �� 6�   $ fr-fr�6�   $
�Role��6�   6�   �� 5   
   -   5        $��Ajouter��5      $
��Left=�6$   $��272,199,0,0q�6?   $	��Top=�6T   $��36��6l   $��91��6x   
����������	#FF063681���	#FF063681$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6  6+  �� 5   
   -   5        $��Modifier��5      $
��Left=�6$   $��455,199,0,0q�6?   $	��Top=�6T   $��36��6l   $��91��6x   
����������	#FF18A42A���	#FF18A42A$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6  6+  �� 5   
   -   5        $��	Supprimez��5      $
��Left=�6%   $��632,199,0,0q�6@   $	��Top=�6U   $��36��6m   $��91��6y   
����������	#FFE31010���	#FFE31010$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6  6,  &   System.Windows.Controls.DataGrid  5   
   -   5        $��EmployeesDataGrid��5      $��10,250,294,10q�6N   ���	#FFF3F3F3   AutoGenerateColumns .  
������� J� Opacity$	 0.9Q�6�   ��6,   �� *	Employees+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Id+6H     5      $	 Nom��6%   $	 150 6K   	 62   �� *Name+6K     5      $ Prénom��6%   $	 150 6S   	 65   �� *	FirstName+6S     5      $ Email��6%   $	 200 6N   	 64   �� *Email+6N     5       $ Rôle��6%   $	 150 6L   	 63   �� *Role+6L   5"      �� 5$   
   -	   5        $��Exit ��5$      $
��Left=�6!   $��886,366,0,0q�6<   $	��Top=�6Q   $��36��6i   $��91��6u   
����������	#FFE31010���	#FFE31010$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6  6(  �� 5%   
   -
   5        $��Exporter��5%      $
��Left=�6$   $��728,282,0,0q�6?   $	��Top=�6T   $��36��6l   $��90��6x   
����������	#FF3DA491���	#FF3DA491$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6  6+  �� 5&   
   -   5        $��
Actualiser��5&      $
��Left=�6&   $��728,343,0,0q�6A   $	��Top=�6V   $��36��6n   $��90��6z   
�������
���   �
���   �$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6
  6%  �� 5'   
   $
��Left=�6   $��55��6+   $��
911,86,0,0q�67   $	��Top=�6K   $��88��6c   $��/Views/281780-200.png��6n   5)      5*      