#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B4D7863C54C6F94D92F9E9C3C3155BF0A216A0ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using MindFusion.Diagramming.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MindFusion.Diagramming.Wpf.Samples.CS.FlowCharter {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mIFile;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mIFNew;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mIFOpen;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mIFSave;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mIFPrint;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mIExit;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MindFusion.Diagramming.Wpf.Diagram diagram;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MindFusion.Diagramming.Wpf.NodeListView nodeListView;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox _connectorList;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _connectorTypeCombo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FlowCharter;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.menu1 = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.mIFile = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.mIFNew = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\MainWindow.xaml"
            this.mIFNew.Click += new System.Windows.RoutedEventHandler(this.Yenile);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mIFOpen = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.mIFOpen.Click += new System.Windows.RoutedEventHandler(this.Ac);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mIFSave = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.mIFSave.Click += new System.Windows.RoutedEventHandler(this.Kaydet);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mIFPrint = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 7:
            this.mIExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.mIExit.Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 8:
            this.diagram = ((MindFusion.Diagramming.Wpf.Diagram)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.diagram.AddHandler(System.Windows.DragDrop.DragOverEvent, new System.Windows.DragEventHandler(this.diagram_DragOver));
            
            #line default
            #line hidden
            
            #line 43 "..\..\MainWindow.xaml"
            this.diagram.AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.diagram_Drop));
            
            #line default
            #line hidden
            
            #line 44 "..\..\MainWindow.xaml"
            this.diagram.NodeActivated += new System.EventHandler<MindFusion.Diagramming.Wpf.NodeEventArgs>(this.diagram_NodeActivated);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MainWindow.xaml"
            this.diagram.NodeDeactivated += new System.EventHandler<MindFusion.Diagramming.Wpf.NodeEventArgs>(this.diagram_NodeDeactivated);
            
            #line default
            #line hidden
            
            #line 46 "..\..\MainWindow.xaml"
            this.diagram.NodeClicked += new System.EventHandler<MindFusion.Diagramming.Wpf.NodeEventArgs>(this.diagram_NodeClicked);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.diagram.LinkClicked += new System.EventHandler<MindFusion.Diagramming.Wpf.LinkEventArgs>(this.diagram_LinkClicked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.nodeListView = ((MindFusion.Diagramming.Wpf.NodeListView)(target));
            return;
            case 10:
            this._connectorList = ((System.Windows.Controls.ListBox)(target));
            
            #line 117 "..\..\MainWindow.xaml"
            this._connectorList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this._connectorList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this._connectorTypeCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 120 "..\..\MainWindow.xaml"
            this._connectorTypeCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this._connectorTypeCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

