# WpfFontPicker
[![NuGet](https://img.shields.io/nuget/v/QIQI.WpfFontPicker.svg)](https://www.nuget.org/packages/QIQI.WpfFontPicker)   
Namespace: `QIQI.WpfFontPicker`(CLR)  or `xmlns:fp="https://github.com/1354092549/WpfFontPicker"`(XAML)

# Install
Package Manager `Install-Package QIQI.WpfFontPicker`  
.NET CLI `dotnet add package QIQI.WpfFontPicker`  

# Usage
See `QIQI.Sample.WpfFontPicker`

# Preview
![Screenshot 1](https://github.com/1354092549/WpfFontPicker/blob/master/Screenshot/1.png)   

```xaml
<StackPanel Orientation="Vertical">
    <Button x:Name="OpenFontDialogButton" Click="OpenFontDialogButton_Click">OpenFontDialog</Button>
    <fp:FontPicker x:Name="FontPicker1"/>
</StackPanel>
```

```c#
private void OpenFontDialogButton_Click(object sender, RoutedEventArgs e)
{
    FontPicker1.OpenFontDialog();
}
```