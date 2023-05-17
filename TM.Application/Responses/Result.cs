using System;
using System.Collections.Generic;

namespace TM.Application;
public class Result<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T Value { get; set; }
    public List<string> Errors { get; set; }

    public static Result<T> Ok(T value)
    {
        return new Result<T>
        {
            Success = true,
            Value = value
        };
    }

    public static Result<T> Fail(string message, List<string> errors = null)
    {
        return new Result<T>
        {
            Success = false,
            Message = message,
            Errors = errors ?? new List<string>()
        };
    }
}