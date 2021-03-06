﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Base.Interface
{
    public enum TupleState : int
    {
        Outlier = 1,
        Inlier = 2,
    }
    /// <summary>
    /// 作为通用的数据实体
    /// </summary>
    public interface ITuple : IDisposable
    {
        int ArrivalStep { get; set; }
        int DepartStep { get; set; }
        bool IsOutlier { get; set; }
        int Dimension { get; set; }

        int ID { get;}

        /// <summary>
        /// 各维度的数据，以下标作为一个维度
        /// </summary>
        List<double> Data { get; set; }
    }
}
