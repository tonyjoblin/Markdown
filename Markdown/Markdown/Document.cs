using System.Collections.Generic;
using System.Linq;

namespace Markdown
{
    internal class Document
    {
        public Document(INode root)
        {
            Root = root;
        }

        public Document()
        {
            
        }

        public INode Root { get; set; }

        public string ToHtml()
        {
            return Root != null ? Root.ToHtml() : string.Empty;
        }

        #region HelpersToCreateNodes
        public INode Literal(string text)
        {
            return new Literal(text);
        }

        public INode Strong(INode n)
        {
            return new Strong(n);
        }

        public INode Paragraph(INode n)
        {
            return new Paragraph(n);
        }

        public INode Heading(int level, INode n)
        {
            return new Heading(level, n);
        }

        public INode List(params INode[] nodes)
        {
            return new List(nodes.ToList());
        }

        public INode Sequence(params INode[] nodes)
        {
            return new Sequence(nodes.ToList());
        }
        #endregion
    }
}
