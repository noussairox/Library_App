   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LibraryApp.ViewsLibraryApp.Views  5      !    LibraryApp.Views.LivresView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:LibraryApp.Views     5        N� Title$  
LivresView��5	      .��5      � 
�������.+�5   
   �� $��Center=�6   $��48��62   $	��Top=�6>   $
��1000��6V   ���	#FF5F86706c   �� 5   
   $
��Left=�6   $��
452,53,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��27��6o   $	��118��6{   $��Berlin Sans FB)�6�   $��18(�6�   ���	#FF2E8A31�� 6�    � Language$ fr-fr�6�   $�Liste Des Livres��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ LivresDataGrid��5   /      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly . $��64,85,42,99q�6�      AlternatingRowBackground �#E5E5E5   GridLinesVisibility$	 All=�5   .   	   HorizontalGridLinesBrush	 �#C0C0C0
   VerticalGridLinesBrush
 �#C0C0C0   RowBackground �#F0F0F0   SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   ���#C0C0C0$��1q�6�   ��5   G   �� *Livres+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ Titre��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 64    6@   �� *Titre+  5      $ Auteur��6%   $	 150 65    6A   �� *Auteur+  5      $
 ISBN��6%   $	 150 63    6?   �� *ISBN+  5      $ Date de Publication��6%   $	 150 6B    6N   �� *DatePublication+  5      $ Quantité Disponible��6%   $	 150 6B    6N   �� *QuantiteDisponible+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Image��6)   $	 100 68      CellTemplate 5      �� 5      .R�5      �� $��50��6C   $��50��6N   ��6$   �� *ImageSource+6N   5      5      5       �� 5!   
   -   5        $��Ajouter Livre��5!      $
��Left=�6)   $��515,388,0,0q�6D   $	��Top=�6Y   $��36��6q   $��90��6}   
�������
���   �
���   �$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6  6(  �� 5"   
   -   5        $��
Export_Csv��5"      $
��Left=�6&   $��381,388,0,0q�6A   $	��Top=�6V   $��36��6n   $��90��6z   
����������	#FF2E8A31���	#FF2E8A31$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6  6-  �� 5#   
   -   5        $��
Import_Csv��5#      $
��Left=�6&   $��868,385,0,0q�6A   $	��Top=�6V   $��36��5$   	   $��90��6   
����������	#FF2E8A31���	#FF2E8A31$��2,2,2,2q�5%   	   ��. $��Impact)�6@   $��1,1,10,1q�6T   5&   	   �� 5'   
   -   5        $��PageReservation��5'      $
��Left=�6+   $��
64,388,0,0q�6F   $	��Top=�6Z   $��36��6r   $��90��6~   
�������
���   �
���   �$��2,2,2,2q�6�   ��. $��Impact)�6�   $��1,1,10,1q�6  6)  5*      5+      