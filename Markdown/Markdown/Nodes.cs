using System.Collections.Generic;
using System.Linq;

namespace Markdown
{
    internal interface INode
    {
        string ToHtml();
    }

    internal class Literal : INode
    {
        public Literal(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public string ToHtml()
        {
            return Value;
        }
    }

    internal class Strong : INode
    {
        public Strong(INode node)
        {
            Inner = node;
        }

        public INode Inner { get; set; }

        public string ToHtml()
        {
            return $"<strong>{Inner.ToHtml()}</strong>";
        }
    }

    internal class Paragraph : INode
    {
        public Paragraph(INode node)
        {
            Inner = node;
        }

        public INode Inner { get; set; }

        public string ToHtml()
        {
            return $"<p>{Inner.ToHtml()}</p>";
        }
    }

    internal class Heading : INode
    {
        public Heading(int level, INode n)
        {
            Level = level;
            Inner = n;
        }

        public INode Inner { get; set; }

        public int Level { get; set; }

        public string ToHtml()
        {
            return $"<h{Level}>{Inner.ToHtml()}</h{Level}>";
        }
    }

    class List : INode
    {
        public List(List<INode> nodes)
        {
            Nodes = nodes;
        }

        public List<INode> Nodes { get; set; }

        public string ToHtml()
        {
            var listItems = Nodes
                .Aggregate(string.Empty, (acc, n) => acc + $"<li>{n.ToHtml()}</li>");
            return $"<ul>{listItems}</ul>";
        }
    }

    class Sequence : INode
    {
        public Sequence(List<INode> nodes)
        {
            Nodes = nodes;
        }

        public List<INode> Nodes { get; set; }

        public string ToHtml()
        {
            return Nodes.Aggregate(string.Empty, (acc, node) => acc + node.ToHtml());
        }
    }
}
