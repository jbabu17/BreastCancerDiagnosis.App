   M S B A M L   `   `   `  ����T  PBreastCancerDiagnosis.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:BreastCancerDiagnosis.App.ViewModels$BreastCancerDiagnosis.App.ViewModels  5   	   9    3BreastCancerDiagnosis.App.Views.DiagnosisDetailView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   B	viewmodel2clr-namespace:BreastCancerDiagnosis.App.ViewModels  5   	     � Title$  Breast Cancer Diagnosis��5   	   $	��600��6)   $	��500��66    � DataContext 5   	   ��    MainViewModelLocator �� Source# [   �� Path$ DiagnosisDetailViewModel� J� InputBindings 5
      �� 5   
   
 �� Key$ D��6    �� 	Modifiers$ Controlf�6    �� Command 61   �� *DeleteCommand+�� 5   
   $ S��6   $ Controlf�6    61   �� *SaveCommand+ � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%V   '��       �� 5   
   "	 ��6   .�5      �� 
 � ��$ 5q�6'   63   5      5      .��5      �� .��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   6+   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $
��Auto �6   6,   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5       $��30 �6   6*    � ColumnDefinitions 5"   
   �� 5#      $	��100 �6   6-   �� 5$      $��* �6   6+   .+�5&   
   �� $��2��5'      $��Center=�5(      $��Center=�5)      $��10q�5*      ��5&      �� *SelectedDiagnosis.ImageId+  LocalImageConverter �� 	Converter# [ 5*      �� 5+   
   $��1��6   $��Id��6   $
��Bold"�6+   �� 5,   
   $��2��6   $
��Name��6   $
��Bold"�6-   �� 5-   
   $��3��6   $��Description��6   $
��Bold"�64   �� 5.   
   $��4��6   $
��Type��6   $
��Bold"�6-   �� 5/   
   $��5��6   $
��Cost��6   $
��Bold"�6-   �� 51   
   $��1��6   $��1��6   ��6/   �� *SelectedDiagnosis.DiagnosisId+ �� Mode$ TwoWay=��� 52   
   $��2��6   $��1��6   ��6/   �� *!SelectedDiagnosis.DiagnosisName+$ TwoWay=��� 53   
   $��3��6   $��1��6    �� TextWrapping$ WrapWithOverflow=�6k   ��6/   �� *SelectedDiagnosis.Description+$ TwoWay=�6k   �� 54   
   $��4��6   $��1��6   ��6/   �� *!SelectedDiagnosis.DiagnosisType+$ TwoWay=��� 55   
   $��5��6   $��1��6   ��6/   �� *SelectedDiagnosis.Cost+$ TwoWay=��� 57   
   $��8��6    �� Orientation$ 
Horizontal=�6"   $��2��6;   $��Center=�6O   .+�58      �� $��Save Diagnosis��6   ��6.   �� *SaveCommand+6Q   �� 59      $
��    ��6   �� 5:      $��Delete Diagnosis��6   ��60   �� *DeleteCommand+6T   5;      5<      5=      5>      