   M S B A M L   `   `   `  ????P  LProcurementDepartment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProcurementDepartment.ViewsProcurementDepartment.Views  5   	   ,    &ProcurementDepartment.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:ProcurementDepartment.Views     5   	   $	??600??5	   	   $	??600??5
   	   $
??1000??5   	   $
??1000??5   	     ? WindowState$  	Maximized=?5   	      
MainWindow#??[  5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??43 ?6   ?? 5      $??* ?6   ?? 5      $??63 ?6   .+?5   
   ? $??0??6    ? ColumnDefinitions 5      ?? 5      $
??Auto ?6#   ?? 5      $??* ?6#   ?? 5      $
??Auto ?6#   .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??
10 7 10 15q?5      $??0??5      5(      ?? 5*      $ 
Horizontal=?6   $??	0 4 10 15q?5+      $??1??5,      .+?5-      ?? -   5         ??Name$ 	btnOrders??5-      $??ЗАКАЗЫ??5.      $
??10 0q?5/        PageSelectButton#???  50      51      ?? 52      -   5        $ btnSuppliers??52      $??ПОСТАВЩИКИ??53      $
??10 0q?54      #???  55      56      5?      ?? 5A      $??2??6   $??0 0 10 0q?5B      $
??Auto??5C      $??25??5D      $??Right=?5E        PageBackground#??[ 5F      .+?5G      ??   BluePrimaryText#??[ 5H      $	??5 0q?5I      ??5G      ?? *
FullName+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=?5I      5J      5L       ? 5O   
   -   5          ?Name$ MainWindowFrame??5O        ? NavigationUIVisibility$ Hidden=?5P      #??[ 5R      $??1??5S      ??5Q      ?? *CurrentPage+5U      5V      5W      