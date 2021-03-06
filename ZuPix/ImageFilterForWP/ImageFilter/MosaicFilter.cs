﻿

namespace ZuPix.ImageFilter
{
    public class MosaicFilter : IImageFilter
    {

        
        public int MosiacSize = 4;

        public string Name { get { return "Mosaic"; } }
        //@Override
        public CustomImage process(CustomImage imageIn)
        {
            int width = imageIn.getWidth();
            int height = imageIn.getHeight();
            int r = 0, g = 0, b = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y % MosiacSize == 0)
                    {
                        if (x % MosiacSize == 0)
                        {                    	 
                            r = imageIn.getRComponent(x, y);
                            g = imageIn.getGComponent(x, y);
                            b = imageIn.getBComponent(x, y);
                        }
                        imageIn.setPixelColor(x, y, r, g, b);
                    }
                    else
                    { 	       		 
                        imageIn.setPixelColor(x, y, imageIn.getPixelColor(x, y - 1));
                    }
                }
            }
            return imageIn;
        }
    }
}
