using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
	public class Builder
	{
		public static void BuilderMain()
		{
			Console.WriteLine("\n *********** BUILDER PATTERN *********** \n");
            /// 

            // if you want to build a simple HTML paragraph using StringBuilder
            var hello = "hello";
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("<p>");
            stringBuilder.Append(hello);
            stringBuilder.Append("</p>");
            Console.WriteLine(stringBuilder);

            // now I want an HTML list with 2 words in it
            var words = new[] { "hello", "world" };
            stringBuilder.Clear();
            stringBuilder.Append("<ul>");

            foreach(var word in words)
            { stringBuilder.AppendFormat("<li>{0}</li>", word); }

            stringBuilder.Append("</ul>");
            Console.WriteLine(stringBuilder);

            // ordinary non-fluent builder
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());

            // fluent builder
            stringBuilder.Clear();
            builder.Clear(); // disengage builder from the object it's building, then...
            builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
            Console.WriteLine(builder);
        }

        class HtmlElement
        {
            public string Name, Text;
            public List<HtmlElement> Elements = new List<HtmlElement>();
            private const int _indentSize = 2;

            public HtmlElement()
            { }

            public HtmlElement(string name, string text)
            {
                Name = name;
                Text = text;
            }

            private string ToStringImpl(int indent)
            {
                var stringBuilder = new StringBuilder();
                var i = new string(' ', _indentSize * indent);
                stringBuilder.Append($"{i}<{Name}>\n");
                if(!string.IsNullOrWhiteSpace(Text))
                {
                    stringBuilder.Append(new string(' ', _indentSize * (indent + 1)));
                    stringBuilder.Append(Text);
                    stringBuilder.Append("\n");
                }

                foreach(var e in Elements)
                { stringBuilder.Append(e.ToStringImpl(indent + 1)); }

                stringBuilder.Append($"{i}</{Name}>\n");

                return stringBuilder.ToString();
            }

            public override string ToString()
            { return ToStringImpl(0); }
        }

        class HtmlBuilder
        {
            private readonly string _rootName;

            public HtmlBuilder(string rootName)
            {
                _rootName = rootName;
                root.Name = rootName;
            }

            // not fluent
            public void AddChild(string childName, string childText)
            {
                var e = new HtmlElement(childName, childText);
                root.Elements.Add(e);
            }

            public HtmlBuilder AddChildFluent(string childName, string childText)
            {
                var e = new HtmlElement(childName, childText);
                root.Elements.Add(e);
                return this;
            }

            public override string ToString()
            { return root.ToString(); }

            public void Clear()
            { root = new HtmlElement { Name = _rootName }; }

            HtmlElement root = new HtmlElement();
        }
    }
}
