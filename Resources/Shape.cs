using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindFusion.Diagramming.Wpf.Samples.CS.FlowCharter.Resources
{
    class Shape
    {
        /// <summary>
        /// Bağlayıcıları tutan array için getter ve setter özellikleri tanımlı olan bir sınıf
        /// </summary>
        private class Nodes
        {
            public Nodes(AnchorPattern anchor,
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
        /// Bağlayıcıları tutan array için getter ve setter özellikleri tanımlı olan bir sınıf
        /// </summary>
		private class Connectors
        {
            public Connectors(Shape head, string name)
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
    }
}
