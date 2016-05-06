using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IProperty<T,S>:IComponent
{

    /// <summary>
    /// 当前值
    /// </summary>
    T current { get; set; }
    /// <summary>
    /// 原始值
    /// </summary>
    T original { get; set; }
    /// <summary>
    /// 反映数字的颜色
    /// </summary>
    void color();
    /// <summary>
    /// 用于比较两个数字的大小
    /// </summary>
    int test(S p1, S p2);
}