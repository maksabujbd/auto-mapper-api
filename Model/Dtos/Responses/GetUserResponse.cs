﻿namespace AutoMapper.API.Model.Dtos.Responses;

public class GetUserResponse
{
    public string FullName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}