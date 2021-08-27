<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618728/14.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4943)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyColorPickEdit.cs](./CS/CustomColorPIckEdit/MyColorPickEdit.cs) (VB: [MyColorPickEdit.vb](./VB/CustomColorPIckEdit/MyColorPickEdit.vb))
* [MyPopupBaseFormViewInfo.cs](./CS/CustomColorPIckEdit/MyPopupBaseFormViewInfo.cs) (VB: [MyPopupBaseFormViewInfo.vb](./VB/CustomColorPIckEdit/MyPopupBaseFormViewInfo.vb))
* [MyPopupColorPickEditForm.cs](./CS/CustomColorPIckEdit/MyPopupColorPickEditForm.cs) (VB: [MyPopupColorPickEditForm.vb](./VB/CustomColorPIckEdit/MyPopupColorPickEditForm.vb))
* [RepositoryItemMyColorPickEdit.cs](./CS/CustomColorPIckEdit/RepositoryItemMyColorPickEdit.cs) (VB: [RepositoryItemMyColorPickEdit.vb](./VB/CustomColorPIckEdit/RepositoryItemMyColorPickEdit.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MyColorObject.cs](./CS/Helpers/MyColorObject.cs) (VB: [MyColorObject.vb](./VB/Helpers/MyColorObject.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to add a Clear button to implement a clear edit value functionality


<p>This example demonstrates how to add a Clear button to the ColorPickEdit dropdown form to implement a clear edit value functionality.<br />
For this, add the ShowClear property to the RepositoryItemMyColorPickEdit class, create a SimpleButton, and add it to the Control collection of the dropdown form.  The ShowClear property specifies the visibility of the Clear button in the dropdown form. <br />
If the value is true, the dropdown form contains a Clear button; otherwise, false. The default is true. The Clear button allows end-users to clear the currently selected color. Clicking the button assigns the null value to the edit value and closes the dropdown. <br />
You can use this approach both in inplace and standalone modes.</p>

<br/>


