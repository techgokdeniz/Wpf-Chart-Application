//
// Copyright (c) 2016, MindFusion LLC - Bulgaria.
//

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Shape = MindFusion.Diagramming.Wpf.Shape;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;
using MouseButton = MindFusion.Diagramming.Wpf.MouseButton;
using MindFusion.Diagramming.Wpf.Commands;
using System.Xml;


namespace MindFusion.Diagramming.Wpf.Samples.CS.FlowCharter
{
	/// <summary>
	/// MainWindow XML Etkileşimi
	/// </summary>
	public partial class MainWindow : Window
	{
		MenuItem mIDelete = null;

        /// <summary>
        /// Kurucu Metot
        /// </summary>
		public MainWindow()
		{
			InitializeComponent();


            //Bu kısım tüm diyagramın test şemasını çizdirmek içindir
            /*XmlDocument document = new XmlDocument(); //yeni bir xml dosyası oluşturuyoruz 
            document.LoadXml(Properties.Resources.Diagram); //içerisine diagramın proplarını ekliyoruz
            diagram.LoadFromXml(document); //diyagramı içine yüklüyoruz*/

            diagram.NodeCreated += (s, e) =>
				{
					e.Node.EnabledHandles = AdjustmentHandles.All;
					e.Node.TextAlignment = TextAlignment.Center;
					e.Node.TextVerticalAlignment = AlignmentY.Center;
					var containerNode = e.Node as ContainerNode;
					if (containerNode != null)
						containerNode.Margin = 4;
				};
			diagram.EnterInplaceEditMode += (s, e) =>
				{
					e.TextBox.FontSize = e.Node.FontSize;
					e.TextBox.Padding = new Thickness(0);
				};
			diagram.Selection.StrokeThickness = 0.2;

			mIDelete = new MenuItem();
			mIDelete.Header = "Sil";
			mIDelete.Click += new RoutedEventHandler(mIDelete_Click);
			
			_contextMenu = new ContextMenu();
			_contextMenu.Items.Add(mIDelete);
			this.ContextMenu = _contextMenu;

			SolidColorBrush defAnch = new SolidColorBrush(Colors.Red); //şekillerin yuvarlak kısımlarını renklendirmek için

            //Burada şekillerimizi yüklüyoruz
			_nodes = new Node[]
				{
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Alternative.Id), // Şekil İsimlerini String Olarak Almakta
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(30, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.PunchedCard.Id),
					new Node(
						AnchorPattern.Decision2In2Out,
						Shapes.Decision.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Delay.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(15, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(15, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.DirectAccessStorage.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 20, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 80, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 80, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 20, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.DiskStorage.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(40, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(40, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Display.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.DividedEvent.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.DividedProcess.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Document.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.InternalStorage.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(25, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(75, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 25, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 25, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.BeginLoop.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 40, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Input.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(80, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.ManualOperation.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(80, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.MessageFromUser.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(20, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.MessageToUser.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(45, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.MultiDocument.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 10, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 10, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 10, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Microform.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(80, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.PrimitiveFromCall.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(20, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.PrimitiveToCall.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Procedure.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(15, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 70, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(15, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 70, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Start.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Tape.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 52, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 52, true, true, MarkStyle.Circle, defAnch)
						}),
						"Table2x2"),
					
				};

            //Burada oklarımızı yüklüyoruz
            _connectors = new Connector[]
				{
					new Connector(
						ArrowHeads.Arrow,
						"Ok"),
					new Connector(
						ArrowHeads.BackSlash,
						"Ters Çizgi"),
					new Connector(
						ArrowHeads.BowArrow,
						"Yay Oku"),
					new Connector(
						ArrowHeads.Circle,
						"Yuvarlak"),
					new Connector(
						ArrowHeads.DoubleArrow,
						"Çift Ok"),
					new Connector(
						ArrowHeads.None,
						"Yok"),
					new Connector(
						ArrowHeads.Pentagon,
						"Pentagon"),
					new Connector(
						ArrowHeads.PointerArrow,
						"İşaretci"),
					new Connector(
						ArrowHeads.Quill,
						"Tüy"),
					new Connector(
						ArrowHeads.Reversed,
						"Ters"),
					new Connector(
						ArrowHeads.RevTriangle,
						"Ters Üçgen"),
					new Connector(
						ArrowHeads.RevWithCirc,
						"Ters Yuvarlak"),
					new Connector(
						ArrowHeads.RevWithLine,
						"Ters Çizgi"),
					new Connector(
						ArrowHeads.Rhombus,
						"Eşkenar Dörtgen"),
					new Connector(
						ArrowHeads.Slash,
						"Yırtmaç"),
					new Connector(
						ArrowHeads.Tetragon,
                        "Dörtgen"),
					new Connector(
						ArrowHeads.Triangle,
						"Üçgen")
				};
			foreach (Connector c in _connectors)
				InitConnectorListItems(c);

			_connectorList.SelectedIndex = 0;

			diagram.DocumentPlane.AllowDrop = true;
			diagram.UndoManager.UndoEnabled = true;
			diagram.UndoManager.History.Capacity = 30;
			diagram.Bounds = new Rect(0, 0, 219, 297);

			diagram.ActiveItemHandlesStyle.HandlePen.Thickness = 0.2;
			diagram.SelectedItemHandlesStyle.HandlePen.Thickness = 0.2;
			diagram.LinkHeadShapeSize = 6;
			diagram.CellFrameStyle = CellFrameStyle.None;
		}

        /// <summary>
        /// Silme metodu burası çalıştığında diagramın aktif itemini temizliyoruz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void mIDelete_Click(object sender, RoutedEventArgs e)
		{
			if (diagram.ActiveItem == null)
				return;

			diagram.Items.Remove(diagram.ActiveItem);
		}

        /// <summary>
        /// Liste ögelerini şekillendirmek için kullandığımız metot
        /// </summary>
        /// <param name="c"></param>
		private void InitConnectorListItems(Connector c)
		{
			Grid sp = new Grid();
			//sp.Background = Brushes.White;
			sp.Height = 25;
			sp.Width = 157;

			TextBlock textBlock = new TextBlock();
			//textBlock.Background = Brushes.White;
			textBlock.Text = c.Name;
			textBlock.VerticalAlignment = VerticalAlignment.Top;
			textBlock.HorizontalAlignment = HorizontalAlignment.Left;
			textBlock.Width = 80;
			textBlock.Height = 30;
			textBlock.Margin = new Thickness(25, 0, 0, 0);

			var drawingVisual = new DrawingVisual();
			var drawingContext = drawingVisual.RenderOpen();
			var defaultStroke = GetStyleValue(diagram.DiagramLinkStyle, DiagramLink.StrokeProperty) as Brush;
			var defaultBrush = GetStyleValue(diagram.DiagramLinkStyle, DiagramLink.BrushProperty) as Brush;
			drawingContext.DrawLine(new Pen(defaultStroke, 1), new Point(1, 8), new Point(16, 8));
			DiagramLink.DrawArrowhead(drawingContext, new Pen(defaultStroke, 1), defaultBrush,
				c.Head, new Point(50, 0), new Point(16, 8), new Point(1, 8), 12);
			drawingContext.Close();

			sp.Children.Add(new VisualHost(drawingVisual));
			sp.Children.Add(textBlock);
			
			_connectorList.Items.Add(sp);
		}

		public class VisualHost : FrameworkElement
		{
			protected override int VisualChildrenCount
			{
				get 
				{ 
					return 1;
				}
			}

			protected override Visual GetVisualChild(int index)
			{
				return visual;
			}

			public VisualHost(DrawingVisual visual)
			{
				this.visual = visual;
			}

			private DrawingVisual visual;
		}

		Node[] _nodes = null; //şekillerimizi tutan array
		Connector[] _connectors = null; //connectorlerimizi tutan array

        /// <summary>
        /// Menü Kısmı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void Yenile(object sender, RoutedEventArgs e)
		{
			diagram.ClearAll();
		}

		private void Ac(object sender, RoutedEventArgs e)
		{
			if (openFileDialog.ShowDialog() == true)
			{
				try
				{
					diagram.LoadFromXml(openFileDialog.FileName);
				}
				catch
				{
					MessageBox.Show("Tanınmayan Format");
				}
			}
		}

		private void Kaydet(object sender, RoutedEventArgs e)
		{
			if (saveFileDialog.ShowDialog() == true)
			{
				diagram.SaveToXml(saveFileDialog.FileName);
			}
		}

		

		private void Exit(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		OpenFileDialog openFileDialog = new OpenFileDialog();
		SaveFileDialog saveFileDialog = new SaveFileDialog();

        #endregion


        NodeProps _selected; //seçilaai içemiaaaaaa

        /// <summary>
        /// Secilen Şekili Deaktif edebilmek için yazılmış metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void diagram_NodeDeactivated(object sender, NodeEventArgs e)
		{
			_selected = null;
		}

        /// <summary>
        /// Diagramada Link(Bağlantı) Meydana Gelecek Olay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void diagram_LinkClicked(object sender, LinkEventArgs e)
		{
			if (e.MouseButton != MouseButton.Right)
				return;

			diagram.Selection.Clear();
			e.Link.Selected = true;

			Point pt = diagram.DocToClient(e.MousePosition);
			_contextMenu.PlacementRectangle = new Rect(pt, new Size());
			_contextMenu.Visibility = Visibility.Visible;
			//	Show(diagram, pt);
		}

        /// <summary>
        /// Diagram üzerinde node üzerine tıklandığında meydana gelecek olay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void diagram_NodeClicked(object sender, NodeEventArgs e)
		{
			if (e.MouseButton != MouseButton.Right)
				return;

			diagram.Selection.Clear();
			e.Node.Selected = true;
			
			Point pt = diagram.DocToClient(e.MousePosition);
			_contextMenu.PlacementRectangle = new Rect(pt, new Size());
			_contextMenu.Visibility = Visibility.Visible;
		}

        /// <summary>
        /// Menu Kısmı
        /// </summary>
		ContextMenu _contextMenu;

        /// <summary>
        /// Aktif Node ile ilgili metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void diagram_NodeActivated(object sender, NodeEventArgs e)
		{
			_selected = new NodeProps();
			_selected.Text = e.Node.Text;
			_selected.Brush = e.Node.Brush as SolidColorBrush;
		}

        /// <summary>
        /// Property panelini geliştiriyordum yarım kaldı orası ile ilgili bir metot
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
		private void _propertyGrid_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			if (diagram.Selection.Nodes.Count == 0)
				return;

			DiagramNode b = diagram.Selection.Nodes[0] as DiagramNode;
			if (b == null)
				return;
			
			
			// Create undo record
			ChangeItemCmd cmd =
				new ChangeItemCmd(b, "Property Değişti");

			b.Text = _selected.Text;
			b.Brush = _selected.Brush;
			b.Selected = false;

			cmd.Execute();
			b.Selected = true;
		}


        /// <summary>
        /// Nesnenin style değerlerini alabilmek için oluşturulan metot
        /// </summary>
        /// <param name="style"></param>
        /// <param name="property"></param>
        /// <returns></returns>
		private object GetStyleValue(Style style, DependencyProperty property)
		{
			foreach (Setter setter in style.Setters)
			{
				if (setter.Property == property)
					return setter.Value;
			}

			return null;
		}


        /// <summary>
        /// Diagram üzerinde nesnenin sürüklenme olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void diagram_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(DraggedNode)))
			{
				e.Effects = DragDropEffects.Copy;
			}
			else
			{
				e.Effects = DragDropEffects.None;
			}
		}


        /// <summary>
        /// Diagram üzerine nesne bırakıldığında olacak olaylar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void diagram_Drop(object sender, DragEventArgs e)
		{
			AnchorPattern ap = null;

			if (e.Data.GetDataPresent(typeof(DraggedNode)))
			{
				DiagramNode node = diagram.Nodes[diagram.Nodes.Count - 1];
				if (node is ShapeNode)
				{
					var p = diagram.AlignPointToGrid(node.Bounds.Location);
					node.Bounds = new Rect(p.X - 15, p.Y - 15, 30, 30);
					foreach (Node n in _nodes)
					{
						if (n.ShapeId.Equals(((ShapeNode)node).Shape.Id))
						{
							ap = n.AnchorPattern;
							break;
						}
					}
				}
				else if (node is TableNode)
				{
					var table = (TableNode)node;
					node.Bounds = new Rect(node.Bounds.Left - 25, node.Bounds.Top - 20, 50, 40);
					if (table.RowCount == 2)
						ap = _nodes[_nodes.Length - 3].AnchorPattern;
					else
						ap = _nodes[_nodes.Length - 2].AnchorPattern;
					table.ConnectionStyle = TableConnectionStyle.Table;
					table.CellTextStyle.FontSize = 4;
					foreach (TableNode.Row row in table.Rows)
						row.Height = 8;
				}
				else if (node is ContainerNode)
				{
					ap = _nodes[_nodes.Length - 1].AnchorPattern;
					node.Bounds = new Rect(node.Bounds.Left - 25, node.Bounds.Top - 20, 50, 40);
				}


				foreach (AnchorPoint point in ap.Points)
				{
					point.MarkStyle = _anchorStyle;
					point.Brush = _anchorBrush;
				}
				node.AnchorPattern = ap;
			}
		}

        /// <summary>
        /// Nesnelerin proprerty'lerini barındıran sınıf metin ve nesne rengi gibi
        /// </summary>
		private class NodeProps
		{
			[Category("Properties")]
			[Description("Düğüm içinde görüntülenen metin.")]
			public string Text
			{
				get { return _text; }
				set { _text = value; }
			}

			[Category("Properties")]
			[Description("Düğümün iç rengi.")]
			public Brush Brush
			{
				get { return _brush; }
				set { _brush = value; }
			}

			private string _text;
			private Brush _brush;
		}

        #region
        /// <summary>
        /// Şekilleri tutan array için getter ve setter özellikleri için Tanımlanan Sınıf
        /// </summary>
        private class Node
		{
			public Node(AnchorPattern anchor,
				string shapeId)
			{
				_anchor = anchor;
				_template = shapeId;
			}

			public AnchorPattern AnchorPattern
			{
				get { return _anchor; }
			}

			public string ShapeId
			{
				get { return _template; }
			}

			private AnchorPattern _anchor;
			private string _template;
		}

        /// <summary>
        /// Bağlayıcıları tutan array için getter ve setter özellikleri
        /// </summary>
		private class Connector
		{
			public Connector(Shape head, string name)
			{
				_head = head;
				_name = name;
			}

			public Shape Head
			{
				get { return _head; }
			}

			public string Name
			{
				get { return _name; }
			}

			private Shape _head;
			private string _name;
		}
        #endregion

        /// <summary>
        /// Bağlayıcı Tipi Seçimi Değiştiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _connectorTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (_connectorTypeCombo.SelectedIndex)
			{

				case 0:
					diagram.LinkShape = LinkShape.Polyline;
					break;
				case 1:
					diagram.LinkShape = LinkShape.Bezier;
					break;
				case 2:
					diagram.LinkShape = LinkShape.Cascading;
					break;
			}
		}

        /// <summary>
        /// Listedeki seçim değiştiğinde meydana gelecek olaylar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void _connectorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int si = _connectorList.SelectedIndex;
			if (si < 0 || si >= _connectors.Length)
				return;

			diagram.LinkHeadShape = _connectors[si].Head;
		}


		private SolidColorBrush _anchorBrush = Brushes.Red;
		private MarkStyle _anchorStyle = MarkStyle.Circle;

       
    }
}