﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Base.Interface
{
    public interface IWindow
    {
        bool ShouldWindowSlide();

        void SlideWindow();
    }
}
