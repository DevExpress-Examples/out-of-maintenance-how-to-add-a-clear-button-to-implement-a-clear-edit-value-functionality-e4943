# How to add a Clear button to implement a clear edit value functionality


<p>This example demonstrates how to add a Clear button to the ColorPickEdit dropdown form to implement a clear edit value functionality.<br />
For this, add the ShowClear property to the RepositoryItemMyColorPickEdit class, create a SimpleButton, and add it to the Control collection of the dropdown form.  The ShowClear property specifies the visibility of the Clear button in the dropdown form. <br />
If the value is true, the dropdown form contains a Clear button; otherwise, false. The default is true. The Clear button allows end-users to clear the currently selected color. Clicking the button assigns the null value to the edit value and closes the dropdown. <br />
You can use this approach both in inplace and standalone modes.</p>

<br/>


