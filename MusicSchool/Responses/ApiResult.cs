﻿using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MusicSchool.Responses;

public class ApiResult<T> : StatusCodeResult where T : class
{
    public string? Message { get; init; }
    public T? Data { get; init; }
    public bool IsSuccess
    {
        get
        {
            return StatusCode >= 200 && StatusCode <= 299;
        }
    }

    public ApiResult(HttpStatusCode status, string? message) : base((int) status)
    {
        Message = message;
    }

    public ApiResult(HttpStatusCode status, T? data) : base((int) status)
    {
        Data = data;
    }
}