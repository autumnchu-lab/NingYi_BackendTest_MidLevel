using System;
using System.Collections.Generic;

namespace BackendTest.Models;

public partial class MyOfficeAcpd
{
    /// <summary>
    /// 員工編號
    /// </summary>
    /// <example>A001</example>
    public string AcpdSid { get; set; } = null!;

    /// <summary>
    /// 中文姓名
    /// </summary>
    /// <example>秋天</example>
    public string? AcpdCname { get; set; }

    /// <summary>
    /// 中文姓名
    /// </summary>
    /// <example>Autumn</example>
    public string? AcpdEname { get; set; }

    public string? AcpdSname { get; set; }

    public string? AcpdEmail { get; set; }

    /// <summary>
    /// 狀態 (1:啟用, 0:停用)
    /// </summary>
    /// <example>1</example>
    public byte? AcpdStatus { get; set; }

    public bool? AcpdStop { get; set; }

    public string? AcpdStopMemo { get; set; }

    public string? AcpdLoginId { get; set; }

    public string? AcpdLoginPwd { get; set; }

    public string? AcpdMemo { get; set; }

    public DateTime? AcpdNowDateTime { get; set; }

    public string? AcpdNowId { get; set; }

    public DateTime? AcpdUpddateTime { get; set; }

    public string? AcpdUpdid { get; set; }
}
