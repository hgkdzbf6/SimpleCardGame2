using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum CHARACTER_STATUS
{
    /// <summary>
    /// 无法攻击
    /// </summary>
    CHARACTE_STATUS_CANT_ATTACK = 1,
    /// <summary>
    /// 冻结
    /// </summary>
    CHARACTE_STATUS_FROZEN = 2,
    /// <summary>
    /// 嘲讽
    /// </summary>
    CHARACTE_STATUS_TAUNT = 4,
    /// <summary>
    /// 圣盾
    /// </summary>
    CHARACTER_STATUS_SHIELD = 8,
    /// <summary>
    /// 冲锋
    /// </summary>
    CHARACTER_STATUS_CHARGE = 16,
    /// <summary>
    /// 风怒
    /// </summary>
    CHARACTER_STATUS_WINDFURY = 32,
    /// <summary>
    /// 疲惫：就是刚上去不能打
    /// </summary>
    CHARACTER_STATUS_TIRED = 64,
    /// <summary>
    /// 占个坑
    /// </summary>
    CHARACTER_STATUS_ERR = 129
}