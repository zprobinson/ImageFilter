﻿using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary
{
    public static class TestExtension
    {
        public static void Test(this ImageEditorState @this, int radius)
        {
            var newImage = ImageProcessor.Instance.Pixellate(@this.Image, radius);

            @this.Update(newImage);
        }
    }
}
