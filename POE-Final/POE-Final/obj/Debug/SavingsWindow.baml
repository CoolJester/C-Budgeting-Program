   M S B A M L   `   `   `  ����D  @POE-Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:POE_Final	POE_Final  5   	       POE_Final.SavingsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:POE_Final     5   	     � Title$  SavingsWindow��5   	   $	��362��6   $	��364��6,    � 
ResizeMode$ NoResize=�68   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��225* �6   �� 5      $
��131* �6   .+�5   
   �� $��Savings��6   $
��Left=�6"   $��	10,10,0,0q�6=   $	��Top=�6P   $��48(�6h   $
��Bold"�6v   �� 5   
   $��What are you saving for?��6   $
��Left=�63   $��	32,84,0,0q�6N   $	��Top=�6a   $	��178��6y   �� 5   
   -   5         ��Name$ txtReasonForSaving��5      $
��Left=�6.   $��23��6I   $��
215,88,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $��2��6�   �� 5   
   $��Enter total amount��6   $
��Left=�6-   $��
32,115,0,0q�6H   $	��Top=�6\   $	��178��6t   �� 5   
   -   5        $ txtTotalAmount��5      $
��Left=�6*   $��23��6E   $��215,119,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $��2��6�   �� 5   
   $��Enter interest rate��6   $
��Left=�6.   $��
32,146,0,0q�6I   $	��Top=�6]   $	��178��6u   �� 5   
   -   5        $ txtInterest��5      $
��Left=�6'   $��23��6B   $��215,149,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $��2��6�   �� 5   
   $��Enter duration in years��6   $
��Left=�62   $��
32,177,0,0q�6M   $	��Top=�6a   $	��178��6y   �� 5   
   -   5        $ txtDuration��5      $
��Left=�6'   $��23��6B   $��215,181,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $��2��6�   �� 5   
   -   5         ��Name$ txtCalculate��5      $��	CALCULATE��6'   $
��Left=�6;   $��
32,208,0,0q�6V   $	��Top=�6j   $	��303��6�   $��37��6�   $��2��6�   6�   �� 5   
   $��Amount due per month: ��6   $
��Left=�61   $��
32,250,0,0q�6L   $	��Top=�6`   $	��188��6x   �� 5   
   -   5         ��Name$ lblSavingsAmount��5      $��R--,--��6*   $
��Left=�6;   $��	0,250,0,0q�6V   $	��Top=�6i   $	��110��6�   $��1��6�   �� 5   
   -   5        $ btnPrintReport��5      $��PRINT REPORT��6)   $
��Left=�6@   $��
32,281,0,0q�6[   $	��Top=�6o   $	��303��6�   $��39��6�   $��2��6�   6�   5      5      