﻿

namespace ZuPix.ImageFilter
{
    public class SmashColorFilter : IImageFilter
    {
        public string Name { get { return "Smash"; } }
        //@Override
        public CustomImage process(CustomImage imageIn)
        {
            ParamEdgeDetectFilter pde = new ParamEdgeDetectFilter();
            pde.K00 = 1;
            pde.K01 = 2;
            pde.K02 = 1;
            pde.Threshold = 0.25f;
            pde.DoGrayConversion = false;
            pde.DoInversion = false;
            ImageBlender ib = new ImageBlender();
            ib.Mode = (int)BlendMode.LinearLight;
            ib.Mixture = 2.5f;
            return ib.Blend(imageIn.clone(), pde.process(imageIn));
        }
    }

}
