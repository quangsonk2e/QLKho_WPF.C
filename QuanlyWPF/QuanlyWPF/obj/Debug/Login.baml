   M S B A M L   `   `   `  ����D  @QuanlyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QuanlyWPF	QuanlyWPF  5      9!clr-namespace:QuanlyWPF.ViewModelQuanlyWPF.ViewModel  5   	       QuanlyWPF.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   #localclr-namespace:QuanlyWPF  5      *vm!clr-namespace:QuanlyWPF.ViewModel  5   	   -   5          �Name$  Vlogin��5   	      MaterialDesignBody#���   5      $��Regular"�5	      $��14(�5
   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Login��5   	   $��320.925��6   $	��300��6(    � DataContext 5      "   QuanlyWPF.ViewModel.dangnhap  5   
   -   5        dangnhap��5      .��5      � 
���� ��.+�5   
   ��  �� CornerRadius$ 10��6   $��10 20q�6#   
�������._�5      �� 	 �� Orientation$	 Vertical=�6   .+�5      �� $ 60��6   $��2q�6+   
����  �$��90��6R   
���� ��._�5      �� $��/Resource/Login-icon.png��6   $��80��6>   $	��Top=�6I   $��0 10 0 0q�6a   5      �� 5       $  MaterialDesignHeadline6TextBlock#��[ 6   $��Center=�6V   
 �� TextAlignment$
 Center=�6q   $��0 0 0 10q�6�   
����  �$
��Bold"�6�   Đăng nhập hệ thống5       �� 5!      $
��10 0q�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên Sử Dụng��5"       % !MaterialDesignFloatingHintTextBox#��[ 5#      $��Center=�5$      G� 5%      -   5         G�Name$ FloatingPasswordBox��5&      $
��10 0q�5%      $ Mật Khẩu��5'       ) %MaterialDesignFloatingHintPasswordBox#��[ 5)      �� 5*      $	 
Horizontal=�6   $��10 20q�66   .+�5+      �� $��Đăng nhập��6   $
��20 0q�61   ��6?   �� *
checklogin+��6^   ��  �� ElementName$ Vlogin��6�   �� 5,      $��Đăng nhập��6   $
��50 0q�61   .  (System.Windows.Interactivity.Interaction   Triggers 5-      /  )System.Windows.Interactivity.EventTrigger  5.         	EventName$ click��6-   .  (System.Windows.Interactivity.TriggerBase   Actions. 5/   "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *leftButtonDownCommand+   CommandParameter 6b   �� $ Vlogin��6�   50      52      �� 53      -   5        $��
  Thoát  ��53      $
��10 0q�61   6V   54      55      56      57      58      