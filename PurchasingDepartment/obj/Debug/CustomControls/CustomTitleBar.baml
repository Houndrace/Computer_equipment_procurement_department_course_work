   M S B A M L   `   `   `  ????  PurchasingDepartment8    2PurchasingDepartment.CustomControls.CustomTitleBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >?Name$  TitleBar??5       ? 	Resources 5
         MinimizeButtonStyle ?? 
TargetType ?? Property ?? Value ?? 
TargetType ??Name ?? Triggers P? Property	 P? Value
 ?? 
TargetName  ExpandButtonStyle ?? Value ?? Binding ?? RelativeSource ?? Mode ?? Path ?? AncestorType ^? 
Conditions ?? Binding ?? Value  CloseButtonStyle??%?  &	        &	      &	 ?    ?? 5   
   " ??5      .?5      ??  ? ?? 5      ?? 5      " ??6&   .R?5      ? 
?????? $??25??5      $??35??5      .+?5      ?? $ ButtonImage??6$   $A??;/PurchasingDepartment;component/Images/MinimizeInactive.png??5   $   $??8??5   $   $??3??5   $   $??	10 25 0 6q?5   $   5       5      P? 5       ?@J?IsMouseOver	 . . ?5   "   ?? $
 ButtonImage??6)    ? ??$? 9/PurchasingDepartment;component/Images/MinimizeActive.png??6T   5      5      5       5!      ?? 5"   
   " ??5#      .?5$      ??  ? ??$ Right=?64   ?? 5%       ? ?? 5&      ?? 5'      " ??6&   .R?5(      ? 
?????? $??30??5)      $??35??5*      .+?5+      ?? $ ButtonImage??6$   $???9/PurchasingDepartment;component/Images/ExpandInactive.png??5,   $   $??10??5-   $   $??9??5.   $   $??3 19 0 6q?5/   $   50       51      ?? 52      $
 True??6u    6*   ?? *IsMouseOver+ ?? $
 Self=?.a?53   "   ?? $
 ButtonImage??6)    ? ??$= 7/PurchasingDepartment;component/Images/ExpandActive.png??6T   54      ?? 56      $ 	Maximized??6?    6*   ?? $ WindowState? ?? " ?.a?57   "   ?? $
 ButtonImage??6)    ? ??$A ;/PurchasingDepartment;component/Images/ExpandedInactive.png??6T   58      ^? 5:       5;   "   ?? 5<   &    60   ?? $ WindowState? ?? " ? 	Maximized6?   ?? 5=   &    60   ?? *IsMouseOver+ ?? $
 Self=? True6{   .0?5?   "   ?? $
 ButtonImage??6)    ? ??$? 9/PurchasingDepartment;component/Images/ExpandedActive.png??6T   5@      5B      5D      5E      ?? 5F   
   " ??5G      .?5H      ??  ? ?? 5I      ?? 5J      " ??6&   .R?5K      ? 
?????? $??35??5L      $??35??5M      .+?5N      ?? $ ButtonImage??6$   $>??8/PurchasingDepartment;component/Images/CloseInactive.png??5O   $   $??9??5P   $   $??9??5Q   $   $??	0 19 15 6q?5R   $   5S       5U      P? 5V       ?@J?IsMouseOver	 . . ?5W   "   ?? $
 ButtonImage??6)    ? ??$< 6/PurchasingDepartment;component/Images/CloseActive.png??6T   5X      5Z      5\      5]      5^      .??5`      ? -   5        $??grdTitleBar??5`      $??35??5a       ? ColumnDefinitions 5b   
   ?? 5c      $??* ?6   ?? 5d      $
??Auto ?6   .+?5f   
   ?? $??Отдел закупок??6     SecondaryText#??[ 5g      $
??Left=?5h      $??Center=?5i      $??15 8 0 0q?5j      ?? 5k   
    ?? Orientation$ 
Horizontal=?6   $??Right=?5l      $??1??5m      .+?5n      ?? -   5        $??MinimizeButton??5n      #???   5o      '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome . 5q      ?? 5s      -   5        $??ExpandButton??5s      #???  5t       . 5v      ?? 5x      -   5        $??CloseButton??5x      #???  5y       . 5{      5|      5}      5~      