   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LibraryApp.ViewsLibraryApp.Views  5      #    LibraryApp.Views.AddLivreView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:LibraryApp.Views     5        N� Title$  AddLivreView��5	      .��5      � 
�������.+�5   
   �� $��Center=�6   $��48��62   $	��Top=�6>   $
��1000��6V   ���	#FF5F86706c   �� 5   
   $
��Left=�6   $��
452,53,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��27��6o   $	��118��6{   $��Berlin Sans FB)�6�   $��18(�6�   ���	#FF2E8A31�� 5       � Language$ fr-fr�6   $�Ajouter Livre��6#   5      � 5   
   $��64,85,500,52q�6   .+�5      �� $��Titre :��6   $	��Top=�6'   $
��Left=�6?   $��	25,31,0,0q�6Z   $��16(�6m   �� 5      -   5         ��Name$ TitreTextBox��5      $	��Top=�6,   $
��Left=�6D   $��
204,30,0,0q�6_   $	��200��6s   $��25��6   �� 5      $��Auteur :��6   $	��Top=�6(   $
��Left=�6@   $��	25,66,0,0q�6[   $��16(�6n   �� 5      -   5        $ AuteurTextBox��5      $	��Top=�6-   $
��Left=�6E   $��
205,64,0,0q�6`   $	��200��6t   $��25��6�   �� 5      $��ISBN :��6   $	��Top=�6&   $
��Left=�6>   $��
25,101,0,0q�6Y   $��16(�6m   �� 5      -   5        $ ISBNTextBox��5      $	��Top=�6+   $
��Left=�6C   $��
205,97,0,0q�6^   $	��200��6r   $��25��6~   �� 5      $��Date de Publication :��6   $	��Top=�65   $
��Left=�6M   $��
25,134,0,0q�6h   $��16(�6|   (  "System.Windows.Controls.DatePicker  5       -   5          Name$ DatePublicationDatePicker��5       $	��Top=�6<   $
��Left=�6T   $��206,134,0,0q�6o   $	��199��6�   $��25��6�   �� 5#      $��Quantité Disponible :��6   $	��Top=�65   $
��Left=�6M   $��
25,169,0,0q�6h   $��16(�6|   �� 5$      -   5        $ QuantiteDisponibleTextBox��5$      $	��Top=�69   $
��Left=�6Q   $��206,167,0,0q�6l   $��50��6�   $��25��6�   �� 5'      $��Image :��6   $	��Top=�6'   $
��Left=�6?   $��
25,204,0,0q�6Z   $��16(�6n   �� 5(      $��Sélectionner une Image��6   $	��Top=�66   $
��Left=�6N   $��206,204,0,0q�6i   $	��199��6~   $��25��6�   �� 5+      -   5        $��Enregistrer��5+      $	��Top=�6+   $
��Left=�6C   $��150,247,0,0q�6^   $��90��6s   $��30��6~   
��� � �
�������$��1,1,5,1q�6�   6�   5,      � 5-   
   $��534,85,30,52q�6   .+�5.      &   System.Windows.Controls.DataGrid  -   5          Name$ LivresDataGrid��5.      $��0,1,0,82q�6/      AutoGenerateColumns .  ��6A   �� *Livres+   Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+  51      $ Titre��6)    69   �� *Titre+  52      $ Auteur��6)    6:   �� *Auteur+  53      $
 ISBN��6)    68   �� *ISBN+  54      $ Date de Publication��6)    6G   �� *DatePublication+  55      $ Quantité Disponible��6)    6G   �� *QuantiteDisponible+4  .System.Windows.Controls.DataGridTemplateColumn  56      $ Image��6-   	   CellTemplate	 57      �� 58      .R�59   "   �� $��50��6G   $��50��6R   ��6(   �� *ImageSource+6R   5:      5<      5?      �� 5@      -   5        $��Delete��5@      $	��Top=�6&   $
��Left=�6>   $��256,253,0,0q�6Y   $��90��6n   $��30��6y   
���  ��
�������$��1,1,5,1q�6�   
���   �6�   �� 5A      -	   5        $��Update��5A      $	��Top=�6&   $
��Left=�6>   $��115,253,0,0q�6Y   $��90��6n   $��30��6y   ���	#FF96AB00
�������$��1,1,5,1q�6�   
�������6�   5B      5C      5D      