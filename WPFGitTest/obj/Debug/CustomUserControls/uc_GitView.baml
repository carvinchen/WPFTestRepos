   M S B A M L   `   `   `  ����E  AWPFGitTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFGitTest.ModelWPFGitTest.Model  5      ;"clr-namespace:WPFGitTest.ViewModelWPFGitTest.ViewModel  5      .    (WPFGitTest.CustomUserControls.uc_GitView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0Modelclr-namespace:WPFGitTest.Model     5      8	ViewModel"clr-namespace:WPFGitTest.ViewModel     5        � DataContext  5      *   $WPFGitTest.ViewModel.AdressViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $	��280��6*   �� 5      $��* �6   .+�5   
   � -   5         �Name$ GridFolderSelection��5   ?   $��0��6   $��0��6   $��	10 10 0 0q�6,   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ SelectedFolderPath��5      $	��350��66   $��26��6B   $��Path...For ... Test��6N   6k   �� 5      -   5         ��Name$ btnOpenFolder��5      $��35��60   $��26��6;   $��5 0 0 0q�6G   $
��open��6X   6j   5      5      � 5!   
   -   5        $ 	GridArea2��5!   ?   $��0��6   $��1��6   $��	10 10 0 0q�6,   .+�5"      �� $ Vertical=�6   .+�5#      �� $ 
Horizontal=�6   $��0 0 0 10q�66   .+�5$      �� $��	Firstname��6   $��60��60   $��0 0 10 0q�6;   �� 5%      -   5        $ FirstnameTB��5%      $	��320��63   $��26��6?   $��Firstname...��6K   $��Center=�6_   5&      �� 5'      $ 
Horizontal=�6   $��0 0 0 10q�66   .+�5(      �� $��Lastname��6   $��60��6/   $��0 0 10 0q�6:   �� 5)      -   5        $ 
LastnameTB��5)      $	��320��62   $��26��6>   $��Lastname...��6J   $��Center=�6]   5*      �� 5+      $ 
Horizontal=�6   $��0 0 0 10q�66   .+�5,      �� $��Street��6   $��60��6-   $��0 0 10 0q�68   �� 5-      -   5        $ strTB��5-      $	��160��6-   $��26��69   $��	Street...��6E   $��Center=�6V   �� 5.      $��HouseNr.��6   $��60��6/   $��0 0 10 0q�6:   �� 5/      -   5         ��Name$ houseNrComB��5/      $��90��64   $��Center=�6�    �� SelectedItem 6?   �� 	 �� Path$	 SelectedHouseNumber�
 �� Mode$
 TwoWay=���6~   �� $	 ListOfHouseNrLing� �� Text 6�   �� *ListOfHouseNrLing[0]+50      �� 51      $ 
Horizontal=�6   $��0 0 0 10q�66   .+�52      �� $��ZipCode��6   $��60��6.   $��0 0 10 0q�69   �� 53      -	   5        $ 	zipcodeTB��53      $	��130��61   $��26��6=   $��
ZipCode...��6I   $��Center=�6[   �� 54      $
��City��6   $��60��6+   $��0 0 10 0q�66   �� 55      -
   5        $ cityTB��55      $	��120��6.   $��26��6:   $��City...��6F   $��Center=�6U   56      �� 57      $ 
Horizontal=�6   $��0 0 0 10q�66   .+�58      �� $��Country��6   $��60��6.   $��0 0 10 0q�69   �� 59      -   5        $ 	countryTB��59      $	��320��61   $��26��6=   $��
Country...��6I   $��Center=�6[   5:      �� 5;      $ Vertical=�6   $��0 0 10 0q�64   .+�5<      �� $��About��6   $��60��6,   $��0 0 0 5q�67   $
��Left=�6H   �� 5=      $	��390��6   $	��300��6*    �� TextWrapping$
 Wrap=�67   $��Test a text box��6K   6d   5>      5@      5B      � 5D   
   -   5        $ GridAreaRightMiddle��5D   ?   $��1��6   $��1��6   $��	20 10 0 0q�6,   .+�5E      &   System.Windows.Controls.DataGrid  $
��Auto=�6   $
��Auto=�6I      
IsReadOnly .    CanUserResizeRows .     AutoGenerateColumns .  $	��Top=�5F   M   ��6e   �� $	 AdressVMList�   Columns 5H      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Character ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� $	 PlayerID�6a     5J      $
 Name��6)   $ 90 6[    67   �� $	 
PlayerName�6[     5K      $ Gender��6)   $ 60 6_    69   �� $	 PlayerGender�6_     5L      $
 Race��6)   $	 100 6[    67   �� $	 
PlayerRace�6[     5M      $ 
Homeplanet��6)   $ 90 6g    6=   �� $	 PlayerHomeplanet�6g     5N      $ Lifeform��6)   $ 90 6c    6;   �� $	 PlayerLifeform�6c   5Q      5R      5T      5U      