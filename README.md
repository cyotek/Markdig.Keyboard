# Markdig.Keyboard.Extension

[![NuGet][nugetbadge]][nuget]
[![Donate][paypalbadge]][paypal]

![A basic demonstration showing the output][1]

The **Markdig.Keyboard** library is an extension for use with
the [Markdig][2] processing library and allows easier insertion
of `kbd` elements without having to resort to raw HTML.

## Getting the library

The easiest way of obtaining the library is via [NuGet][nuget].

> `Install-Package Cyotek.Markdig.Keyboard`

## Using the library

When you build your Markdig pipeline, call `UseKeyboard()`. Any
text wrapped in double angled brackets will be converted to
`kbd` tags.

```csharp
_markdownPipeline = new MarkdownPipelineBuilder()
  .UseAdvancedExtensions()
  .UseKeyboard()
  .Build();
```

## Options

There is also a `KeyboardOptions` class you can use to control
the output. Currently it allows you either to assign a CSS class
to generated elements via the `ClassName` property, or specify a
different HTML tag via the `TagName` property.

```csharp
_markdownPipeline = new MarkdownPipelineBuilder()
  .UseAdvancedExtensions()
  .UseKeyboard(new KeyboardOptions
  {
    ClassName = "my-class",
    TagName = "code"
  })
  .Build();
```

## Examples

This first example uses default options, which output `kbd` tags
with no further processing.

```csharp
var markdownPipeline = new MarkdownPipelineBuilder()
  .UseAdvancedExtensions()
  .UseKeyboard()
  .Build();

var output = Markdown.ToHtml(@"### File Menu

| Description | Shortcut Keys |
| ----------- | ------------- |
| New         | <<Ctrl+N>>    |
| Open        | <<Ctrl+O>>    |
| Save        | <<Ctrl+S>>    |
| Save As     |               |
| Export      |               |
| Exit        | <<Alt+F4>>    |
", markdownPipeline);
```

```html
<h3 id="file-menu">File Menu</h3>
<table>
  <thead>
    <tr>
      <th>Description</th>
      <th>Shortcut Keys</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>New</td>
      <td><kbd>Ctrl+N</kbd></td>
    </tr>
    <tr>
      <td>Open</td>
      <td><kbd>Ctrl+O</kbd></td>
    </tr>
    <tr>
      <td>Save</td>
      <td><kbd>Ctrl+S</kbd></td>
    </tr>
    <tr>
      <td>Save As</td>
      <td></td>
    </tr>
    <tr>
      <td>Export</td>
      <td></td>
    </tr>
    <tr>
      <td>Exit</td>
      <td><kbd>Alt+F4</kbd></td>
    </tr>
  </tbody>
</table>
```

This second example uses custom options to change the output tag
to `code` and apply a custom class.

```csharp
var markdownPipeline = new MarkdownPipelineBuilder()
  .UseAdvancedExtensions()
  .UseKeyboard(new KeyboardOptions
  {
    ClassName = "keyboard",
    TagName = "code"
  })
  .Build();

var output = Markdown.ToHtml("Press <<Alt+F4>> to exit.", markdownPipeline);
```

```html
<p>Press <code class="keyboard">Alt+F4</code> to exit.</p>
```

## Requirements

.NET Framework 3.5 or later.

Pre-built binaries are available via a signed [NuGet package][nuget]
containing the following targets.

* .NET 4.8
* .NET Standard 2.0
* .NET Standard 2.1
* .NET Core 2.1
* .NET Core 3.1
* .NET 5.0

Is there a target not on this list you'd like to see? Raise an
[issue][ghissue], or even better, a [pull request][ghpull].

## Acknowledgements

Interim package icon derived from the [Tango Icon Library][3].

## License

This source is licensed under the MIT license. See `LICENSE.txt`
for the full text.

[nugetbadge]: https://img.shields.io/nuget/v/Cyotek.Markdig.Keyboard.svg
[nuget]: https://www.nuget.org/packages/Cyotek.Markdig.Keyboard/
[paypalbadge]: https://www.paypalobjects.com/en_US/i/btn/btn_donate_SM.gif
[paypal]: https://paypal.me/cyotek
[ghissue]: https://github.com/cyotek/Markdig.Keyboard/issues
[ghpull]: https://github.com/cyotek/Markdig.Keyboard/pulls
[ghrel]: https://github.com/cyotek/Markdig.Keyboard/releases
[gh]: https://github.com/cyotek/Markdig.Keyboard

[1]: res/screenshot.png
[2]: https://github.com/lunet-io/markdig/
[3]: https://www.iconfinder.com/icons/118804/map_character_accessories_icon
