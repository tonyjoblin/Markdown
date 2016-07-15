# Markdown
Markdown DSL following an example given by Thomas Petricek at an NDC conference.

Follows along with conference presentation from Thomas Petricek from an NDC conference. See https://vimeo.com/97315970.

Here I implement a simple internal Markdown DSL in C#. The one in the conference video is in F#. The application constructs a markdown document, converts it to html and displays it in a winform.

I don't think it went that badly. I have used classes to represent the nodes which is more verbose than the F# discriminated unions. The actual use of the DSL to create the document is very close to the F# version - I had thought it would be much more verbose so this was a pleasant surprise.

The final distinction is that each of my nodes know how to render themselves and their children. This is different to the F# example. The F# example uses a function and pattern matching to do this.
