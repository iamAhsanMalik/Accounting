﻿namespace Application.DTOs.Unhandeld;

public class AuthorizationDto
{
    public bool IsPosted { get; set; }
    public int GLReferenceID { get; set; }
    public string? RefID { get; set; }
    public string? Message { get; set; }
    public string? HtmlBody { get; set; }
    public string? Type { get; set; }
    public string? LabelType { get; set; }
    public string? AuthorizedBy { get; set; }
    public string? AuthorizedDate { get; set; }
    public string? DatePosted { get; set; }
    public string? PostedBy { get; set; }
    public string? VoucherNumber { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
    public string? AccountCode { get; set; }
}