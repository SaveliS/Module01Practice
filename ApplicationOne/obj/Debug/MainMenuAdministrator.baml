   M S B A M L   `   `   `  ????I  EApplicationOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ApplicationOneApplicationOne  5   	   *    $ApplicationOne.MainMenuAdministrator   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ApplicationOne     5   	     ? Title$'  !AMONIC Airlines Automation System??5   	   $	??450??63   $	??800??6@   .??5	      ??  ?? Orientation$ Vertical=?6   .+?5
   
   ?? $ 
Horizontal=?6   $??55??6.   $	??Top=?6:   .+?5      ?? -   5         ??Name$ GoWindowAddUser??5   r   $??75??6   $??30??6    $??10q?6,   $??Add user??68   
???????
???????6?   ?? 5      $??75??6   $??30??6    $??10q?6,   $
??Exit??68   
???????
???????6p   5      ?? 5   
   $	??330??6   $ Vertical=?6"   .+?5      ?? $??40??6   $ 
Horizontal=?6%   .+?5      ?? $??Office: ??6   $??Center=?6+   $??10 ,0 ,0 ,0q?6F   6]   ?? 5      -   5         ??Name$ 
SortOffice??5      $	??150??6   $??30??6'   $??Center=?63   $??10(?6q   ??6N   ?? *
officeList+??5      ?? 5      .R?5      ?? $ 
Horizontal=?6)   .+?5   "   ?? ??6(   ?? *Title+6D   5      5      5      5      ?? 5      $	??290??6   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ MainDataGrid??5   7      AutoGenerateColumns .  ??6M   ?? *	usersList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *	FirstName+6[     5      $ 	Last Name??6-    6@   ?? *
LastName+6_     5       $ 	Birthdate??6-    6@   ?? *	Birthdate+6`     5!      $ 	User Role??6-    6@   ?? *Roles.Title+6b     5"      $ Email Address??6-    6D   ?? *Email+6`     5#      $ Office??6-    6=   ?? *Offices.Title+6a   5%      5&      5'      ?? 5(   
   $??50??6   $ 
Horizontal=?6!   .+?5)      ?? -   5        $ ChangeRoleButton??5)   u   $??75??6   $??30??6    $??10q?6,   $??Change Role??68   
???????
???   ?6?   ?? 5*      -   5        $ EnableDisableLogin??5*      $	??125??6   $??30??6!   $??10q?6-   $??Enable/Disable Login??69   
???????
???   ?6?   5+      5,      5-      