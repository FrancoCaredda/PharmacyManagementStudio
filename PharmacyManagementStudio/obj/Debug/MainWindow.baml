   M S B A M L   `   `   `  ????S  OPharmacyManagementStudio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PharmacyManagementStudioPharmacyManagementStudio  5   	   a5clr-namespace:PharmacyManagementStudio.MVVM.ViewModel'PharmacyManagementStudio.MVVM.ViewModel  5      )    #PharmacyManagementStudio.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:PharmacyManagementStudio     5   	   K	viewModel5clr-namespace:PharmacyManagementStudio.MVVM.ViewModel     5        ? Title$  
MainWindow??5	   	   $	??490??6   $
??1000??6)    ? DataContext 5
      ;   5PharmacyManagementStudio.MVVM.ViewModel.MainViewModel  5   
   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??31* ?6   ?? 5      $
??129* ?6    ? RowDefinitions 5   
   ?? 5      $	??30* ?6   ?? 5      $
??187* ?6   .+?5   
   ?? $!??Pharmacy 
Management Studio??5       ?? TextAlignment$ Center=?5      $??Center=?5      $??16(?5      $??42??6   ?? 5   
   $??2??6   ???#000$??0, 0, 0.25, 0q?65   ._?5      ??  ?? Orientation$ Vertical=?6   $??0,60,0,0q?60   .+?5      	? $??Medicine??6A      
PageButton#??[  6T   ??6   ?? *MedicineSwitch+6T   	? 5      $??Customer??6A   #??[  6T   ??6   ?? *CustomerSwitch+6T   	? 5      $??Saler??6>   #??[  6N   ??6   ?? *SalerSwitch+6N   	? 5       $??Order??6   #??[  6.   5!      5"      ?? 5#   
   $??1??6   $??1??6!    ?? Padding$ 10q?6.   ._?5$      ?? ??6   ?? *	ViewModel+5%      5&      5'      