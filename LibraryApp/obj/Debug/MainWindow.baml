   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryApp
LibraryApp  5   	       LibraryApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryApp     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$ SingleBorderWindow=�6    � Title$ 
MainWindow��5	   	   $	��470��6   $
��1000��6)   $��Rockwell Condensed)�66   .��5      � 
�������.+�5   
   ]� ��.  $��	0,0,500,0q�6*   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF5F8670��6#    � Offset$ 1Q�65   � 5      $ 	#FF2EFA87��6#   $ 0Q�65   5      5      �� 5   
   $��Gestion de bibliothèque��6   $
��Left=�62   $��
570,27,0,0q�6M   $	��Top=�6a   ���	#FF4167514  .System.Windows.Automation.AutomationProperties   HelpText$  ��6�   $��48(�6�   $��Medium&�6�   $��66��6�   $	��413��6�   �� 5   
   $
��Left=�6   $��78��6+   $��
718,93,0,0q�67   $	��Top=�6K   $��84��6c   $��/248928.png��6n   �� 5   
   -   5         ��Name$ UsernameTextBox��5      $��614,194,24,0q�6+   	 �� TextWrapping$
	 Wrap=�6A   $	��Top=�6U   $��31��6n   $��3q�6z   $��16(�6�   
 � Cursor$
 Arrow��6�   $��2,2,2,0q�6�    � 
InputScope$ Default��6�   G� 5   
   -   5         G�Name$ PasswordBox��5      $
��Left=�6+   $��614,252,0,0q�6F   $	��Top=�6[   $��31��6t   $��3q�6�   $��16(�6�   $
 Arrow��6�   $��2,2,2,0q�6�   $ Password��6�   $	��347��6�   �� 5   
   $��Username��6   $
��Left=�6#   $��	528,0,0,0q�6>   $��Center=�6Q   ���	#FF416751$��20(�6�   $��Italic$�6�   $��	ExtraBold"�6�   $��51��6�   $��76��6�   �� 5   
   $��Password��6   $
��Left=�6#   $��528,252,0,0q�6>   $	��Top=�6S   ���	#FF416751$��20(�6�   $��Italic$�6�   $��	ExtraBold"�6�   $��31��6�   $��71��6�   �� 5   
   -   5         ��Name$ IsAdministrator��5      $��Administrator��6,   $��735,346,132,62q�6D   $��20(�6�    d� 	IsChecked 6\   �� *IsAdministrator+6�   �� 5   
   -   5        $��Se connecter��5      $
��Left=�6(   $��654,304,0,0q�6C   $	��Top=�6X   $��31��6p   $	��122��6|   
����������	#FF5F8670���	#FF5F8670$��18(�6�   $��Medium&�6�   $��Heavy"�6�   $
 Cross��6   $��2q�6  6#  �� 5    
   $
��Left=�6   $��781,304,0,0q�6+   $	��Top=�6@   $��18(�6X   $��Italic$�6f   $��	ExtraBold"�6y   $��42��6�   $	��107��6�   .��5!      �� $��Reset Password��6   $��	Underline{�6.   ���	#FF0027BD6J   5"       � 5#   
   -   5          �Name$ 	mainFrame��5#        � NavigationUIVisibility$ Hidden=�6#   6C   5%      5'      