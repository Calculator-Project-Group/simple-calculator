# Simple Calculator——More than simple！
This is a modern scientific calculator, which features in real-time rendering math expressions you type in..

It's a WPF application written in `C#`.
## Platforms
- Windows XP (.NET 4 required)
- Windows 7+
## Download
Click here to download the latest binary release. (The link will be released soon.)

Of course, alternatively, you can built the application by yoursef using Visual Studio. Don't forget to install the required NuGet packages first :).
## Usage
### Overview of UI
![UI](docs/ui.png)
### Interaction
You can either input the linear expression to be calculated via keyboard, or using buttons shown above.
> A tip about the autocomplete facility:
>
> The `(` button supports autocomplete by default. However, you can disable this using left click.

The format of expressions you should input strictly follows a definition specified by a grammar specification file. But you needn't worry much for that because our grammar takes accounts of the most common forms of linear expressions, and the expressions you would naturally think of will usually be properly accepted by our parser.

Calculate the expression pressing "`=`" button.