﻿namespace Application.DTOs.Unhandeld;
public class AddAccountCodeResponseDto
{
    public bool isAdded = false;
    public string? AccountCode { get; set; }
    public string? AccountName { get; set; }
}