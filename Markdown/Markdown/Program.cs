using System;
using System.Windows.Forms;

namespace Markdown
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            var d = new Document();
            d.Root = d.Sequence(
                    d.Heading(1, d.Literal("Creating DSLs with C#")),
                    d.Paragraph(d.Literal("Key components of a DSL")),
                    d.List(
                        d.Sequence(
                            d.Strong(d.Literal("Model")),
                            d.Literal(" describes the structure of the domain that we are modelling")
                            ),
                        d.Sequence(
                            d.Strong(d.Literal("Syntax")),
                            d.Literal(" provides an easy way for solving problems using the DSL")
                            )
                    )
                );

            var f = new WebForm();
            f.SetTitle("Markdown");
            f.SetHtml(d.ToHtml());
            Application.Run(f);
        }
    }
}
