   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5      ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 5       FlowCharterB   <MindFusion.Diagramming.Wpf.Samples.CS.FlowCharter.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MindFusion.Diagramming.Wpf, Version=3.4.1.401, Culture=neutral, PublicKeyToken=1080b51628c81789/diag$http://mindfusion.eu/diagramming/wpf  5      Hf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms  5      YwfiOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration  5        � Title$4  .MindFusion Yazılımı İle FlowChart Desinger��5      $	��809��65   .��5	      ]� .+�5
      o� -   5        $��menu1��5
      $��22��6	   $	��Top=�6"   .@�5      m� -   5        $��mIFile��5      $��_Dosya��6   .@�5      m� -   5        $��mIFNew��5      $��_Yeni��6   6,   m� 5      -   5        $��mIFOpen��5      $
��_Aç��6   6+   m� 5      -   5        $��mIFSave��5      $��_Kaydet��6   60   �� 5      m� 5      -   5        $��mIFPrint��5      $��
Yazdır...��6+   �� 5      m� 5      -   5        $��mIExit��5      $��	Çıkış��6   6,   5      5      � 5       � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6   .+�5      &   MindFusion.Diagramming.Wpf.Ruler     Unit$ 
Millimeter=�6      ProjectionColor$ 	#30000000��6"      Document. 5      (  "MindFusion.Diagramming.Wpf.Diagram  -   5        $��diagram��5         MeasureUnit
  A.KD$ 
Millimeter 5   
      ShowAnchors$
 Auto=�5   
      	BackBrush
 �����   AlignToGrid . 	   GridOffsetX$	 0Q�5!   
   
   GridOffsetY$
 0Q�5"   
      	GridSizeX$ 5Q�5#   
      	GridSizeY$ 5Q�5$   
      ShapeHandlesStyle$ HatchHandles3=�5%   
      AdjustmentHandlesSize$	 2.5Q�5&   
      ShowGrid .    Behavior$ 	DrawLinks=�5(   
      
ShapeBrush
 ��İ�   AllowInplaceEdit .  J� 	AllowDrop . $	��824��51      $	��705��6'      GridPen 52      >� 53       >� Brush
 �   � >� 	Thickness$ 1Q�6      ShapeNodeStyle 55      �� 56       �� 
TargetType*  $MindFusion.Diagramming.Wpf.ShapeNode"  6   .�57   	   �� ,  &MindFusion.Diagramming.Wpf.DiagramItem �� Property �@ Brush �� Value
 ��İ�6!   �� 58   	    �@ StrokeThickness$	 0.2Q�6+   �� 59   	    �@ FontSize$ 4Q�6$   5:   	      TableNodeStyle 5<      �� 5=      *  $MindFusion.Diagramming.Wpf.TableNode"  6   .�5>   	   ��  �@ StrokeThickness$	 0.2Q�6+   �� 5?   	    �@ FontSize$ 4Q�6$   5@   	      ContainerNodeStyle 5B      �� 5C      .  (MindFusion.Diagramming.Wpf.ContainerNode"  6   .�5D   	   ��  �@ StrokeThickness$	 0.2Q�6+   �� 5E   	    �@ FontSize$ 4Q�6$   5F   	      DiagramLinkStyle 5H      �� 5I      ,  &MindFusion.Diagramming.Wpf.DiagramLink"  6   .�5J   	   ��  �@ Stroke �	#FF0000006"   �� 5K   	    �@ StrokeThickness$	 0.2Q�6+   �� 5L   	    �@ HeadStrokeThickness$	 0.2Q�6/   �� 5M   	    �@ Brush �	#FFFFFFFF6!   �� 5N   	    �@ FontSize$ 4Q�6$   5O   	   5Q      5R      � 5S      $��1��6
   $	��180��6    � RowDefinitions 5T      �� 5U      .+�5W      �� $��2��6   .@�5X      �� $��	Şekiller��6   .��5Y      -	  'MindFusion.Diagramming.Wpf.NodeListView	  -	   5        $��nodeListView��5Y      .@�5Z   	        Shape/
  )MindFusion.Diagramming.Wpf.ShapeConverter$ Alternative
 6   ,  &MindFusion.Diagramming.Wpf.DiagramNode    Bounds$  	0,0,20,20�6,   !   Brush
! ��İ�" 	  Label$"  Alternatif��6V     5[      $ PunchedCard
 6-   $  	0,0,20,20�6A   
! ��İ�$"  Delikli kart��6k     5\      $ Decision
 6-   $  	0,0,20,20�6>   
! ��İ�$"  Karar / Eğer��6h     5]   	   $ Delay
 6   $  	0,0,20,20�6&   
! ��İ�$"  Gecikme - Bekleme��6P     5^      $ DirectAccessStorage
 6-   $  	0,0,20,20�6I   
! ��İ�$" 	 Depolama��6s     5_      $ DiskStorage
 6-   $  	0,0,20,20�6A   
! ��İ�$"  Disk kapasitesi��6k     5`   	   $ Display
 6   $  	0,0,20,20�6(   
! ��İ�$"  Görüntüle��6R     5a   	   $ DividedEvent
 6   $  	0,0,20,20�6-   
! ��İ�$"  Bölünen Etkinlik��6W     5b   	   $ DividedProcess
 6   $  	0,0,20,20�6/   
! ��İ�$"  Bölünmüş İşlemler��6Y     5c   	   $ Document
 6   $  	0,0,20,20�6)   
! ��İ�$"  Dosya��6S     5d   	   $ InternalStorage
 6   $  	0,0,20,20�60   
! ��İ�$"  Dahili Depolama��6Z     5e   	   $ 	BeginLoop
 6   $  	0,0,20,20�6*   
! ��İ�$"  Döngü��6T     5f   	   $ Input
 6   $  	0,0,20,20�6&   
! ��İ�$"  Giriş��6P     5g   	   $ ManualOperation
 6   $  	0,0,20,20�60   
! ��İ�$"  Manuel İşlem��6Z     5h   	   $ MessageFromUser
 6   $  	0,0,20,20�60   
! ��İ�$"  Kullanıcıdan Mesaj��6Z     5i      $ MessageToUser
 6-   $  	0,0,20,20�6C   
! ��İ�$"  Kullanıcıya Mesaj��6m     5j   	   $ MultiDocument
 6   $  	0,0,20,20�6.   
! ��İ�$"  Çoklu Belgeleme��6X     5k      $ 	Microform
 6-   $  	0,0,20,20�6?   
! ��İ�$" 
 MikroForm��6i     5l      $ PrimitiveToCall
 6-   $  	0,0,20,20�6E   
! ��İ�$" 	 Çağrı��6o     5m   	   $ 	Procedure
 6   $  	0,0,20,20�6*   
! ��İ�$"  İşlem��6T     5n   	   $ Start
 6   $  	0,0,20,20�6&   
! ��İ�$"  Başla��6P   5q   	   5r      �� 5s      $��Bağlayıcılar��6   .��5t      � $��
0, 0, 0, 0q�6   .+�5u   	   �� -
   5        $��_connectorList��5u      $��0, 0, 0, 25q�6'   5v   
   �� 5w   	   -   5        $��_connectorTypeCombo��5w      $��20��6-   $��Bottom=�69   # �� SelectedIndex$# 0��6T   .@�5y   
   �� .��6   
Polyline6!   �� 5z   
   .��6   Bezier6   �� 5{   
   .��6   Perpendicular6&   5|   
   5}   	   5~      5      5�      5�      5�      5�      