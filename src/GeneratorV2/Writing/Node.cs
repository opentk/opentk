using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace GeneratorV2.Writing
{
    public abstract class Node
    {
        protected Node(List<Node>? children)
        {
            Children = children;
        }

        protected List<Node>? Children { get; }

        public Node? Parent { get; private set; }

        public abstract void Write();

        public Node AddNode(Node child)
        {
            if (Children == null)
            {
                throw new InvalidOperationException();
            }
            Children.Add(child);
            SetParent(child, this);
            return child;
        }

        private static void SetParent(Node child, Node parent)
        {
            child.Parent = parent;
        }

        protected void WriteChildren()
        {
            if (Children == null)
            {
                return;
            }

            foreach (var n in Children)
            {
                n.Write();
            }
        }
    }
}
