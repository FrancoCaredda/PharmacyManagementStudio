   M S B A M L   `   `   `  ????S  OPharmacyManagementStudio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:PharmacyManagementStudio.MVVM.View"PharmacyManagementStudio.MVVM.View  5      a5clr-namespace:PharmacyManagementStudio.MVVM.ViewModel'PharmacyManagementStudio.MVVM.ViewModel  5      5    /PharmacyManagementStudio.MVVM.View.MedicineView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:PharmacyManagementStudio.MVVM.View     5      K	viewModel5clr-namespace:PharmacyManagementStudio.MVVM.ViewModel     5      .??5      ?   ? RowDefinitions  5   
   ?? 5      $??2* ?6   ?? 5      $	??13* ?6   .+?5   
   ?? $??0??6    ?? Orientation$ 
Horizontal=?6"   $??Center=?6;   .+?5      ?? $
??5, 0q?6   .+?5      ?? $
??Name??6   ?? 5      $	??100??6   $??25??6&   ??62   ?? *Medicine.Name+5      ?? 5      $
??5, 0q?6   .+?5      ?? $
??Type??6   ?? 5      $	??100??6   $??25??6&   ??62   ?? *Medicine.Type+5      ?? 5      $
??5, 0q?6   .+?5      ?? $??Price??6   ?? 5      $	??100??6   $??25??6&   ??62   ?? *Medicine.Price+5      ?? 5      $
??5, 0q?6   .+?5      ?? $??Count??6   ?? 5      $	??100??6   $??25??6&   ??62   ?? *Medicine.StockCount+5       ?? 5!      $
??5, 5q?6   $	??Add??6#   $??70??6P   $??30??6[   ??61   ?? *
AddCommand+6[   ?? 5"      $
??5, 5q?6   $??Remove??6#   $??70??6V   $??30??6a   ??64   ?? *DeleteCommand+6a   ?? 5#      $
??5, 5q?6   $??Update??6#   $??70??6V   $??30??6a   ??64   ?? *UpdateCommand+6a   ?? 5$      $
??5, 5q?6   $??
Select row??6#   $??70??6Z   $??30??6e   ??68   ?? *SelectCommand+6e   5%      &   System.Windows.Controls.DataGrid  5&   
   $
??0, 5q?6   $??1??5'         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5(         AutoGenerateColumns . $??Stretch=?5+         HeadersVisibility$ Column=?5,      ??5)      ?? *MedicineList+ ?? SelectedIndex 5-      ?? *
RowIndex+5.      5/      50      