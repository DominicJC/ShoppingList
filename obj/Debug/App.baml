   M S B A M L   `   `   `  ����G  CShoppingList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ShoppingListShoppingList  5      ;"clr-namespace:ShoppingList.HelpersShoppingList.Helpers  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          ShoppingList.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ,localclr-namespace:ShoppingList     5      3help"clr-namespace:ShoppingList.Helpers     5      9System&clr-namespace:System;assembly=mscorlib     5        �� 	Resources  5	         LISTPATH  LASTLISTPATH  	ITEMSPATH  CATEGORIESPATH  DEFAULTCATEGORY  	mainColor �� Color  secondColor  
thirdColor  mainFontColour 	 secondFontColor 
 thirdFontColor  borderColor  mainFont  headerFontSize �� 
TargetType �� Property �� Value  subFontSize?  9ShoppingList.Helpers.StringToShoppingListElementConverter  myConverter<  6ShoppingList.Helpers.MultiStringToStringArrayConverter  comboConverter  MyExpanderToggleButton �� 
TargetType � ColumnDefinitions F�Name ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName  
MyExpander d�Name � OverridesDefaultStyle d� 	IsChecked �� Path �� RelativeSource  
mainColour  myControlButton �� CornerRadius  myMenuHeader ��Name m� IsSubmenuOpen J� SnapsToDevicePixels K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation P� 
SourceName��%n  &	        &	 (     &	 T     &	 u     &	 �     &	 �     &	 �     &	 �     &	 "    &		 A    &	
 e    &	 �    &	 �    &	 �    &	     &	 ]    &	 p    &	 �    7  7  &	 �    7  '�� �	    &	 4    &	 a    7  7  7  7  ��5   
   ShoppingList.csv��6;   ��5   
   LastShoppingList.csv��6C   ��5   
   	Items.csv��65   ��5   
   Categories.csv��6?   ��5   
   Misc��66   �� 5   
   $ 	PaleGreen��6,   �� 5   
   $ SpringGreen��6.   �� 5   
   $ 	LimeGreen��6-   �� 5   
   $ Black��61   �� 5   
   $ 
WhiteSmoke��62   �� 5   
   $ 	DarkGreen��61   �� 5    
   $ Black��6.   *�5#   
   Century Gothic)�66   �� 5&   
   " ��6'   .�5'      ��  � ��$ 24(�6)   5(      �� 5)   
   " ��6$   .�5*      ��  � ��$ 15(�6)   5+        5.   
   64     5/   
   61   �� 56   
   " d�69   .R�57      �  58      �� 59      $
��Auto �6'   �� 5:      $��* �6'   .+�5=      �� 
������ $��2��5>      �� 5@      $��IconRectangle��6   $��0��5A      #���  5B      $��50��5C      $��50��5D      $��Center=�5E      $��Center=�5F      #���  5G      F� 5I      $ 
HeaderIcon��6   $��0��5J      "����    @KL р�� ��� � -1@KL 	#���  5L      $��20��5M      $��20��5N      $��1��5O      #���  5P      $��Center=�5Q      $��Center=�5R      �� 5T      8��  $��1��6>   �� 5V      $ HeaderContent��6#   $��1��5W   #   $��4,0,0,0q�5X   #   $��Content��5Y   #   $
��Left=�5Z   #   $��Center=�5[   #   $��22(�5\   #   $��Regular"�5]   #   8�� 5^   #   5`      	 5d      P� 5f      
 �@d�	IsChecked$
 TrueY�6/   . �5g      �� $ 
HeaderIcon��5h       � ��" ��    ��� р�� @KL � -1��� 	5i      5j      P� 5m      
 �@J�IsMouseOver . . �5n      �� # �  5o      $ 
HeaderIcon��5p       � ���� 5q      # �  5r      $ 
HeaderIcon��5s       � ��5t      P� 5w      
 � �� . . �5x      �� # � 
 5y      $ 
HeaderIcon��5z       � ���� 5{      # � 
 5|      $ 
HeaderIcon��5}       � ��5~      5�      �� 5�   
   " 9�6-   .R�5�      ]� #���  6   .+�5�      d� $ ExpanderButton��6   $	��Top=�5�      8��  #��z��5�       .  5�      �� $ 
IsExpanded� �� *TemplatedParent+5�      �� 5�      $ ExpanderContent��6#   $��1��5�   #   $y�	Collapsed=�5�   #   $��Bottom=�5�   #   $��4q�5�   #   $��50��5�   #   {�.  5�      5�      	 5�      P� 5�      
 �@9�
IsExpanded . . �5�      �� $ ExpanderContent��6    � y�$ Visible=�6P   �� 5�      $ ExpanderContent��6    � {� . 6O   5�      5�      �� 5�   
   " ��6   .�5�      ��  � ��# �  6+   �� 5�       � ��$ 0q�60   �� 5�       � ��$ 0q�6'   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� #��z��6%   .+�5�      �� $ contentPresenter��5�      #��z��5�      #��z��5�      5�      5�      5�      5�      �� 5�   
   " ��6(   .�5�      ��  � �� 5�      �� 5�      " ��6&   .R�5�      �� #��z��6!   #��z��5�   !   $ 4��5�   !   #��z��5�   !   #��z��5�   !   #��z��5�   !   #��z��5�   !   ._�5�      �� 5�      5�      5�      �� 5�       � ��$ 14(�6)   5�      �� 5�   
   " m�6/   .R�5�      �� $ Border��6   ._�5�      � .+�5�      �� $��6,3,6,3q�6'   $��Header��5�   '   ��. 5�   '   � 5�      $��Popup��6   $��Bottom=�5�      #��z 5�      |�.  $
��Fade=�5�      .��5�      �� $��SubmenuBorder��6!    . 8��  8�� $��1q�5�   !   ._�5�      �� ��.  .��5�   "   ��  . $ Cycle=�5�   -   5�      5�      5�      5�      5�      	 5�      P� 5�      "
 �@m�IsSuspendingPopupAnimation . . �5�      �� $ Popup��6    � ��$
 None=�6J   5�      P� 5�      
 �@m�IsHighlighted . . �5�      �� $ Border��6   8   � ��6G   �� 5�      $ Border��6    � ��
 ���� 6H   5�      P� 5�      $ Popup��6   
 �@�AllowsTransparency . . �5�      �� $ SubmenuBorder��6    �@��CornerRadius$ 0,0,4,4��6P   �� 5�      $ SubmenuBorder��6    �@��Padding$ 0,0,0,3q�6K   5�      P� 5�      
 � {� .  . �5�      �� 8   � ��63   5�      5�      5     5     