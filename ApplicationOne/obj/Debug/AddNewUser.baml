   M S B A M L   `   `   `  ????I  EApplicationOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ApplicationOneApplicationOne  5   	       ApplicationOne.AddNewUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ApplicationOne     5   	     ? Title$  
AddNewUser??5   	   $	??500??6   $	??400??6)   .??5	      ?? $??Center=?6   $??Center=?6.   .+?5   
   ?? .+?5      ?? $
??Name??6   $??20(?6$   ?? 5      -   5         ??Name$ nameBox??5      $	??150??6'   $??30??63   $??20(?6?   ??5      ?? *
LastName+5      ?? 5   
   .+?5      ?? $??	Last Name??6   $??20(?6)   ?? 5      -   5        $ lastNameBox??5      $	??150??6+   $??30??67   $??20(?6C   ??5      ?? *	FirstName+5      ?? 5   
   .+?5      ?? $	??Age??6   $??20(?6#   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
selectDate??5   &   $??30??6   6&   5      ?? 5   
   .+?5       ?? $??	User Role??6   $??20(?6)   ?? 5!      -   5         ??Name$ comboboxRole??5!       ?? DisplayMemberPath$ Title??6-    ?? SelectedItem 6G   ?? *Roles+5"      ?? 5%   
   .+?5&      ?? $??Email address??6   $??20(?6-   ?? 5'      -   5        $ emailBox??5'      $	??150??6(   $??30??64   $??20(?6@   ??5(      ?? *Email+5)      ?? 5,   
   .+?5-      ?? $??Office??6   $??20(?6&   ?? 5.      -   5        $ comboboxOffice??5.      $ Title??6/    5/      ?? *	Offices+50      ?? 53   
   $??0 0 0 20q?6   .+?54      ?? $??Password??6   $??20(?6(   ?? 55      -   5        $ passwordBox??55      $	??150??6+   $??30??67   $??20(?6C   ??56      ?? *
Password+57      ?? 59   
   -   5         ??Name$ 	addButton??59   +   $??30??6   $	??Add??6   6>   5:      5;      