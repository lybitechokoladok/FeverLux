   M S B A M L   `   `   `  ????F  BFeverluxApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FeverluxApp.WPF.ViewModelsFeverluxApp.WPF.ViewModels  5      =#clr-namespace:FeverluxApp.WPF.ViewsFeverluxApp.WPF.Views  5      C&clr-namespace:FeverluxApp.WPF.ControlsFeverluxApp.WPF.Controls  5      S.clr-namespace:FeverluxApp.WPF.State.Navigators FeverluxApp.WPF.State.Navigators  5
      ,    &FeverluxApp.WPF.Controls.NavigationBar   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >	viewModel(clr-namespace:FeverluxApp.WPF.ViewModels     5      4view#clr-namespace:FeverluxApp.WPF.Views     5      8local&clr-namespace:FeverluxApp.WPF.Controls     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5	      8nav.clr-namespace:FeverluxApp.WPF.State.Navigators  5
      .??5      ?   ? RowDefinitions  5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $??LeftToRight=?5      $??1??5      
???????.+?5      	?    
menuButton#??[  6    
 Color4
 ? Tag# [ 5      /   )FeverluxApp.WPF.State.Navigators.ViewType   Home#??Z 5      ??5      ?? *UpdateCurrentViewModelCommand+.??5      ?? $ 
Horizontal=?6   .+?5      "  FontAwesome.WPF.ImageAwesome     Icon$
 Home=?6&     menuButtonIcon#??[ 62   ?? 5      $
??Home??6      menuButtonText#??[ 6,   5      5       	? 5"      #??[  6    
 Color2# [ 5#         Shop#??Z 5%      ??5$      ?? *UpdateCurrentViewModelCommand+.??5&      ?? $ 
Horizontal=?6   .+?5'        $ ShoppingCart=?6&   #??[ 6:   ?? 5(      $
??Shop??6    #??[ 6,   5)      5*      	? 5,      #??[  6    
 Color3# [ 5-      .??5.      ?? $ 
Horizontal=?6   .+?5/        $
 User=?6&   #??[ 62   ?? 50      $??	Customers??6    #??[ 61   51      52      53      54      55      