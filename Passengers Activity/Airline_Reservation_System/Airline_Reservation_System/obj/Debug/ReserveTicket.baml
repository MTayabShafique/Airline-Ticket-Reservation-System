   M S B A M L   `   `   `  ����  Airline_Reservation_System.    (Airline_Reservation_System.ReserveTicket   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ReserveTicket��5   	   $	��428��6   $	��584��6,    � Icon$  images/useractivity.ico��5   	   ��5      �� 5   
    �� ImageSource$ images/plane.jpg��6   .��5	      � $��Right=�6   $	��576��6'   .+�5
   
   �� -   5         ��Name$ fromAirport��5
      $��Right=�6(   $��0,0,302,333q�6D   $��Bottom=�6Y   $	��120��6t   $��26��6�   �� 5   
   -   5        $ 	toAirport��5      $��Right=�6&   $��
0,96,302,0q�6B   $	��Top=�6V   $	��120��6n    J� RenderTransformOrigin$ 0.408,0.591&�6z   $��26��6�   �� 5   
   $��From:��6   $��Right=�6    $��0,0,477,333q�6<   $
��Bold"�6Q   $��Times New Roman)�6c   $��14(�6�   $��Bottom=�6�   $��89��6�   �� 5   
   -   5        $ T_Type��5      $��Right=�6#   $��0,155,302,0q�6?   $	��Top=�6T   $	��120��6l   $ 0.408,0.591&�6x   $��26��6�   �� 5   
   $��Ticket Type:��6   $��Right=�6'   $
��Bold"�6C   $��Times New Roman)�6U   $��14(�6r   $��0,0,477,216q�6�   $��Bottom=�6�   $��89��6�   �� 5   
   $	��To:��6   $��Right=�6   $��0,0,477,275q�6:   $��Bottom=�6O   $��89��6j   $
��Bold"�6u   $��Times New Roman)�6�   $��14(�6�   �� 5   
   $��Ticket Fare:��6   $��Right=�6'   $
��Bold"�6C   $��Times New Roman)�6U   $��14(�6r   $��0,0,477,162q�6�   $��Bottom=�6�   $��89��6�   �� 5   
   -   5         ��Name$ T_Fare��5      $��Right=�6"    �� 
IsReadOnly . $��26��6P   $��0,209,302,0q�6\    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ 	print_tkt��5      $��Print Ticket��6$   $
��Left=�6;   $��214,305,0,0q�6V   $	��Top=�6k   $	��100��6�   $
��Bold"�6�   $��14(�6�   6�   �� 5   
   -   5        $ 	cancelTCK��5      $��Cancel��6$   $
��Left=�65   $��439,305,0,0q�6P   $	��Top=�6e   $	��100��6}   $
��Bold"�6�   $��14(�6�   6�   �� 5   
   -   5        $ backRT��5      $
��Back��6!   $
��Left=�60   $��
10,305,0,0q�6K   $	��Top=�6_   $	��100��6w   $
��Bold"�6�   $��14(�6�   6�   5      5      