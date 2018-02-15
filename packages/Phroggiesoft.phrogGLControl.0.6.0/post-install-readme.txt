phrogGLControl version 0.6.0 - 2017 May 01

This package is intended to be a drop-in replacement for
OpenTK.GLControl, while offering some distinct advantages to interested
parties. So far, that includes:
    Enhanced design-time support
    Run-time context shifting (many features are in-progress)

-------------------------------------------

To add a new GLControl in Visual Studio:
    1) Reference phrogGLControl.dll, and build your project.
    2) Open a designable component, then right-click in the "Toolbox"
         panel, and click "Chose Items...".
    3) Click the "Browse..." button, and select the phrogGLControl.dll
         file from your project's bin\$(Configuration) folder.
    4) Click OK to dismiss the dialog, then drag and drop a GLControl
         from the toolbox.

-------------------------------------------

Check out the OpenTK documentation for information on how to actually
use this in practice. Typically, you will want to hook in to the
phrogGLControl.Load and phrogGLControl.Paint events:
    .Load: Fires once before the control is first shown. Useful for
        setting initial matrices, vectors, etc.
    .Paint: Fires every time the control needs to paint (render).

Important: do not attempt to invoke any GL method calls before the
.Load event has fired. To handle this gracefully, try:
        private void phrogGLControl1_Load(object sender, EventArgs e)
        {
            phrogGLControl1.Paint += phrogGLControl1_Paint;
        }

Note that you will likely want to add an Application.Idle delegate to
call `phrogGLControl1.Invalidate()` in order to force painting. This
may change to be handled by the phrogGLControl library at some point.

(TODO: handle this in phrogGLControl, and add timing to allow for
measured callbacks, or something.)
